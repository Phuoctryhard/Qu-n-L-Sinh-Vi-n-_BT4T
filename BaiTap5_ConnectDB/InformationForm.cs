using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap5_ConnectDB
{
    public partial class InformationForm : Form
    {
        public delegate void MyDel(object o);
        public MyDel d { set; get; }
        public InformationForm()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button_Oke_Click(object sender, EventArgs e)
        {
            try
            {
                SV sv = new SV()
                {
                    MSSV = Convert.ToInt32(textBox_MSSV.Text),
                    HoTenSV = textBox_TenSV.Text,
                    LopSH = textBox_LopSH.Text,
                    Ngaysinh = dateTimePicker1.Value,
                    DTB = Convert.ToDouble(textBox_DiemTB.Text),
                    Nam = radioButton_Nam.Checked,
                    Nu = radioButton_Nu.Checked,
                    Anh = checkBox_Anh.Checked,
                    HB = checkBox_HB.Checked,
                    CCCD = checkBox_CCCD.Checked,
                };
                d(sv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Dispose();
        }
    }
}
