<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="WebProjectPBD.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Prima pagină</title>
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
            <img src="https://images.unsplash.com/photo-1551198581-aec5c1556d7c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title">Table</h5>
                <p class="card-text">Înregistreză următorul joc de table.</p>
                <a href="#" class="btn btn-primary">Către table</a>
            </div>
        </div>
        
        <div class="card" style="width: 18rem; margin: 10px;">
            <img src="https://images.unsplash.com/photo-1602968407815-5963b28c66af?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title">Șah</h5>
                <p class="card-text">Înregistrează următorul jocul de șah</p>
                <a href="#" class="btn btn-primary">Către șah</a>
            </div>
        </div>
    </div>
</asp:Content>
