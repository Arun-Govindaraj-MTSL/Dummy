<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dummy._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Button ID="showRecord" runat="server" Text="Show Record" OnClick="showRecord_Click"/>
        <asp:GridView ID="gridRecord" runat="server"></asp:GridView>

</asp:Content>
