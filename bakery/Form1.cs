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
    public partial class Form1 : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=HAJER;Initial Catalog=bakery;Integrated Security=True; ");
        public Form1()
        {
            InitializeComponent();

        }
       //Connection String
        string conn = Properties.Settings.Default.conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            filldatagraid();
            dGridV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            getoutgoingname();

           

        }

        void filldatagraid ()
        {
           
            //fill data graid ///
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM expenses ", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dGridV.DataSource = dt;
            ////////اسماء الاعمدة///////
            dGridV.Columns[0].HeaderText = "التاريخ";
            dGridV.Columns[1].HeaderText = "المنصرف";
            dGridV.Columns[2].HeaderText = "العدد";
            dGridV.Columns[3].HeaderText = "المبلغ";
            
        }

        private void btSave_Click(object sender, EventArgs e)
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
                sqlCmd = new SqlCommand("expenses_sp", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
              
                sqlCmd.Parameters.AddWithValue("@payDate", payDate.Value.Date);
                sqlCmd.Parameters.AddWithValue("@outgoing", outgoing.Text);
                sqlCmd.Parameters.AddWithValue("@outgoingnum", outgoingnum.Text);
                sqlCmd.Parameters.AddWithValue("@payAmount", payAmount.Text);
                
                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    MessageBox.Show("Record Saved Successfully !!!");
                    filldatagraid();
                    //ClearAllData();
                    //payDate.Text ="";
                    outgoing.Text = "";
                    outgoingnum.Text = "";
                    payAmount.Text = "";
                }
                else
                    label6.Text = "Please Try Again !!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }




            ///////////////////////


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void payDate_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            /////////////
            SqlConnection con = new SqlConnection(conn);
            SqlCommand sqlCmd;

            con.Open();

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataTable dtData = new DataTable();
                sqlCmd = new SqlCommand("expenses_SP_delete", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@payDate", payDate.Value.Date);
                sqlCmd.Parameters.AddWithValue("@outgoing", outgoing.Text);

                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    label6.Text="Record deleted Successfully !!!";
                    // ClearAllData();
                    // قفل الكونكشن////
                    filldatagraid();
                    con.Close();
                }
                else

                    //DialogResult result =
                    label6.Text = "Please Try Again !!!";
           
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }

           




            //////////////
        }
        private void getoutgoingname()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandText = "select * from outgoingItems";
            //SqlCommand cmd = new SqlCommand("SELECT empName,empJop FROM empData" ,con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                outgoing.Items.Add(dr["outgoing"]);

            }
            con.Close();
        }
        private void outgoing_SelectedIndexChanged(object sender, EventArgs e)
        {
       

        }

        private void outgoingnum_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void outgoing_TextUpdate(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            ///////////تعديل الداتاقريد حسب المنصرف//////////
            SqlDataAdapter adapt = new SqlDataAdapter("select * from expenses where outgoing like '" + outgoing.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dGridV.DataSource = dt;
            con.Close();

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            //DialogResult iExit;
            //iExit = MessageBox.Show("هل تريد الخروج","الفاروق",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //if (iExit== DialogResult.Yes)
            //{
                
               this.Close();
                //Application.Exit();

            //}
        }

        private void dGridV_SelectionChanged(object sender, EventArgs e)
        {
            

            
        }

        private void dGridV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //DateTime payDate.Text;
                DataGridViewRow dvgrow = dGridV.Rows[e.RowIndex];
                payDate.Value = ((DateTime)dvgrow.Cells[0].Value);
                //payDate.Value = Convert.ToDateTime(dvgrow.Cells[5].Value.ToString());
                //dataGridView1.Rows[i].Cells[5].Value = dtpdate.Value.ToString("dd-MM-yyyy");
                //payDate.Value.ToString("dd-MM-yyyy") = dvgrow.Cells[0].Value;
                outgoing.Text = dvgrow.Cells[1].Value.ToString();
                outgoingnum.Text = dvgrow.Cells[2].Value.ToString();
                payAmount.Text = dvgrow.Cells[3].Value.ToString();
            }
        }

        private void payDate_ValueChanged_1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(conn);
            //con.Open();
            /////////////تعديل الداتاقريد حسب المنصرف//////////
            //SqlDataAdapter adapt = new SqlDataAdapter("select * from expenses where payDate like '" + payDate.Value + "%'", con);
            //DataTable dt = new DataTable();
            //adapt.Fill(dt);
            //dGridV.DataSource = dt;
            //con.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e)
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
                if (outgoing.Text != string.Empty && outgoingnum.Text != string.Empty && payAmount.Text != string.Empty)
                {
                    DataTable dtData = new DataTable();
                    //sqlCmd = new SqlCommand("expensesUpdate_sp", con);
                    sqlCmd = new SqlCommand("UPDATE expenses SET payDate=@payDate,outgoing = @outgoing, outgoingnum = @outgoingnum, payAmount = @payAmount WHERE payDate = @payDate and outgoing = @outgoing", con);
                    
                    sqlCmd.CommandType = CommandType.Text;

                    sqlCmd.Parameters.AddWithValue("@payDate", payDate.Value.Date);
                    sqlCmd.Parameters.AddWithValue("@outgoing", outgoing.Text);
                    sqlCmd.Parameters.AddWithValue("@outgoingnum", outgoingnum.Text);
                    sqlCmd.Parameters.AddWithValue("@payAmount", payAmount.Text);

                    var rowsUpdated = sqlCmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsUpdated > 0) {
                        label6.Text = "Product updated successfully";
                        filldatagraid();
                    }
                    else { label6.Text = "Product NOT updated successfully";
                    }

                    //int numRes = sqlCmd.ExecuteNonQuery();
                    //if (numRes > 0)
                    //{
                    //    MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    filldatagraid();

                    //}
                    //else
                    //{

                    //    //DialogResult result =
                    //    MessageBox.Show("Please Try Again !!!");
                    //}



                    //btnDelete.Enabled = false;
                    //btnUpdate.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            outgoingItems fm = new outgoingItems();
            fm.ShowDialog();
        }

        private void outgoing_MouseClick(object sender, MouseEventArgs e)
        {
            //getoutgoingname();
        }
    }
}
