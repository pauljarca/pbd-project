<%@ Page Title="Functions" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Functions.aspx.cs" Inherits="WebProjectPBD.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <header class="d-flex justify-content-center py-3">
            <ul class="nav nav-pills">
                <li class="nav-item"><a href="Homepage.aspx" class="nav-link">Overview</a></li>
                <li class="nav-item"><a href="Functions.aspx" class="nav-link active" aria-current="page">Functions</a></li>
            </ul>
        </header>
    </div>
    <div class="container justify-content-center">
        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Afisare jocuri" />
        <asp:Button ID="Button2" runat="server" Text="Afisare jucatori" class="btn btn-primary" />
    </div>
    
</asp:Content>
