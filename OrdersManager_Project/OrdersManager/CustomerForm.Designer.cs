namespace OrdersManager
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.panel_clientManagement = new System.Windows.Forms.Panel();
            this.button_cancelEdit = new System.Windows.Forms.Button();
            this.button_comleteEdit = new System.Windows.Forms.Button();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.middleName_textBox = new System.Windows.Forms.TextBox();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.panel_clientManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Клиент";
            // 
            // panel_clientManagement
            // 
            this.panel_clientManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_clientManagement.Controls.Add(this.button_cancelEdit);
            this.panel_clientManagement.Controls.Add(this.button_comleteEdit);
            this.panel_clientManagement.Controls.Add(this.lastName_textBox);
            this.panel_clientManagement.Controls.Add(this.middleName_textBox);
            this.panel_clientManagement.Controls.Add(this.firstName_textBox);
            this.panel_clientManagement.Location = new System.Drawing.Point(12, 16);
            this.panel_clientManagement.Name = "panel_clientManagement";
            this.panel_clientManagement.Size = new System.Drawing.Size(343, 70);
            this.panel_clientManagement.TabIndex = 12;
            // 
            // button_cancelEdit
            // 
            this.button_cancelEdit.Location = new System.Drawing.Point(166, 35);
            this.button_cancelEdit.Name = "button_cancelEdit";
            this.button_cancelEdit.Size = new System.Drawing.Size(80, 23);
            this.button_cancelEdit.TabIndex = 4;
            this.button_cancelEdit.Text = "Отмена";
            this.button_cancelEdit.UseVisualStyleBackColor = true;
            this.button_cancelEdit.Click += new System.EventHandler(this.button_cancelEdit_Click);
            // 
            // button_comleteEdit
            // 
            this.button_comleteEdit.Location = new System.Drawing.Point(252, 35);
            this.button_comleteEdit.Name = "button_comleteEdit";
            this.button_comleteEdit.Size = new System.Drawing.Size(75, 23);
            this.button_comleteEdit.TabIndex = 3;
            this.button_comleteEdit.Text = "ОК";
            this.button_comleteEdit.UseVisualStyleBackColor = true;
            this.button_comleteEdit.Click += new System.EventHandler(this.button_comleteEdit_Click);
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName_textBox.Location = new System.Drawing.Point(227, 9);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(100, 20);
            this.lastName_textBox.TabIndex = 2;
            // 
            // middleName_textBox
            // 
            this.middleName_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.middleName_textBox.Location = new System.Drawing.Point(121, 9);
            this.middleName_textBox.Name = "middleName_textBox";
            this.middleName_textBox.Size = new System.Drawing.Size(100, 20);
            this.middleName_textBox.TabIndex = 1;
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Location = new System.Drawing.Point(15, 9);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(100, 20);
            this.firstName_textBox.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 95);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_clientManagement);
            this.MinimumSize = new System.Drawing.Size(384, 103);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel_clientManagement.ResumeLayout(false);
            this.panel_clientManagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_clientManagement;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.TextBox middleName_textBox;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.Button button_cancelEdit;
        private System.Windows.Forms.Button button_comleteEdit;
    }
}