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
    public partial class wrdiya : Form
    {
        //Connection String
        string conn = Properties.Settings.Default.conn;
        SqlCommand cmd;
        //SqlConnection con ;
        SqlDataAdapter adapt;
        SqlDataReader dr;
        //int ID = 0;

        public wrdiya()
        {
            InitializeComponent();
            //displayData();
        }

        private void wrdiya_Load(object sender, EventArgs e)
        {
            ////////تعبئة الداتا قريد/////
            displayDatadgv1();
            displayDatadgv2();
            displayDatadgv3();
            displayDatadgv4();
            ///////////////

            SqlConnection con = new SqlConnection(conn);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT empName,empJop FROM empData";
            //SqlCommand cmd = new SqlCommand("SELECT empName,empJop FROM empData" ,con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["empName"]);

            }
            con.Close();
        }

        private void _SelectedIndexChanged(object sender, EventArgs e)
        {
            //filltext1();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conn);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd2 = new SqlCommand("SELECT empJop FROM empData where empname ='" + comboBox1.Text + "'", con);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                {
                    ////textBox2.Text = reader[0].ToString();
                    textBox1.Text = reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            //con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (comboBox1.Text !=" " && comboBox2.Text !=" ")
            {
               
                cmd = new SqlCommand("INSERT INTO  wrdia (wrDate,empName,empJob,wrdiaNo) VALUES(@wrDate,@empName,@empJob,@wrdiaNo)", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@wrDate", dtp1.Value);
                cmd.Parameters.AddWithValue("@empName", comboBox1.Text);
                cmd.Parameters.AddWithValue("@empJob", textBox1.Text);
                cmd.Parameters.AddWithValue("@wrdiaNo", comboBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                displayDatadgv1();
                displayDatadgv2();
                displayDatadgv3();
                displayDatadgv4();
                //cleardata();
            }
            else
            {
                MessageBox.Show("gggggggggg");
            }
            con.Close();
        }
        private void displayDatadgv1()
        {
            SqlConnection con = new SqlConnection(conn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
           
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT wrDate, empName, empJob, wrdiaNo FROM  dbo.wrdia WHERE (wrDate = CAST(GETDATE() AS date) and wrdiaNo = 'الاولي')", con);
                adapt.Fill(dt);
                dgv1.DataSource = dt;
                con.Close();
            ////////اسماء الاعمدة///////
            dgv1.Columns[0].HeaderText = "التاريخ";
            dgv1.Columns[1].HeaderText = "الاسم";
            dgv1.Columns[2].HeaderText = "الوظيفة";
            dgv1.Columns[3].HeaderText = "الوردية";




        }
        private void displayDatadgv2()
        {
            SqlConnection con = new SqlConnection(conn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT wrDate, empName, empJob, wrdiaNo FROM  dbo.wrdia WHERE (wrDate = CAST(GETDATE() AS date) and wrdiaNo = 'الثانية')", con);
            adapt.Fill(dt);
            dgv2.DataSource = dt;
            con.Close();
            ////////اسماء الاعمدة///////
            dgv2.Columns[0].HeaderText = "التاريخ";
            dgv2.Columns[1].HeaderText = "الاسم";
            dgv2.Columns[2].HeaderText = "الوظيفة";
            dgv2.Columns[3].HeaderText = "الوردية";

        }
        private void displayDatadgv3()
        {
            SqlConnection con = new SqlConnection(conn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT wrDate, empName, empJob, wrdiaNo FROM  dbo.wrdia WHERE (wrDate = CAST(GETDATE() AS date) and wrdiaNo = 'الثالثة')", con);
            adapt.Fill(dt);
            dgv3.DataSource = dt;
            con.Close();
            ////////اسماء الاعمدة///////
            dgv3.Columns[0].HeaderText = "التاريخ";
            dgv3.Columns[1].HeaderText = "الاسم";
            dgv3.Columns[2].HeaderText = "الوظيفة";
            dgv3.Columns[3].HeaderText = "الوردية";

        }

        private void displayDatadgv4()
        {
            SqlConnection con = new SqlConnection(conn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT wrDate, empName, empJob, wrdiaNo FROM  dbo.wrdia WHERE (wrDate = CAST(GETDATE() AS date) and wrdiaNo = 'الرابعة')", con);
            adapt.Fill(dt);
            dgv4.DataSource = dt;
            con.Close();
            dgv4.Columns[0].HeaderText = "التاريخ";
            dgv4.Columns[1].HeaderText = "الاسم";
            dgv4.Columns[2].HeaderText = "الوظيفة";
            dgv4.Columns[3].HeaderText = "الوردية";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

