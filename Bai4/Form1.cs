using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai4
{
    public partial class Form_QuanLyThongTinTaiKhoan : Form
    {
        public Form_QuanLyThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        

        private void Form_QuanLyThongTinTaiKhoan_Load(object sender, EventArgs e)
        {   
            textBox_TongTien.Text = "0";
        }

        private int GetSelectedRow(string stk)
        {
            for (int i = 0; i < listView_Infor.Items.Count; i++)
            {
                if (listView_Infor.Items[i].SubItems[1].Text != null &&
                    listView_Infor.Items[i].SubItems[1].Text == stk)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(string pos)
        {
            ListViewItem item = new ListViewItem(pos);
            item.SubItems.Add(textBox_stk.Text);
            item.SubItems.Add(textBox_Ten.Text);
            item.SubItems.Add(textBox_DiaChi.Text);
            item.SubItems.Add(textBox_SoTienTrongTK.Text);
            listView_Infor.Items.Add(item);
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_stk.Text == "" || textBox_Ten.Text == "" || textBox_DiaChi.Text == "" || textBox_SoTienTrongTK.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");

                int selectedRow = GetSelectedRow(textBox_stk.Text);
                if (selectedRow == -1)
                {
                    string position = (listView_Infor.Items.Count + 1).ToString();
                    InsertUpdate(position);
                    float SoTien = float.Parse(listView_Infor.Items[int.Parse(position) - 1].SubItems[4].Text);
                    UpdateSumMoney(SoTien);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    double MoneyPre = double.Parse(listView_Infor.Items[selectedRow].SubItems[4].Text);
                    double MoneyNow = double.Parse(textBox_SoTienTrongTK.Text);
                    listView_Infor.Items[selectedRow].SubItems[1].Text = textBox_stk.Text;
                    listView_Infor.Items[selectedRow].SubItems[2].Text = textBox_Ten.Text;
                    listView_Infor.Items[selectedRow].SubItems[3].Text = textBox_DiaChi.Text;
                    listView_Infor.Items[selectedRow].SubItems[4].Text = textBox_SoTienTrongTK.Text;
                    UpdateSumMoney(-MoneyPre + MoneyNow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView_Infor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_Infor.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_Infor.SelectedItems[0];
                textBox_stk.Text = item.SubItems[1].Text;
                textBox_Ten.Text = item.SubItems[2].Text;
                textBox_DiaChi.Text = item.SubItems[3].Text;
                textBox_SoTienTrongTK.Text = item.SubItems[4].Text; 
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(textBox_stk.Text);
            if (selectedRow == -1)
            {
                MessageBox.Show("Tài khoản không tồn tại!");
            }
            else
            {
                float SoTien = float.Parse(listView_Infor.Items[selectedRow].SubItems[4].Text);
                UpdateSumMoney(-SoTien);
                listView_Infor.Items.RemoveAt(selectedRow);
                MessageBox.Show("Xóa tài khoản thành công!");
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UpdateSumMoney(double SoTien)
        {
            double sumMoney = double.Parse(textBox_TongTien.Text);
            sumMoney += SoTien;
            textBox_TongTien.Text = sumMoney.ToString();
        }
    }
}
