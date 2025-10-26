namespace Bai05
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
            this.LabelNum1 = new System.Windows.Forms.Label();
            this.LabelNum2 = new System.Windows.Forms.Label();
            this.TextBoxNum1 = new System.Windows.Forms.TextBox();
            this.TextBoxNum2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelAnswer = new System.Windows.Forms.Label();
            this.TextBoxAnswer = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelNum1
            // 
            this.LabelNum1.AutoSize = true;
            this.LabelNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNum1.Location = new System.Drawing.Point(3, 0);
            this.LabelNum1.Name = "LabelNum1";
            this.LabelNum1.Size = new System.Drawing.Size(127, 68);
            this.LabelNum1.TabIndex = 0;
            this.LabelNum1.Text = "Number 1";
            // 
            // LabelNum2
            // 
            this.LabelNum2.AutoSize = true;
            this.LabelNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNum2.Location = new System.Drawing.Point(3, 68);
            this.LabelNum2.Name = "LabelNum2";
            this.LabelNum2.Size = new System.Drawing.Size(127, 64);
            this.LabelNum2.TabIndex = 1;
            this.LabelNum2.Text = "Number 2";
            // 
            // TextBoxNum1
            // 
            this.TextBoxNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNum1.Location = new System.Drawing.Point(136, 3);
            this.TextBoxNum1.Name = "TextBoxNum1";
            this.TextBoxNum1.Size = new System.Drawing.Size(447, 35);
            this.TextBoxNum1.TabIndex = 2;
            this.TextBoxNum1.TextChanged += new System.EventHandler(this.TextBoxNum1_Changed);
            // 
            // TextBoxNum2
            // 
            this.TextBoxNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNum2.Location = new System.Drawing.Point(136, 71);
            this.TextBoxNum2.Name = "TextBoxNum2";
            this.TextBoxNum2.Size = new System.Drawing.Size(447, 35);
            this.TextBoxNum2.TabIndex = 3;
            this.TextBoxNum2.TextChanged += new System.EventHandler(this.TextBoxNum2_Changed);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnPlus);
            this.flowLayoutPanel1.Controls.Add(this.BtnSubtract);
            this.flowLayoutPanel1.Controls.Add(this.BtnMulti);
            this.flowLayoutPanel1.Controls.Add(this.BtnDivide);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(210, 354);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(455, 105);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(3, 3);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(105, 72);
            this.BtnPlus.TabIndex = 3;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Location = new System.Drawing.Point(114, 3);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(105, 72);
            this.BtnSubtract.TabIndex = 4;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(225, 3);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(105, 72);
            this.BtnMulti.TabIndex = 5;
            this.BtnMulti.Text = "x";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(336, 3);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(105, 72);
            this.BtnDivide.TabIndex = 6;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.79152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.20848F));
            this.tableLayoutPanel1.Controls.Add(this.TextBoxNum1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelNum1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelNum2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxNum2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(140, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.15054F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.84946F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 132);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // LabelAnswer
            // 
            this.LabelAnswer.AutoSize = true;
            this.LabelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAnswer.Location = new System.Drawing.Point(163, 557);
            this.LabelAnswer.Name = "LabelAnswer";
            this.LabelAnswer.Size = new System.Drawing.Size(93, 29);
            this.LabelAnswer.TabIndex = 6;
            this.LabelAnswer.Text = "Answer";
            // 
            // TextBoxAnswer
            // 
            this.TextBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAnswer.Location = new System.Drawing.Point(292, 557);
            this.TextBoxAnswer.Name = "TextBoxAnswer";
            this.TextBoxAnswer.Size = new System.Drawing.Size(431, 35);
            this.TextBoxAnswer.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 679);
            this.Controls.Add(this.TextBoxAnswer);
            this.Controls.Add(this.LabelAnswer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNum1;
        private System.Windows.Forms.Label LabelNum2;
        private System.Windows.Forms.TextBox TextBoxNum1;
        private System.Windows.Forms.TextBox TextBoxNum2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelAnswer;
        private System.Windows.Forms.TextBox TextBoxAnswer;
    }
}

