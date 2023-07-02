<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CustomerSearch.aspx.cs" Inherits="WebApplication3.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <div>
        
            customer name <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
          <br />
           <asp:Label ID="Label1" runat="server" Text="NAME :"></asp:Label>
         
              <br />

              <asp:Label ID="Label2" runat="server" Text="PASSWORD"></asp:Label>
    
              <br />

              <asp:Label ID="Label3" runat="server" Text="ROLE"></asp:Label>
        
              <br />
              <asp:Label ID="Label4" runat="server" Text="DATE"></asp:Label>    
           
    </div>
    </center>
</asp:Content>
