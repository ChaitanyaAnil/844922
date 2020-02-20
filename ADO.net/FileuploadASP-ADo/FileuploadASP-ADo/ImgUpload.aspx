<%@ Page Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="ImgUpload.aspx.cs" Inherits="FileuploadASP_ADo.Resources.WebFormFileUpload" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_click" />
        <br />
        <br />

        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <asp:Image ID="Image1" ImageUrl='<%# Eval("Name","~/Resources/{0}") %>'
                    Width="350px" Height="350px" runat="server" />
                <br />
                <%# Eval("Name") %>
            </ItemTemplate>


        </asp:DataList>

        


    </div>



</asp:Content>