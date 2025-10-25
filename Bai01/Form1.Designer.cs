namespace Bai01
{
    partial class Form1
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
            this.btnopenmodal = new System.Windows.Forms.Button();
            this.btncloseform = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.btnopenmodal);
            this.panel2.Controls.Add(this.btncloseform);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(506, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 370);
            this.panel2.TabIndex = 1;
            // 
            // btnopenmodal
            // 
            this.btnopenmodal.Location = new System.Drawing.Point(19, 54);
            this.btnopenmodal.Name = "btnopenmodal";
            this.btnopenmodal.Size = new System.Drawing.Size(220, 69);
            this.btnopenmodal.TabIndex = 3;
            this.btnopenmodal.Text = "Open Modal (Activated)";
            this.btnopenmodal.UseVisualStyleBackColor = true;
            this.btnopenmodal.Click += new System.EventHandler(this.btnclickmodalform);
            // 
            // btncloseform
            // 
            this.btncloseform.Location = new System.Drawing.Point(19, 144);
            this.btncloseform.Name = "btncloseform";
            this.btncloseform.Size = new System.Drawing.Size(220, 58);
            this.btncloseform.TabIndex = 2;
            this.btncloseform.Text = "Close Form";
            this.btncloseform.UseVisualStyleBackColor = true;
            this.btncloseform.Click += new System.EventHandler(this.btnclickclosefrom);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Lifetime";
            this.Activated += new System.EventHandler(this.Activatedform);
            this.Deactivate += new System.EventHandler(this.Deactivatedform);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingform);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closedform);
            this.Load += new System.EventHandler(this.loadform);
            this.Shown += new System.EventHandler(this.Shownform);
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
        private System.Windows.Forms.Button btnopenmodal;
        private System.Windows.Forms.Button btncloseform;
    }
}

