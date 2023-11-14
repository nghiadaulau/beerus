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
            lblCreateCar.Location = new Point(30, 12);
            lblCreateCar.Name = "lblCreateCar";
            lblCreateCar.Size = new Size(393, 67);
            lblCreateCar.TabIndex = 0;
            lblCreateCar.Text = "Create New Car";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(427, 23);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(54, 61);
            btnExit.TabIndex = 1;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 148);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Car Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(45, 172);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(436, 27);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 223);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "Brand";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(45, 247);
            txtBrand.Margin = new Padding(3, 4, 3, 4);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(436, 27);
            txtBrand.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 296);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 6;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 364);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Car Type";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(45, 459);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(208, 76);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Items.AddRange(new object[] { "Mini", "Sedan", "Hatchback", "CUV Gầm Cao", "SUV Gầm Cao", "MPV Gầm thấp", "Bán tải" });
            cmbModel.Location = new Point(45, 320);
            cmbModel.Margin = new Padding(3, 4, 3, 4);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(436, 28);
            cmbModel.TabIndex = 9;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "4 seats", "5 seats", "7 seats", "7 seats", "truck" });
            cmbType.Location = new Point(45, 400);
            cmbType.Margin = new Padding(3, 4, 3, 4);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(436, 28);
            cmbType.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(273, 459);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(208, 76);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormCreateCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCreateCar";
            Text = "FormCreateCar";
            Load += FormCreateCar_Load;
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