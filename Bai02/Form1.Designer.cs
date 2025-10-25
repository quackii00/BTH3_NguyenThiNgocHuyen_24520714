namespace Bai02
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
            this.LabelPaintEvent = new System.Windows.Forms.Label();
            this.BtnPaintEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelPaintEvent
            // 
            this.LabelPaintEvent.AutoSize = true;
            this.LabelPaintEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPaintEvent.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelPaintEvent.Location = new System.Drawing.Point(381, 328);
            this.LabelPaintEvent.Name = "LabelPaintEvent";
            this.LabelPaintEvent.Size = new System.Drawing.Size(190, 37);
            this.LabelPaintEvent.TabIndex = 0;
            this.LabelPaintEvent.Text = "Paint Event";
            // 
            // BtnPaintEvent
            // 
            this.BtnPaintEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPaintEvent.AutoSize = true;
            this.BtnPaintEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaintEvent.Location = new System.Drawing.Point(12, 648);
            this.BtnPaintEvent.Name = "BtnPaintEvent";
            this.BtnPaintEvent.Size = new System.Drawing.Size(172, 69);
            this.BtnPaintEvent.TabIndex = 1;
            this.BtnPaintEvent.Text = "Paint Event";
            this.BtnPaintEvent.UseVisualStyleBackColor = true;
            this.BtnPaintEvent.UseWaitCursor = true;
            this.BtnPaintEvent.Click += new System.EventHandler(this.BtnPaintEvent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.BtnPaintEvent);
            this.Controls.Add(this.LabelPaintEvent);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Event";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPaintEvent;
        private System.Windows.Forms.Button BtnPaintEvent;
    }
}

