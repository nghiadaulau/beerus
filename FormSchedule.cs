using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace beerus
{
    public partial class FormSchedule : Form
    {
        public FormSchedule()
        {
            InitializeComponent();
        }
        private void loadSchedule()
        {
            dgvSchedule.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select customer_id, car_id, rent_time, return_time, features_id, fuel_id, total_price from [Order]", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                dgvSchedule.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6]);
            }
            db.cn.Close();
        }
        private void loadCarStatus()
        {
            dgvCarStatus.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("SELECT c.car_id, c.name, c.brand, c.model, c.car_type, o.return_time, " +
                   "CASE WHEN o.return_time IS NOT NULL THEN 'Renting' ELSE 'Free' END AS Status " +
                   "FROM Car c LEFT JOIN [Order] o ON c.car_id = o.car_id", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                dgvCarStatus.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6]);
            }

            db.cn.Close();
        }
        private void FormSchedule_Load(object sender, EventArgs e)
        {
            loadSchedule();
            loadCarStatus();
        }
        private bool checkExist(int id, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!string.IsNullOrEmpty(arr[i]) && int.TryParse(arr[i], out int currentValue))
                {
                    if (currentValue == id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private double getCarPrice(string id)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select price from Car where car_id=" + id, db.cn);
            db.dr = db.cm.ExecuteReader();
            double price = 0;
            while (db.dr.Read())
            {
                price += Convert.ToDouble(db.dr[0]);
            }
            db.cn.Close();
            return price;
        }
        private double getFuelPrice(string id)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select price from Fuel where fuel_id=" + id, db.cn);
            db.dr = db.cm.ExecuteReader();
            double price = 0;
            while (db.dr.Read())
            {
                price += Convert.ToDouble(db.dr[0]);
            }
            db.cn.Close();
            return price;
        }
        private double getFeaturePrice(string id)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Feature", db.cn);
            db.dr = db.cm.ExecuteReader();
            List<Car> carList = new List<Car>();
            string[] idList = id.Split(",");
            double price = 0;
            while (db.dr.Read())
            {
                if (checkExist(Convert.ToInt32(db.dr[0]), idList))
                {
                    price += Convert.ToDouble(db.dr[0]);
                }

            }
            db.cn.Close();
            return price;
        }
        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvSchedule.Columns[e.ColumnIndex].Name;
            if (colname == "Confirm")
            {
                Double total = 0;
                db._id = (int)dgvSchedule.CurrentRow.Cells[0].Value;
                total += getFeaturePrice(dgvSchedule.CurrentRow.Cells[4].Value.ToString()) + getFuelPrice(dgvSchedule.CurrentRow.Cells[5].Value.ToString())
                    + getCarPrice(dgvSchedule.CurrentRow.Cells[1].Value.ToString());
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("update [order] set return_time=@return_time, total_price=@total_price where order_id='" + db._id + "'", db.cn);
                db.cm.Parameters.AddWithValue("@return_time", DateTime.Now);
                db.cm.Parameters.AddWithValue("@total_price", total);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Updated");
                db.cn.Close();
                loadSchedule();
            }
        }
    }
}
