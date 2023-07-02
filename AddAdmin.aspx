<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddAdmin.aspx.cs" Inherits="WebApplication3.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center>
    <div class ="card-body">
           <div class="row">
                    <div class="col">
                     <center> 
                         <h1>  Add admin</h1>
                     </center>
                    </div>
                </div>
            <br />
           <div class="row">
                   <div class="col-12">  
                     <center> 
                          <br />
                         <div class ="form-group">
                                Admin name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                                      <asp:TextBox Class="textbox_class" ID="TextBox1" runat="server"  ></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Admin name" ForeColor="Red"></asp:RequiredFieldValidator>
                         </div>
                     </center>
                    </div>
                  </div>
                </div>
        <p>
            &nbsp;</p>
        <p>
            Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox Class="textbox_class" ID="TextBox2" runat="server"  TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter password" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Confirm password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox Class="textbox_class" ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter confirm password" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
    <p>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password does not match confirm password" ForeColor="Red"></asp:CompareValidator>
        </p>
    <p>
        <asp:Button Class="btnemail" ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        </p>
    <p>
        <asp:Label Class="label_class" ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
   </center>
</asp:Content>
