using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5_Demo
{
    public partial class Form1 : Form
    {
        List<Button> danhSachChon = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị MessageBox để xác nhận thoát chương trình
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", hủy việc đóng form
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng Form
            }
        }

        private void btnGheNgoi_Click(object sender, EventArgs e)
        {
            Button btnGheNgoi = (Button)sender;
            //MessageBox.Show(btnGheNgoi.Text);
            if (btnGheNgoi.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghe nay da ban!!!");
                return;
            }

            if (btnGheNgoi.BackColor == Color.White)
            {
                btnGheNgoi.BackColor = Color.Blue;
                danhSachChon.Add(btnGheNgoi);
            }
            else
            {
                btnGheNgoi.BackColor = Color.White;
                danhSachChon.Remove(btnGheNgoi);
            }
        }

        private void btnTinhtien(object sender, EventArgs e)
        {
            double tongTien = 0;

            foreach (Button btnGheChon in danhSachChon)
            {
                int soGhe = int.Parse(btnGheChon.Text);
                if (soGhe <= 5)
                    tongTien += 30000;
                else if (soGhe <= 10)
                    tongTien += 40000;
                else if (soGhe <= 15)
                    tongTien += 50000;
                else
                    tongTien += 80000;
                btnGheChon.BackColor = Color.Yellow;
            }
            txtTongTien.Text = tongTien.ToString();
            danhSachChon.Clear();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            foreach (Button btnGheChon in danhSachChon)
            {
                btnGheChon.BackColor = Color.White;
            }
            danhSachChon.Clear();
            txtTongTien.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // xác nhận thoát chương trình 
            // Hiển thị MessageBox để xác nhận thoát chương trình
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", hủy việc đóng form
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
