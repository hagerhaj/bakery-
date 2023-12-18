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
    public partial class addrestaurant : Form
    {
        //Connection String
        string conn = Properties.Settings.Default.conn;
        SqlCommand cmd;
        SqlConnection con;
        //SqlDataAdapter adapt;
        //SqlDataReader dr;
        public addrestaurant()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (textBox1.Text != " " )
            {

                cmd = new SqlCommand("INSERT INTO restaurantnames (restaurantName,resAddress,resTel) VALUES (@restaurantName,@resAddress,@resTel)", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                cmd.Parameters.AddWithValue("@restaurantName", textBox1.Text);
                cmd.Parameters.AddWithValue("@resAddress", resAddress.Text);
                cmd.Parameters.AddWithValue("@resTel", resTel.Text);

                cmd.ExecuteNonQuery();
                textBox1.Text = " ";
               label3.Text="تمت اضافة جهة توزيع جديدة";
            }
            else
            {
                label3.Text="خطأ في الادخال اعد المحاولة";
                textBox1.Text = " ";
            }
            con.Close();
        }

        private void addrestaurant_Load(object sender, EventArgs e)
        {

        }
    }//////////////


}
