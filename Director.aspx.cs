using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Director : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Token_Click(object sender, EventArgs e)
    {
        Response.Redirect("DirectRequests.aspx");
    }

    protected void Req_Click(object sender, EventArgs e)
    {
        Response.Redirect("Allactivity.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}