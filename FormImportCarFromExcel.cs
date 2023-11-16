using ExcelDataReader;
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
using Z.Dapper.Plus;

namespace beerus
{
    public partial class FormImportCarFromExcel : Form
    {
        public FormImportCarFromExcel()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Excel 97-2003 Workbook|*.xls| Excel Workbook|*.xlsx"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true },
                            });
                            tableCollection = result.Tables;
                            chooseSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                chooseSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void chooseSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = tableCollection[chooseSheet.SelectedItem.ToString()];
            if (data != null)
            {
                List<Car> carList = new List<Car>();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    Car car = new Car();
                    car.name = data.Rows[i]["name"].ToString();
                    car.brand = data.Rows[i]["brand"].ToString();
                    car.model = data.Rows[i]["model"].ToString();
                    car.car_type = data.Rows[i]["car_type"].ToString();
                    carList.Add(car);
                }
                carBindingSource2.DataSource = carList;
            }
        }
        
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                DapperPlusManager.Entity<Car>().Table("Car");
                List<Car> carList = carBindingSource2.DataSource as List<Car>;
                string access = db._Access;
                if (carList != null)
                {
                    db.cn.Open();
                    using (IDbConnection dbcon = new SqlConnection(access))
                    {
                        dbcon.BulkInsert(carList);
                    }
                }
                db.cn.Close();
                MessageBox.Show("Success");
                
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
