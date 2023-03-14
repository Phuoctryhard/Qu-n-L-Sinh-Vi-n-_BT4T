using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap5_ConnectDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllClass();
        }

        private void AllClass()
        {
            List<string> list = new List<string>();
            string query = "Select Distinct LopSH From SV ";
            DataTable dt = DBHelper.Instance.GetDataTable(query);
            foreach(DataRow row in dt.Rows)
            {
                list.Add(row["LopSH"].ToString());
            }
            comboBoxSelectClass.Items.Clear();
            comboBoxSelectClass.Items.Add("All");
            comboBoxSelectClass.Items.AddRange(list.ToArray());
        }

        private void LoadAllSV()
        {
            string query = "Select * From SV ";
            dataGridView1.DataSource = DBHelper.Instance.GetDataTable(query);
            comboBoxSelectClass.SelectedIndex = 0;
            textBox_selectString.Text = "";
        }

        private bool CheckHaveSV(int mssv)
        {
            string query = "Select COUNT(*) From SV Where MSSV = " + mssv;
            if (DBHelper.Instance.ExecuteScalar(query) == 1) { return true; }
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectClass.SelectedIndex == -1) return;
            string item = comboBoxSelectClass.SelectedItem.ToString();
            if(item =="All")
            {
                item = "%";
            }
            SqlParameter[] listPar =
            { 
                new SqlParameter("@item", item) 
            };
            string query = "Select * From SV "
                + "WHERE LopSH LIKE @item"
                + " And HoTenSV LIKE N'%" + textBox_selectString.Text + "%'";
            dataGridView1.DataSource = DBHelper.Instance.GetDataTable(query, listPar);
        }

        private void AddSV(object obj)
        {
            SV sv = (SV)obj;
            if (CheckHaveSV(sv.MSSV) == true)
            {
                MessageBox.Show("Mssv đã tồn tại");
                return;
            }

            SqlParameter[] listPar = 
            {
                new SqlParameter("@mssv", sv.MSSV),
                new SqlParameter("@name", sv.HoTenSV),
                new SqlParameter("@lopsh", sv.LopSH),
                new SqlParameter("@ngaySinh", sv.Ngaysinh),
                new SqlParameter("@dtb", sv.DTB),
                new SqlParameter("@nam", sv.Nam),
                new SqlParameter("@nu", sv.Nu),
                new SqlParameter("@anh", sv.Anh),
                new SqlParameter("@hb", sv.HB),
                new SqlParameter("@cccd",sv.CCCD)
            };
            string query = "Insert into SV (MSSV,HoTenSV,LopSH,NgaySinh,DTB,Male,Female,Anh,HB,CCCD) "
                + "VALUES (@mssv,@name,@lopsh,@ngaySinh,@dtb,@nam,@nu,@anh,@hb,@cccd)";
            DBHelper.Instance.ExecuteNonQuery(query, listPar);
            AllClass();
            LoadAllSV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm();
            form.d += new InformationForm.MyDel(AddSV);
            form.Show();
            AllClass();
            comboBoxSelectClass.SelectedIndex = 0;
        }

        private void UpdateSV(object obj)
        {
            SV sv = (SV)obj;
            SqlParameter[] listPar = 
            {
                new SqlParameter("@mssv", sv.MSSV),
                new SqlParameter("@name", sv.HoTenSV),
                new SqlParameter("@lopsh", sv.LopSH),
                new SqlParameter("@ngaySinh", sv.Ngaysinh),
                new SqlParameter("@dtb", sv.DTB),
                new SqlParameter("@nam", sv.Nam),
                new SqlParameter("@nu", sv.Nu),
                new SqlParameter("@anh", sv.Anh),
                new SqlParameter("@hb", sv.HB),
                new SqlParameter("@cccd",sv.CCCD)
            };
            string query = "Update SV " +
                "SET HoTenSV = @name," 
                + "LopSH = @lopsh," 
                + "NgaySinh = @ngaysinh," 
                + "DTB = @dtb," 
                + "Male = @nam," 
                + "Female = @nu," 
                + "Anh = @anh," 
                + "HB = @hb," 
                + "CCCD = @cccd "
                +" WHERE MSSV = " + sv.MSSV;
            DBHelper.Instance.ExecuteNonQuery(query, listPar);
            AllClass();
            LoadAllSV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            InformationForm form = new InformationForm();
            form.d += new InformationForm.MyDel(UpdateSV);
            form.textBox_MSSV.ReadOnly = true;
            form.textBox_MSSV.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 
            form.Show();
            comboBoxSelectClass.SelectedIndex = 0;
            LoadAllSV();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string s = row.Cells[0].Value.ToString();
                string query = "Delete from SV "
                    + "Where MSSV = " + s;
                DBHelper.Instance.ExecuteNonQuery(query);
            }
            LoadAllSV();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (comboBox_Sort.SelectedIndex == -1 || comboBox_ASC_DESC.SelectedIndex == -1) return;
            string query = "Select * From SV Order By "
                + comboBox_Sort.SelectedItem.ToString()
                + " "
                + comboBox_ASC_DESC.SelectedItem.ToString();
                ;
            dataGridView1.DataSource = DBHelper.Instance.GetDataTable(query);
            comboBoxSelectClass.SelectedIndex = 0;
        }
    }
}
