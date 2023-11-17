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
            db.cm = new System.Data.SqlClient.SqlCommand("select * from car", db.cn);
            db.dr = db.cm.ExecuteReader();
            List<Car> carList = new List<Car>();
            while (db.dr.Read())
            {
                Car car = new Car { car_id = Convert.ToInt32(db.dr[0]), name = db.dr[1].ToString() };
                carList.Add(car);
            }
            db.cn.Close();
            carID.DataSource = carList;
            carID.DisplayMember = "name";
            carID.ValueMember = "car_id";
            db.cn.Close();
        }
        private void addOrder()
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into [order] (customer_id, car_id, rent_time) values (@customer_id, @car_id, @rent_time)", db.cn);
            db.cm.Parameters.AddWithValue("@customer_id", coBoxCustomer.SelectedValue.ToString());
            db.cm.Parameters.AddWithValue("@car_id", carID.SelectedValue.ToString());
            db.cm.Parameters.AddWithValue("@rent_time", datetime.Value);
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
