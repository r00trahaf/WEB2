<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="details.aspx.cs" Inherits="WebApplication3.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
          <center>
                 <h1>book details</h1>
      <h3>Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h3>  <br />
                  <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" /><br />
      <h3>Price: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h3> <br />
            <asp:TextBox ID="TextBox2" runat="server" /> <br />
           
       <h3>Discount &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h3> 
            <asp:RadioButton ID ="RadioButton1" runat="server" Text="Yes" GroupName="ss" /> 
            <asp:RadioButton ID ="RadioButton2" runat="server" Text="No" /> <br />
         
        <h3> category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h3> 
            <asp:TextBox ID="TextBox3" runat="server" />
                  <br />
                  <br />
           
         <asp:Image ID="Image1" runat="server" Width="150px" />
         <br />
                  <br />
             
           <asp:Label ID ="Label1" runat="server" />
                    <asp:Label ID ="Label2" runat="server" />
          
       
                 
                 


        </div>
     <center>
  
</asp:Content>
