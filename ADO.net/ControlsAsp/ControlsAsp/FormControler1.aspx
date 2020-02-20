<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormControler1.aspx.cs" Inherits="ControlsAsp.FormControler1" %>
<asp:Content ID="id122" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotron">
    <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
    <br />

    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Enter Dob"></asp:Label>
    <br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>male</asp:ListItem>
        <asp:ListItem>female</asp:ListItem>
       
    </asp:RadioButtonList>
    <br />
    <asp:Label ID="Label4" runat="server" Text="tick mark Hobbies:"></asp:Label>
    <br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        <asp:ListItem>Cricket</asp:ListItem>
        <asp:ListItem>Travelling</asp:ListItem>
        <asp:ListItem>Listening</asp:ListItem>
        <asp:ListItem>Reading</asp:ListItem>
    </asp:CheckBoxList>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Education"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>ssc</asp:ListItem>
        <asp:ListItem>hsc</asp:ListItem>
        <asp:ListItem>btech</asp:ListItem>
        <asp:ListItem>mtech</asp:ListItem>
    </asp:DropDownList>

    <br />
    <asp:Button ID="btn1" Text="SUBMIT" runat="server" OnClick="btn1_Click" />

    
</div>
    <div class="jumbotron">
        <asp:Label ID="Label6" runat="server" Text="Display" ForeColor="Red"></asp:Label>
    </div>


</asp:Content>