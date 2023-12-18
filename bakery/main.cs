using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakery
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Application.Run(new empfData());
            payroll fm = new payroll();
            fm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Run(new empfData());
            empfData fm = new empfData();
            //fm.MdiParent = this;
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            //fm.MdiParent = this;
            fm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            


            product fm = new product();
            //fm.MdiParent = this;
            fm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wrdiya fm = new wrdiya();
            fm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            distribute fm = new distribute();
            fm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            finance fm = new finance();
            fm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            
            main main = new main();
            main.IsMdiContainer = true;

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            addrestaurant fm = new addrestaurant();
            fm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tsaaera fm = new tsaaera();
            fm.ShowDialog();
        }
    }
}
