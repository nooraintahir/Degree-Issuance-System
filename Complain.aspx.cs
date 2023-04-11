using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Complain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainUI.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
        string query = "update DEGREE_ISSUANCE set fname=@fn, lname=@ln, addr=@add, cgpa=@gpa where rollno=@id";
        conn.Open();
        SqlCommand cm;
        cm = new SqlCommand(query, conn);
        cm.Parameters.AddWithValue("@fn", TextBox1.Text);
        cm.Parameters.AddWithValue("@id", TextBox3.Text);
        cm.Parameters.AddWithValue("@ln", TextBox2.Text);
        cm.Parameters.AddWithValue("@add", TextBox5.Text);
        cm.Parameters.AddWithValue("@gpa", TextBox4.Text);

        cm.ExecuteNonQuery();

        conn.Close();
        Response.Redirect("Submittedconfirmation.aspx");
    }
}