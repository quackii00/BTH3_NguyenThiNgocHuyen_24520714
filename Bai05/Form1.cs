using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class MainForm : Form
    {
        private double Num1=0;
        private double Num2=0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (TextBoxNum1.Text == "" || TextBoxNum2.Text == "")
                MessageBox.Show("Nếu để trống ô thì ô đó mặc định bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TextBoxAnswer.Text = (Num1 + Num2).ToString();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (TextBoxNum1.Text == "" || TextBoxNum2.Text == "")
                MessageBox.Show("Nếu để trống ô thì ô đó mặc định bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TextBoxAnswer.Text = (Num1 - Num2).ToString();
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            if (TextBoxNum1.Text == "" || TextBoxNum2.Text == "")
                MessageBox.Show("Nếu để trống ô thì ô đó mặc định bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TextBoxAnswer.Text = (Num1 * Num2).ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (TextBoxNum1.Text == "" || TextBoxNum2.Text == "")
                MessageBox.Show("Nếu để trống ô thì ô đó mặc định bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Num2 != 0)
            {
                TextBoxAnswer.Text = (Num1 / Num2).ToString();
            }
            else
            {
                MessageBox.Show("Không thể chia cho không! \nMời nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxNum1_Changed(object sender, EventArgs e)
        {
            double temp1;
            while (!double.TryParse(TextBoxNum1.Text, out temp1))
            {
                if (TextBoxNum1.Text == "")
                {
                    Num1 = 0;
                    return;
                }
                MessageBox.Show("Vui lòng nhập số hợp lệ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Num1 = temp1;
        }

        private void TextBoxNum2_Changed(object sender, EventArgs e)
        {
            double temp2;
            while (!double.TryParse(TextBoxNum2.Text, out temp2))
            {
                if (TextBoxNum2.Text == "")
                {
                    Num2 = 0;
                    return;
                }
                MessageBox.Show("Vui lòng nhập số hợp lệ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Num2 = temp2;
        }

        

        


    }
}
