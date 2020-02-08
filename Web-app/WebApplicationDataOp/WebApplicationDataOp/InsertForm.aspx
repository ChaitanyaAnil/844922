<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertForm.aspx.cs" Inherits="WebApplicationDataOp.InsertForm" %>
<asp:Content ID="myid1" ContentPlaceHolderID="MainContent" runat="server" >
    <div class ="jumbotron">
     <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="insert " onclick="Button1_click"/>
        </div>
    
    </asp:Content> 
