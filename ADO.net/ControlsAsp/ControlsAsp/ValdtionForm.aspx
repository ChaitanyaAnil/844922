<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValdtionForm.aspx.cs" Inherits="ControlsAsp.ValdtionForm" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter text values" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="vg">Enter Name</asp:RequiredFieldValidator><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <br /><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter in mail format" ForeColor="Red" ControlToValidate="TextBox2" ValidationGroup="vg">Enter mail</asp:RegularExpressionValidator>
       <br /> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br /><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="password " ForeColor="Red" ControlToValidate="TextBox5" ValidationGroup="vg">Enterpasword</asp:RegularExpressionValidator>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
       <br /> <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="99" MinimumValue="18" ControlToValidate="TextBox3" ValidationGroup="vg">Enter Age</asp:RangeValidator>
  
   <br /> <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
      <br />  <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password must match" ForeColor="Red" ControlToCompare="TextBox5" ControlToValidate="TextBox4" ValueToCompare="vg">confirm passsword</asp:CompareValidator>
     <br />   <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
      <br />  <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" ForeColor="Red" ValidationGroup="vg" /><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>

</asp:Content>