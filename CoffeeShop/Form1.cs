using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Connection
        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-6J6EM2U\SQLEXPRESS; Database=Delwar; Integrated Security=True");
        string commandString="";

        private void addButton_Click(object sender, EventArgs e)
        {
            //Open
            sqlConnection.Open();

            //Command 
            commandString = "INSERT INTO CustomerInfo (ID, Name, Contact, Address, Orders, Quantity) Values (" + idTextBox.Text + ", '" + nameTextBox.Text + "', '" + contactTextBox.Text + "', '" + addressTextBox.Text + "', '" + ordersComboBox.Text + "', "+quantityTextBox.Text+")";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

           

            //Insert
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            sqlConnection.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Open
            sqlConnection.Open();

            //Command 
            commandString = @"SELECT * FROM CustomerInfo";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No Data Found");
            }

            //Close
            sqlConnection.Close();
        }

       
        private void showDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idTextBox.Text = showDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            nameTextBox.Text = showDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            contactTextBox.Text = showDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            addressTextBox.Text = showDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            ordersComboBox.Text = showDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            quantityTextBox.Text = showDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Open
            sqlConnection.Open();

            //Command 
            commandString = "DELETE FROM CustomerInfo WHERE ID = '" + idTextBox.Text + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandString, sqlConnection);
            sqlDataAdapter.SelectCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Record Deleted!!!");
            

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            { 
            sqlConnection.Open();

            commandString = "UPDATE CustomerInfo SET Name = '"+nameTextBox.Text+"', Contact = '" + contactTextBox.Text + "', Address = '" + addressTextBox.Text + "', Orders = '" + ordersComboBox.Text + "', Quantity = '" + quantityTextBox.Text + "' WHERE ID = " + idTextBox.Text + "";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandString, sqlConnection);
            sqlDataAdapter.SelectCommand.ExecuteNonQuery();

            sqlConnection.Close();

            
            }

            catch (Exception ex)
            {
                MessageBox.Show("General exception. {0}", ex.Message);
            }

            MessageBox.Show("Data Updated!!!");

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            try
            {

                //Open
                sqlConnection.Open();

                //Command 
                commandString = "SELECT * FROM CustomerInfo WHERE ID = " + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);



                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Sorry! No Data Found");
                }

                //Close
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("General exception. {0}", ex.Message);
            }

        }
    }
}
