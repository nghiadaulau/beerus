namespace beerus
{
    partial class FormImportCarFromExcel
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
            components = new System.ComponentModel.Container();
            dgvRead = new DataGridView();
            carBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            chooseSheet = new ComboBox();
            txtFileName = new TextBox();
            btnBrowser = new Button();
            btnImport = new Button();
            panel1 = new Panel();
            carBindingSource1 = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cartypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvRead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dgvRead
            // 
            dgvRead.AllowUserToAddRows = false;
            dgvRead.AllowUserToDeleteRows = false;
            dgvRead.AutoGenerateColumns = false;
            dgvRead.BackgroundColor = Color.White;
            dgvRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRead.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, cartypeDataGridViewTextBoxColumn });
            dgvRead.DataSource = carBindingSource2;
            dgvRead.Dock = DockStyle.Top;
            dgvRead.Location = new Point(0, 0);
            dgvRead.Name = "dgvRead";
            dgvRead.ReadOnly = true;
            dgvRead.RowHeadersWidth = 51;
            dgvRead.RowTemplate.Height = 29;
            dgvRead.Size = new Size(563, 327);
            dgvRead.TabIndex = 0;
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Car);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Location = new Point(12, 359);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "File Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Location = new Point(12, 392);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Sheet:";
            // 
            // chooseSheet
            // 
            chooseSheet.FormattingEnabled = true;
            chooseSheet.Location = new Point(105, 393);
            chooseSheet.Name = "chooseSheet";
            chooseSheet.Size = new Size(151, 28);
            chooseSheet.TabIndex = 3;
            chooseSheet.SelectedIndexChanged += chooseSheet_SelectedIndexChanged;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(105, 359);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(385, 27);
            txtFileName.TabIndex = 4;
            // 
            // btnBrowser
            // 
            btnBrowser.BackColor = Color.AliceBlue;
            btnBrowser.Location = new Point(496, 33);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Size = new Size(64, 29);
            btnBrowser.TabIndex = 5;
            btnBrowser.Text = "...";
            btnBrowser.UseVisualStyleBackColor = false;
            btnBrowser.Click += btnBrowser_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.AliceBlue;
            btnImport.Location = new Point(273, 392);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 29);
            btnImport.TabIndex = 6;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnBrowser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 125);
            panel1.TabIndex = 7;
            // 
            // carBindingSource1
            // 
            carBindingSource1.DataSource = typeof(Car);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            brandDataGridViewTextBoxColumn.HeaderText = "brand";
            brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            modelDataGridViewTextBoxColumn.HeaderText = "model";
            modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // cartypeDataGridViewTextBoxColumn
            // 
            cartypeDataGridViewTextBoxColumn.DataPropertyName = "car_type";
            cartypeDataGridViewTextBoxColumn.HeaderText = "car_type";
            cartypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            cartypeDataGridViewTextBoxColumn.Name = "cartypeDataGridViewTextBoxColumn";
            cartypeDataGridViewTextBoxColumn.ReadOnly = true;
            cartypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // carBindingSource2
            // 
            carBindingSource2.DataSource = typeof(Car);
            // 
            // FormImportCarFromExcel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(btnImport);
            Controls.Add(txtFileName);
            Controls.Add(chooseSheet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRead);
            Controls.Add(panel1);
            Name = "FormImportCarFromExcel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Read Excel File";
            ((System.ComponentModel.ISupportInitialize)dgvRead).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)carBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRead;
        private Label label1;
        private Label label2;
        private ComboBox chooseSheet;
        private TextBox txtFileName;
        private Button btnBrowser;
        private Button btnImport;
        private Panel panel1;
        private DataGridViewTextBoxColumn caridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cartypeDataGridViewTextBoxColumn;
        private BindingSource carBindingSource;
        private DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private BindingSource carBindingSource1;
        private BindingSource carBindingSource2;
    }
}