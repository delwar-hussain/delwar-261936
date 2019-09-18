using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int size = 10;

            int[] num = new int [size];

            num[0] = 1;
            num[1] = 1;
            num[2] = 2;
            num[3] = 3;
            num[4] = 4;
            num[5] = 5;
            num[6] = 6;
            num[7] = 7;
            num[8] = 8;
            num[9] = 9;

            string message = "";

            for (int i = 0; i < size; i++)
            {
                message += " " + num[i] + "\n";  
            }
                MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const int size = 3;

            int[] num = new int[size];

            num[0] = 2;
            num[1] = 5;
            num[2] = 7;

            
            string message = "";

            for (int i = 0; i < 0-1; i--)
            {
                message += " " + num[i] + "\n";
            }
            MessageBox.Show(message);
        }
    }
}
