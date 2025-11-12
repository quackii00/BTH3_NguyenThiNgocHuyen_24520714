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
        // Cập nhật item trong ListView
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
        // Thêm mới item vào ListView
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
        // Thêm item vào ListView
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
        // Xóa item trong ListView
        private void BtnDeleteClick(object sender, EventArgs e)
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
            // Xóa item nếu tồn tại
            if (isExist)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ListTaiKhoan.Items.RemoveAt(index);
                    // Cập nhật lại STT
                    for (int i = 0; i < ListTaiKhoan.Items.Count; i++)
                    {
                        ListTaiKhoan.Items[i].SubItems[0].Text = (i + 1).ToString();
                    }
                    LabelTongTien.Text = count.ToString();
                    ClearInputs();
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                ClearInputs();
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        //Chọn item trong ListView
        private void SelectItem(object sender, EventArgs e)
        {
            if (ListTaiKhoan.SelectedItems.Count > 0)
            {
                int index = ListTaiKhoan.SelectedItems[0].Index;
                ListViewItem item = ListTaiKhoan.SelectedItems[0];
                TxtBoxSTK.Text = item.SubItems[1].Text;
                TxtBoxTenKh.Text = item.SubItems[2].Text;
                TxtBoxAddress.Text = item.SubItems[3].Text;
                TxtBoxSoTien.Text = item.SubItems[4].Text;
            }
            else
            {
                    ClearInputs();
            }
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
