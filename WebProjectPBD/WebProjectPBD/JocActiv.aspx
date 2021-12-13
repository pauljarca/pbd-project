<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JocActiv.aspx.cs" Inherits="WebProjectPBD.JocActiv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <header class="d-flex justify-content-center py-3">
            <ul class="nav nav-pills">
                <li class="nav-item"><a href="#" class="nav-link active" aria-current="page">Overview</a></li>
                <li class="nav-item"><a href="Functions.aspx" class="nav-link">Functions</a></li>
            </ul>
        </header>
    </div>

        
        <div class="row justify-content-center">
        <div class="card" style="width: 18rem; margin: 10px;">
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="Label1" runat="server" Text="Scor Jucator 1"></asp:Label></h5>
                <p class="card-text"> <asp:Label ID="ScorJucator1_lb" runat="server" Text="0"></asp:Label></p>
               <asp:Button ID="Jucator1_btn" runat="server" Text="Jucator 1"  class="btn btn-primary" />
            </div>
        </div>
        
        <div class="card" style="width: 18rem; margin: 10px;">
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="Label2" runat="server" Text="Scor Jucator 2"></asp:Label></h5>
                <p class="card-text"><asp:Label ID="ScorJucator2_lb" runat="server" Text="0"></asp:Label></p>
                 <asp:Button ID="Jucator2_btn" runat="server" Text="Jucator2" class="btn btn-primary" />
            </div>
        </div>
    </div>

</asp:Content>
