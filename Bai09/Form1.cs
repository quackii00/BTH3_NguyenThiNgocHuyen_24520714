using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class MainForm : Form
    {
        private ListBox TempListBox = new ListBox();
        private int rows = 0;
        private bool CheckGioiTinh=false;
        public MainForm()
        {
            InitializeComponent();
            foreach( var item in ListMonHoc.Items)
            {
                TempListBox.Items.Add(item);
            }    
        }

        private void BtnAddMonHocClick(object sender, EventArgs e)
        {
            if (ListMonHoc.SelectedItem != null)
            {
                string item = ListMonHoc.SelectedItem.ToString();
                AnsListBox.Items.Add(item);
                ListMonHoc.Items.Remove(item);
               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void BtnSubtractMonHocClick(object sender, EventArgs e)
        {
            if (AnsListBox.SelectedItem != null)
            {
                string item = AnsListBox.SelectedItem.ToString();
                ListMonHoc.Items.Add(item);
                AnsListBox.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            AnsListBox.Items.Clear();
            ListMonHoc.Items.Clear();
            foreach (var item in TempListBox.Items)
            {
                ListMonHoc.Items.Add(item);
            }
        }

        private void BtnGioiTinhClick(object sender, EventArgs e)
        {
            if (CheckboxNu.Checked && CheckboxNam.Checked)
            {
                MessageBox.Show("Không thể chọn cả Nam và Nữ.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CheckboxNam.Checked = false;
                CheckboxNu.Checked = false;
                CheckGioiTinh = false;
            }    
            else if (!CheckboxNu.Checked && !CheckboxNam.Checked)
            { 
                CheckGioiTinh = false;
            }
            else
            {
                CheckGioiTinh = true;
            }    
        }
        private void AddToListSV(int Rows)
        {
            //Thêm vào ListSV
            string gioiTinh = CheckboxNam.Checked ? "Nam" : "Nữ";
            byte soMonHoc = (byte)AnsListBox.Items.Count;
            ListSV.Rows[Rows].Cells[0].Value = TextBoxMSSV.Text;
            ListSV.Rows[Rows].Cells[1].Value = TextBoxHoten.Text;
            ListSV.Rows[Rows].Cells[2].Value = CbboxChuyenNganh.SelectedItem.ToString();
            ListSV.Rows[Rows].Cells[3].Value = gioiTinh;
            ListSV.Rows[Rows].Cells[4].Value = soMonHoc.ToString();
            ListSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Xóa trắng các trường nhập liệu
            TextBoxHoten.Clear();
            TextBoxMSSV.Clear();
            CbboxChuyenNganh.SelectedIndex = -1;
            CheckboxNam.Checked = false;
            CheckboxNu.Checked = false;
            AnsListBox.Items.Clear();
            ListMonHoc.Items.Clear();
            foreach (var item in TempListBox.Items)
            {
                ListMonHoc.Items.Add(item);
            }
        }
        private void BtnSaveClick(object sender, EventArgs e)
        {
            int rowHaveSameMSSV=0;
            //Kiểm tra các trường nhập liệu
            if (TextBoxHoten.Text == "" || TextBoxMSSV.Text == "" || CbboxChuyenNganh.Items == null || !CheckGioiTinh)
            {
                MessageBox.Show("Vui lòng điền những thông tin đang trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Kiểm tra MSSV đã tồn tại hay chưa
            else
            {
                bool daTonTai = false;
                //Kiểm tra MSSV đã tồn tại
                foreach (DataGridViewRow row in ListSV.Rows)
                {
                    if (row.IsNewRow || row.Cells[0].Value == null) continue;
                    if (row.Cells[0].Value.ToString() == TextBoxMSSV.Text)
                        {
                         daTonTai = true;
                         rowHaveSameMSSV = row.Index;
                         break;
                        } 
                }
                //Xử lý khi MSSV đã tồn tại
                if (daTonTai)
                {
                    DialogResult result = MessageBox.Show(
                    "MSSV đã tồn tại. Bạn có muốn thay thế với số liệu mới không?",
                    "Xác nhận ghi đè",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                  );
                    if (result == DialogResult.Yes)
                    {
                        AddToListSV(rowHaveSameMSSV);
                    }
                }
                else
                {
                    rows = ListSV.Rows.Add();
                    AddToListSV(rows);
                    
                }
            }
        }
    }
}
