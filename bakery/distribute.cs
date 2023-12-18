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
    public partial class distribute : Form
    {
        public distribute()
        {
            InitializeComponent();
        }
        //Connection String
        string conn = Properties.Settings.Default.conn;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ClearAllData()
        {

            ////تنظيف الحقول//////
            distribDate.Text="";
            destinations.Text = "";
            distribTime.Text="";
            totalMony.Text="";
            breadNum.Text="";
            monyReceipt.Text="";
            monyRemain.Text="";
            distributor.Text="";
            distributionCart.Text="";

        }

        private void btsave_Click(object sender, EventArgs e)
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
                sqlCmd = new SqlCommand("distribt_SP_insert", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;

          

                sqlCmd.Parameters.AddWithValue("@distribDate", distribDate.Text);
                sqlCmd.Parameters.AddWithValue("@destinations", destinations.Text);
                sqlCmd.Parameters.AddWithValue("@distribTime", distribTime.Text);
                sqlCmd.Parameters.AddWithValue("@totalMony", totalMony.Text);
                sqlCmd.Parameters.AddWithValue("@breadNum", breadNum.Text);
                sqlCmd.Parameters.AddWithValue("@monyReceipt", monyReceipt.Text);
                sqlCmd.Parameters.AddWithValue("@monyRemain", monyRemain.Text);
                sqlCmd.Parameters.AddWithValue("@distributor", distributor.Text);
                sqlCmd.Parameters.AddWithValue("@distributionCart", distributionCart.Text);
                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    lblMessage.Text = "Record Saved Successfully !!!";
                    ClearAllData();
                    DisplayDatav();

                }
                else
                    lblMessage.Text = "Please Try Again !!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            con.Close();
                   ///////////////////////


        }

        private void btdelet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand sqlCmd;

            

            if (destinations.Text != "" )
            {
                sqlCmd = new SqlCommand("DELETE FROM distribt where  (distribDate='" + distribDate.Text + "' and destinations ='" + destinations.Text + "' and distribTime= '" + distribTime.Text + "')", con);
                con.Open();
                sqlCmd.Parameters.AddWithValue("@distribDate", distribDate.Text);
                sqlCmd.Parameters.AddWithValue("@destinations", destinations.Text);
                sqlCmd.Parameters.AddWithValue("@distribTime", distribTime.Text);
                sqlCmd.ExecuteNonQuery();
                con.Close();
                lblMessage.Text = "Record Deleted Successfully!";
                
            }
            else
            {
                lblMessage.Text = "Please Select Record to Delete";
            }
            ////////////////

            ClearAllData();
                    DisplayDatav();
                    con.Close();
            
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            //DialogResult iExit;
            //iExit = MessageBox.Show("هل تريد الخروج", "الفاروق", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (iExit == DialogResult.Yes)
            //{

                this.Close();
                //Application.Exit();

            //}
        }

        private void distribute_Load(object sender, EventArgs e)
        {
            fiirestaurantNam();
            DisplayDatav();
        }
        private void fiirestaurantNam()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandText = "SELECT  restaurantName FROM dbo.restaurantnames";
            
            //SqlCommand cmd = new SqlCommand("SELECT empName,empJop FROM empData" ,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                destinations.Items.Add(dr["restaurantName"]);

            }
            con.Close();
        }
        private void DisplayDatav()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from distribt order by distribDate", con);
            adapt.Fill(dt);
            dGridV1.DataSource = dt;
            con.Close();

            ////////اسماء الاعمدة///////
            dGridV1.Columns[0].HeaderText = "الرقم";
            dGridV1.Columns[1].HeaderText = "التاريخ";
            dGridV1.Columns[2].HeaderText = "الجهة ";
            dGridV1.Columns[3].HeaderText = "الزمن";
            dGridV1.Columns[4].HeaderText = "المبلغ";
            dGridV1.Columns[5].HeaderText = "المبلغ المدفوع ";
            dGridV1.Columns[6].HeaderText = "المتبقي";
            dGridV1.Columns[7].HeaderText = "الموزع ";
            dGridV1.Columns[8].HeaderText = "العربة ";


        }



        private void button1_Click(object sender, EventArgs e)
        {
            //addrestaurant fm = new addrestaurant();
            //fm.ShowDialog();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            //SqlConnection con = new SqlConnection(strConnString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "distribt_SP_update";

            cmd.Parameters.AddWithValue("@distribDate", distribDate.Text);
            cmd.Parameters.AddWithValue("@destinations", destinations.Text);
            cmd.Parameters.AddWithValue("@distribTime", distribTime.Text);
            cmd.Parameters.AddWithValue("@totalMony", totalMony.Text);
            cmd.Parameters.AddWithValue("@breadNum", breadNum.Text);
            cmd.Parameters.AddWithValue("@monyReceipt", monyReceipt.Text);
            cmd.Parameters.AddWithValue("@monyRemain", monyRemain.Text.ToString());
            cmd.Parameters.AddWithValue("@distributor", distributor.Text);
            cmd.Parameters.AddWithValue("@distributionCart", distributionCart.Text);
            cmd.Connection = con;

            try

            {

                con.Open();

                cmd.ExecuteNonQuery();

                lblMessage.Text = "تم التعديــــل!!!";
                 
                DisplayDatav();

            }

            //catch (Exception ex)

            //{

            //    throw ex;

            //}
            catch (SqlException)
            {
                //MessageBox.Show("Failed to UpdateCurrentTime", "DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally

            {

                con.Close();

                con.Dispose();

            }



        }

        private void dGridV1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //DateTime payDate.Text;
                DataGridViewRow dvgrow = dGridV1.Rows[e.RowIndex];
                //distribDate.Text = dGridV1.Rows[e.RowIndex].Cells[1].Value.ToString();
                destinations.Text = dGridV1.Rows[e.RowIndex].Cells[2].Value.ToString();
                distribTime.Text = dGridV1.Rows[e.RowIndex].Cells[3].Value.ToString();
                totalMony.Text = dGridV1.Rows[e.RowIndex].Cells[4].Value.ToString();
                breadNum.Text = dGridV1.Rows[e.RowIndex].Cells[5].Value.ToString();
                monyReceipt.Text = dGridV1.Rows[e.RowIndex].Cells[6].Value.ToString();
                monyRemain.Text = dGridV1.Rows[e.RowIndex].Cells[7].Value.ToString();
                distributor.Text = dGridV1.Rows[e.RowIndex].Cells[8].Value.ToString();
                distributionCart.Text = dGridV1.Rows[e.RowIndex].Cells[9].Value.ToString();
                
                
                // empTel.Text = Convert.ToInt32(dgvEmp.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }

        private void monyReceipt_TextChanged(object sender, EventArgs e)
        {
            //المتبقي يساوي التوتال - المستلم
            float num1, ans;
            num1 = float.Parse(totalMony.Text);

            ans = num1 - float.Parse(monyReceipt.Text);
            monyRemain.Text = ans.ToString();
        }

        private void destinations_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void totalMony_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void distribTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void destinations_KeyPress(object sender, KeyPressEventArgs e)
        {
            destinations.Refresh();
        }

        private void monyReceipt_Leave(object sender, EventArgs e)
        {

        }

        private void monyRemain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
