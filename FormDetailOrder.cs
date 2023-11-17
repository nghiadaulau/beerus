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
            db.cm = new System.Data.SqlClient.SqlCommand(
                "SELECT customer.name, customer.phone, customer.address, car.name, " +
                "car.brand, car.model, car.car_type, o.rent_time, " +
                "STRING_AGG(f.name, ', ') AS features, fuel.name " +
                "FROM Customer customer " +
                "JOIN Car car ON customer.customer_id = @customer_id AND car.car_id = @car_id " +
                "JOIN [Order] o ON o.order_id = @order_id " +
                "LEFT JOIN Feature f ON CHARINDEX(',' + CAST(f.feature_id AS VARCHAR) + ',', ',' + o.features_id + ',') > 0 " +
                "LEFT JOIN Fuel fuel ON fuel.fuel_id = o.fuel_id " +
                "GROUP BY customer.name, customer.phone, customer.address, car.name, " +
                "car.brand, car.model, car.car_type, o.rent_time, fuel.name", db.cn);
            db.cm.Parameters.AddWithValue("@customer_id", customer_id);
            db.cm.Parameters.AddWithValue("@car_id", car_id);
            db.cm.Parameters.AddWithValue("@order_id", order_id);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                dgv.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6], db.dr[7], db.dr[8], db.dr[9]);
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
