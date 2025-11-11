using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class MainForm : Form
    {
        private bool[,] isChoosed;
        private int[] TicketPrices = { 5000, 6500, 8000 };
        private bool[,] isChoosing;
        private List<Tuple<int,int>> choosingLocations = new List<Tuple<int, int>>();
        private int SumPrice = 0;
        public MainForm()
        {
            InitializeComponent();
            int rows = TableLocation.RowCount;
            int cols = TableLocation.ColumnCount;
            isChoosed = new bool[rows, cols];
            isChoosing = new bool[rows,cols];
        }

        private void BtnLocationClick(object sender, EventArgs e)
        {
            SumTextBox.Text = "";
            Button button = sender as Button;
            int row = TableLocation.GetRow(button);
            int col = TableLocation.GetColumn(button);
            if (isChoosed[row, col] == false)
            {
                if (isChoosing[row, col] == true)
                {
                    button.BackColor = SystemColors.ControlLightLight;
                    Invalidate();
                    isChoosing[row, col] = false;
                    choosingLocations.Remove(new Tuple<int, int>(row, col));
                }
                else
                {
                    button.BackColor = Color.Blue;
                    Invalidate();
                    isChoosing[row, col] = true;
                    choosingLocations.Add(new Tuple<int, int>(row, col));
                }
            }
            else
            {
                MessageBox.Show("Chổ này được đặt rồi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnChooseClick(object sender, EventArgs e)
        {
            foreach (var location in choosingLocations)
            {
                Button button = TableLocation.GetControlFromPosition(location.Item2, location.Item1) as Button;
                button.BackColor = Color.Yellow;
                isChoosed[location.Item1, location.Item2] = true;
                SumPrice += TicketPrices[location.Item1];
                Invalidate();
            }
            SumTextBox.Text = SumPrice.ToString();
            SumPrice = 0;
            choosingLocations.Clear();
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            foreach (var location in choosingLocations)
            {
                Button button = TableLocation.GetControlFromPosition(location.Item2, location.Item1) as Button;
                button.BackColor = SystemColors.ControlLightLight;
                isChoosing[location.Item1, location.Item2] = false;
                Invalidate();
            }
            SumTextBox.Text = SumPrice.ToString();
            choosingLocations.Clear();
        }

        private void BtnFinishClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
