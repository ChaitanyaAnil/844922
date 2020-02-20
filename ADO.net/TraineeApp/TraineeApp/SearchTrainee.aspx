<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchTrainee.aspx.cs" Inherits="TraineeApp.SearchTrainee" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Enter Id"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="enter id" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="vg">id is neccsary</asp:RequiredFieldValidator>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />


        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>


    </div>


</asp:Content>