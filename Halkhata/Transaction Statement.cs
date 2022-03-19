using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Halkhata
{
    public partial class TransactionStatement : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1 port=3306; database=halkhatadb; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public TransactionStatement()
        {
            InitializeComponent();
        }

        private void record_statement_button_Click(object sender, EventArgs e)
        {
            int phoneNumber = Convert.ToInt32(this.t_customer_phone_number_textBox.Text);
            //DateTime dateTime = DateTime.Now;
            this.connection.Open();
            string selectQuery = "SELECT * FROM halkhata.customer WHERE Phone_Number = '" + this.t_customer_phone_number_textBox.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Username not available!");

            }
            else
            {
                string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=halkhatadb;";
                string iquery = "INSERT INTO transaction(Transaction_ID, Customer_Name, Phone_Number, Purchase_Amount, Payment, Date_Time) VALUES ('" + this.textBoxTransactionID.Text+"', '" + this.t_customer_NametextBox.Text + "', '" + this.t_customer_phone_number_textBox.Text + "', '" + this.purchasetextBox.Text + "', '" + this.paymenttextBox.Text + "', '"+ DateTime.Now.ToString("yyyy-MM-dd h:mm tt") + "')";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Account Successfully Created!");
            }

            this.connection.Close();

        }

        private void gobackmenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu access = new AdminMenu();
            access.Show();
        }

        private void TransactionStatement_Load(object sender, EventArgs e)
        {
            Transaction_Id();
        }

        public void Transaction_Id()
        {
            this.connection.Open();

            string query1 = "select max(Transaction_ID) from transaction";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                string value = dr1[0].ToString();
                if (value == "")
                {
                    this.textBoxTransactionID.Text = "6538427";
                }
                else
                {
                    int b;
                    b = int.Parse(dr1[0].ToString());
                    b += 1;
                    this.textBoxTransactionID.Text = b.ToString();

                }
                this.connection.Close();
            }
        }

    }
}
