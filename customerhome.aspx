<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="customerhome.aspx.cs" Inherits="WebApplication3.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>
    <div class="sec_home">
<h1>Welcome to customer page</h1>
  <h2>Reader is a new vision that takes the Bookstores to
another level that makes it easier for reading lovers.</h2>
        </div>
<h1>Our discounts</h1>
</center>
            <asp:Repeater ID="Repeater1" runat="server" >                       
<HeaderTemplate>
    <center>
    <div class="container"> 
<div class="row">
</HeaderTemplate>
<ItemTemplate>
 <div class="col-md-3">
          <div class="card">
              <div class="card-header">
                    Title: <asp:Label ID="Label2" runat="server" Text='<%#Eval("name")%>'></asp:Label>
               </div>
               <div class="card-body">
                 <asp:Image ID="Image1" Height="150px" Width="150px"  runat="server" 
                  ImageUrl ='<%#"~//imgs//"+Eval("imagefilename")%>' />
                     Price:
                      <asp:Label ID="Label3" runat="server" Text='<%# Eval("price")%>'></asp:Label>
                        </div>
                        <div class="card-footer">
                         <asp:HyperLink ID="HyperLink1"   runat ="server" 
                   NavigateUrl='<%# "details.aspx?idd="+  Eval("Id") %> '> more </asp:HyperLink>
                        </div>
                    </div> 
                 </div>
    </center>
        </ItemTemplate>

      </asp:Repeater>
</asp:Content>
