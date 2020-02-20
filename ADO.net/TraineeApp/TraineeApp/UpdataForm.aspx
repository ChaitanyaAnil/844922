<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdataForm.aspx.cs" Inherits="TraineeApp.UpdataForm" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="EnterId"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Enter name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
    </div>



</asp:Content>