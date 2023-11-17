namespace beerus
{
    partial class FormCustomer
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
            dgvCustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ColEdit = new DataGridViewButtonColumn();
            ColDelete = new DataGridViewButtonColumn();
            label1 = new Label();
            panel2 = new Panel();
            btnExport = new Button();
            txtSearch = new TextBox();
            btnExit = new Button();
            btnSearch = new Button();
            btnCreate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvCustomer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 476);
            panel1.TabIndex = 0;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, ColEdit, ColDelete });
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(0, 0);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(1127, 474);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 53;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Phone";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Address";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // ColEdit
            // 
            ColEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColEdit.HeaderText = "Edit";
            ColEdit.MinimumWidth = 6;
            ColEdit.Name = "ColEdit";
            ColEdit.ReadOnly = true;
            ColEdit.Text = "Edit";
            ColEdit.UseColumnTextForButtonValue = true;
            ColEdit.Width = 41;
            // 
            // ColDelete
            // 
            ColDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColDelete.HeaderText = "Delete";
            ColDelete.MinimumWidth = 6;
            ColDelete.Name = "ColDelete";
            ColDelete.ReadOnly = true;
            ColDelete.Text = "Delete";
            ColDelete.UseColumnTextForButtonValue = true;
            ColDelete.Width = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 3);
            label1.Name = "label1";
            label1.Size = new Size(374, 46);
            label1.TabIndex = 1;
            label1.Text = "Customer Management";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnCreate);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1129, 62);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(955, 11);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(95, 38);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(426, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(239, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1081, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(43, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(680, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 38);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(831, 11);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(99, 38);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1129, 538);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnSearch;
        private Button btnCreate;
        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn ColEdit;
        private DataGridViewButtonColumn ColDelete;
        private Button btnExit;
        private TextBox txtSearch;
        private Button btnExport;
    }
}