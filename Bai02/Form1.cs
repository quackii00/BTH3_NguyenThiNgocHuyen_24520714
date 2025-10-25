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
    public partial class Form1 : Form
    {
        private Random Rand = new Random();
        private Point randomPos;
        public Form1()
        {
            InitializeComponent();
        }

        private void paintevent(object sender, PaintEventArgs e)
        {
            
            label1.Location = randomPos;
            int x = Rand.Next(0, 256);
            int y = Rand.Next(0, 256);
            int z = Rand.Next(0, 256);
            label1.BackColor = Color.FromArgb(x,y,z);
            this.Refresh();
        }

        private void btnPaintEven(object sender, EventArgs e)
        {
            int MaxY = this.ClientSize.Height -label1.Height ;
            int MaxX = this.ClientSize.Width -label1.Width ;
            int x = Rand.Next(0, MaxX);
            int y = Rand.Next(0, MaxY);
            randomPos = new Point(x, y);
            
          
        }
    }
}
