using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
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

        Application["Username"] = username.Text;


        if (DropDownList1.SelectedValue.ToString() == "Student")
        {
            string query1 = "select * from Student where Roll_no like " + username.Text + " AND password like '" + password.Text + "'";
            cm = new SqlCommand(query1, con);

            SqlDataReader read1 = cm.ExecuteReader();

            if (read1.HasRows)
            {
                Response.Redirect("Mainstudent.aspx");
            }
            else
            {
                int x = 550;
                int y = 500;
                Response.Write("<div style='position:absolute;font-size:20px;font-weight:bold;font-style:italic;top:" + y.ToString() + "px;left:" + x.ToString() + "px'>The id or password is incorrect</div>");
            }
        }
        else if (DropDownList1.SelectedValue.ToString() == "FYP Department")
        {
            string query2 = "select * from FYP where FYP_NO like " + username.Text + " AND password like '" + password.Text + "'";
            cm = new SqlCommand(query2, con);

            SqlDataReader read2 = cm.ExecuteReader();

            if (read2.HasRows)
            {
                Response.Redirect("FYPUI.aspx");
            }
            else
            {
                int x = 700;
                int y = 500;
                Response.Write("<div style='position:absolute;font-size:20px;font-weight:bold;font-style:italic;top:" + y.ToString() + "px;left:" + x.ToString() + "px'>The id or password is incorrect</div>");
            }
        }
        else if (DropDownList1.SelectedValue.ToString() == "Finance Department")
        {
            string query2 = "select * from Finance where Id like " + username.Text + " AND Password like '" + password.Text + "'";
            cm = new SqlCommand(query2, con);

            SqlDataReader read2 = cm.ExecuteReader();

            if (read2.HasRows)
            {
                Response.Redirect("FinanceUI.aspx");
            }
            else
            {
                int x = 700;
                int y = 500;
                Response.Write("<div style='position:absolute;font-size:20px;font-weight:bold;font-style:italic;top:" + y.ToString() + "px;left:" + x.ToString() + "px'>The id or password is incorrect</div>");
            }
        }
        else if (DropDownList1.SelectedValue.ToString() == "One Stop Admin")
        {
            string query2 = "select * from OneStop where O_Id like " + username.Text + " AND Password like '" + password.Text + "'";
            cm = new SqlCommand(query2, con);

            SqlDataReader read2 = cm.ExecuteReader();

            if (read2.HasRows)
            {
                Response.Redirect("OnestopUI.aspx");
            }
            else
            {
                int x = 700;
                int y = 500;
                Response.Write("<div style='position:absolute;font-size:20px;font-weight:bold;font-style:italic;top:" + y.ToString() + "px;left:" + x.ToString() + "px'>The id or password is incorrect</div>");
            }
        }
        else if (DropDownList1.SelectedValue.ToString() == "Director")
        {
            string query2 = "select * from Dir_Id where dir_Id like " + username.Text + " AND Password like '" + password.Text + "'";
            cm = new SqlCommand(query2, con);

            SqlDataReader read2 = cm.ExecuteReader();

            if (read2.HasRows)
            {
                Response.Redirect("Director.aspx");
            }
            else
            {
                int x = 700;
                int y = 500;
                Response.Write("<div style='position:absolute;font-size:20px;font-weight:bold;font-style:italic;top:" + y.ToString() + "px;left:" + x.ToString() + "px'>The id or password is incorrect</div>");
            }
        }
      
        con.Close();

    }
}