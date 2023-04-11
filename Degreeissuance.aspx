<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Degreeissuance.aspx.cs" Inherits="Degreeissuance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="deg" runat="server" style="; padding: inherit; text-align: center; background-color: #41B3A3;">
        <div>
        </div>
        <br />
        <br />
         <div style="margin-left: 180px; margin-right: 100px; text-align:center">
        <asp:Panel ID="Panel1" runat="server" BackColor="#E27360" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" HorizontalAlign="Center" ForeColor="White" Width="1000" >
            <br />
            Degree Issuance Form<br />
            <br />
        </asp:Panel >
            </div>
        <br />
        <br />
        <p style="font-family: 'Baskerville Old Face'; text-align: justify; margin-left: 1px;">
            &nbsp;</p>
        <p style="font-family: 'Baskerville Old Face'; text-align: center; margin-left: 0px; color:white">
            &nbsp;&nbsp;&nbsp;
            First Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="fnamee" runat="server" OnTextChanged="fname_TextChanged"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp; Last Name:&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="lnamee" runat="server" OnTextChanged="lname_TextChanged"></asp:TextBox>
        </p>
        <p style="font-family: 'Baskerville Old Face'; text-align: center; margin-left: 0px;color:white">
            &nbsp;&nbsp;&nbsp;
            Roll no&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="roll" runat="server" OnTextChanged="rollno_TextChanged"></asp:TextBox>
        </p>
        <p style="font-family: 'Baskerville Old Face'; text-align: center; margin-left: 0px;color:white">
            &nbsp;&nbsp;
            CNIC no.&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="cnicc" runat="server" OnTextChanged="cnic_TextChanged"></asp:TextBox>
        </p>
        <p style="font-family: 'Baskerville Old Face'; text-align: center; margin-left: 0px;color:white">
            &nbsp;Permanent Address&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="address" runat="server" OnTextChanged="address_TextChanged"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="font-family: 'Baskerville Old Face'; text-align: center; margin-left: 0px;color:white">
            Post_grad/Under_grad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Post_grad</asp:ListItem>
                <asp:ListItem>Undergrad</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        </p>
        <p style="font-family: 'Baskerville Old Face'; text-align: center; margin-left: 0px;color:white">
            &nbsp;&nbsp;&nbsp;&nbsp;
            Major&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="majorr" runat="server" OnTextChanged="major_TextChanged"></asp:TextBox>
        </p>
        <p style="font-family: 'Baskerville Old Face'; text-align: center; margin-left: 0px;color:white">
&nbsp;&nbsp;
&nbsp;CGPA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="gpa" runat="server" OnTextChanged="cgpa_TextChanged"></asp:TextBox>
        </p>
        <p style="font-family: 'Baskerville Old Face'; text-align: center; margin-left: 0px;color:white">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
        </p>
        <p style="font-family: 'Baskerville Old Face'; text-align: justify; margin-left: 320px;color:white">
            &nbsp;</p>
        
        <p style="font-family: 'Baskerville Old Face'; text-align: center; margin-left: 0px;">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" TabIndex="1" Text="Submit" />
            &nbsp;&nbsp;</p>
        <p style="font-family: 'Baskerville Old Face'; text-align: justify; margin-left: 320px;">
            &nbsp;</p>
        <p style="font-family: 'Baskerville Old Face'; text-align: justify; margin-left: 320px;">
            &nbsp;</p>
        <p style="font-family: 'Baskerville Old Face'; text-align: justify; margin-left: 320px;">
            &nbsp;</p>
        <p style="font-family: 'Baskerville Old Face'; text-align: justify; margin-left: 320px;">
            &nbsp;</p>
    </form>
</body>
</html>
