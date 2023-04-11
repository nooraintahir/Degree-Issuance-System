using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Activity : System.Web.UI.Page
{
    static string ro;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["Username"] != null)
        {
            ro = Application["Username"].ToString();

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");

        SqlCommand SqlCommand;
        SqlDataReader reader;

        SqlDataAdapter adapter = new SqlDataAdapter();
        con.Open();

        string query = "SELECT fIname as FirstName,laname as Lastname,roll,status FROM PERMISSION INNER JOIN STUDENT ON roll=Roll_no WHERE roll=@ro";

        SqlCommand = new SqlCommand(query, con);
        SqlCommand.Parameters.AddWithValue("@ro", ro);
        adapter.SelectCommand = new SqlCommand(query, con);
        reader = SqlCommand.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainstudent.aspx");
    }
}