namespace Bai01
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
            this.txtbox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnOpenModal = new System.Windows.Forms.Button();
            this.BtnCloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbox);
            this.panel1.Location = new System.Drawing.Point(30, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 370);
            this.panel1.TabIndex = 0;
            // 
            // txtbox
            // 
            this.txtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox.Location = new System.Drawing.Point(0, 0);
            this.txtbox.Name = "txtbox";
            this.txtbox.ReadOnly = true;
            this.txtbox.Size = new System.Drawing.Size(451, 370);
            this.txtbox.TabIndex = 0;
            this.txtbox.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnOpenModal);
            this.panel2.Controls.Add(this.BtnCloseForm);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(506, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 370);
            this.panel2.TabIndex = 1;
            // 
            // BtnOpenModal
            // 
            this.BtnOpenModal.Location = new System.Drawing.Point(19, 54);
            this.BtnOpenModal.Name = "BtnOpenModal";
            this.BtnOpenModal.Size = new System.Drawing.Size(220, 69);
            this.BtnOpenModal.TabIndex = 3;
            this.BtnOpenModal.Text = "Open Modal (Activated)";
            this.BtnOpenModal.UseVisualStyleBackColor = true;
            this.BtnOpenModal.Click += new System.EventHandler(this.BtnModelForm_Click);
            // 
            // BtnCloseForm
            // 
            this.BtnCloseForm.Location = new System.Drawing.Point(19, 144);
            this.BtnCloseForm.Name = "BtnCloseForm";
            this.BtnCloseForm.Size = new System.Drawing.Size(220, 58);
            this.BtnCloseForm.TabIndex = 2;
            this.BtnCloseForm.Text = "Close Form";
            this.BtnCloseForm.UseVisualStyleBackColor = true;
            this.BtnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thao tác:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Lifetime";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOpenModal;
        private System.Windows.Forms.Button BtnCloseForm;
    }
}

