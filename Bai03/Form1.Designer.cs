namespace Bai03
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
            this.BtnChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnChangeColor
            // 
            this.BtnChangeColor.Location = new System.Drawing.Point(308, 253);
            this.BtnChangeColor.Name = "BtnChangeColor";
            this.BtnChangeColor.Size = new System.Drawing.Size(252, 58);
            this.BtnChangeColor.TabIndex = 0;
            this.BtnChangeColor.Text = "Change Color";
            this.BtnChangeColor.UseVisualStyleBackColor = true;
            this.BtnChangeColor.Click += new System.EventHandler(this.BtnChangeColor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 579);
            this.Controls.Add(this.BtnChangeColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnChangeColor;
    }
}

