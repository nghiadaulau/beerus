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
    public partial class FormCarManage : Form
    {

        public FormCarManage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void LoadCars()
        {
            int i = 0;
            dGVCarManage.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from car", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                i++;
                dGVCarManage.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4]);
            }
            db.cn.Close();
        }

        private void FormCarManage_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnCreateNewCar_Click(object sender, EventArgs e)
        {
            FormCreateCar f = new FormCreateCar(this);
            f.ShowDialog();
        }

        private void dGVCarManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dGVCarManage.Columns[e.ColumnIndex].Name;
            if (colname == "ColEdit")
            {
                FormCreateCar f = new FormCreateCar(this);
                db._id = (int)dGVCarManage.CurrentRow.Cells[0].Value;
                f.txtName.Text = dGVCarManage.CurrentRow.Cells[1].Value.ToString();
                f.txtBrand.Text = dGVCarManage.CurrentRow.Cells[2].Value.ToString();
                f.cmbModel.SelectedItem = dGVCarManage.CurrentRow.Cells[3].Value.ToString();
                f.cmbType.SelectedItem = dGVCarManage.CurrentRow.Cells[4].Value.ToString();
                f.btnUpdate.Enabled = true;
                f.btnCreate.Enabled = false;
                f.lblCreateCar.Text = "Update Car";
                f.ShowDialog(this);

            }
            else if (colname == "ColDel")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("delete from car where car_id like '" + dGVCarManage.CurrentRow.Cells[0].Value + "'", db.cn);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Car has been delete");
                db.cn.Close();
                LoadCars();
            }
        }

        private void dGVCarManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0 || txtSearch.Text == "")
            {
                LoadCars();
            }
            else
            {
                int i = 0;
                string query = "SELECT * FROM car " +
                               "WHERE brand LIKE '%' + @searchValue + '%' OR " +
                               "model LIKE '%' + @searchValue + '%' OR " +
                               "car_type LIKE '%' + @searchValue + '%';";
                dGVCarManage.Rows.Clear();
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand(query, db.cn);
                db.cm.Parameters.AddWithValue("@searchValue", txtSearch.Text);
                db.dr = db.cm.ExecuteReader();
                while (db.dr.Read())
                {
                    i++;
                    dGVCarManage.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4]);
                }
                db.cn.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadCars();
        }
    }
}
