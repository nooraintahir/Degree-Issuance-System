using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OnestopUI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }


    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }


    protected void Token_Click(object sender, EventArgs e)
    {
        Response.Redirect("Acceptonestop.aspx");
    }

    protected void Req_Click(object sender, EventArgs e)
    {
        Response.Redirect("Requests.aspx");
    }

    protected void Reject_Click(object sender, EventArgs e)
    {
        Response.Redirect("Reject.aspx");
    }

    protected void Degree_Click(object sender, EventArgs e)
    {
        Response.Redirect("Issue.aspx");
    }

  
}