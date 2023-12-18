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
    
    public partial class payroll : Form
    {
        //Connection String
        string conn = Properties.Settings.Default.conn;
        public payroll()
        {
            InitializeComponent();
       
        }

        private void payroll_Load(object sender, EventArgs e)
        {
            fillcombobox();
           DisplayDatag();
        }
        private void fillcombobox()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandText = "SELECT empName,empJop FROM empData";
            //SqlCommand cmd = new SqlCommand("SELECT empName,empJop FROM empData" ,con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                empName.Items.Add(dr["empName"]);

            }
            con.Close();
        }
        private void shiftproduct()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            

            cmd.CommandText = "SELECT noflourcount, totalOfBread FROM shiftProcduct where productDate='" + paydate.Value + "' and shifts ='" + wrdia.Text + "' " ;
            //SqlCommand cmd = new SqlCommand("SELECT empName,empJop FROM empData" ,con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr.GetValue(0).ToString();

                textBox3.Text = dr.GetValue(1).ToString();
            }
            con.Close();
        }
        private void getempnumb()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandText = "SELECT empId,empJop FROM empData where empName='"+ empName.Text+ "'";
            //SqlCommand cmd = new SqlCommand("SELECT empName,empJop FROM empData" ,con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                empId.Text = dr.GetValue(0).ToString();

                textBox1.Text = dr.GetValue(1).ToString();
            }
            con.Close();
            if (textBox1.Text == "فران")
                Convert.ToInt32(textBox4.Text = "700");
            else if (textBox2.Text == "عجان")
                Convert.ToInt32(textBox4.Text = "800");
        }
        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
   
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand sqlCmd;

            con.Open();
            ////////////////
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataTable dtData = new DataTable();
                sqlCmd = new SqlCommand("INSERT INTO payroll (paydate,empName,payAmount,monyPaid,monyLeft,memos,wrdia,empId) VALUES(@paydate , @empName,@payAmount,@monyPaid,@monyLeft,@memos,@wrdia,@empId )", con);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@paydate", paydate.Text);
                sqlCmd.Parameters.AddWithValue("@empName", empName.Text);
                sqlCmd.Parameters.AddWithValue("@payAmount", payAmount.Text);
                sqlCmd.Parameters.AddWithValue("@monyPaid", monyPaid.Text);
                sqlCmd.Parameters.AddWithValue("@monyLeft", monyLeft.Text);
                sqlCmd.Parameters.AddWithValue("@memos", memos.Text);
                sqlCmd.Parameters.AddWithValue("@wrdia", wrdia.Text);
                sqlCmd.Parameters.AddWithValue("@empId", empId.Text);

                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    label11.Text="Record Saved Successfully !!!";
                    DisplayDatag();

                }
                else
                    label11.Text = "Please Try Again !!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }




            ///////////////////////
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand sqlCmd;

            
            ////////////////
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataTable dtData = new DataTable();
                sqlCmd = new SqlCommand("DELETE FROM payroll WHERE (paydate = '"+ paydate.Text+ "') AND (empName ='" + empName.Text + "') AND (wrdia ='" + wrdia.Text + "')", con);
                sqlCmd.CommandType = CommandType.Text;
               

                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    label11.Text = "تم الحذف !!!";
                    //ClearAllData();
                    DisplayDatag();

                }
                else
                    label11.Text = "اعد المحاولة !!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }




            ///////////////////////
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand sqlCmd;

            con.Open();
            ////////////////
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataTable dtData = new DataTable();
                sqlCmd = new SqlCommand("UPDATE payroll SET paydate= @paydate , empName = @empName, payAmount =  @payAmount, monyPaid =@monyPaid ,monyLeft =  @monyLeft, memos =@memos, wrdia =@wrdia , empId = @empId  WHERE (paydate =@paydate ) AND (empName =@empName) AND (wrdia =@wrdia ) ", con);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@paydate", paydate.Text);
                sqlCmd.Parameters.AddWithValue("@empName", empName.Text);
                sqlCmd.Parameters.AddWithValue("@payAmount", payAmount.Text);
                sqlCmd.Parameters.AddWithValue("@monyPaid", monyPaid.Text);
                sqlCmd.Parameters.AddWithValue("@monyLeft", monyLeft.Text);
                sqlCmd.Parameters.AddWithValue("@memos", memos.Text);
                sqlCmd.Parameters.AddWithValue("@wrdia", wrdia.Text);
                sqlCmd.Parameters.AddWithValue("@empId", empId.Text);

                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    label11.Text = "Record update Successfully !!!";
                    //ClearAllData();

                }
                else
                    label11.Text = "Please Try Again !!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }

            con.Close();


            ///////////////////////
        }
        private void DisplayDatag()
        {
            SqlConnection con = new SqlConnection(conn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from payroll ", con);
            adapt.Fill(dt);
            dGV1.DataSource = dt;
            con.Close();

        }
        private void empName_SelectedValueChanged(object sender, EventArgs e)
        {
            getempnumb();
        }

        private void dGV1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //DateTime payDate.Text;
                DataGridViewRow dvgrow = dGV1.Rows[e.RowIndex];
                paydate.Text= dGV1.Rows[e.RowIndex].Cells[0].Value.ToString();
                empName.Text = dGV1.Rows[e.RowIndex].Cells[1].Value.ToString();
                payAmount.Text = dGV1.Rows[e.RowIndex].Cells[2].Value.ToString();
                monyPaid.Text = dGV1.Rows[e.RowIndex].Cells[3].Value.ToString();
                monyLeft.Text = dGV1.Rows[e.RowIndex].Cells[4].Value.ToString();
                memos.Text = dGV1.Rows[e.RowIndex].Cells[5].Value.ToString();
                wrdia.Text = dGV1.Rows[e.RowIndex].Cells[6].Value.ToString();
                empId.Text = dGV1.Rows[e.RowIndex].Cells[7].Value.ToString();
                
                                
                // empTel.Text = Convert.ToInt32(dgvEmp.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }

        private void paydate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monyPaid_TextChanged(object sender, EventArgs e)
        {
            float num1, ans;
            num1 = float.Parse(payAmount.Text);

            ans = num1 - float.Parse(monyPaid.Text);
            monyLeft.Text = ans.ToString();
           
            //monyLeft.Text = float.Parse(payAmount.Text) = float.Parse(monyPaid.Text);
            //monyLeft.Text =Convert.ToInt32(payAmount.Text) - Convert.ToInt32(monyPaid.Text);
        }

        private void empName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monyLeft_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           



        }

        private void wrdia_SelectedIndexChanged(object sender, EventArgs e)
        {
            shiftproduct();
        }
    }
}
