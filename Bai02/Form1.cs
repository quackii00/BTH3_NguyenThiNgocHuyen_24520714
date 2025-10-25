using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class MainForm : Form
    {
        private Random rand = new Random();
        private Point randomPos = new Point();
        public MainForm()
        {
            InitializeComponent();

        }
        //Vẽ lại Form
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            LabelPaintEvent.Location = randomPos;
        }
        //Khi click tạo 1 ví trị random đồng thời gọi vẽ lại form
        private void BtnPaintEvent_Click(object sender, EventArgs e)
        {
            RanDomPoint();
            this.Invalidate();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            RanDomPoint();
            this.Invalidate();
        }
        public void RanDomPoint()
        {
            int MaxY = this.ClientSize.Height - LabelPaintEvent.Height;
            int MaxX = this.ClientSize.Width - LabelPaintEvent.Width;
            int x = rand.Next(0, MaxX);
            int y = rand.Next(0, MaxY);
            randomPos = new Point(x, y);
        }
        
    }
}
