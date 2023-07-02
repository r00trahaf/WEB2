<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="catalog.aspx.cs" Inherits="WebApplication3.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <asp:Repeater ID="Repeater1" runat="server" >                       
<HeaderTemplate>
    <div class="container-fluid"> 
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
                      <asp:Label ID="Label3" runat="server" Text='<%#Eval("price")%>'></asp:Label>
                        </div>
                        <div class="card-footer">
                         <asp:HyperLink ID="HyperLink1"   runat ="server" 
NavigateUrl='<%# "buypage.aspx?idd="+  Eval("Id") %> '> buy </asp:HyperLink>
                        </div>

                    </div>   </div>
</ItemTemplate>
<FooterTemplate></div> </div></FooterTemplate>
</asp:Repeater>

</asp:Content>
