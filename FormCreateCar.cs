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
    public partial class FormCreateCar : Form
    {
        FormCarManage f = new FormCarManage();
        public FormCreateCar(FormCarManage f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var selectedModel = cmbModel.SelectedItem;
            var selectedCarType = cmbType.SelectedItem;
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống name!");
                txtName.Select();
                return;
            }
            else if (txtBrand.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống brand!");
                txtBrand.Select();
                return;
            }
            else if (selectedModel == null)
            {
                MessageBox.Show("Vui lòng chọn model!");
                return;
            }
            else if (selectedCarType == null)
            {
                MessageBox.Show("Vui lòng chọn loại xe!");
                return;
            }
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into car (name, brand, model, car_type) values (@name, @brand, @model, @car_type)", db.cn);
            db.cm.Parameters.AddWithValue("@name", txtName.Text);
            db.cm.Parameters.AddWithValue("@brand", txtBrand.Text);
            db.cm.Parameters.AddWithValue("@model", selectedModel.ToString());
            db.cm.Parameters.AddWithValue("@car_type", selectedCarType.ToString());
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Car has been created");
            db.cn.Close();
            txtBrand.Clear();
            txtName.Clear();
            cmbModel.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            f.LoadCars();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedModel = cmbModel.SelectedItem;
            var selectedCarType = cmbType.SelectedItem;
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update car set name=@name,brand=@brand,model=@model,car_type=@car_type where car_id='" + db._id + "'", db.cn);
            db.cm.Parameters.AddWithValue("@name", txtName.Text);
            db.cm.Parameters.AddWithValue("@brand", txtBrand.Text);
            db.cm.Parameters.AddWithValue("@model", selectedModel.ToString());
            db.cm.Parameters.AddWithValue("@car_type", selectedCarType.ToString());
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Car has been updated");
            db.cn.Close();
            txtBrand.Clear();
            txtName.Clear();
            cmbModel.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            f.LoadCars();
        }

        private void FormCreateCar_Load(object sender, EventArgs e)
        {

        }
    }
}
