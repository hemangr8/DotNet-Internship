<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <h1>LOGIN PAGE </h1>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;
        </p>
        <p>
            User Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="UserName" runat="server" OnTextChanged="UserName_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            Password&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </p>
        <p>
        </p>


</asp:Content>
