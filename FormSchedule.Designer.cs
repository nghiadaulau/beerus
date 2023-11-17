namespace beerus
{
    partial class FormSchedule
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
            dgvSchedule = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            dgvCarStatus = new DataGridView();
            car_id = new DataGridViewTextBoxColumn();
            car_name = new DataGridViewTextBoxColumn();
            car_brand = new DataGridViewTextBoxColumn();
            car_model = new DataGridViewTextBoxColumn();
            car_type = new DataGridViewTextBoxColumn();
            car_returndate = new DataGridViewTextBoxColumn();
            car_status = new DataGridViewTextBoxColumn();
            Order_ID = new DataGridViewTextBoxColumn();
            Customer_ID = new DataGridViewTextBoxColumn();
            CarID = new DataGridViewTextBoxColumn();
            RentDate = new DataGridViewTextBoxColumn();
            ReturnDate = new DataGridViewTextBoxColumn();
            FeatureID = new DataGridViewTextBoxColumn();
            FuelID = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            colConfirm = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarStatus).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(430, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 81);
            label1.TabIndex = 0;
            label1.Text = "Schedule";
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSchedule.BackgroundColor = SystemColors.ButtonFace;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { Order_ID, Customer_ID, CarID, RentDate, ReturnDate, FeatureID, FuelID, TotalPrice, colConfirm });
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(0, 94);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.Size = new Size(1098, 657);
            dgvSchedule.TabIndex = 1;
            dgvSchedule.CellClick += dgvSchedule_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvCarStatus);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 484);
            panel2.Name = "panel2";
            panel2.Size = new Size(1098, 267);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(445, 0);
            label2.Name = "label2";
            label2.Size = new Size(235, 62);
            label2.TabIndex = 1;
            label2.Text = "Car Status";
            // 
            // dgvCarStatus
            // 
            dgvCarStatus.AllowUserToAddRows = false;
            dgvCarStatus.AllowUserToDeleteRows = false;
            dgvCarStatus.BackgroundColor = SystemColors.ButtonFace;
            dgvCarStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarStatus.Columns.AddRange(new DataGridViewColumn[] { car_id, car_name, car_brand, car_model, car_type, car_returndate, car_status });
            dgvCarStatus.Dock = DockStyle.Bottom;
            dgvCarStatus.Location = new Point(0, 75);
            dgvCarStatus.Name = "dgvCarStatus";
            dgvCarStatus.ReadOnly = true;
            dgvCarStatus.RowHeadersWidth = 51;
            dgvCarStatus.RowTemplate.Height = 29;
            dgvCarStatus.Size = new Size(1098, 192);
            dgvCarStatus.TabIndex = 0;
            // 
            // car_id
            // 
            car_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            car_id.HeaderText = "CarID";
            car_id.MinimumWidth = 6;
            car_id.Name = "car_id";
            car_id.ReadOnly = true;
            car_id.Width = 75;
            // 
            // car_name
            // 
            car_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            car_name.HeaderText = "CarName";
            car_name.MinimumWidth = 6;
            car_name.Name = "car_name";
            car_name.ReadOnly = true;
            // 
            // car_brand
            // 
            car_brand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            car_brand.HeaderText = "CarBrand";
            car_brand.MinimumWidth = 6;
            car_brand.Name = "car_brand";
            car_brand.ReadOnly = true;
            // 
            // car_model
            // 
            car_model.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            car_model.HeaderText = "CarModel";
            car_model.MinimumWidth = 6;
            car_model.Name = "car_model";
            car_model.ReadOnly = true;
            // 
            // car_type
            // 
            car_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            car_type.HeaderText = "CarType";
            car_type.MinimumWidth = 6;
            car_type.Name = "car_type";
            car_type.ReadOnly = true;
            // 
            // car_returndate
            // 
            car_returndate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            car_returndate.HeaderText = "ReturnDate";
            car_returndate.MinimumWidth = 6;
            car_returndate.Name = "car_returndate";
            car_returndate.ReadOnly = true;
            // 
            // car_status
            // 
            car_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            car_status.HeaderText = "Status";
            car_status.MinimumWidth = 6;
            car_status.Name = "car_status";
            car_status.ReadOnly = true;
            car_status.Width = 78;
            // 
            // Order_ID
            // 
            Order_ID.HeaderText = "Order_ID";
            Order_ID.MinimumWidth = 6;
            Order_ID.Name = "Order_ID";
            Order_ID.ReadOnly = true;
            // 
            // Customer_ID
            // 
            Customer_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Customer_ID.HeaderText = "Customer_ID";
            Customer_ID.MinimumWidth = 6;
            Customer_ID.Name = "Customer_ID";
            Customer_ID.ReadOnly = true;
            Customer_ID.Width = 122;
            // 
            // CarID
            // 
            CarID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CarID.HeaderText = "CarID";
            CarID.MinimumWidth = 6;
            CarID.Name = "CarID";
            CarID.ReadOnly = true;
            CarID.Width = 75;
            // 
            // RentDate
            // 
            RentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RentDate.HeaderText = "RentDate";
            RentDate.MinimumWidth = 6;
            RentDate.Name = "RentDate";
            RentDate.ReadOnly = true;
            // 
            // ReturnDate
            // 
            ReturnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReturnDate.HeaderText = "ReturnDate";
            ReturnDate.MinimumWidth = 6;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            // 
            // FeatureID
            // 
            FeatureID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FeatureID.HeaderText = "FeatureID";
            FeatureID.MinimumWidth = 6;
            FeatureID.Name = "FeatureID";
            FeatureID.ReadOnly = true;
            // 
            // FuelID
            // 
            FuelID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FuelID.HeaderText = "FuelID";
            FuelID.MinimumWidth = 6;
            FuelID.Name = "FuelID";
            FuelID.ReadOnly = true;
            FuelID.Width = 80;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // colConfirm
            // 
            colConfirm.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colConfirm.HeaderText = "Confirm";
            colConfirm.MinimumWidth = 6;
            colConfirm.Name = "colConfirm";
            colConfirm.ReadOnly = true;
            colConfirm.Resizable = DataGridViewTriState.True;
            colConfirm.SortMode = DataGridViewColumnSortMode.Automatic;
            colConfirm.Text = "Confirm";
            colConfirm.UseColumnTextForButtonValue = true;
            colConfirm.Width = 91;
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 751);
            Controls.Add(panel2);
            Controls.Add(dgvSchedule);
            Controls.Add(panel1);
            Name = "FormSchedule";
            Text = "FormSchedule";
            Load += FormSchedule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvSchedule;
        private Panel panel2;
        private Label label2;
        private DataGridView dgvCarStatus;
        private DataGridViewTextBoxColumn car_id;
        private DataGridViewTextBoxColumn car_name;
        private DataGridViewTextBoxColumn car_brand;
        private DataGridViewTextBoxColumn car_model;
        private DataGridViewTextBoxColumn car_type;
        private DataGridViewTextBoxColumn car_returndate;
        private DataGridViewTextBoxColumn car_status;
        private DataGridViewTextBoxColumn Order_ID;
        private DataGridViewTextBoxColumn Customer_ID;
        private DataGridViewTextBoxColumn CarID;
        private DataGridViewTextBoxColumn RentDate;
        private DataGridViewTextBoxColumn ReturnDate;
        private DataGridViewTextBoxColumn FeatureID;
        private DataGridViewTextBoxColumn FuelID;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewButtonColumn colConfirm;
    }
}