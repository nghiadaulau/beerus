using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beerus
{
    public partial class FormAddCustomer : Form
    {
        FormCustomer customer = new FormCustomer();
        public FormAddCustomer(FormCustomer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }
        private void addCustomer()
        {

            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into customer (name, phone, address) values (@name, @phone, @address)", db.cn);
            db.cm.Parameters.AddWithValue("@name", txtName.Text);
            db.cm.Parameters.AddWithValue("@phone", txtPhone.Text);
            db.cm.Parameters.AddWithValue("@address", txtAddress.Text);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Customer has been created");
            db.cn.Close();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            customer.loadCustomer();
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update customer set name=@name, phone=@phone, address=@address where customer_id='" + db._id + "'", db.cn);
            db.cm.Parameters.AddWithValue("@name", txtName.Text);
            db.cm.Parameters.AddWithValue("@phone", txtPhone.Text);
            db.cm.Parameters.AddWithValue("@address", txtAddress.Text);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Customer has been updated");
            db.cn.Close();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            customer.loadCustomer();
            Dispose();
        }
    }
}
