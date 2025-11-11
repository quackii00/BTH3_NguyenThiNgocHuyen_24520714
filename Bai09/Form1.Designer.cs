namespace Bai09
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTTSV = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelHoten = new System.Windows.Forms.Label();
            this.LabelChuyennganh = new System.Windows.Forms.Label();
            this.LabelGt = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.ListMonHoc = new System.Windows.Forms.ListBox();
            this.AnsListBox = new System.Windows.Forms.ListBox();
            this.BtnAddItemList = new System.Windows.Forms.Button();
            this.BtnSubtractItemList = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TextBoxHoten = new System.Windows.Forms.TextBox();
            this.CbboxChuyenNganh = new System.Windows.Forms.ComboBox();
            this.CheckboxNam = new System.Windows.Forms.CheckBox();
            this.CheckboxNu = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListSV = new System.Windows.Forms.DataGridView();
            this.ColMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListSV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LabelTTSV);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(42, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 284);
            this.panel1.TabIndex = 0;
            // 
            // LabelTTSV
            // 
            this.LabelTTSV.AutoSize = true;
            this.LabelTTSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTTSV.Location = new System.Drawing.Point(0, 0);
            this.LabelTTSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTTSV.Name = "LabelTTSV";
            this.LabelTTSV.Size = new System.Drawing.Size(104, 13);
            this.LabelTTSV.TabIndex = 1;
            this.LabelTTSV.Text = "Thông Tin Sinh Viên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.6943F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.326425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.TextBoxMSSV, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelHoten, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelChuyennganh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelGt, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ListMonHoc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.AnsListBox, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddItemList, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnSubtractItemList, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.BtnSave, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.BtnDelete, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxHoten, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CbboxChuyenNganh, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CheckboxNam, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.CheckboxNu, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 6, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 270);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBoxMSSV
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextBoxMSSV, 4);
            this.TextBoxMSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMSSV.Location = new System.Drawing.Point(90, 5);
            this.TextBoxMSSV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 6);
            this.TextBoxMSSV.Multiline = true;
            this.TextBoxMSSV.Name = "TextBoxMSSV";
            this.TextBoxMSSV.Size = new System.Drawing.Size(162, 22);
            this.TextBoxMSSV.TabIndex = 21;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelHoten
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LabelHoten, 2);
            this.LabelHoten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHoten.Location = new System.Drawing.Point(2, 33);
            this.LabelHoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelHoten.Name = "LabelHoten";
            this.LabelHoten.Size = new System.Drawing.Size(81, 33);
            this.LabelHoten.TabIndex = 1;
            this.LabelHoten.Text = "Họ Tên";
            this.LabelHoten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelChuyennganh
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LabelChuyennganh, 2);
            this.LabelChuyennganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelChuyennganh.Location = new System.Drawing.Point(2, 66);
            this.LabelChuyennganh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelChuyennganh.Name = "LabelChuyennganh";
            this.LabelChuyennganh.Size = new System.Drawing.Size(81, 33);
            this.LabelChuyennganh.TabIndex = 5;
            this.LabelChuyennganh.Text = "Chuyên Ngành";
            this.LabelChuyennganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelGt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LabelGt, 2);
            this.LabelGt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelGt.Location = new System.Drawing.Point(2, 99);
            this.LabelGt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelGt.Name = "LabelGt";
            this.LabelGt.Size = new System.Drawing.Size(81, 33);
            this.LabelGt.TabIndex = 6;
            this.LabelGt.Text = "Giới Tính";
            this.LabelGt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Label, 4);
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Location = new System.Drawing.Point(2, 132);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(167, 33);
            this.Label.TabIndex = 7;
            this.Label.Text = "Chọn Các Môn Học Tham Gia";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListMonHoc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ListMonHoc, 4);
            this.ListMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListMonHoc.FormattingEnabled = true;
            this.ListMonHoc.Items.AddRange(new object[] {
            "Cơ Sở Dữ Liệu",
            "Cơ Sở DL NC",
            "PTTK Hệ Thống Thông tin",
            "Xác suất thống kê",
            "Nhập môn lập trình",
            "Lập trình hướng đối tượng",
            "Hệ điều hành",
            "Mạng máy tính"});
            this.ListMonHoc.Location = new System.Drawing.Point(2, 167);
            this.ListMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.ListMonHoc.Name = "ListMonHoc";
            this.tableLayoutPanel1.SetRowSpan(this.ListMonHoc, 2);
            this.ListMonHoc.Size = new System.Drawing.Size(167, 62);
            this.ListMonHoc.TabIndex = 8;
            // 
            // AnsListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.AnsListBox, 4);
            this.AnsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnsListBox.FormattingEnabled = true;
            this.AnsListBox.Location = new System.Drawing.Point(216, 167);
            this.AnsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.AnsListBox.Name = "AnsListBox";
            this.tableLayoutPanel1.SetRowSpan(this.AnsListBox, 2);
            this.AnsListBox.Size = new System.Drawing.Size(170, 62);
            this.AnsListBox.TabIndex = 9;
            // 
            // BtnAddItemList
            // 
            this.BtnAddItemList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItemList.Location = new System.Drawing.Point(176, 169);
            this.BtnAddItemList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnAddItemList.Name = "BtnAddItemList";
            this.BtnAddItemList.Size = new System.Drawing.Size(33, 25);
            this.BtnAddItemList.TabIndex = 10;
            this.BtnAddItemList.Text = ">";
            this.BtnAddItemList.UseVisualStyleBackColor = false;
            this.BtnAddItemList.Click += new System.EventHandler(this.BtnAddMonHocClick);
            // 
            // BtnSubtractItemList
            // 
            this.BtnSubtractItemList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSubtractItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSubtractItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtractItemList.Location = new System.Drawing.Point(176, 202);
            this.BtnSubtractItemList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSubtractItemList.Name = "BtnSubtractItemList";
            this.BtnSubtractItemList.Size = new System.Drawing.Size(33, 25);
            this.BtnSubtractItemList.TabIndex = 11;
            this.BtnSubtractItemList.Text = "<";
            this.BtnSubtractItemList.UseVisualStyleBackColor = false;
            this.BtnSubtractItemList.Click += new System.EventHandler(this.BtnSubtractMonHocClick);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnSave, 3);
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Location = new System.Drawing.Point(91, 237);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 27);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Lưu Thông Tin";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnDelete, 2);
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(220, 237);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(74, 27);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Xóa Chọn";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
            // 
            // TextBoxHoten
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextBoxHoten, 5);
            this.TextBoxHoten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxHoten.Location = new System.Drawing.Point(90, 38);
            this.TextBoxHoten.Margin = new System.Windows.Forms.Padding(5, 5, 5, 6);
            this.TextBoxHoten.Multiline = true;
            this.TextBoxHoten.Name = "TextBoxHoten";
            this.TextBoxHoten.Size = new System.Drawing.Size(205, 22);
            this.TextBoxHoten.TabIndex = 15;
            // 
            // CbboxChuyenNganh
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CbboxChuyenNganh, 5);
            this.CbboxChuyenNganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbboxChuyenNganh.FormattingEnabled = true;
            this.CbboxChuyenNganh.Items.AddRange(new object[] {
            "Khoa học máy tính",
            "Công nghệ phần mềm",
            "Kỹ thuật máy tính",
            "An toàn thông tin",
            "Hệ thống thông tin",
            "Trí tuệ nhân tạo"});
            this.CbboxChuyenNganh.Location = new System.Drawing.Point(90, 71);
            this.CbboxChuyenNganh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 6);
            this.CbboxChuyenNganh.Name = "CbboxChuyenNganh";
            this.CbboxChuyenNganh.Size = new System.Drawing.Size(205, 21);
            this.CbboxChuyenNganh.TabIndex = 16;
            // 
            // CheckboxNam
            // 
            this.CheckboxNam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckboxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxNam.Location = new System.Drawing.Point(143, 106);
            this.CheckboxNam.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.CheckboxNam.Name = "CheckboxNam";
            this.CheckboxNam.Size = new System.Drawing.Size(18, 19);
            this.CheckboxNam.TabIndex = 17;
            this.CheckboxNam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckboxNam.UseVisualStyleBackColor = true;
            this.CheckboxNam.Click += new System.EventHandler(this.BtnGioiTinhClick);
            // 
            // CheckboxNu
            // 
            this.CheckboxNu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckboxNu.Location = new System.Drawing.Point(231, 106);
            this.CheckboxNu.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.CheckboxNu.Name = "CheckboxNu";
            this.CheckboxNu.Size = new System.Drawing.Size(16, 19);
            this.CheckboxNu.TabIndex = 18;
            this.CheckboxNu.UseVisualStyleBackColor = true;
            this.CheckboxNu.Click += new System.EventHandler(this.BtnGioiTinhClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nam";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nữ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListSV
            // 
            this.ListSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMSSV,
            this.ColHoten,
            this.ColChuyenNganh,
            this.ColGioiTinh,
            this.ColSoMon});
            this.ListSV.Location = new System.Drawing.Point(42, 305);
            this.ListSV.Name = "ListSV";
            this.ListSV.ReadOnly = true;
            this.ListSV.Size = new System.Drawing.Size(498, 139);
            this.ListSV.TabIndex = 2;
            // 
            // ColMSSV
            // 
            this.ColMSSV.HeaderText = "MSSV";
            this.ColMSSV.Name = "ColMSSV";
            this.ColMSSV.ReadOnly = true;
            // 
            // ColHoten
            // 
            this.ColHoten.HeaderText = "Họ Tên";
            this.ColHoten.Name = "ColHoten";
            this.ColHoten.ReadOnly = true;
            // 
            // ColChuyenNganh
            // 
            this.ColChuyenNganh.HeaderText = "Chuyên Ngành";
            this.ColChuyenNganh.Name = "ColChuyenNganh";
            this.ColChuyenNganh.ReadOnly = true;
            this.ColChuyenNganh.Width = 120;
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.HeaderText = "Giới Tính";
            this.ColGioiTinh.Name = "ColGioiTinh";
            this.ColGioiTinh.ReadOnly = true;
            this.ColGioiTinh.Width = 80;
            // 
            // ColSoMon
            // 
            this.ColSoMon.HeaderText = "Số Môn";
            this.ColSoMon.Name = "ColSoMon";
            this.ColSoMon.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 459);
            this.Controls.Add(this.ListSV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Liệu Sinh Vien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelHoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelChuyennganh;
        private System.Windows.Forms.Label LabelGt;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ListBox ListMonHoc;
        private System.Windows.Forms.ListBox AnsListBox;
        private System.Windows.Forms.Button BtnAddItemList;
        private System.Windows.Forms.Button BtnSubtractItemList;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LabelTTSV;
        private System.Windows.Forms.TextBox TextBoxHoten;
        private System.Windows.Forms.ComboBox CbboxChuyenNganh;
        private System.Windows.Forms.CheckBox CheckboxNam;
        private System.Windows.Forms.CheckBox CheckboxNu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxMSSV;
        private System.Windows.Forms.DataGridView ListSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoMon;
    }
}

