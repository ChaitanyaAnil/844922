<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnterData.aspx.cs" Inherits="TraineeApp.EnterData" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server" >
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Tid"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="ID mudtnot exceed 4 numbers" ControlToValidate="TextBox1" MaximumValue="4" MinimumValue="1" ValidationGroup="vg" ForeColor="#FF3300" Type="Integer"></asp:RangeValidator>

        <br />
        <asp:Label ID="Label2" runat="server" Text="Tname"></asp:Label><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Trinee Name" ControlToValidate="TextBox2" ForeColor="#FF3300" ValidationGroup="vg"></asp:RequiredFieldValidator><br />
        <asp:Label ID="Label3" runat="server" Text="Tloc"></asp:Label><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Trianee Location" ForeColor="Red" ValidationGroup="vg" ControlToValidate="TextBox3"></asp:RequiredFieldValidator><br />
   
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Trainee Domain" ControlToValidate="TextBox4" ForeColor="#FF5050" ValidationGroup="vg"></asp:RequiredFieldValidator><br />
        <asp:Label ID="Label4" runat="server" Text="Tdomain"></asp:Label><br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label5" runat="server" Text="TstartDate"></asp:Label><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="enter trainee strat date" ControlToValidate="TextBox5" ForeColor="#FF3300" ValidationGroup="vg"></asp:RequiredFieldValidator><br />
           
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="insert" Height="36px" OnClick="Button1_Click" ForeColor="#FF5050" ValidationGroup="vg" /><br />
        
            
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" HeaderText="ERRORS" ValidationGroup="vg" /><br />

        </div>
    <div class="jumbotron">


    </div>
</asp:Content>
