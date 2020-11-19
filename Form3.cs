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
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\c# form\\WindowsFormsApp1\\WindowsFormsApp1\\dataform.mdf;Integrated Security=True");
        public Form3()
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

        private void label5_Click(object sender, EventArgs e)
        {
            account1 newForm = new account1();
            newForm.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [cart] (pdid,pdname,price,qty,totqtyp) Values(101,'salt',55,'" + textBox1.Text + "','" + textBox1.Text + "' * 55)";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = "";
            MessageBox.Show("added to cart successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [cart] (pdid,pdname,price,qty,totqtyp) Values(102,'oil',65,'" + textBox2.Text + "','" + textBox2.Text + "' * 65)";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox2.Text = "";
            MessageBox.Show("added to cart successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [cart] (pdid,pdname,price,qty,totqtyp) Values(103,'biscuit',15,'" + textBox3.Text + "','" + textBox3.Text + "' * 15)";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox3.Text = "";
            MessageBox.Show("added to cart successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [cart] (pdid,pdname,price,qty,totqtyp) Values(104,'dal',45,'" + textBox4.Text + "','" + textBox4.Text + "' * 45)";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox4.Text = "";
            MessageBox.Show("added to cart successfully");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
