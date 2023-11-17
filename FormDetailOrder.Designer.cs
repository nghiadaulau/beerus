namespace beerus
{
    partial class FormDetailOrder
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
            button1 = new Button();
            label1 = new Label();
            dgv = new DataGridView();
            CustomerName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            CarName = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            CarType = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            Feature = new DataGridViewTextBoxColumn();
            Fuel = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1294, 84);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1258, 3);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 1;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(518, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 62);
            label1.TabIndex = 0;
            label1.Text = "Order Detail";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { CustomerName, Phone, Address, CarName, Brand, Model, CarType, DateTime, Feature, Fuel });
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 84);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1294, 125);
            dgv.TabIndex = 1;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "CustomerName";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 125;
            // 
            // CarName
            // 
            CarName.HeaderText = "CarName";
            CarName.MinimumWidth = 6;
            CarName.Name = "CarName";
            CarName.ReadOnly = true;
            CarName.Width = 125;
            // 
            // Brand
            // 
            Brand.HeaderText = "Brand";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            Brand.Width = 125;
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            Model.ReadOnly = true;
            Model.Width = 125;
            // 
            // CarType
            // 
            CarType.HeaderText = "CarType";
            CarType.MinimumWidth = 6;
            CarType.Name = "CarType";
            CarType.ReadOnly = true;
            CarType.Width = 125;
            // 
            // DateTime
            // 
            DateTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateTime.HeaderText = "RentTime";
            DateTime.MinimumWidth = 6;
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            // 
            // Feature
            // 
            Feature.HeaderText = "Feature";
            Feature.MinimumWidth = 6;
            Feature.Name = "Feature";
            Feature.ReadOnly = true;
            Feature.Width = 125;
            // 
            // Fuel
            // 
            Fuel.HeaderText = "Fuel";
            Fuel.MinimumWidth = 6;
            Fuel.Name = "Fuel";
            Fuel.ReadOnly = true;
            Fuel.Width = 125;
            // 
            // FormDetailOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1294, 209);
            Controls.Add(dgv);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDetailOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDetailOrder";
            Load += FormDetailOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgv;
        private Button button1;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn CarName;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn CarType;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewTextBoxColumn Feature;
        private DataGridViewTextBoxColumn Fuel;
    }
}