namespace OrdersManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_clients = new System.Windows.Forms.ListBox();
            this.listBox_orders = new System.Windows.Forms.ListBox();
            this.listBox_actions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label_selectedOrderPrice = new System.Windows.Forms.Label();
            this.panel_clientManagement = new System.Windows.Forms.Panel();
            this.button_clientListSave = new System.Windows.Forms.Button();
            this.button_clientRemove = new System.Windows.Forms.Button();
            this.button_clientEdit = new System.Windows.Forms.Button();
            this.button_clientNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_orderCompletedList = new System.Windows.Forms.Button();
            this.button_orderListSave = new System.Windows.Forms.Button();
            this.button_orderPrint = new System.Windows.Forms.Button();
            this.button_orderDelete = new System.Windows.Forms.Button();
            this.button_orderNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_actionReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_clientManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_clients
            // 
            this.listBox_clients.FormattingEnabled = true;
            this.listBox_clients.Location = new System.Drawing.Point(12, 39);
            this.listBox_clients.Name = "listBox_clients";
            this.listBox_clients.Size = new System.Drawing.Size(205, 225);
            this.listBox_clients.TabIndex = 0;
            // 
            // listBox_orders
            // 
            this.listBox_orders.FormattingEnabled = true;
            this.listBox_orders.Location = new System.Drawing.Point(236, 39);
            this.listBox_orders.Name = "listBox_orders";
            this.listBox_orders.Size = new System.Drawing.Size(205, 225);
            this.listBox_orders.TabIndex = 1;
            // 
            // listBox_actions
            // 
            this.listBox_actions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_actions.FormattingEnabled = true;
            this.listBox_actions.Location = new System.Drawing.Point(583, 39);
            this.listBox_actions.Name = "listBox_actions";
            this.listBox_actions.Size = new System.Drawing.Size(418, 225);
            this.listBox_actions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список клиентов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список заказов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(583, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус состояния";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 210);
            this.dataGridView1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена заказа:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_selectedOrderPrice
            // 
            this.label_selectedOrderPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_selectedOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_selectedOrderPrice.Location = new System.Drawing.Point(236, 496);
            this.label_selectedOrderPrice.Name = "label_selectedOrderPrice";
            this.label_selectedOrderPrice.Size = new System.Drawing.Size(205, 23);
            this.label_selectedOrderPrice.TabIndex = 8;
            this.label_selectedOrderPrice.Text = "0";
            this.label_selectedOrderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_clientManagement
            // 
            this.panel_clientManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_clientManagement.Controls.Add(this.button_clientListSave);
            this.panel_clientManagement.Controls.Add(this.button_clientRemove);
            this.panel_clientManagement.Controls.Add(this.button_clientEdit);
            this.panel_clientManagement.Controls.Add(this.button_clientNew);
            this.panel_clientManagement.Location = new System.Drawing.Point(471, 283);
            this.panel_clientManagement.Name = "panel_clientManagement";
            this.panel_clientManagement.Size = new System.Drawing.Size(530, 67);
            this.panel_clientManagement.TabIndex = 9;
            // 
            // button_clientListSave
            // 
            this.button_clientListSave.Location = new System.Drawing.Point(3, 38);
            this.button_clientListSave.Name = "button_clientListSave";
            this.button_clientListSave.Size = new System.Drawing.Size(135, 23);
            this.button_clientListSave.TabIndex = 3;
            this.button_clientListSave.Text = "Сохранить список клиентов";
            this.button_clientListSave.UseVisualStyleBackColor = true;
            this.button_clientListSave.Click += new System.EventHandler(ClientButtons.button_clientListSave_Click);
            // 
            // button_clientRemove
            // 
            this.button_clientRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clientRemove.Location = new System.Drawing.Point(384, 9);
            this.button_clientRemove.Name = "button_clientRemove";
            this.button_clientRemove.Size = new System.Drawing.Size(143, 23);
            this.button_clientRemove.TabIndex = 2;
            this.button_clientRemove.Text = "Удалить клиента";
            this.button_clientRemove.UseVisualStyleBackColor = true;
            this.button_clientRemove.Click += new System.EventHandler(ClientButtons.button_clientRemove_Click);
            // 
            // button_clientEdit
            // 
            this.button_clientEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clientEdit.Location = new System.Drawing.Point(147, 9);
            this.button_clientEdit.Name = "button_clientEdit";
            this.button_clientEdit.Size = new System.Drawing.Size(231, 23);
            this.button_clientEdit.TabIndex = 1;
            this.button_clientEdit.Text = "Редактировать клиента";
            this.button_clientEdit.UseVisualStyleBackColor = true;
            this.button_clientEdit.Click += new System.EventHandler(ClientButtons.button_clientEdit_Click);
            // 
            // button_clientNew
            // 
            this.button_clientNew.Location = new System.Drawing.Point(3, 9);
            this.button_clientNew.Name = "button_clientNew";
            this.button_clientNew.Size = new System.Drawing.Size(135, 23);
            this.button_clientNew.TabIndex = 0;
            this.button_clientNew.Text = "Новый клиент";
            this.button_clientNew.UseVisualStyleBackColor = true;
            this.button_clientNew.Click += new System.EventHandler(ClientButtons.button_clientNew_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button_orderCompletedList);
            this.panel1.Controls.Add(this.button_orderListSave);
            this.panel1.Controls.Add(this.button_orderPrint);
            this.panel1.Controls.Add(this.button_orderDelete);
            this.panel1.Controls.Add(this.button_orderNew);
            this.panel1.Location = new System.Drawing.Point(471, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 67);
            this.panel1.TabIndex = 10;
            // 
            // button_orderCompletedList
            // 
            this.button_orderCompletedList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_orderCompletedList.Location = new System.Drawing.Point(262, 41);
            this.button_orderCompletedList.Name = "button_orderCompletedList";
            this.button_orderCompletedList.Size = new System.Drawing.Size(265, 23);
            this.button_orderCompletedList.TabIndex = 8;
            this.button_orderCompletedList.Text = "Список готовых заказов";
            this.button_orderCompletedList.UseVisualStyleBackColor = true;
            this.button_orderCompletedList.Click += new System.EventHandler(OrderButtons.button_orderCompletedList_Click);
            // 
            // button_orderListSave
            // 
            this.button_orderListSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_orderListSave.Location = new System.Drawing.Point(3, 41);
            this.button_orderListSave.Name = "button_orderListSave";
            this.button_orderListSave.Size = new System.Drawing.Size(253, 23);
            this.button_orderListSave.TabIndex = 7;
            this.button_orderListSave.Text = "Сохранить сисок заказов";
            this.button_orderListSave.UseVisualStyleBackColor = true;
            this.button_orderListSave.Click += new System.EventHandler(OrderButtons.button_orderListSave_Click);
            // 
            // button_orderPrint
            // 
            this.button_orderPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_orderPrint.Location = new System.Drawing.Point(376, 10);
            this.button_orderPrint.Name = "button_orderPrint";
            this.button_orderPrint.Size = new System.Drawing.Size(151, 23);
            this.button_orderPrint.TabIndex = 6;
            this.button_orderPrint.Text = "Печать заказа";
            this.button_orderPrint.UseVisualStyleBackColor = true;
            this.button_orderPrint.Click += new System.EventHandler(OrderButtons.button_orderPrint_Click);
            // 
            // button_orderDelete
            // 
            this.button_orderDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_orderDelete.Location = new System.Drawing.Point(147, 10);
            this.button_orderDelete.Name = "button_orderDelete";
            this.button_orderDelete.Size = new System.Drawing.Size(223, 23);
            this.button_orderDelete.TabIndex = 5;
            this.button_orderDelete.Text = "Удалить заказ";
            this.button_orderDelete.UseVisualStyleBackColor = true;
            this.button_orderDelete.Click += new System.EventHandler(OrderButtons.button_orderDelete_Click);
            // 
            // button_orderNew
            // 
            this.button_orderNew.Location = new System.Drawing.Point(3, 10);
            this.button_orderNew.Name = "button_orderNew";
            this.button_orderNew.Size = new System.Drawing.Size(135, 23);
            this.button_orderNew.TabIndex = 4;
            this.button_orderNew.Text = "Новый заказ";
            this.button_orderNew.UseVisualStyleBackColor = true;
            this.button_orderNew.Click += new System.EventHandler(OrderButtons.button_orderNew_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Клиенты";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Заказы";
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Location = new System.Drawing.Point(923, 496);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 13;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // button_actionReset
            // 
            this.button_actionReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_actionReset.Location = new System.Drawing.Point(780, 496);
            this.button_actionReset.Name = "button_actionReset";
            this.button_actionReset.Size = new System.Drawing.Size(124, 23);
            this.button_actionReset.TabIndex = 14;
            this.button_actionReset.Text = "Сброс состояний";
            this.button_actionReset.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 529);
            this.Controls.Add(this.button_actionReset);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_clientManagement);
            this.Controls.Add(this.label_selectedOrderPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_actions);
            this.Controls.Add(this.listBox_orders);
            this.Controls.Add(this.listBox_clients);
            this.MinimumSize = new System.Drawing.Size(1029, 568);
            this.Name = "MainForm";
            this.Text = "Программа управления заказами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_clientManagement.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_clients;
        private System.Windows.Forms.ListBox listBox_orders;
        private System.Windows.Forms.ListBox listBox_actions;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_selectedOrderPrice;
        private System.Windows.Forms.Panel panel_clientManagement;
        private System.Windows.Forms.Button button_clientListSave;
        private System.Windows.Forms.Button button_clientRemove;
        private System.Windows.Forms.Button button_clientEdit;
        private System.Windows.Forms.Button button_clientNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_orderCompletedList;
        private System.Windows.Forms.Button button_orderListSave;
        private System.Windows.Forms.Button button_orderPrint;
        private System.Windows.Forms.Button button_orderDelete;
        private System.Windows.Forms.Button button_orderNew;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_actionReset;
    }
}

