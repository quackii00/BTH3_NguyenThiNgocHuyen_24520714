using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void loadform(object sender, EventArgs e)
        {
            
            string notion = "Load: Form đang được tải (chuẩn bị dữ liệu)\n";
            txtbox.Text += notion;
        }

        private void Activatedform(object sender, EventArgs e)
        {
            string notion = "Activated: Form đang được kích hoạt (focus)\n";
            txtbox.Text += notion;
        }

        private void Shownform(object sender, EventArgs e)
        {
            string notion = "Shown: Form đã được hiển thị lần đầu\n";
            txtbox.Text += notion;
        }

        private void btnclickmodalform(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Deactivatedform(object sender, EventArgs e)
        {
            string notion = "Deactivated: Form đã bị mất focus\n";
            txtbox.Text += notion;
        }

        private void btnclickclosefrom(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closingform(object sender, FormClosingEventArgs e)
        {
            string notion = "Closing: Form đang chuẩn bị đóng\n";
            txtbox.Text += notion;
            DialogResult result =MessageBox.Show("Bạn có muốn đóng form", "Closing form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
               e.Cancel = true;
            }
        }
        private void closedform(object sender, FormClosedEventArgs e)
        {
            string notion = "Closed: Form đã đóng\n";
            txtbox.Text += notion;
            MessageBox.Show("Đóng đây");
        }
    }
}
