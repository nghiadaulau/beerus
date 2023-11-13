using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace beerus
{
    internal class db
    {
        protected private static string DBName = "midterm";

        public static string _Access = @"Data Source=;Initial Catalog='" + DBName + "';User ID=;Password=";

        public static SqlConnection cn = new SqlConnection(_Access);
        public static SqlCommand cm = new SqlCommand("", cn);
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static SqlDataReader dr = null;
        public static DataTable dt = new DataTable();

        public static int _id = 0;
        public static byte[] _img;

        public static void FormatDataGridRow(DataGridView dgv, string TypeFormat, int NumberOfCell)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[NumberOfCell].Value.ToString() == TypeFormat)
                {
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
        public static void FormatDataGridCell(DataGridView dgv, string TypeFormat, int NumberOfCell)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[NumberOfCell].Value.ToString() == TypeFormat)
                {

                    row.Cells[NumberOfCell].Style.BackColor = Color.OrangeRed;
                }
                else
                {
                    row.Cells[NumberOfCell].Style.BackColor = Color.Green;
                }
            }
        }


        public static void ShowData(string TableName, DataGridView dgv)
        {

            dt.Rows.Clear();
            cn.Open();
            da = new SqlDataAdapter("select * from " + TableName + " ", cn);
            da.Fill(dt);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dt;
            cn.Close();
        }
        public static void ShowDataSearch(string TableName, string FieldName, string PlaceSearch, DataGridView dgv)
        {
            dt.Rows.Clear();
            cn.Open();
            da = new SqlDataAdapter("select * from " + TableName + " where " + FieldName + " LIKE '%" + PlaceSearch + "%' ", cn);
            da.Fill(dt);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dt;
            cn.Close();
        }
        public static void DeleteData(string TableName, DataGridView dgv)
        {
            cn.Open();
            cm = new SqlCommand("Delete  from " + TableName + " where id=@id ", cn);
            cm.Parameters.AddWithValue(@"id", dgv.CurrentRow.Cells[0].Value);
            cm.ExecuteNonQuery();
            cn.Close();
            ConfirmDelete();

        }

        public static void Btn(Button btn, Panel pl)
        {
            pl.Height = btn.Height;
            pl.Top = btn.Top;

        }
        public static void FillCombo(string TableName, ComboBox ComboName, int FieldNumber)
        {
            cn.Open();
            cm = new SqlCommand("select * from " + TableName + "", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ComboName.Items.Add(dr[FieldNumber]);
            }
            cn.Close();
        }
        public static void FillComboinDataGrid(string TableName, DataGridViewComboBoxColumn ComboName, int FieldNumber)
        {
            cn.Open();
            cm = new SqlCommand("select * from " + TableName + "", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ComboName.Items.Add(dr[FieldNumber]);
            }
            cn.Close();
        }

        public static void ClearText(Form FormName)
        {
            foreach (Control c in FormName.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        public static void ConfirmSave()
        {
            MessageBox.Show("Record has been saved successfully");
        }
        public static void ConfirmDelete()
        {
            MessageBox.Show("Record has been Delete successfully");

        }
        public static void ConfirmUpdate()
        {
            MessageBox.Show("Record has been Update successfully");

        }
        public static void ClearImage(PictureBox NamePictureBox)
        {
            NamePictureBox.Image = new PictureBox().Image;
        }

        public static void ScreenFull(Form FormName)
        {
            int heiht = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            FormName.Width = width;
            FormName.Height = heiht - 40;
            FormName.Top = 0;
            FormName.Left = 0;
        }


        public static void ConvertImageToSave(PictureBox PictureBoxName)
        {
            MemoryStream ms = new MemoryStream();
            PictureBoxName.Image.Save(ms, PictureBoxName.Image.RawFormat);
            byte[] img = ms.ToArray();
            _img = img;
            ms.Close();
        }

        public static void OpenImage(PictureBox NamePictureBox)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose image |*.png;*.bmp;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NamePictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }
        public static void ShowImageinPictureBox(PictureBox PictureBoxName, DataGridView Dgv, int NumberCell)
        {
            byte[] img = (byte[])Dgv.CurrentRow.Cells[NumberCell].Value;
            MemoryStream ms = new MemoryStream(img);
            PictureBoxName.Image = Image.FromStream(ms);
        }
    }
}
