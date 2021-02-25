using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8ball
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void eightBallButton_Click(object sender, EventArgs e)
        {
            int eightBall;
            eightBall = randGen.Next(1, 7);

            switch (eightBall)
            {
                case 1:
                    outputLabel.Text = "Possibly";
                    break;
                case 2:
                    outputLabel.Text = "Yeah, no";
                    break;
                case 3:
                    outputLabel.Text = "Most definitely";
                    break;
                case 4:
                    outputLabel.Text = "Ask again later";
                    break;
                case 5:
                    outputLabel.Text = "Don't count on it";
                    break;
                case 6:
                    outputLabel.Text = "Yes";
                    break;
                case 7:
                    outputLabel.Text = "future is foggy, can not answer";
                    break;
            }
        }
    }
}
