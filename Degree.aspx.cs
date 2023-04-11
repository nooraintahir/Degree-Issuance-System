using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Degree : System.Web.UI.Page
{
    static string ro;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["Username"] != null)
        {
            ro = Application["Username"].ToString();

        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mainstudent.aspx");
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");

        SqlCommand SqlCommand;
        SqlDataReader reader;

        SqlDataAdapter adapter = new SqlDataAdapter();
        con.Open();

        string query = "SELECT * FROM DEGREE WHERE rollno=@ro";

        SqlCommand = new SqlCommand(query, con);
        SqlCommand.Parameters.AddWithValue("@ro", ro);
        adapter.SelectCommand = new SqlCommand(query, con);
        reader = SqlCommand.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();
        reader.Close(); 

        SqlCommand SqlCommand2;
        SqlDataReader reader2;

        SqlDataAdapter adapter2 = new SqlDataAdapter();

        string query2 = "SELECT * FROM TRANSCRIPT WHERE stid=@ro";

        SqlCommand2 = new SqlCommand(query2, con);
        SqlCommand2.Parameters.AddWithValue("@ro", ro);
        adapter2.SelectCommand = new SqlCommand(query2, con);
        reader2 = SqlCommand2.ExecuteReader();
        GridView2.DataSource = reader2;
        GridView2.DataBind();


    }
}