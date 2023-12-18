using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace bakery
{
    public partial class outgoingItems : Form
    {
        //Connection String
        string conn = Properties.Settings.Default.conn;
        public outgoingItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand sqlCmd;

            con.Open();
            ////////////////
              if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataTable dtData = new DataTable();
                sqlCmd = new SqlCommand("INSERT INTO outgoingItems (outgoing) VALUES(@outgoing)", con);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@outgoing", textBox1.Text);
                

                int numRes = sqlCmd.ExecuteNonQuery();
               label2.Text="!!!تـــم";
               
            ///////////////////////
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
