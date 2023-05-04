using OrdersManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrdersManager.MainForm;

namespace OrdersManager
{
    public enum NewFormSettings
    {
        WithButtons,
        WithNoButtons,
        WithNoCancel,
        WithNoFinishEdit
    }
    public partial class CustomerForm : Form
    {
        public EventWaitHandle ComliteEditHandle = new EventWaitHandle(false, EventResetMode.AutoReset);
        private static Customer ClientBeforeEdit { get; set; }
        public static bool Result { get; private set; }
        private static Customer SelectedClient { get; set; }
        private static CustomerForm _base;
        public static CustomerForm Base { get { if (_base != null) return _base; else return _base = new CustomerForm(); } }
        private CustomerForm()
        {
            InitializeComponent();
        }
        public static void UpdateData(Customer client, NewFormSettings settings)
        {
            SelectedClient = client;
            if (client != null)
                ClientBeforeEdit = (Customer)client.Clone();
            else
            {
                SelectedClient = new Customer();
                ClientBeforeEdit = new Customer();
            }

            Base.ComliteEditHandle.Reset();
            Base.firstName_textBox.DataBindings.Clear();
            Base.middleName_textBox.DataBindings.Clear(); 
            Base.lastName_textBox.DataBindings.Clear();

            Base.firstName_textBox.DataBindings.Add("Text", SelectedClient, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            Base.middleName_textBox.DataBindings.Add("Text", SelectedClient, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
            Base.lastName_textBox.DataBindings.Add("Text", SelectedClient, "FatherName", true, DataSourceUpdateMode.OnPropertyChanged);

            SetSettings(settings);
        }
        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComliteEditHandle.Set();
            e.Cancel = true;
            Hide();
        }
        protected override void OnShown(EventArgs e)
        {
            if(SelectedClient != null)
            {
                base.OnShown(e);
                Result = false;
            }
        }

        private void button_cancelEdit_Click(object sender, EventArgs e)
        {
            SelectedClient.Became(ClientBeforeEdit);
            Result = false;
            this.Close();
        }

        private void button_comleteEdit_Click(object sender, EventArgs e)
        {
            Result = true;
            this.Close();
        }
        private static void SetSettings(NewFormSettings settings)
        {
            switch (settings)
            {
                case NewFormSettings.WithNoButtons:
                    Base.button_cancelEdit.Enabled = false;
                    Base.button_comleteEdit.Enabled = false;
                    break;
                case NewFormSettings.WithButtons:
                    Base.button_cancelEdit.Enabled = true;
                    Base.button_comleteEdit.Enabled = true;
                    break;
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
