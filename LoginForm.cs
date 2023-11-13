using System;

namespace beerus
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống username!");
                txtUserName.Select();
                return;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống password!");
                txtPassword.Select();
                return;
            }
            try
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("select * from users WHERE username='" + txtUserName.Text + "'and password='" + txtPassword.Text + "'", db.cn);
                db.dr = db.cm.ExecuteReader();
                if (db.dr.HasRows)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    FormMain f = new FormMain();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin đăng nhập");
                }
                db.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}