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

    public partial class empfData : Form
    {
        //Connection String
        string conn = Properties.Settings.Default.conn;
        public empfData()
        {
            
            InitializeComponent();
           
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        //private void BindGrid()
        //{
        //    string conn = Properties.Settings.Default.conn;
        //    SqlConnection con = new SqlConnection(conn);
        //    //SqlConnection sqlCon = new SqlConnection(conString);
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM empData", con);
        //    cmd.CommandType = CommandType.Text;
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    dgvEmp.DataSource = dt;
        //}
        private void empfData_Load(object sender, EventArgs e)
        {
            DisplayData();
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
                sqlCmd = new SqlCommand("empData_sp", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@empName", empName.Text);
                sqlCmd.Parameters.AddWithValue("@empHirdate", empHirdate.Text);
                sqlCmd.Parameters.AddWithValue("@empAddress", empAddress.Text);
                sqlCmd.Parameters.AddWithValue("@empJop", empJop.Text);
                sqlCmd.Parameters.AddWithValue("@empHealth", empHealth.Text);
                sqlCmd.Parameters.AddWithValue("@empTel", empTel.Text);
                sqlCmd.Parameters.AddWithValue("@releventTel", releventTel.Text);
                sqlCmd.Parameters.AddWithValue("@natonalNo", natonalNo.Text);
             


                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    label11.Text = "تم الحفظ بنجاح";
                    //MessageBox.Show("تم الحفظ بنجاح","مخبز الفاروق",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //ClearAllData();

                }
                else
                    label11.Text = "لم يتم الحفظ رجاء التأكد من جميع البيانات محاولة مرة اخري";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            con.Close();

            DisplayData();
            ////////////نهاية الحفظ    END OF SAVE/////////
        }
        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btdelet_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conn);
            SqlCommand sqlCmd;

            con.Open();
            ///////start of delete/////////
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataTable dtData = new DataTable();
                sqlCmd = new SqlCommand("empData_SP_delete", con);

                sqlCmd.CommandType = CommandType.Text;

                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    label11.Text = "تم الحذف !!!";
                    //ClearAllData();

                }
                else
                    label11.Text = "اعد المحاولة !!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            con.Close();
            DisplayData();
            ///////////end of delete ////////////
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btupdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conn);
            SqlCommand sqlCmd;

            con.Open();
            //////////UPDATE TABLE //////
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataTable dtData = new DataTable();
                sqlCmd = new SqlCommand("empUpdateData_sp", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@empId", empId.Text);
                sqlCmd.Parameters.AddWithValue("@empName", empName.Text);
                sqlCmd.Parameters.AddWithValue("@empHirdate", empHirdate.Text);
                sqlCmd.Parameters.AddWithValue("@empAddress", empAddress.Text);
                sqlCmd.Parameters.AddWithValue("@empJop", empJop.Text);
                sqlCmd.Parameters.AddWithValue("@empHealth", empHealth.Text);
                sqlCmd.Parameters.AddWithValue("@empTel", empTel.Text);
                sqlCmd.Parameters.AddWithValue("@releventTel", releventTel.Text);
                sqlCmd.Parameters.AddWithValue("@natonalNo", natonalNo.Text);


                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    label11.Text = "تم التعديل !!!!";
                    //ClearAllData();

                }
                else
                    label11.Text = "حاول مرة اخري !!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            con.Close();
            DisplayData();
                ////////نهاية التعديل UPDATE///////////////
        }
        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from empData", con);
            adapt.Fill(dt);
            dgvEmp.DataSource = dt;
            con.Close();
            ////////اسماء الاعمدة///////
            dgvEmp.Columns[0].HeaderText = "الرقم";
            dgvEmp.Columns[1].HeaderText = "الاسم";
            dgvEmp.Columns[2].HeaderText = "تاريخ التعيين";
            dgvEmp.Columns[3].HeaderText = "العنوان";
            dgvEmp.Columns[4].HeaderText = "الوظيفة";
            dgvEmp.Columns[5].HeaderText = "الحالة الصحية";
            dgvEmp.Columns[6].HeaderText = "الهاتف";
            dgvEmp.Columns[7].HeaderText = "الرقم الوطني";
            dgvEmp.Columns[8].HeaderText = "هاتف الاقارب";

        }

        private void dgvEmp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //DateTime payDate.Text;
                DataGridViewRow dvgrow = dgvEmp.Rows[e.RowIndex];
                empId.Text= dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
                empName.Text = dgvEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
                empHirdate.Text = dgvEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
                empAddress.Text = dgvEmp.Rows[e.RowIndex].Cells[3].Value.ToString();
                empJop.Text = dgvEmp.Rows[e.RowIndex].Cells[4].Value.ToString();
                empHealth.Text = dgvEmp.Rows[e.RowIndex].Cells[5].Value.ToString();
                empTel.Text = dgvEmp.Rows[e.RowIndex].Cells[6].Value.ToString();
                natonalNo.Text = dgvEmp.Rows[e.RowIndex].Cells[7].Value.ToString();
                releventTel.Text = dgvEmp.Rows[e.RowIndex].Cells[8].Value.ToString();
                


                
                // empTel.Text = Convert.ToInt32(dgvEmp.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }
    }


    }

