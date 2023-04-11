<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: #41B3A3; color:white">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <div style="margin-left: auto; margin-right: auto; text-align:justify">
            <asp:Panel ID="Panel1" runat="server" BackColor="#C38D9E" Font-Bold="True" Font-Size="XX-Large" Align="Center" ForeColor="White" BorderWidth="5">
                <br />
                ONE STOP DEGREE ISSUANCE SYSTEM<br />
            </asp:Panel>
        </div>
            <br />
            <br />
            <div style="margin-left: 180px; margin-right: 100px; text-align:center">
                <asp:Panel ID="Panel3" runat="server" BackColor="#E27360" Font-Bold="True" Font-Italic="False" Font-Size="Larger" HorizontalAlign="Center" ForeColor="White" Width="1000" Height="50px" >
            <br />
            Login<br />
            <br />
        </asp:Panel >
            </div>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;
            Pick Your Role<br />
            <br />
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 10px">
                <asp:ListItem>Student</asp:ListItem>
                <asp:ListItem>FYP Department</asp:ListItem>
                <asp:ListItem>Finance Department</asp:ListItem>
                <asp:ListItem>One Stop Admin</asp:ListItem>
                <asp:ListItem>Director</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="username" runat="server" style="margin-left: 6px"></asp:TextBox>
            &nbsp;<br />
            <br />
            Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
