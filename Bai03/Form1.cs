using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class MainForm : Form
    {
        private Random random = new Random();
        private Color randomColor = Color.White;
        public MainForm()
        {
            InitializeComponent();
        }
       
        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            randomColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            this.BackColor = randomColor;
            this.Invalidate();
        } 
    }
}
