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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        //Connection String
        string conn = Properties.Settings.Default.conn;

        private void btsave_Click(object sender, EventArgs e)
        {
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
                sqlCmd = new SqlCommand("shiftProcduct_SP_insert", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;


                sqlCmd.Parameters.AddWithValue("@productDate", productDate.Text);
                sqlCmd.Parameters.AddWithValue("@shifts", shifts.Text);
                sqlCmd.Parameters.AddWithValue("@noflour1", tB1.Text);
                sqlCmd.Parameters.AddWithValue("@noflour2", tB2.Text);
                sqlCmd.Parameters.AddWithValue("@noflour3", tB3.Text);
                sqlCmd.Parameters.AddWithValue("@noflour4", tB4.Text);
                sqlCmd.Parameters.AddWithValue("@noflour5", tB5.Text);
                sqlCmd.Parameters.AddWithValue("@noflour6", tB6.Text);
                sqlCmd.Parameters.AddWithValue("@noflour7", tB7.Text);
                sqlCmd.Parameters.AddWithValue("@noflour8", tB8.Text);
                sqlCmd.Parameters.AddWithValue("@noflour9", tB9.Text);
                sqlCmd.Parameters.AddWithValue("@noflour10", tB10.Text);
                sqlCmd.Parameters.AddWithValue("@noflourcount", tBsno.Text);
                sqlCmd.Parameters.AddWithValue("@totalOfBread", tBtotal.Text);
                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    MessageBox.Show("تم الحفظ !!!");
                    ClearAllData();
                    DisplayDatview();

                }
                else
                    MessageBox.Show("محاولة مرة اخري!!!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }

            // قفل الكونكشن////
            con.Close();


        }
        private void DisplayDatview()
        {
            //SqlConnection con = new SqlConnection(conn);
            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}

            //DataTable dt = new DataTable();
            //SqlDataAdapter adapt = new SqlDataAdapter("select * from shiftProcduct ", con);
            //adapt.Fill(dt);
            //dGV.DataSource = dt;
            //con.Close();

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearAllData()
        {
            //productDate.Text = "";
            //shifts.Text = "";
            //noflour1.Text = "";
            //bread.Text = "";
            //dgvEmp.AutoGenerateColumns = false;
            ////dgvEmp.DataSource = FetchEmpDetails();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(conn);
            //SqlCommand sqlCmd;

            //con.Open();
            //////////////////
            //try
            //{
            //    if (con.State == ConnectionState.Closed)
            //    {
            //        con.Open();
            //    }
            //    DataTable dtData = new DataTable();
            //    sqlCmd = new SqlCommand("DELETE FROM shiftProcduct WHERE ((productDate = '" + productDate.Text + "') AND (shifts ='" + shifts.Text + "'))", con);
            //    sqlCmd.CommandType = CommandType.Text;
            //    int numRes = sqlCmd.ExecuteNonQuery();
            //    if (numRes > 0)
            //    {
            //        MessageBox.Show("تم الحذف !!!");
            //        ClearAllData();
            //        DisplayDatview();
            //        con.Close();
            //    }
            //    else
            //        MessageBox.Show("اعد المحاولة !!!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error:- " + ex.Message);
            //}

            
            ///////////////////////
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            //SqlCommand sqlCmd;

            con.Open();

            //try
            //{
            //    if (con.State == ConnectionState.Closed)
            //    {
            //        con.Open();
            //    }
            //    DataTable dtData = new DataTable();
            //    sqlCmd = new SqlCommand("shiftProcduct_SP_update", con);
            //    sqlCmd.CommandType = CommandType.StoredProcedure;

            //    sqlCmd.Parameters.AddWithValue("@productDate", productDate.Text);
            //    sqlCmd.Parameters.AddWithValue("@shifts", shifts.Text);
            //    sqlCmd.Parameters.AddWithValue("@noflour", noflour1.Text);
            //    sqlCmd.Parameters.AddWithValue("@bread", bread.Text);

            //    int numRes = sqlCmd.ExecuteNonQuery();
            //    if (numRes > 0)
            //    {
            //        MessageBox.Show("Record updated Successfully !!!");
            //        ClearAllData();

            //    }
            //    else
            //        MessageBox.Show("Please Try Again !!!");
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error:- " + ex.Message);
            //}

            //// قفل الكونكشن////
            //con.Close();

        }

        private void btupdate_Click_1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(conn);
            //SqlCommand sqlCmd;

            //con.Open();
            //////////////////
            //try
            //{
            //    if (con.State == ConnectionState.Closed)
            //    {
            //        con.Open();
            //    }
            //    DataTable dtData = new DataTable();
            //    sqlCmd = new SqlCommand("shiftProcduct_SP_update ", con);
            //    sqlCmd.CommandType = CommandType.StoredProcedure;

            //    sqlCmd.Parameters.AddWithValue("@productDate", productDate.Text);
            //    sqlCmd.Parameters.AddWithValue("@shifts", shifts.Text);
            //    sqlCmd.Parameters.AddWithValue("@noflour", noflour1.Text);
            //    sqlCmd.Parameters.AddWithValue("@bread", bread.Text);

            //    int numRes = sqlCmd.ExecuteNonQuery();
            //    if (numRes > 0)
            //    {
            //        MessageBox.Show("Record update Successfully !!!");
            //        //ClearAllData();
            //        DisplayDatview();

            //    }
            //    else
            //        MessageBox.Show("Please Try Again !!!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error:- " + ex.Message);
            //}

            //con.Close();
            /////////////////////////
        }

        private void product_Load(object sender, EventArgs e)
        {
            DisplayDatview();
            int b =0;

            //int c = a + b;

            tBtotal.Text = Convert.ToString(b);


        }

       
        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("هل تريد الخروج", "الفاروق", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {

                this.Close();
                //Application.Exit();

            }
        }

        private void dGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex != -1)
            //{
            //    //DateTime payDate.Text;
            //    DataGridViewRow dvgrow = dGV.Rows[e.RowIndex];
            //    productDate.Text = dGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    shifts.Text = dGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    noflour1.Text = dGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    bread.Text = dGV.Rows[e.RowIndex].Cells[3].Value.ToString();
              
            //}
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0; // create counter
            foreach (Control c in Controls) // start loop through all the controls in the current form
            {
                if (!(c is TextBox)) continue; // if the control is not a TextBox, continue the loop
                TextBox t = c as TextBox; // redeclare
                if (t.Text != "") // if the text in the textbox is NOT empty
                {
                    count++; // add to the counter
                }
                tBsno.Text = Convert.ToString(count);
            } // end loop
        }

        private void tB1_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
        }
        ///دالة الجمع للحقول//
        private void sumNumbers()
        {/////
            float n1, n2, n3, n4, n5, n6,n7,n8,n9,n10;
            float prototal;
            float.TryParse(tB1.Text, out n1);
            float.TryParse(tB2.Text, out n2);
            float.TryParse(tB3.Text, out n3);
            float.TryParse(tB4.Text, out n4);
            float.TryParse(tB5.Text, out n5);
            float.TryParse(tB6.Text, out n6);
            float.TryParse(tB7.Text, out n7);
            float.TryParse(tB8.Text, out n8);
            float.TryParse(tB9.Text, out n9);
            float.TryParse(tB10.Text, out n10);
            prototal = n1 + n2 + n3 + n4 + n5 + n6+n7+n8+n9+n10 ;
            tBtotal.Text = Convert.ToString(prototal);


        }
        private void tB2_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
            //int a = Convert.ToInt32(tB2.Text);

            //int b = Convert.ToInt32(tB1.Text);

            //int c = a + b;

            //tBtotal.Text = Convert.ToString(c);
        }

        private void tB3_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
        }

        private void tB4_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
        }

        private void tB5_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
        }

        private void tB6_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
        }

        private void tB7_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
        }

        private void tB8_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
        }

        private void tB9_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
        }

        private void tB10_TextChanged(object sender, EventArgs e)
        {
            sumNumbers();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            int cnt = 0;

            foreach (Control c in this.Controls)
                if (c is System.Windows.Forms.TextBox)
                    if (!string.IsNullOrEmpty(c.Text))
                        cnt++;
            textBox5.Text = Convert.ToString(cnt);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Form1 fm = new Form1();
            //fm.MdiParent = this;
            int count = 0; // create counter
            foreach (Control c in Controls) // start loop through all the controls in the current form
            {
                if (!(c is TextBox)) continue; // if the control is not a TextBox, continue the loop
                TextBox t = c as TextBox; // redeclare
                if (t.Text != "") // if the text in the textbox is NOT empty
                {
                    count++; // add to the counter
                }
                textBox5.Text = Convert.ToString(count - 1);
            } // end loop

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int count = 0; // create counter
            foreach (Control c in Controls) // start loop through all the controls in the current form
            {
                //if (!(c is TextBox)) continue; // if the control is not a TextBox, continue the loop
                TextBox t = c as TextBox; // redeclare
                if (t.Text != "") // if the text in the textbox is NOT empty
                {
                    count++; // add to the counter
                }
                textBox5.Text = Convert.ToString(count - 1);
            } // end loop
        }
    } }
