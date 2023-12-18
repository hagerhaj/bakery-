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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HAJER;Initial Catalog=bakery;Integrated Security=True;"); // making connection  
            string query = "SELECT * FROM userlogin WHERE userName='" + userName.Text.Trim() + "' AND userPassword='" + userPassword.Text.Trim() + "'" ;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);

            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                /*  If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                new Form1().Show();
            }
            else 
            // MessageBox.Show("الاسم او كلمة السر غير صحيح "); 
             label5.Text= "الاسم او كلمة السر غير صحيح ";

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("هل تريد الخروج", "الفاروق", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {

                this.Close();
                //Application.Exit();

            }
        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
