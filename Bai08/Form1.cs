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

namespace Bai08
{
    public partial class MainForm : Form
    {
        private int count = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void UpdatetoListView(int row)
        {
            count += int.Parse(TxtBoxSoTien.Text);
            ListViewItem item = ListTaiKhoan.Items[row];
            item.SubItems[0].Text = (row+1).ToString();
            item.SubItems[1].Text = TxtBoxSTK.Text;
            item.SubItems[2].Text = TxtBoxTenKh.Text;
            item.SubItems[3].Text = TxtBoxAddress.Text;
            item.SubItems[4].Text = TxtBoxSoTien.Text;
            LabelTongTien.Text = count.ToString();
            ClearInputs(); 

        }
        private void AddtoListView()
        {
            int row = ListTaiKhoan.Items.Count;
            ListViewItem item = new ListViewItem((row + 1).ToString());
            item.SubItems.Add(TxtBoxSTK.Text);
            item.SubItems.Add(TxtBoxTenKh.Text);
            item.SubItems.Add(TxtBoxAddress.Text);
            item.SubItems.Add(TxtBoxSoTien.Text);

            ListTaiKhoan.Items.Add(item);
            count += int.Parse(TxtBoxSoTien.Text);
            LabelTongTien.Text = count.ToString();
            ClearInputs();
        }
        private void ClearInputs()
        {
            TxtBoxAddress.Clear();
            TxtBoxSTK.Clear();
            TxtBoxTenKh.Clear();
            TxtBoxSoTien.Clear();
        }
        private void BtnAddClick(object sender, EventArgs e)
        {
            if (TxtBoxAddress.Text == "" || TxtBoxSTK.Text == "" || TxtBoxTenKh.Text == "" || TxtBoxSoTien.Text =="")
            {
                MessageBox.Show("Vui lòng nhập đầy dủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool isExist = false;
                int index = -1;
                // Kiểm tra số tài khoản đã tồn tại
                foreach (ListViewItem item in ListTaiKhoan.Items)
                {
                    if (item.SubItems[1].Text == TxtBoxSTK.Text)
                    {
                        count -= int.Parse(item.SubItems[4].Text);
                        index = item.Index;
                        isExist = true;
                        break;
                    }
                }

                if (isExist)
                {
                    UpdatetoListView(index);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int row = ListTaiKhoan.Items.Count;
                    AddtoListView();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    

            }
        }
    }
}
