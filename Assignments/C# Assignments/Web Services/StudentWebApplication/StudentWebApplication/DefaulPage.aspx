<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaulPage.aspx.cs" Inherits="StudentWebApplication.DefaulPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <br />
        Enter Student Details:<br />
        <br />
        Roll No.&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
        <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox>
        <br />
        <br />
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        Grade&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
        <asp:TextBox ID="txtGrade" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDetails" runat="server" OnClick="btnDetails_Click" Text="SubmitDetails" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblHeading" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblRollNo" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblName" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblGrade" runat="server"></asp:Label>
    </form>
</body>
</html>
