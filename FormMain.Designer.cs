﻿namespace beerus
{
    partial class FormMain
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
            btnManageCar = new Button();
            btnCustomer = new Button();
            btnOrder = new Button();
            btnSchedule = new Button();
            btnStatistic = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(273, 68);
            label1.Name = "label1";
            label1.Size = new Size(911, 67);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO RENTAL CAR SYSTEM";
            // 
            // btnManageCar
            // 
            btnManageCar.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnManageCar.Location = new Point(273, 216);
            btnManageCar.Margin = new Padding(3, 4, 3, 4);
            btnManageCar.Name = "btnManageCar";
            btnManageCar.Size = new Size(331, 139);
            btnManageCar.TabIndex = 1;
            btnManageCar.Text = "Car";
            btnManageCar.UseVisualStyleBackColor = true;
            btnManageCar.Click += btnManageCar_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.Location = new Point(769, 216);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(331, 139);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.Location = new Point(273, 428);
            btnOrder.Margin = new Padding(3, 4, 3, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(331, 139);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchedule.Location = new Point(769, 428);
            btnSchedule.Margin = new Padding(3, 4, 3, 4);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(331, 139);
            btnSchedule.TabIndex = 4;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnStatistic
            // 
            btnStatistic.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnStatistic.Location = new Point(273, 651);
            btnStatistic.Margin = new Padding(3, 4, 3, 4);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(827, 139);
            btnStatistic.TabIndex = 5;
            btnStatistic.Text = "Statistic";
            btnStatistic.UseVisualStyleBackColor = true;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1218, 13);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(61, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1291, 920);
            Controls.Add(btnExit);
            Controls.Add(btnStatistic);
            Controls.Add(btnSchedule);
            Controls.Add(btnOrder);
            Controls.Add(btnCustomer);
            Controls.Add(btnManageCar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnManageCar;
        private Button btnCustomer;
        private Button btnOrder;
        private Button btnSchedule;
        private Button btnStatistic;
        private Button btnExit;
    }
}