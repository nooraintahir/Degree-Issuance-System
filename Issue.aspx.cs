using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Issue : System.Web.UI.Page
{
    static int roll;
    static string fname, lname, major;
    static double gpa;

    protected void Page_Load(object sender, EventArgs e)
    {
        Button7.Visible = false;
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Button7.Visible = true;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
        string query = "update PERMISSION set accept=@tim, status = 'Degree and Transcript Issued' where roll=@id";
        conn.Open();
        SqlCommand cm;
        cm = new SqlCommand(query, conn);
        DateTime timee = DateTime.Now;
        cm.Parameters.AddWithValue("@id", roll);
        cm.Parameters.AddWithValue("@tim", timee);
        cm.ExecuteNonQuery();

        string query2 = "INSERT INTO DEGREE VALUES( '" + fname + "','" + lname + "','" + roll + "','" + major + "')";
        cm = new SqlCommand(query2, conn);
        cm.ExecuteNonQuery();

        string query3 = "INSERT INTO Transcript VALUES('" + roll + "','" + fname + "','" + lname + "','" + major + "','" + gpa + "')";
        cm = new SqlCommand(query3, conn);
        cm.ExecuteNonQuery();


        conn.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");

        SqlCommand SqlCommand;
        SqlDataReader reader;

        SqlDataAdapter adapter = new SqlDataAdapter();
        con.Open();

        string query = "SELECT fname,lname,rollno,cnic,cgpa,major FROM (DEGREE_ISSUANCE INNER JOIN STUDENT ON rollno=Roll_no) INNER JOIN PERMISSION ON Roll_no=roll WHERE Fypaccept LIKE 1 AND Financeaccept LIKE 1 AND processed LIKE 1 AND STATUS NOT LIKE 'Degree and Transcript Issued'";

        SqlCommand = new SqlCommand(query, con);
        adapter.SelectCommand = new SqlCommand(query, con);
        reader = SqlCommand.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        roll = Convert.ToInt32(GridView1.SelectedRow.Cells[3].Text);
        fname=GridView1.SelectedRow.Cells[1].Text;
        lname = GridView1.SelectedRow.Cells[2].Text;
        major = GridView1.SelectedRow.Cells[6].Text;
        gpa = Convert.ToDouble(GridView1.SelectedRow.Cells[5].Text);
        Button7.Visible = true;

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("OnestopUI.aspx");
    }
}