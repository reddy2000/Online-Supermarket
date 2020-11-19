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

namespace WindowsFormsApp1
{
    public partial class account1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\c# form\\WindowsFormsApp1\\WindowsFormsApp1\\dataform.mdf;Integrated Security=True");
        public account1()
        {
            InitializeComponent();
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            account2 newForm = new account2();
            newForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from [userdetails] where name='" + textBox1.Text + "'and password ='" + textBox2.Text + "'", connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("Login successfull");

                connection.Close();
                Form1 frm = new Form1(textBox1.Text);
                frm.Show();
                
             }
            else
            {
                MessageBox.Show("invalid details");
                connection.Close();

                account2 frm = new account2();
                frm.Show();

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text =="admin")
            {

                admin frm = new admin(textBox1.Text);
                frm.Show();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            reset_password frm = new reset_password();
            frm.Show();
        }
    }
}
