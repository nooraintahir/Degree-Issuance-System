using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Reject : System.Web.UI.Page
{
    static int roll;
    protected void Page_Load(object sender, EventArgs e)
    {
        Button7.Visible = false;

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");

        SqlCommand SqlCommand;
        SqlDataReader reader;

        SqlDataAdapter adapter = new SqlDataAdapter();
        con.Open();

        string query = "SELECT TOP(1) fname,lname,rollno,cnic,cgpa FROM (DEGREE_ISSUANCE INNER JOIN STUDENT ON rollno=Roll_no) INNER JOIN PERMISSION ON Roll_no=roll WHERE (Fypaccept LIKE 0 OR Financeaccept LIKE 0) AND processed LIKE 0 AND status LIKE 'Sent to Onestop Committee'";

        SqlCommand = new SqlCommand(query, con);
        adapter.SelectCommand = new SqlCommand(query, con);
        reader = SqlCommand.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("OnestopUI.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Button7.Visible = true;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
        string query = "update PERMISSION set accept=@tim, status = 'Rejected' where roll=@id";
        conn.Open();
        SqlCommand cm;
        cm = new SqlCommand(query, conn);
        DateTime timee = DateTime.Now;
        cm.Parameters.AddWithValue("@id", roll);
        cm.Parameters.AddWithValue("@tim", timee);
        cm.ExecuteNonQuery();


        conn.Close();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        roll = Convert.ToInt32(GridView1.SelectedRow.Cells[3].Text);
        Button7.Visible = true;

    }
}