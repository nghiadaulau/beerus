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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnManageCar_Click(object sender, EventArgs e)
        {
            FormCarManage f = new FormCarManage();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrder f = new FormOrder();
            f.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer f = new FormCustomer();
            f.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            FormSchedule f = new FormSchedule();
            f.ShowDialog();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            FormStatistic f = new FormStatistic();
            f.ShowDialog();
        }
    }
}
