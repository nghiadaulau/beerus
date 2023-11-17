namespace beerus
{
    partial class FormAddOrder
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
            coBoxCustomer = new ComboBox();
            carID = new ComboBox();
            label4 = new Label();
            datetime = new DateTimePicker();
            label3 = new Label();
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
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 63);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 12);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 0;
            label1.Text = "Create Order";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(coBoxCustomer);
            panel2.Controls.Add(carID);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(datetime);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 251);
            panel2.TabIndex = 1;
            // 
            // coBoxCustomer
            // 
            coBoxCustomer.FormattingEnabled = true;
            coBoxCustomer.Location = new Point(139, 28);
            coBoxCustomer.Name = "coBoxCustomer";
            coBoxCustomer.Size = new Size(364, 28);
            coBoxCustomer.TabIndex = 7;
            // 
            // carID
            // 
            carID.FormattingEnabled = true;
            carID.Location = new Point(139, 104);
            carID.Name = "carID";
            carID.Size = new Size(364, 28);
            carID.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 181);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 5;
            label4.Text = "Date:";
            // 
            // datetime
            // 
            datetime.Location = new Point(141, 174);
            datetime.Name = "datetime";
            datetime.Size = new Size(362, 27);
            datetime.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 103);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Car ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 31);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Customer Phone:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(364, 385);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(120, 53);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(103, 385);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 53);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(364, 385);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 53);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormAddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(562, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAddOrder";
            Text = "FormAddOrder";
            Load += FormAddOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnExit;
        public DateTimePicker datetime;
        public ComboBox carID;
        public ComboBox coBoxCustomer;
        public Button btnUpdate;
        public Button btnCreate;
        public Label label1;
    }
}