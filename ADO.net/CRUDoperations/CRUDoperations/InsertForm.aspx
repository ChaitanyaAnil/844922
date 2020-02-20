<%@ Page Language="C#"  MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="InsertForm.aspx.cs" Inherits="CRUDoperations.InsertForm" %>
<asp:Content ID="myid" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label ID="Label1" runat="server" Text="Rlic"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Label ID="Label2" runat="server" Text=" RNAME"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<asp:Label ID="Label3" runat="server" Text="R loc"></asp:Label>
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<asp:Label ID="Label4" runat="server" Text="R type"></asp:Label>
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
<asp:Button ID="Button1" runat="server" Text="INSERT" OnClick="Button1_Click" />
    </asp:Content>