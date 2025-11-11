using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class MainForm : Form
    {
        private double firstNumber;
        private double tempNumber;
        private double memoryNumber=0;
        private bool flagnewcalculation = false;
        private bool flagmemory = false;
        private char cal;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Calculation(char Cal)
        {
            switch (Cal)
            {
                case '+':
                    tempNumber = tempNumber + firstNumber;
                    Answerbox.Text = tempNumber.ToString();
                    break;
                case '-':
                    tempNumber = tempNumber - firstNumber;
                    Answerbox.Text = tempNumber.ToString();
                    break;
                case '*':
                    tempNumber = tempNumber * firstNumber;
                    Answerbox.Text = tempNumber.ToString();
                    break;
                case '/':
                    if (firstNumber == 0) Answerbox.Text = "Khong the chia cho 0, hay nhap lai ";
                    else
                    {
                        tempNumber = tempNumber / firstNumber;
                        Answerbox.Text = tempNumber.ToString();
                    }
                    break;
                case '%':
                    if (firstNumber == 0) Answerbox.Text = "Khong the chia cho 0, hay nhap lai ";
                    else
                    {
                        tempNumber = tempNumber % firstNumber;
                        Answerbox.Text = tempNumber.ToString();
                    }
                    break;
            }
        }


        private void BtnNumberClick(object sender, EventArgs e)
        {
            if (flagnewcalculation == true)
            {
                Answerbox.Text = "";
                flagnewcalculation = false;
            }
            Answerbox.Text += (sender as Button).Text;
        }

        private void BtnEqualClick(object sender, EventArgs e)
        {
            if (Answerbox.Text != "")
            {
                if (flagnewcalculation == true)
                {
                    Calculation(cal);
                }
                else
                {
                    firstNumber = double.Parse(Answerbox.Text);
                    Calculation(cal);
                    flagnewcalculation = true;
                }
            }
            else
            {
                Answerbox.Text = "Hay nhap so truoc";
            }
        }

        private void BtnCalClick(object sender, EventArgs e)
        {
            if (Answerbox.Text == "")
            {
                Answerbox.Text = "Hay nhap so truoc";
            }
            else
            {
                firstNumber = double.Parse(Answerbox.Text);
                tempNumber = firstNumber;
                cal = (sender as Button).Text[0];
                flagnewcalculation = true;
            }
        }

        private void BtnPointClick(object sender, EventArgs e)
        {
            if (!Answerbox.Text.Contains("."))
                Answerbox.Text += (sender as Button).Text;
        }

        private void BtnSignClick(object sender, EventArgs e)
        {
            double temp = double.Parse(Answerbox.Text);
            temp = -temp;
            Answerbox.Text = temp.ToString();
            tempNumber = temp;
        }

        private void BtnRecipClick(object sender, EventArgs e)
        {
            double temp = double.Parse(Answerbox.Text);
            temp = 1 / temp;
            Answerbox.Text = temp.ToString();
            tempNumber = temp;
            flagnewcalculation = true;
        }

        private void BtnSqrtClick(object sender, EventArgs e)
        {
            double temp = double.Parse(Answerbox.Text);
            temp = Math.Sqrt(temp);
            Answerbox.Text = temp.ToString();
            tempNumber = temp;
            flagnewcalculation = true;
        }

        private void BtnMCClick(object sender, EventArgs e)
        {
            flagmemory = false;
            memoryNumber = 0;
        }

        private void BtnMRClick(object sender, EventArgs e)
        {
            if (flagmemory == true)
            {
                Answerbox.Text = memoryNumber.ToString();
                tempNumber = memoryNumber;             
            }
            else
            {
                Answerbox.Text = "Khong co gia tri trong bo nho";
            }
            flagnewcalculation = true;
        }

        private void BtnMSClick(object sender, EventArgs e)
        {
            if (!double.TryParse(Answerbox.Text,out double a))
            {
                Answerbox.Text = "Gia tri khong hop le";
            }
            else
            {
                memoryNumber = double.Parse(Answerbox.Text);
                flagmemory = true;
            }
            flagnewcalculation = true;
        }

        private void BtnMplusClick(object sender, EventArgs e)
        {
            if (!double.TryParse(Answerbox.Text, out double a))
            {
                Answerbox.Text = "Moi nhap so hop le";
            }
            else
            {
                memoryNumber += double.Parse(Answerbox.Text);
            }
            if (flagmemory == false) flagmemory = true;
        }

        private void BtnBackSpaceClick(object sender, EventArgs e)
        {
            if (Answerbox.Text.Length > 0)
            Answerbox.Text = Answerbox.Text.Remove(Answerbox.Text.Length - 1, 1);
        }

        private void BtnCEClick(object sender, EventArgs e)
        {
            Answerbox.Text = "";
        }

        private void BtnCClick(object sender, EventArgs e)
        {
            Answerbox.Text = "";
            firstNumber = 0;
            tempNumber = 0;
            cal = '\0';
        }
    }
}
