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

namespace beerus
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void loadOrder()
        {
            dgv.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from [Order]", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                dgv.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3]);
            }
            db.cn.Close();
        }
        private void FormRentCar_Load(object sender, EventArgs e)
        {
            loadOrder();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddOrder f = new FormAddOrder(this);
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private string getCustomerPhone(string id)
        {
            string result = "";
            db.cn.Open();
            SqlCommand command = new SqlCommand("select phone from Customer where customer_id = " + id, db.cn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = (reader["phone"].ToString());
            }
            db.cn.Close();
            return result;
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgv.Columns[e.ColumnIndex].Name;
            if (colname == "ColEdit")
            {
                FormAddOrder f = new FormAddOrder(this);
                db._id = (int)dgv.CurrentRow.Cells[0].Value;
                f.coBoxCustomer.SelectedValue = dgv.CurrentRow.Cells[1].Value.ToString();
                f.coBoxCustomer.DisplayMember = getCustomerPhone(dgv.CurrentRow.Cells[1].Value.ToString());
                f.carID.DisplayMember = dgv.CurrentRow.Cells[2].Value.ToString();
                f.datetime.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                f.btnUpdate.Visible = true;
                f.btnCreate.Visible = false;
                f.label1.Text = "Update Order";
                f.ShowDialog(this);

            }
            else if (colname == "ColDel")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("delete from [order] where order_id like '" + dgv.CurrentRow.Cells[0].Value + "'", db.cn);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Order has been deleted");
                db.cn.Close();
                loadOrder();
            }
            else if (colname == "Detail")
            {
                FormDetailOrder f = new FormDetailOrder(dgv.CurrentRow.Cells[1].Value.ToString(), dgv.CurrentRow.Cells[2].Value.ToString(), dgv.CurrentRow.Cells[0].Value.ToString());
                f.ShowDialog();
            }
        }
    }
}
