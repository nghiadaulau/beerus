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
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
            dgvCarQuantityByBrand.Columns.Add("Brand", "Brand");
            dgvCarQuantityByBrand.Columns.Add("TotalCars", "Total Cars");

            dgvRevenueByCarModel.Columns.Add("Model", "Model");
            dgvRevenueByCarModel.Columns.Add("TotalRevenue", "Total Revenue");

            dgvOrderQuantityByRentTime.Columns.Add("RentTime", "Rent Time");
            dgvOrderQuantityByRentTime.Columns.Add("TotalOrders", "Total Orders");

            dgvOrderQuantityByRentTimeQuarter.Columns.Add("RentTime", "Rent Time");
            dgvOrderQuantityByRentTimeQuarter.Columns.Add("TotalOrders", "Total Orders");

        }
        private void DisplayReports()
        {
            DisplayReport("Car Quantity by Brand", "SELECT car.brand, COUNT(*) AS TotalCars FROM Car GROUP BY car.brand", dgvCarQuantityByBrand);

            DisplayReport("Revenue by Car Model", "SELECT car.model, SUM(o.total_price) AS TotalRevenue FROM [Order] o JOIN Car car ON o.car_id = car.car_id GROUP BY car.model", dgvRevenueByCarModel);

            DisplayReport("Order Quantity by Rent Time", "SELECT DATEPART(MONTH, o.rent_time) AS RentMonth, COUNT(*) AS TotalOrders FROM [Order] o GROUP BY DATEPART(MONTH, o.rent_time)", dgvOrderQuantityByRentTime);

            DisplayReport("Order Quantity by Rent Time", "SELECT DATEPART(QUARTER, o.rent_time) AS RentQuarter, COUNT(*) AS TotalOrders FROM [Order] o GROUP BY DATEPART(QUARTER, o.rent_time)", dgvOrderQuantityByRentTimeQuarter);

        }
        private void DisplayReport(string title, string query, DataGridView dataGridView)
        {
            db.cn.Open();
            SqlCommand cmd = new SqlCommand(query, db.cn);
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView.Rows.Clear();

            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];
                reader.GetValues(row);
                dataGridView.Rows.Add(row);
            }

            db.cn.Close();
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            DisplayReports();
        }
    }
}
