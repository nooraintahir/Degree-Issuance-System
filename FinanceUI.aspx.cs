using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class FinanceUI : System.Web.UI.Page
{
    static int roll;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Button7.Visible = false;
        TextBox1.Visible = false;
        Label1.Visible = false;
    }
    

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");

        SqlCommand SqlCommand;
        SqlDataReader reader;

        SqlDataAdapter adapter = new SqlDataAdapter();
        con.Open();

        string query = "SELECT fname,lname,rollno,cnic,cgpa,Feepaid,Financeaccept FROM (DEGREE_ISSUANCE INNER JOIN STUDENT ON rollno=Roll_no) INNER JOIN PERMISSION ON Roll_no=roll WHERE Financeaccept LIKE 0 AND STATUS LIKE 'Sent to Finance Committee'";

        SqlCommand = new SqlCommand(query, con);
        adapter.SelectCommand = new SqlCommand(query, con);
        reader = SqlCommand.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();
        Button7.Visible = true;
        TextBox1.Visible = true;
        Label1.Visible = true;

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        roll = Convert.ToInt32(GridView1.SelectedRow.Cells[3].Text);
        TextBox1.Text = GridView1.SelectedRow.Cells[6].Text;
        Button7.Visible = true;
        TextBox1.Visible = true;
        Label1.Visible = true;
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Button7.Visible = true;
        TextBox1.Visible = true;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
        string query = "update PERMISSION set financeaccept=@accept, fintime=@tim, status = 'Sent to Onestop Committee' where roll=@id";
        conn.Open();
        SqlCommand cm;
        cm = new SqlCommand(query, conn);
        DateTime timee = DateTime.Now;
        cm.Parameters.AddWithValue("@accept", TextBox1.Text);
        cm.Parameters.AddWithValue("@id", roll);
        cm.Parameters.AddWithValue("@tim", timee);
        cm.ExecuteNonQuery();


        conn.Close();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

}