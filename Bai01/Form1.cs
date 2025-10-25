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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            string notion = "Load: Form đang được tải (chuẩn bị dữ liệu)\n";
            txtbox.Text += notion;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            string notion = "Activated: Form đang được kích hoạt (focus)\n";
            txtbox.Text += notion;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            string notion = "Shown: Form đã được hiển thị lần đầu\n";
            txtbox.Text += notion;
        }

        private void BtnModelForm_Click(object sender, EventArgs e)
        {
            ModalForm form2 = new ModalForm();
            form2.ShowDialog();
        }

        private void MainForm_Deactivated(object sender, EventArgs e)
        {
            string notion = "Deactivated: Form đã bị mất focus\n";
            txtbox.Text += notion;
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            string notion = "Closing: Form đang chuẩn bị đóng\n";
            txtbox.Text += notion;
            DialogResult result =MessageBox.Show("Bạn có muốn đóng form", "Closing form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
               e.Cancel = true;
            }
        }
        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            string notion = "Closed: Form đã đóng\n";
            txtbox.Text += notion;
            MessageBox.Show("Đóng đây");
        }
    }
}
