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
    public partial class Transaction_Data : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1; port=3306; database=halkhatadb; username=root; password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Transaction_Data()
        {
            InitializeComponent();
        }

        private void Transaction_Data_Load(object sender, EventArgs e)
        {
            transaction_data_listView.GridLines = true;
            transaction_data_listView.View = View.Details;


            transaction_data_listView.Columns.Add("Transaction ID", 150);
            transaction_data_listView.Columns.Add("Customer Name", 150);
            transaction_data_listView.Columns.Add("Customer Phone Number", 150);
            transaction_data_listView.Columns.Add("Purchase Amount", 150);
            transaction_data_listView.Columns.Add("Payment", 150);
            transaction_data_listView.Columns.Add("Date & Time", 150);

            transactionDatashow();
        }



        private void transactionDatashow()
        {
            string search = "SELECT * FROM transaction;";

            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {

                ListViewItem lvi = new ListViewItem(mdr.GetInt32(0).ToString());
                lvi.SubItems.Add(mdr.GetString(1));
                lvi.SubItems.Add(mdr.GetInt32(2).ToString());
                lvi.SubItems.Add(mdr.GetString(3));
                lvi.SubItems.Add(mdr.GetString(4));
                lvi.SubItems.Add(mdr.GetString(5));

                transaction_data_listView.Items.Add(lvi);

            }
            connection.Close();
        }

        private void gobackmenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu access = new AdminMenu();
            access.Show();
        }
    }
}
