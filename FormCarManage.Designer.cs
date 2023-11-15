namespace beerus
{
    partial class FormCarManage
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
            label1 = new Label();
            dGVCarManage = new DataGridView();
            CarID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            car_type = new DataGridViewTextBoxColumn();
            ColEdit = new DataGridViewButtonColumn();
            ColDel = new DataGridViewButtonColumn();
            btnExit = new Button();
            btnCreateNewCar = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnReset = new Button();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVCarManage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(349, 54);
            label1.TabIndex = 0;
            label1.Text = "Car Management";
            // 
            // dGVCarManage
            // 
            dGVCarManage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVCarManage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dGVCarManage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVCarManage.Columns.AddRange(new DataGridViewColumn[] { CarID, Name, Brand, Model, car_type, ColEdit, ColDel });
            dGVCarManage.Location = new Point(12, 56);
            dGVCarManage.Name = "dGVCarManage";
            dGVCarManage.RowHeadersVisible = false;
            dGVCarManage.RowTemplate.Height = 25;
            dGVCarManage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVCarManage.Size = new Size(950, 479);
            dGVCarManage.TabIndex = 1;
            dGVCarManage.CellClick += dGVCarManage_CellClick;
            dGVCarManage.CellContentClick += dGVCarManage_CellContentClick;
            // 
            // CarID
            // 
            CarID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CarID.HeaderText = "#";
            CarID.Name = "CarID";
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Brand
            // 
            Brand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brand.HeaderText = "Brand";
            Brand.Name = "Brand";
            // 
            // Model
            // 
            Model.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Model.HeaderText = "Model";
            Model.Name = "Model";
            Model.Width = 66;
            // 
            // car_type
            // 
            car_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            car_type.HeaderText = "Car Type";
            car_type.Name = "car_type";
            car_type.Width = 77;
            // 
            // ColEdit
            // 
            ColEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColEdit.HeaderText = "Edit";
            ColEdit.Name = "ColEdit";
            ColEdit.Text = "Edit";
            ColEdit.UseColumnTextForButtonValue = true;
            ColEdit.Width = 33;
            // 
            // ColDel
            // 
            ColDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColDel.HeaderText = "Delete";
            ColDel.Name = "ColDel";
            ColDel.Text = "Delete";
            ColDel.UseColumnTextForButtonValue = true;
            ColDel.Width = 46;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(910, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 38);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCreateNewCar
            // 
            btnCreateNewCar.Location = new Point(716, 12);
            btnCreateNewCar.Name = "btnCreateNewCar";
            btnCreateNewCar.Size = new Size(121, 38);
            btnCreateNewCar.TabIndex = 3;
            btnCreateNewCar.Text = "Create New Car";
            btnCreateNewCar.UseVisualStyleBackColor = true;
            btnCreateNewCar.Click += btnCreateNewCar_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(355, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 38);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(424, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(217, 23);
            txtSearch.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(647, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(63, 38);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnImport
            // 
            btnImport.ImageAlign = ContentAlignment.MiddleRight;
            btnImport.Location = new Point(843, 12);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(64, 38);
            btnImport.TabIndex = 7;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // FormCarManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 534);
            Controls.Add(btnImport);
            Controls.Add(btnReset);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnCreateNewCar);
            Controls.Add(btnExit);
            Controls.Add(dGVCarManage);
            Controls.Add(label1);
            Text = "FormCarManage";
            Load += FormCarManage_Load;
            ((System.ComponentModel.ISupportInitialize)dGVCarManage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dGVCarManage;
        private Button btnExit;
        private Button btnCreateNewCar;
        private DataGridViewTextBoxColumn CarID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn car_type;
        private DataGridViewButtonColumn ColEdit;
        private DataGridViewButtonColumn ColDel;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnReset;
        private Button btnImport;
    }
}