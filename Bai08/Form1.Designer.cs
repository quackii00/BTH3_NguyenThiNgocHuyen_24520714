namespace Bai08
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtBoxSoTien = new System.Windows.Forms.TextBox();
            this.TxtBoxAddress = new System.Windows.Forms.TextBox();
            this.TxtBoxTenKh = new System.Windows.Forms.TextBox();
            this.labelstk = new System.Windows.Forms.Label();
            this.labelkh = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.labelmoney = new System.Windows.Forms.Label();
            this.TxtBoxSTK = new System.Windows.Forms.TextBox();
            this.BtnAddorUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ListTaiKhoan = new System.Windows.Forms.ListView();
            this.ColSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMaTK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTongTien = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label1.Size = new System.Drawing.Size(642, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.88889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.74074F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28941F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.76227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.11628F));
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxSoTien, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxTenKh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelstk, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelkh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labeladdress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelmoney, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxSTK, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddorUpdate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnDelete, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnExit, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 61);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 192);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TxtBoxSoTien
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtBoxSoTien, 4);
            this.TxtBoxSoTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxSoTien.Location = new System.Drawing.Point(158, 119);
            this.TxtBoxSoTien.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtBoxSoTien.Multiline = true;
            this.TxtBoxSoTien.Name = "TxtBoxSoTien";
            this.TxtBoxSoTien.Size = new System.Drawing.Size(380, 28);
            this.TxtBoxSoTien.TabIndex = 7;
            // 
            // TxtBoxAddress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtBoxAddress, 4);
            this.TxtBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxAddress.Location = new System.Drawing.Point(158, 81);
            this.TxtBoxAddress.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtBoxAddress.Multiline = true;
            this.TxtBoxAddress.Name = "TxtBoxAddress";
            this.TxtBoxAddress.Size = new System.Drawing.Size(380, 28);
            this.TxtBoxAddress.TabIndex = 6;
            // 
            // TxtBoxTenKh
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtBoxTenKh, 4);
            this.TxtBoxTenKh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxTenKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxTenKh.Location = new System.Drawing.Point(158, 43);
            this.TxtBoxTenKh.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtBoxTenKh.Multiline = true;
            this.TxtBoxTenKh.Name = "TxtBoxTenKh";
            this.TxtBoxTenKh.Size = new System.Drawing.Size(380, 28);
            this.TxtBoxTenKh.TabIndex = 5;
            // 
            // labelstk
            // 
            this.labelstk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelstk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstk.Location = new System.Drawing.Point(2, 0);
            this.labelstk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstk.Name = "labelstk";
            this.labelstk.Size = new System.Drawing.Size(152, 38);
            this.labelstk.TabIndex = 0;
            this.labelstk.Text = "Số tài khoản";
            this.labelstk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelkh
            // 
            this.labelkh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkh.Location = new System.Drawing.Point(2, 38);
            this.labelkh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelkh.Name = "labelkh";
            this.labelkh.Size = new System.Drawing.Size(152, 38);
            this.labelkh.TabIndex = 1;
            this.labelkh.Text = "Tên khách hàng";
            this.labelkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labeladdress
            // 
            this.labeladdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.Location = new System.Drawing.Point(2, 76);
            this.labeladdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(152, 38);
            this.labeladdress.TabIndex = 2;
            this.labeladdress.Text = "Địa chỉ khách hàng";
            this.labeladdress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelmoney
            // 
            this.labelmoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmoney.Location = new System.Drawing.Point(2, 114);
            this.labelmoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelmoney.Name = "labelmoney";
            this.labelmoney.Size = new System.Drawing.Size(152, 38);
            this.labelmoney.TabIndex = 3;
            this.labelmoney.Text = "Số tiền trong tài khoản";
            this.labelmoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBoxSTK
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtBoxSTK, 4);
            this.TxtBoxSTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxSTK.Location = new System.Drawing.Point(158, 5);
            this.TxtBoxSTK.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TxtBoxSTK.Multiline = true;
            this.TxtBoxSTK.Name = "TxtBoxSTK";
            this.TxtBoxSTK.Size = new System.Drawing.Size(380, 28);
            this.TxtBoxSTK.TabIndex = 4;
            // 
            // BtnAddorUpdate
            // 
            this.BtnAddorUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddorUpdate.Location = new System.Drawing.Point(246, 154);
            this.BtnAddorUpdate.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnAddorUpdate.Name = "BtnAddorUpdate";
            this.BtnAddorUpdate.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnAddorUpdate.Size = new System.Drawing.Size(121, 36);
            this.BtnAddorUpdate.TabIndex = 8;
            this.BtnAddorUpdate.Text = "Thêm/Cập Nhật";
            this.BtnAddorUpdate.UseVisualStyleBackColor = true;
            this.BtnAddorUpdate.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(377, 154);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnDelete.Size = new System.Drawing.Size(75, 36);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(462, 154);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnExit.Size = new System.Drawing.Size(73, 36);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.btnExitClick);
            // 
            // ListTaiKhoan
            // 
            this.ListTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColSTT,
            this.ColMaTK,
            this.ColTenKH,
            this.ColAddress,
            this.ColMoney});
            this.ListTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTaiKhoan.FullRowSelect = true;
            this.ListTaiKhoan.HideSelection = false;
            this.ListTaiKhoan.Location = new System.Drawing.Point(29, 257);
            this.ListTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.ListTaiKhoan.Name = "ListTaiKhoan";
            this.ListTaiKhoan.Size = new System.Drawing.Size(592, 225);
            this.ListTaiKhoan.TabIndex = 2;
            this.ListTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.ListTaiKhoan.View = System.Windows.Forms.View.Details;
            this.ListTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
            // 
            // ColSTT
            // 
            this.ColSTT.Text = "STT";
            this.ColSTT.Width = 80;
            // 
            // ColMaTK
            // 
            this.ColMaTK.Text = "Mã tài khoản";
            this.ColMaTK.Width = 123;
            // 
            // ColTenKH
            // 
            this.ColTenKH.Text = "Tên khách hàng";
            this.ColTenKH.Width = 171;
            // 
            // ColAddress
            // 
            this.ColAddress.Text = "Địa chỉ";
            this.ColAddress.Width = 135;
            // 
            // ColMoney
            // 
            this.ColMoney.Text = "Số tiền";
            this.ColMoney.Width = 180;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.55289F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.44711F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelTongTien, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(311, 486);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTongTien
            // 
            this.LabelTongTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTongTien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTongTien.Location = new System.Drawing.Point(76, 0);
            this.LabelTongTien.Name = "LabelTongTien";
            this.LabelTongTien.Size = new System.Drawing.Size(231, 30);
            this.LabelTongTien.TabIndex = 3;
            this.LabelTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 527);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ListTaiKhoan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Quản Lý Tài Khoản";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelstk;
        private System.Windows.Forms.Label labelkh;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label labelmoney;
        private System.Windows.Forms.TextBox TxtBoxSoTien;
        private System.Windows.Forms.TextBox TxtBoxAddress;
        private System.Windows.Forms.TextBox TxtBoxTenKh;
        private System.Windows.Forms.TextBox TxtBoxSTK;
        private System.Windows.Forms.Button BtnAddorUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListView ListTaiKhoan;
        private System.Windows.Forms.ColumnHeader ColSTT;
        private System.Windows.Forms.ColumnHeader ColMaTK;
        private System.Windows.Forms.ColumnHeader ColTenKH;
        private System.Windows.Forms.ColumnHeader ColAddress;
        private System.Windows.Forms.ColumnHeader ColMoney;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelTongTien;
    }
}

