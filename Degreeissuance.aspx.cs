using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Degreeissuance : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1B8R5V\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
        con.Open();
        SqlCommand cm;

        string fname = fnamee.Text, lname = lnamee.Text, major = majorr.Text;
        string addr = address.Text, rollno=roll.Text, cnic=cnicc.Text, cgpa=gpa.Text, grad= DropDownList1.Text;
        DateTime date= DateTime.Today;
        DateTime timesubmitted = DateTime.Now;
        string issuefee = "1";
        String query = "Insert into DEGREE_ISSUANCE values ( '"+fname+"','"+lname+ "','" + addr + "','" + rollno+"','"+cnic+"','"+grad+"','"+major+"','"+cgpa+"','"+date+ "','" + timesubmitted + "','" + issuefee + "')";
        cm= new SqlCommand(query, con);
        cm.ExecuteNonQuery();
        cm.Dispose();

        SqlCommand cmd;
        string query2 = "Insert into PERMISSION (roll,status) VALUES (@id,'Sent to FYP Committee')";
        cmd = new SqlCommand(query2, con);
        cmd.Parameters.AddWithValue("@id", roll.Text);
        cmd.ExecuteNonQuery();

        con.Close();
        Response.Redirect("Submittedconfirmation.aspx");

    }




    protected void fname_TextChanged(object sender, EventArgs e)
    {

    }

    protected void lname_TextChanged(object sender, EventArgs e)
    {

    }

    protected void rollno_TextChanged(object sender, EventArgs e)
    {

    }

    protected void cnic_TextChanged(object sender, EventArgs e)
    {

    }

    protected void address_TextChanged(object sender, EventArgs e)
    {

    }

    protected void major_TextChanged(object sender, EventArgs e)
    {

    }

    protected void cgpa_TextChanged(object sender, EventArgs e)
    {

    }
}