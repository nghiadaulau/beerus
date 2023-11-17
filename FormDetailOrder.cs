using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beerus
{
    public partial class FormDetailOrder : Form
    {
        private string car_id;
        private string customer_id;
        private string order_id;
        public FormDetailOrder(string customer_id, string car_id, string oder_id)
        {
            InitializeComponent();
            this.customer_id = customer_id;
            this.car_id = car_id;
            this.order_id = oder_id;

        }
        private void loadOrder()
        {
            dgv.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select customer.name, customer.phone, customer.address, car.name, " +
                "car.brand, car.model, car.car_type, o.rent_time from Customer customer, Car car, [Order] o where customer.customer_id = " + customer_id + "and car.car_id =" + car_id + "and o.order_id =" + order_id, db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                dgv.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6], db.dr[7]);
            }
            db.cn.Close();
        }
        private void FormDetailOrder_Load(object sender, EventArgs e)
        {
            loadOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
