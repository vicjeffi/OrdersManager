using OrdersManager.Models;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OrdersManager
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        public static readonly string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public event PropertyChangedEventHandler PropertyChanged;
        public event AccountHandler Notify;

        public delegate void AccountHandler(string message);

        private bool isSomethingChanged = false;
        private bool isActionOnStart = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["CatchStartAction"]);
        private string actionOnEndPreffix = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["CatchStartAction"]) ? " конец" : "";
        private void AddActions(string message)
        {
            if(isActionOnStart || !message.Contains("начало"))
                actions.Add(message + " " + DateTime.Now.ToString("T"));

            if (message.Contains("конец") || !isActionOnStart)
                isSomethingChanged = true;

            if (listBox_actions != null)
                listBox_actions.SelectedIndex = -1;
        }

        public static BindingList<Product> products;
        public static BindingList<Customer> clients;
        public static BindingList<Order> orders;
        public static BindingList<string> actions;

        public static BindingSource ProductsBinding { get; private set; }
        public static BindingSource ClientsBinding { get; private set; }
        public static BindingSource OrdersBinding { get; private set; }
        public static BindingSource ActionBinding { get; private set; }

        public MainForm()
        {
            Notify += AddActions;

            clients = new BindingList<Customer>();
            orders = new BindingList<Order>();
            products = new BindingList<Product>();
            actions = new BindingList<string>();

            if (!File.Exists(myDocumentsPath + @"\" + typeof(MainForm).Namespace + @"\" + "data.txt"))
            {
                Directory.CreateDirectory(myDocumentsPath + @"\" + typeof(MainForm).Namespace);
                File.Create(myDocumentsPath + @"\" + typeof(MainForm).Namespace + @"\" + "data.txt").Close();
            }
            LoadFileData();

            ClientsBinding = new BindingSource(clients, null);
            OrdersBinding = new BindingSource(orders, null);
            ProductsBinding = new BindingSource(null, null);
            ActionBinding = new BindingSource(actions, null);

            InitializeComponent();
            BindLists();

            ProductsBinding.DataSource = null;
        }

        private Customer _selectedClient;
        public Customer SelectedClient { get { return _selectedClient; } set { _selectedClient = value; OnPropertyChanged("SelectedClient"); } }
        private void listBox_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_clients.SelectedItem != SelectedClient)
            {
                SelectedClient = listBox_clients.SelectedItem as Customer;
                if (SelectedClient != null)
                {
                    OrdersBinding.DataSource = SelectedClient.Orders;
                } 
                listBox_orders.SelectedIndex = -1;
            }
        }
        private Order _selectedOrder = new Order();
        public Order SelectedOrder { get { return _selectedOrder; } set { _selectedOrder = value; OnPropertyChanged("SelectedOrderTotalPrice"); } }
        private string _currency = " " + System.Configuration.ConfigurationManager.AppSettings["Currency"];
        public string SelectedOrderTotalPrice
        {
            get
            {
                if (_selectedOrder != null)
                    return _selectedOrder.TotalPrice.ToString() + _currency;
                else
                    return 0f.ToString() + _currency;
            }
        }
        private void listBox_orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_orders.SelectedItem != SelectedOrder)
            {
                SelectedOrder = listBox_orders.SelectedItem as Order;
                if (SelectedOrder != null)
                    ProductsBinding.DataSource = SelectedOrder.Products;
                else
                    ProductsBinding.DataSource = null;
            }
        }
        private void BindLists()
        {
            listBox_clients.DataSource = ClientsBinding; listBox_orders.DataSource = OrdersBinding; dataGridView_selectedOrder.DataSource = ProductsBinding; listBox_actions.DataSource = ActionBinding;
            //label_selectedOrderPrice.DataBindings.Add("Text", this, "SelectedOrderTotalPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            label_selectedOrderPrice.DataBindings.Add("Text", this, "SelectedOrderTotalPrice", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        public void LoadFileData()
        {
            Notify?.Invoke($"Загрузка локальных данных");
            string jsonData = File.ReadAllText(myDocumentsPath + @"\" + typeof(MainForm).Namespace + @"\" + "data.txt");
            if(jsonData != null && jsonData != "")
                clients = JsonSerializer.Deserialize<BindingList<Customer>>(jsonData);
        }
        private async void button_clientNew_Click(object sender, EventArgs e)
        {
            Notify?.Invoke($"Добавление клиента начало");

            Customer newCustomer = new Customer();
            clients.Add(newCustomer);
            //listBox_clients.SelectedIndex = clients.IndexOf(newCustomer);
            listBox_clients.SetSelected(clients.IndexOf(newCustomer), true);
            SelectedClient = newCustomer;
            CustomerForm.UpdateData(SelectedClient, NewFormSettings.WithButtons);
            CustomerForm.Base.Show();

            LockUGI();
            await Task.Run(() => CustomerForm.Base.ComliteEditHandle.WaitOne());
            UnlockGUI();

            if (CustomerForm.Result != true)
                clients.Remove(newCustomer);

            Notify?.Invoke($"Добавление клиента" + actionOnEndPreffix);
        }

        private async void button_clientEdit_Click(object sender, EventArgs e)
        {
            Notify?.Invoke($"Изменение данных клиента начало");

            CustomerForm.UpdateData(SelectedClient, NewFormSettings.WithButtons);
            CustomerForm.Base.Show();

            LockUGI();
            await Task.Run(() => CustomerForm.Base.ComliteEditHandle.WaitOne());
            UnlockGUI();

            Notify?.Invoke($"Изменение данных клиента" + actionOnEndPreffix);
        }
        private bool ShowingDialog = true;
        private void button_clientRemove_Click(object sender, EventArgs e)
        {
            Notify?.Invoke($"Удаление клиента из списка начало");
            LockUGI();

            if(listBox_clients.SelectedItem != null)
            {
                if (ShowingDialog)
                {
                    DialogResult result = MessageBox.Show("Вы точно хотите удалить этого клиента? \nОтмена, чтобы убрать это оповещение и удалить клиента", "Подтвердите действие", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        orders.Clear();
                        clients.Remove((Customer)listBox_clients.SelectedItem);
                        listBox_clients.SelectedItem = null;

                        Notify?.Invoke($"Удаление клиента из списка" + actionOnEndPreffix);
                    }
                    else if (result == DialogResult.No)
                    {
                        Notify?.Invoke($"Отмена удаления клиента из списка");
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        ShowingDialog = false;
                        orders.Clear();
                        clients.Remove((Customer)listBox_clients.SelectedItem);
                        listBox_clients.SelectedItem = null;

                        Notify?.Invoke($"Отключение подтверждения удаления");
                        Notify?.Invoke($"Удаление клиента из списка" + actionOnEndPreffix);
                    }
                }
                else
                {
                    clients.Remove((Customer)listBox_clients.SelectedItem);
                    listBox_clients.SelectedItem = null;
                    Notify?.Invoke($"Удаление клиента из списка" + actionOnEndPreffix);
                }
            }
            else
            {
                MessageBox.Show("Сначало выберите клиента", "Ошибка");
                Notify?.Invoke($"Ошибка удаления клиента из списка");
            }
            UnlockGUI();
        }

        private void button_clientListSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            Notify?.Invoke($"Выгрузка локальных данных");
            var opt = new JsonSerializerOptions() { WriteIndented = true };
            string strJson = JsonSerializer.Serialize(clients, opt);

            if (File.Exists(myDocumentsPath + @"\" + typeof(MainForm).Namespace + @"\" + "data.txt"))
            {
                File.WriteAllText(myDocumentsPath + @"\" + typeof(MainForm).Namespace + @"\" + "data.txt", strJson);
            }
            isSomethingChanged = false;
        }
        private void button_orderNew_Click(object sender, EventArgs e)
        {
            if (SelectedClient != null)
            {
                Notify?.Invoke($"Добавление нового заказа пользователю");
                Order order = new Order();
                SelectedClient.Orders.Add(order);
                listBox_orders.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Для начала выберите пользователя", "Ошибка");
        }

        private void button_orderDelete_Click(object sender, EventArgs e)
        {
            if(SelectedOrder != null && SelectedClient != null)
            {
                Notify?.Invoke($"Удаление заказа у пользователя");
                SelectedClient.Orders.Remove(SelectedOrder);
            }
            else
                MessageBox.Show("Для начала выберите пользователя и его заказ", "Ошибка");
        }

        private void button_orderPrint_Click(object sender, EventArgs e)
        {
            string textToPrint = "";

            foreach(Customer client in clients)
            {
                if(client.Orders.Count > 0)
                {
                    textToPrint += Printer.Base.getTabs(0) + "Клиент: " + client + "\n";
                    foreach (var order in client.Orders)
                    {
                        textToPrint += Printer.Base.getTabs(1) + "Заказ: " + order + "\n";
                        if (order.Products.Count > 0)
                        {
                            textToPrint += Printer.Base.getTabs(1) + "Список продуктов: " + "\n";
                            foreach (var product in order.Products)
                            {
                                textToPrint += Printer.Base.getTabs(2) + product + "\n";
                            }
                            textToPrint += Printer.Base.getTabs(1) + "Общая цена заказа: " + order.TotalPrice + _currency  + "\n";
                        }
                    }
                    textToPrint += "\n";
                }
                else
                {
                    textToPrint += Printer.Base.getTabs(0) + "Клиент: " + client + "\n";
                    textToPrint += Printer.Base.getTabs(1) + "Нет заказов" + "\n";
                    textToPrint += "\n";
                }
            }
            if(textToPrint != null && textToPrint != "")
            {
                var result = MessageBox.Show(textToPrint, "Подтвердите печать всех заказов", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Printer.PrintText(textToPrint);
                }
            }
            else
                MessageBox.Show("У вас нету клиентов с заказами", "Ошибка");
        }

        private void button_orderListSave_Click(object sender, EventArgs e)
        {
            if(SelectedOrder != null)
            {
                SelectedOrder.Complited = !SelectedOrder.Complited;
                SelectedClient.Orders.ResetItem(SelectedClient.Orders.IndexOf(SelectedOrder));
            }
        }

        private void button_orderCompletedList_Click(object sender, EventArgs e)
        {
            string textToPrint = "";

            foreach (Customer client in clients)
            {
                if (client.Orders.Count > 0 && client.HasComlitedOrders)
                {
                    textToPrint += Printer.Base.getTabs(0) + "Клиент: " + client + "\n";
                    foreach (var order in client.Orders)
                    {
                        if (order.Complited)
                        {
                            textToPrint += Printer.Base.getTabs(1) + "Заказ: " + order + "\n";
                            if (order.Products.Count > 0)
                            {
                                textToPrint += Printer.Base.getTabs(1) + "Список продуктов: " + "\n";
                                foreach (var product in order.Products)
                                {
                                    textToPrint += Printer.Base.getTabs(2) + product + "\n";
                                }
                                textToPrint += Printer.Base.getTabs(1) + "Общая цена заказа: " + order.TotalPrice + _currency + "\n";
                            }
                        }
                    }
                    textToPrint += "\n";
                }
            }
            if(textToPrint == "")
                textToPrint = "Нету";

            var result = MessageBox.Show(textToPrint, "Список всех готовых заказов: ");
        }
        private void LockAllButton()
        {
            button_actionReset.Enabled = false;
            button_clientEdit.Enabled = false;
            button_clientListSave.Enabled = false;
            button_clientNew.Enabled = false;
            button_clientRemove.Enabled = false;
            button_orderCompletedList.Enabled = false;
            button_orderDelete.Enabled = false;
            button_orderListSave.Enabled = false;
            button_orderNew.Enabled = false;
            button_orderPrint.Enabled = false;
        }
        private void UnlockAllButton()
        {
            button_actionReset.Enabled = true;
            button_clientEdit.Enabled = true;
            button_clientListSave.Enabled = true;
            button_clientNew.Enabled = true;
            button_clientRemove.Enabled = true;
            button_orderCompletedList.Enabled = true;
            button_orderDelete.Enabled = true;
            button_orderListSave.Enabled = true;
            button_orderNew.Enabled = true;
            button_orderPrint.Enabled = true;
        }
        private void LockUGI()
        {
            LockAllButton();
            listBox_clients.Enabled = false;
        }
        private void UnlockGUI()
        {
            UnlockAllButton();
            listBox_clients.Enabled = true;
        }

        private void button_actionReset_Click(object sender, EventArgs e)
        {
            actions.Clear();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if(!isSomethingChanged)
                Close();
            else
            {
                var result = MessageBox.Show("Сохранить изменения?", "Подтвердите измения", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveData();
                    Close();
                }
                else
                    Close();
            }
        }

        //https://stackoverflow.com/questions/3147043/bind-a-label-to-a-variable
        //INotifyPropertyChanged Интерфейс для фиксации изменения свойства
        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        private void dataGridView_selectedOrder_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            SelectedClient.Orders.ResetItem(SelectedClient.Orders.IndexOf(SelectedOrder));
        }
    }
}
