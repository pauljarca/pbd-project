<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JocActiv.aspx.cs" Inherits="WebProjectPBD.JocActiv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <header class="d-flex justify-content-center py-3">
            <ul class="nav nav-pills">
                <li class="nav-item"><a href="Homepage.aspx" class="nav-link active" aria-current="page">Overview</a></li>
                <li class="nav-item"><a href="Functions3.aspx" class="nav-link">Functions</a></li>
            </ul>
        </header>
    </div>
   

        <div class="container">
            <h1 style="text-align: center">
                <asp:Label ID="Lbl_round" runat="server" Text="Label"></asp:Label>
            </h1>
            <p style="text-align: center">
                <asp:Label ID="Lbl_remaining_rounds" runat="server" Text="Label"></asp:Label>
            </p></div>

        <div class="row justify-content-center">
        <div class="card" style="width: 18rem; margin: 10px;">
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="Label1" runat="server" Text="Scor Jucator 1"></asp:Label></h5>
                <p class="card-text"> 
                    <asp:Label ID="ScorJucator1_lb" runat="server" Text="0"></asp:Label>
                </p>
               <asp:Button ID="Jucator1_btn" runat="server" Text="Jucator 1"  class="btn btn-primary" OnClick="Jucator1_btn_Click" />
            </div>
        </div>
        
    
       
        <div class="card" style="width: 18rem; margin: 10px;">
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="Label2" runat="server" Text="Scor Jucator 2"></asp:Label></h5>
                <p class="card-text">
                    <asp:Label ID="ScorJucator2_lb" runat="server" Text="0"></asp:Label>
                </p>
                 <asp:Button ID="Jucator2_btn" runat="server" Text="Jucator2" class="btn btn-primary" OnClick="Jucator2_btn_Click" />
            </div>
        </div>
    </div>
        <div class="container">

            <asp:Label ID="winner_lbl" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" class="btn btn-secondary" Text="Inca un joc" Visible="False" OnClick="Button1_Click"/>

        </div>


</asp:Content>
