namespace beerus
{
    partial class FormCreateCar
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
            lblCreateCar = new Label();
            btnExit = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtBrand = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCreate = new Button();
            cmbModel = new ComboBox();
            cmbType = new ComboBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lblCreateCar
            // 
            lblCreateCar.AutoSize = true;
            lblCreateCar.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreateCar.Location = new Point(26, 9);
            lblCreateCar.Name = "lblCreateCar";
            lblCreateCar.Size = new Size(317, 54);
            lblCreateCar.TabIndex = 0;
            lblCreateCar.Text = "Create New Car";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(374, 17);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(47, 46);
            btnExit.TabIndex = 1;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 111);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Car Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(39, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(382, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 167);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Brand";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(39, 185);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(382, 23);
            txtBrand.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 222);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 273);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Car Type";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(39, 344);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(182, 57);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Items.AddRange(new object[] { "Mini", "Sedan", "Hatchback", "CUV Gầm Cao", "SUV Gầm Cao", "MPV Gầm thấp", "Bán tải" });
            cmbModel.Location = new Point(39, 240);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(382, 23);
            cmbModel.TabIndex = 9;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "4 seats", "5 seats", "7 seats", "7 seats", "truck" });
            cmbType.Location = new Point(39, 300);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(382, 23);
            cmbType.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(239, 344);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(182, 57);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormCreateCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(btnUpdate);
            Controls.Add(cmbType);
            Controls.Add(cmbModel);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBrand);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(lblCreateCar);
            Name = "FormCreateCar";
            Text = "FormCreateCar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox txtName;
        public TextBox txtBrand;
        public ComboBox cmbModel;
        public ComboBox cmbType;
        public Button btnUpdate;
        public Button btnCreate;
        public Label lblCreateCar;
    }
}