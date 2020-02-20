 <%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormDisplay.aspx.cs" Inherits="CRUDoperations.FormDisplay" %>

<asp:Content ID="myid" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>

</asp:Content>
