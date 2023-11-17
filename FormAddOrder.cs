using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace beerus
{
    public partial class FormAddOrder : Form
    {
        FormOrder formOrder = new FormOrder();
        private string fuel = "";
        public FormAddOrder(FormOrder formOrder)
        {
            InitializeComponent();
            this.formOrder = formOrder;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loadCustomer()
        {
            db.cn.Open();
            SqlCommand command = new SqlCommand("select customer_id, phone from Customer", db.cn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            coBoxCustomer.DataSource = dt;
            coBoxCustomer.DisplayMember = "phone";
            coBoxCustomer.ValueMember = "customer_id";
            db.cn.Close();
        }
        private void loadCars()
        {
            db.cn.Open();
            SqlCommand command = new SqlCommand("select car_id from Car", db.cn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            carID.DataSource = dt;
            carID.DisplayMember = "car_id";
            carID.ValueMember = "car_id";
            db.cn.Close();
        }
        private string getCheckBoxValue()
        {
            string result = "";
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    if (checkBox.Checked)
                    {
                        result = checkBox.Text + " " + result;
                    }
                }
            }
            return result;
        }
        private void addOrder()
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into [order] (customer_id, car_id, rent_time, feature, fuel) values (@customer_id, @car_id, @rent_time, @feature, @fuel)", db.cn);
            db.cm.Parameters.AddWithValue("@customer_id", coBoxCustomer.SelectedValue.ToString());
            db.cm.Parameters.AddWithValue("@car_id", carID.SelectedValue.ToString());
            db.cm.Parameters.AddWithValue("@rent_time", datetime.Value);
            db.cm.Parameters.AddWithValue("@feature", getCheckBoxValue());

            db.cm.ExecuteNonQuery();
            MessageBox.Show("Order has been created");
            db.cn.Close();
            formOrder.loadOrder();
            Dispose();
        }
        private void FormAddOrder_Load(object sender, EventArgs e)
        {
            loadCustomer();
            loadCars();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            addOrder();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update [order] set customer_id=@customer_id, car_id=@car_id, rent_time=@rent_time where order_id='" + db._id + "'", db.cn);
            db.cm.Parameters.AddWithValue("@customer_id", coBoxCustomer.SelectedValue.ToString());
            db.cm.Parameters.AddWithValue("@car_id", carID.SelectedValue.ToString());
            db.cm.Parameters.AddWithValue("@rent_time", datetime.Value);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Order has been updated");
            db.cn.Close();
            formOrder.loadOrder();
            Dispose();
        }


    }
}
