namespace beerus
{
    partial class FormStatistic
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
            dgvCarQuantityByBrand = new DataGridView();
            dgvRevenueByCarModel = new DataGridView();
            dgvOrderQuantityByRentTime = new DataGridView();
            dgvOrderQuantityByRentTimeQuarter = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarQuantityByBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueByCarModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderQuantityByRentTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderQuantityByRentTimeQuarter).BeginInit();
            SuspendLayout();
            // 
            // dgvCarQuantityByBrand
            // 
            dgvCarQuantityByBrand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarQuantityByBrand.Location = new Point(14, 83);
            dgvCarQuantityByBrand.Margin = new Padding(3, 4, 3, 4);
            dgvCarQuantityByBrand.Name = "dgvCarQuantityByBrand";
            dgvCarQuantityByBrand.RowHeadersWidth = 51;
            dgvCarQuantityByBrand.RowTemplate.Height = 25;
            dgvCarQuantityByBrand.Size = new Size(274, 200);
            dgvCarQuantityByBrand.TabIndex = 0;
            // 
            // dgvRevenueByCarModel
            // 
            dgvRevenueByCarModel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenueByCarModel.Location = new Point(319, 83);
            dgvRevenueByCarModel.Margin = new Padding(3, 4, 3, 4);
            dgvRevenueByCarModel.Name = "dgvRevenueByCarModel";
            dgvRevenueByCarModel.RowHeadersWidth = 51;
            dgvRevenueByCarModel.RowTemplate.Height = 25;
            dgvRevenueByCarModel.Size = new Size(274, 200);
            dgvRevenueByCarModel.TabIndex = 1;
            // 
            // dgvOrderQuantityByRentTime
            // 
            dgvOrderQuantityByRentTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderQuantityByRentTime.Location = new Point(14, 384);
            dgvOrderQuantityByRentTime.Margin = new Padding(3, 4, 3, 4);
            dgvOrderQuantityByRentTime.Name = "dgvOrderQuantityByRentTime";
            dgvOrderQuantityByRentTime.RowHeadersWidth = 51;
            dgvOrderQuantityByRentTime.RowTemplate.Height = 25;
            dgvOrderQuantityByRentTime.Size = new Size(274, 200);
            dgvOrderQuantityByRentTime.TabIndex = 2;
            // 
            // dgvOrderQuantityByRentTimeQuarter
            // 
            dgvOrderQuantityByRentTimeQuarter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderQuantityByRentTimeQuarter.Location = new Point(319, 384);
            dgvOrderQuantityByRentTimeQuarter.Margin = new Padding(3, 4, 3, 4);
            dgvOrderQuantityByRentTimeQuarter.Name = "dgvOrderQuantityByRentTimeQuarter";
            dgvOrderQuantityByRentTimeQuarter.RowHeadersWidth = 51;
            dgvOrderQuantityByRentTimeQuarter.RowTemplate.Height = 25;
            dgvOrderQuantityByRentTimeQuarter.Size = new Size(274, 200);
            dgvOrderQuantityByRentTimeQuarter.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 4;
            label1.Text = "Statistic by brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 36);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 5;
            label2.Text = "Vehicle Profits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 345);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 6;
            label3.Text = "Statistics by month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 345);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 7;
            label4.Text = "Statistics by year";
            // 
            // FormStatistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 599);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrderQuantityByRentTimeQuarter);
            Controls.Add(dgvOrderQuantityByRentTime);
            Controls.Add(dgvRevenueByCarModel);
            Controls.Add(dgvCarQuantityByBrand);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormStatistic";
            Text = "FormStatistic";
            Load += FormStatistic_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarQuantityByBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueByCarModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderQuantityByRentTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderQuantityByRentTimeQuarter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCarQuantityByBrand;
        private DataGridView dgvRevenueByCarModel;
        private DataGridView dgvOrderQuantityByRentTime;
        private DataGridView dgvOrderQuantityByRentTimeQuarter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}