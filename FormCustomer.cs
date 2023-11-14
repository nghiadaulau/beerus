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
    }
}
