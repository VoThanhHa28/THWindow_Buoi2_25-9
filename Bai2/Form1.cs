using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Bai2
{
    public partial class Form_QuanLySinhVien : Form
    {
        public Form_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_Title_Click(object sender, EventArgs e)
        {

        }

    

        private void Form_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            comboBox_Faculty.SelectedIndex = 0;
        }

        

        private int GetSelectedRow(string studentId)
        {
            for(int i = 0; i<dataGridView_Student.Rows.Count; i++)
            {
                if (dataGridView_Student.Rows[i].Cells[0].Value.ToString() == studentId)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dataGridView_Student.Rows[selectedRow].Cells[0].Value = textBox_StudentId.Text;
            dataGridView_Student.Rows[selectedRow].Cells[1].Value = textBox_Name.Text;
            dataGridView_Student.Rows[selectedRow].Cells[2].Value = radioButton_Male.Checked ? "Nam" : "Nữ";
            dataGridView_Student.Rows[selectedRow].Cells[3].Value = float.Parse(textBox_AverageScore.Text).ToString();
            dataGridView_Student.Rows[selectedRow].Cells[4].Value = comboBox_Faculty.Text;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_StudentId.Text == "" || textBox_Name.Text == "" || textBox_AverageScore.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");

                int selectedRow = GetSelectedRow(textBox_StudentId.Text);
                if(selectedRow == -1 )
                {
                    selectedRow = dataGridView_Student.Rows.Add();
                    InsertUpdate(selectedRow);
                    UpdateStudentCounts();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(textBox_StudentId.Text);
                if(selectedRow == -1 ) {
                    throw new Exception("Không tìm thấy MSSV cần xoá!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xoá ?", "YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dataGridView_Student.Rows.RemoveAt(selectedRow);
                        UpdateStudentCounts();
                        MessageBox.Show("Xoá sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void dataGridView_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_Student.Rows[e.RowIndex];

                textBox_StudentId.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                textBox_Name.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                string gender = selectedRow.Cells[2].Value?.ToString();
                if (gender != null)
                {
                    if (gender.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                    {
                        radioButton_Male.Checked = true;
                        radioButton_Female.Checked = false;
                    }
                    else if (gender.Equals("Nữ", StringComparison.OrdinalIgnoreCase))
                    {
                        radioButton_Male.Checked = false;
                        radioButton_Female.Checked = true;
                    }
                }
                textBox_AverageScore.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                string fal = selectedRow.Cells[4].Value?.ToString();
                comboBox_Faculty.SelectedItem = fal;
            }
        }
        private void UpdateStudentCounts()
        {
            int maleCount = 0;
            int femaleCount = 0;


            foreach (DataGridViewRow row in dataGridView_Student.Rows)
            {
                if (row.Cells[2].Value != null) 
                {
                    string gender = row.Cells[2].Value.ToString();

                    if (gender.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                    {
                        maleCount++;
                    }
                    else if (gender.Equals("Nữ", StringComparison.OrdinalIgnoreCase))
                    {
                        femaleCount++;
                    }
                }
            }

            textBox_SumMale.Text = maleCount.ToString();
            textBox_SumFemale.Text = femaleCount.ToString();
        }

        private void dataGridView_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
