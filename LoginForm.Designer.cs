namespace beerus
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            txtUserName = new TextBox();
            lblUsername = new Label();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Sans Serif Collection", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(12, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(779, 99);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "RENTAL CAR SYSTEM";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(240, 187);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(384, 30);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "admin";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(143, 187);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(191, 345);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(138, 46);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(143, 264);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(84, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(241, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(384, 30);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "admin";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(457, 345);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(167, 46);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(814, 453);
            Controls.Add(btnExit);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblUsername);
            Controls.Add(txtUserName);
            Controls.Add(lblWelcome);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TextBox txtUserName;
        private Label lblUsername;
        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnExit;
    }
}