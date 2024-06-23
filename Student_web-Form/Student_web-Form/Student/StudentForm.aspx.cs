using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_web_Form.Student
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetStudent();
                //GetCollege();
            }
        }
        String Connectionstring = @"Data Source=Praveen\SQLEXPRESS;Initial Catalog=STUDENTWEBFORM;Integrated Security=True;";

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETESTUDENTBYID", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@STUDENTID", TextBox1.Text);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull');", true);
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("STUDENTREGISTER", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@STUDENTID", TextBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", TextBox2.Text);
            cmd.Parameters.AddWithValue("@EMAIL", TextBox3.Text);
            cmd.Parameters.AddWithValue("@PHONENUMBER", TextBox4.Text);
            cmd.Parameters.AddWithValue("@COLLAGE", TextBox5.Text);
            cmd.Parameters.AddWithValue("@BRANCHE", DropDownList1.SelectedValue);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Inserted');", true);
            con.Close();
            GetStudent();
        }
        public void GetStudent()
        {
            //String Connectionstring = @"Data Source=Praveen\SQLEXPRESS;Initial Catalog=STUDENTWEBFORM;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(Connectionstring);
            conn.Open();
            SqlCommand co = new SqlCommand("GETALLSTUDENTS", conn);
            SqlDataAdapter sd = new SqlDataAdapter(co);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }  
        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATESTUDENTBYID", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@STUDENTID", TextBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", TextBox2.Text);
            cmd.Parameters.AddWithValue("@EMAIL", TextBox3.Text);
            cmd.Parameters.AddWithValue("@PHONENUMBER", TextBox4.Text);
            cmd.Parameters.AddWithValue("@COLLAGE", TextBox5.Text);
            cmd.Parameters.AddWithValue("@BRANCHE", DropDownList1.SelectedValue);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull');", true);
            con.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            int STUDDENTID = int.Parse(TextBox1.Text);
            SqlCommand cmd = new SqlCommand("GETSTUDENTBYID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@STUDENTID", TextBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update_by_name", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NAME", TextBox2.Text);
            cmd.Parameters.AddWithValue("@EMAIL", TextBox3.Text);
            cmd.Parameters.AddWithValue("@PHONENUMBER", TextBox4.Text);
            cmd.Parameters.AddWithValue("@COLLAGE", TextBox5.Text);
            cmd.Parameters.AddWithValue("@BRANCHE", DropDownList1.SelectedValue);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull');", true);
            con.Close();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("AddCollegeDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CollegeId", TextBox6.Text);
            cmd.Parameters.AddWithValue("@STUDENTID", TextBox7.Text);
            cmd.Parameters.AddWithValue("@CollegeName", TextBox8.Text);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Inserted');", true);
            con.Close();
            GetStudent();
        }
        public void GetCollege()
        {
            SqlConnection conn = new SqlConnection(Connectionstring);
            conn.Open();
            SqlCommand co = new SqlCommand("GetStudentWithCollege", conn);
            SqlDataAdapter sd = new SqlDataAdapter(co);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}