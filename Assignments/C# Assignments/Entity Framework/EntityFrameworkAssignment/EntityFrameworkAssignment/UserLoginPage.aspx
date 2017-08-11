<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLoginPage.aspx.cs" Inherits="EntityFrameworkAssignment.UserLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <br />
        <br />
        LOGIN PAGE<br />
        <br />
        Enter Your Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Your User Type&nbsp; :&nbsp;
        <asp:DropDownList ID="dropdownUserType" runat="server" >
            <asp:ListItem Value="Null">Choose User Type</asp:ListItem>
            <asp:ListItem>Normal</asp:ListItem>
            <asp:ListItem>Admin</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Login" runat="server" OnClick="Login_Click" Text="LOGIN" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>

    </form>
</body>
</html>
