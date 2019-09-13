using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class coffeeShop : Form
    {
        public coffeeShop()
        {
            InitializeComponent();
        }

        private void coffeeShop_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextBox.Text;
            int contactNumber = Convert.ToInt32(contactNumberTextBox.Text);
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            int item = 0;

            if (order == "Black")
            {
                item = 120;
            }
            else if (order == "Cold")
            {
                item = 100;
            }
            else if (order == "Hot")
            {
                item = 90;
            }
            else if (order == "Regular")
            {
                item = 80;
            }
            else
            {
                MessageBox.Show("Please select an item");
            }

            int total = item * quantity;

            displayRichTextBox.Text = ("Customer Name:  " +customerName +"\nContact Number:  " +contactNumber 
                                        +"\nAddress:  " +address + "\nOrder:  " +order
                                        +"\nQuantity  " +quantity +"\nTotal  " +total);
        }
    }
}
