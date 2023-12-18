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
    public partial class finance : Form
    {

        //Connection String
        string conn = Properties.Settings.Default.conn;
        public finance()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void finance_Load(object sender, EventArgs e)
        {
            // Set title.
            this.chart1.Titles.Add("الحسابات");
            fillchart();

        }
        private void fillentajtext()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd;

            //try
            //{
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                cmd = new SqlCommand("SELECT breadmony,breadNum,monyReceipt,productDate ,distribDate  FROM dbo.entajj ", con);

                cmd.CommandType = CommandType.Text;
               
                SqlDataReader sdr = cmd.ExecuteReader();

            sdr.Read();
            textBox2.Text = sdr["breadNum"].ToString();
            textBox5.Text = sdr["breadmony"].ToString();
            textBox6.Text = sdr["monyReceipt"].ToString();

            con.Close();
            //}

            }
        void fillchart()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM expenses ", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            chart1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fillentajtext();
        }
    }
  
   
}

