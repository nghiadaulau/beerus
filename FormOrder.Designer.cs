namespace beerus
{
    partial class FormOrder
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
            dgvOrder = new DataGridView();
            panel1 = new Panel();
            btnExit = new Button();
            btnCreate = new Button();
            label1 = new Label();
            dgv = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            customer_id = new DataGridViewTextBoxColumn();
            car_id = new DataGridViewTextBoxColumn();
            rent_time = new DataGridViewTextBoxColumn();
            ColEdit = new DataGridViewButtonColumn();
            ColDel = new DataGridViewButtonColumn();
            Detail = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.BackgroundColor = SystemColors.ButtonFace;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Dock = DockStyle.Fill;
            dgvOrder.Location = new Point(0, 0);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(852, 471);
            dgvOrder.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 77);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(805, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(36, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(563, 21);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(106, 44);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 11);
            label1.Name = "label1";
            label1.Size = new Size(137, 54);
            label1.TabIndex = 0;
            label1.Text = "Order ";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { ID, customer_id, car_id, rent_time, ColEdit, ColDel, Detail });
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 77);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(852, 394);
            dgv.TabIndex = 2;
            dgv.CellClick += dgv_CellClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "order_id";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 93;
            // 
            // customer_id
            // 
            customer_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customer_id.HeaderText = "customer_id";
            customer_id.MinimumWidth = 6;
            customer_id.Name = "customer_id";
            customer_id.ReadOnly = true;
            customer_id.Width = 118;
            // 
            // car_id
            // 
            car_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            car_id.HeaderText = "car_id";
            car_id.MinimumWidth = 6;
            car_id.Name = "car_id";
            car_id.ReadOnly = true;
            car_id.Width = 77;
            // 
            // rent_time
            // 
            rent_time.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rent_time.HeaderText = "rent_time";
            rent_time.MinimumWidth = 6;
            rent_time.Name = "rent_time";
            rent_time.ReadOnly = true;
            // 
            // ColEdit
            // 
            ColEdit.HeaderText = "Edit";
            ColEdit.MinimumWidth = 6;
            ColEdit.Name = "ColEdit";
            ColEdit.ReadOnly = true;
            ColEdit.Text = "Edit";
            ColEdit.UseColumnTextForButtonValue = true;
            ColEdit.Width = 125;
            // 
            // ColDel
            // 
            ColDel.HeaderText = "Delete";
            ColDel.MinimumWidth = 6;
            ColDel.Name = "ColDel";
            ColDel.ReadOnly = true;
            ColDel.Text = "Delete";
            ColDel.UseColumnTextForButtonValue = true;
            ColDel.Width = 125;
            // 
            // Detail
            // 
            Detail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Detail.HeaderText = "Detail";
            Detail.MinimumWidth = 6;
            Detail.Name = "Detail";
            Detail.ReadOnly = true;
            Detail.Text = "...";
            Detail.UseColumnTextForButtonValue = true;
            Detail.Width = 55;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 471);
            Controls.Add(dgv);
            Controls.Add(panel1);
            Controls.Add(dgvOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOrder";
            Text = "FormRentCar";
            Load += FormRentCar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrder;
        private Panel panel1;
        private Button btnExit;
        private Button btnCreate;
        private Label label1;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn car_id;
        private DataGridViewTextBoxColumn rent_time;
        private DataGridViewButtonColumn ColEdit;
        private DataGridViewButtonColumn ColDel;
        private DataGridViewButtonColumn Detail;
    }
}