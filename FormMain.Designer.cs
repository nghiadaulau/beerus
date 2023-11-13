namespace beerus
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
            label1.Location = new Point(239, 51);
            label1.Name = "label1";
            label1.Size = new Size(724, 54);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO RENTAL CAR SYSTEM";
            // 
            // btnManageCar
            // 
            btnManageCar.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnManageCar.Location = new Point(239, 162);
            btnManageCar.Name = "btnManageCar";
            btnManageCar.Size = new Size(290, 104);
            btnManageCar.TabIndex = 1;
            btnManageCar.Text = "Car";
            btnManageCar.UseVisualStyleBackColor = true;
            btnManageCar.Click += btnManageCar_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.Location = new Point(673, 162);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(290, 104);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.Location = new Point(239, 321);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(290, 104);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            btnSchedule.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchedule.Location = new Point(673, 321);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(290, 104);
            btnSchedule.TabIndex = 4;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            btnStatistic.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnStatistic.Location = new Point(239, 488);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(724, 104);
            btnStatistic.TabIndex = 5;
            btnStatistic.Text = "Statistic";
            btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1043, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 54);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 690);
            Controls.Add(btnExit);
            Controls.Add(btnStatistic);
            Controls.Add(btnSchedule);
            Controls.Add(btnOrder);
            Controls.Add(btnCustomer);
            Controls.Add(btnManageCar);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "FormMain";
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