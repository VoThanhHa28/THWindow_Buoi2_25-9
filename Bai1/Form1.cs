using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Answer_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox_Number1.Text);
                float number2 = float.Parse(textBox_Number2.Text);
                float answer = number1 + number2;
                textBox_Answer.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_Sub_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox_Number1.Text);
                float number2 = float.Parse(textBox_Number2.Text);
                float answer = number1 - number2;
                textBox_Answer.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_Mul_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox_Number1.Text);
                float number2 = float.Parse(textBox_Number2.Text);
                float answer = number1 * number2;
                textBox_Answer.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_Div_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(textBox_Number1.Text);
                float number2 = float.Parse(textBox_Number2.Text);
                float answer = number1 / number2;
                textBox_Answer.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
