using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_web_Form.Student
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                GetCollege();
            }

        }
        String Connectionstring = @"Data Source=Praveen\SQLEXPRESS;Initial Catalog=STUDENTWEBFORM;Integrated Security=True;";
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("AddCollegeDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CollegeId", TextBox1.Text);
            cmd.Parameters.AddWithValue("@STUDENTID", TextBox2.Text);
            cmd.Parameters.AddWithValue("@CollegeName", TextBox3.Text);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Inserted');", true);
            con.Close();
            
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentForm.aspx");
        }
    }
}