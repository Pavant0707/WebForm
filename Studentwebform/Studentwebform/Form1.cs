using System.Data.SqlClient;

namespace Studentwebform
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Praveen\SQLEXPRESS;Initial Catalog=STUDENTWEBFORM;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT VALUES('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DATA INSERTED");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE STUDENT SET StudentId='" + textBox5.Text + "',Name='" + textBox1.Text + "',EMAIL='" + textBox2.Text + "',PHONENUMBER='" + textBox3.Text + "',COLLAGE='" + textBox4.Text + "',BRANCHE='" + comboBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DATA UPDATED");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE STUDENT WHERE StudentId='" + textBox5.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DATA DELETED");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox3.Text = " ";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
