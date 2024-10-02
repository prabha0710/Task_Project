<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Task._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label Text="Enter a Count Of Adult : " runat="server" />
        <asp:TextBox ID="AdultCount" runat="server" />
    </div>
    <div>
        <asp:Label Text="Enter a Count Of Children : " runat="server" />
        <asp:TextBox runat="server" ID="ChildrenCount" />
    </div>

    <div>
        <asp:Button ID="Button" class="buttonsave" runat="server" Text="View Room" OnClick="BookRoom" />
    </div>
    <div>
        <asp:Label ID="Message" runat="server" />
    </div>


</asp:Content>