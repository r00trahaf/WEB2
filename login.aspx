<%@ Page Title="" Language="C#" MasterPageFile="~/Site2login.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication3.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="contact-form">
            <center> 
            <h1>Login</h1>
            <br />
            Username:<br /><br />
                <asp:TextBox ID="TextBox1" runat="server"  placeholder="Enter Username"></asp:TextBox><br /><br />
            Password:<br /><br />
           <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Password"></asp:TextBox><br />
      <br />
            <asp:Button ID="Button1" class="btnemail" runat="server" Text="Login" OnClick="Button1_Click"/> 
      <br />     

                <asp:CheckBox ID="CheckBox1" runat="server" Text="Auto Login" />
                <br />
                <asp:LinkButton ID="link1" runat="server" OnClick="Button2_Click"> NOT REGESTERATION?</asp:LinkButton>
                <asp:Label ID="Label2" runat="server" ></asp:Label>

          </center>   
    </div>
</asp:Content>
