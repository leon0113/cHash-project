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
    public partial class Send_Notification : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1;port=3306; database=halkhata; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Send_Notification()
        {
            InitializeComponent();
        }

        private void transactionDatashow()
        {
            string search = "SELECT Customer_Name,Customer_Phone_Number,Purchase_Amount,Payment FROM transaction;";

            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {

                ListViewItem lvi = new ListViewItem(mdr.GetString(0));
                lvi.SubItems.Add(mdr.GetInt32(1).ToString());
                lvi.SubItems.Add(mdr.GetInt32(2).ToString());
                lvi.SubItems.Add(mdr.GetInt32(3).ToString());
                //lvi.SubItems.Add(mdr.GetInt32(4).ToString());

                notification_send_listView.Items.Add(lvi);

            }
            connection.Close();
        }
        private void Send_Notificartion_Load(object sender, EventArgs e)
        {
            notification_send_listView.GridLines = true;
            notification_send_listView.View = View.Details;

            //Add Column Header
            notification_send_listView.Columns.Add("Customer Name", 150);
            notification_send_listView.Columns.Add("Customer Phone Number", 150);
            notification_send_listView.Columns.Add("Purchase Amount", 150);
            notification_send_listView.Columns.Add("Payment", 150);
            //notification_send_listView.Columns.Add("Due Amount", 150);

            transactionDatashow();
        }
    }
}
