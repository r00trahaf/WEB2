<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="buypage.aspx.cs" Inherits="WebApplication3.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center>
         <h1>Buy page</h1>
               Book name
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
         
            <asp:Image ID="Image1" runat="server" Height="67px" Width="92px" />
            <br />
            <h3> price</h3>  <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <h3> Quantity in store</h3>  <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
        <h3>     discount&nbsp;</h3>  <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <br />
           <h3>  category</h3> 
            <asp:Label ID="Label6" runat="server"></asp:Label>
            <br />
          <h4> how many book you need to buy&nbsp;</h4> 
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            you need to pay&nbsp;
            <asp:Label ID="Label7" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pay" />
&nbsp;
            <asp:Label ID="Label8" runat="server" ForeColor="#006600"></asp:Label>
        </div>
          <center/>

</asp:Content>
