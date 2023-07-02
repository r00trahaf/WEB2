<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sendemail.aspx.cs" Inherits="WebApplication3.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class ="card-body">
                <div class="row">
                    <div class="col-12">
                     <center> 
                         <img src="imgs/تصميم_بدون_عنوان-removebg-preview.png" width="180" hight="180"/>
                     </center>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                     <center> 
                         <h1>MESSAGE</h1>
                         <asp:TextBox ID="textbox1" runat="server" placeholder="THIS EMAIL SEND TO"></asp:TextBox>
                     </center>
                    </div>
                </div>
                <div class="row">
                    <div class="col-12">
                     <center> 
                    <br />
                         <div class ="form-group">
                             <asp:TextBox id="textbox2" runat ="server" placeholder="Write your message" TextMode ="MultiLine" Rows="8" ></asp:TextBox>
                         </div>
                     </center>
                    </div>
                </div>
                  <div class="row">
                    <div class="col">
                     <center> 
                        <label>MESSAGE </label>
                         <div class ="form-group">
                             <asp:Button ID="btnemail" class="btnemail" runat="server" Text="SEND" OnClick="EmailBottunClick" />
                         </div>
                         <asp:Label ID="statusLabel" runat="server"></asp:Label>
                     </center>
                    </div>
                </div>
            </div>

</asp:Content>
