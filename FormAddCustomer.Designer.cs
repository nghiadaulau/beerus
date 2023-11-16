namespace beerus
{
    partial class FormAddCustomer
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtAddress = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            btnCreate = new Button();
            btnExit = new Button();
            btnUpdate = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 14);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 0;
            label1.Text = "Create Customer";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 324);
            panel2.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 231);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(495, 27);
            txtAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 200);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 147);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(495, 27);
            txtPhone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(495, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(311, 456);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(181, 42);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(52, 456);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(181, 42);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button2_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(311, 456);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(181, 42);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormAddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(555, 523);
            Controls.Add(btnUpdate);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddCustomer";
            Text = "FormAddCustomer";
            Load += FormAddCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private Label label3;
        public TextBox txtAddress;
        public TextBox txtPhone;
        public TextBox txtName;
        public Button btnCreate;
        public Button btnExit;
        public Button btnUpdate;
        public Label label1;
    }
}