using OfficeOpenXml;
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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        public void loadCustomer()
        {
            dgvCustomer.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Customer", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                dgvCustomer.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3]);
            }
            db.cn.Close();

        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            loadCustomer();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddCustomer f = new FormAddCustomer(this);
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0 || txtSearch.Text == "")
            {
                loadCustomer();
            }
            else
            {

                string query = "SELECT * FROM customer " +
                               "WHERE name LIKE '%' + @searchValue + '%' OR " +
                               "phone LIKE '%' + @searchValue + '%' OR " +
                               "address LIKE '%' + @searchValue + '%';";
                dgvCustomer.Rows.Clear();
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand(query, db.cn);
                db.cm.Parameters.AddWithValue("@searchValue", txtSearch.Text);
                db.dr = db.cm.ExecuteReader();
                while (db.dr.Read())
                {
                    dgvCustomer.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3]);
                }
                txtSearch.Clear();
                db.cn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadCustomer();
        }


        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colname == "ColEdit")
            {
                FormAddCustomer f = new FormAddCustomer(this);
                db._id = (int)dgvCustomer.CurrentRow.Cells[0].Value;
                f.txtName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                f.txtPhone.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
                f.txtAddress.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
                f.btnUpdate.Visible = true;
                f.btnCreate.Visible = false;
                f.label1.Text = "Update Customer";
                f.ShowDialog(this);

            }
            else if (colname == "ColDelete")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("delete from customer where customer_id like '" + dgvCustomer.CurrentRow.Cells[0].Value + "'", db.cn);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Customer has been deleted");
                db.cn.Close();
                loadCustomer();
            }
        }
        private List<Customer> getData()
        {
            List<Customer> customerList = new List<Customer>();
            for(int i = 0; i< dgvCustomer.Rows.Count; i++) {
                Customer customer = new Customer();
                customer.customer_id = (int)dgvCustomer.Rows[i].Cells[0].Value;
                customer.name = dgvCustomer.Rows[i].Cells[1].Value.ToString();
                customer.phone = dgvCustomer.Rows[i].Cells[2].Value.ToString();
                customer.address = dgvCustomer.Rows[i].Cells[3].Value.ToString();
                customerList.Add(customer);
            }
            return customerList;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx"})
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var fileInfo = new FileInfo(saveFileDialog.FileName);
                        using (var package = new ExcelPackage(fileInfo))
                        {
                            ExcelWorksheet excelWorksheet = package.Workbook.Worksheets.Add("customers");
                            excelWorksheet.Cells.LoadFromCollection<Customer>(getData(), true);
                            package.Save();
                        }
                        MessageBox.Show("Successfully Export Data To Excel File!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                    
                }
            }
        }
    }
}
