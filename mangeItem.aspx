<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="mangeItem.aspx.cs" Inherits="WebApplication3.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
         <div>
            Item  name
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
         item descraption <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
        <br />
            price <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            item quantity
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
           item discount
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gg" Text="yes" />
            <asp:RadioButton ID="RadioButton2" runat="server" Checked="True" GroupName="gg" Text="no" />
            <br />
           
            <br />
           item catagory
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="5">cultural</asp:ListItem>
                <asp:ListItem Value="1">public</asp:ListItem>
                <asp:ListItem Value="2">History</asp:ListItem>
                 <asp:ListItem Value="3">religion</asp:ListItem>
                 <asp:ListItem Value="4">Psychology </asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Width="150px" />
            <br />
            image file
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br /> upload image
            <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="insert" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="update" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="delete" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </center>

</asp:Content>
