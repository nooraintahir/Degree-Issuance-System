using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Requests : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("OnestopUI.aspx");
    }

    protected void Pend_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");

        SqlCommand SqlCommand;
        SqlDataReader reader;

        SqlDataAdapter adapter = new SqlDataAdapter();
        con.Open();

        string query = "SELECT fname,lname,rollno,cnic,cgpa,Fypaccept,Financeaccept,processed FROM (DEGREE_ISSUANCE INNER JOIN STUDENT ON rollno=Roll_no) INNER JOIN PERMISSION ON Roll_no=roll WHERE Fypaccept LIKE 1 AND Financeaccept LIKE 1 AND processed LIKE 0";

        SqlCommand = new SqlCommand(query, con);
        adapter.SelectCommand = new SqlCommand(query, con);
        reader = SqlCommand.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();

        con.Close();
    }

    protected void Proc_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");

        SqlCommand SqlCommand;
        SqlDataReader reader;

        SqlDataAdapter adapter = new SqlDataAdapter();
        con.Open();

        string query = "SELECT fname,lname,rollno,cnic,cgpa,Fypaccept,Financeaccept,processed FROM (DEGREE_ISSUANCE INNER JOIN STUDENT ON rollno=Roll_no) INNER JOIN PERMISSION ON Roll_no=roll WHERE processed LIKE 1";

        SqlCommand = new SqlCommand(query, con);
        adapter.SelectCommand = new SqlCommand(query, con);
        reader = SqlCommand.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();

        con.Close();
    }

    protected void New_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");

        SqlCommand SqlCommand;
        SqlDataReader reader;

        SqlDataAdapter adapter = new SqlDataAdapter();
        con.Open();

        string query = "SELECT fname,lname,rollno,cnic,cgpa,Fypaccept,Financeaccept,processed FROM (DEGREE_ISSUANCE INNER JOIN STUDENT ON rollno=Roll_no) INNER JOIN PERMISSION ON Roll_no=roll WHERE Fypaccept LIKE 0 OR Financeaccept LIKE 0";

        SqlCommand = new SqlCommand(query, con);
        adapter.SelectCommand = new SqlCommand(query, con);
        reader = SqlCommand.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();

        con.Close();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

 