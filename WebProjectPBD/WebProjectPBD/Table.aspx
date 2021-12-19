<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Table.aspx.cs" Inherits="WebProjectPBD.Table" %>
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
     <div class="row" >
         <div class="col">
            <img src="https://images.unsplash.com/photo-1551198581-aec5c1556d7c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" style="width: 50%;">
            <div class="card-body">
                <h5 class="card-title">Table</h5>
                <p class="card-text">Înregistrează următorul jocul de table</p>
                <p class="card-text">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="#FF5050" Text="Label" Visible="False"></asp:Label>
                </p>
                <p class="card-text">
                    <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Jucator 1"></asp:Label>
                </p>
                <p class="card-text">
                    <asp:Label ID="Label1" runat="server" Text="Nume"></asp:Label>
                    <asp:TextBox ID="Nume1_tb" runat="server"></asp:TextBox>
                </p>
                <p class="card-text">
                    <asp:Label ID="Label2" runat="server" Text="Data nasterii"></asp:Label>
                    <asp:TextBox ID="DataNasterii1_tb" TextMode="Date" runat="server"></asp:TextBox>
                </p>
                <p class="card-text">
                    <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Jucator 2"></asp:Label>
                </p>
                <p class="card-text">
                    <asp:Label ID="Label5" runat="server" Text="Nume"></asp:Label>
                    <asp:TextBox ID="Nume2_tb" runat="server"></asp:TextBox>
                </p>
                <p class="card-text">
                    <asp:Label ID="Label6" runat="server" Text="Data nasterii"></asp:Label>
                    <asp:TextBox ID="DataNasterii2_tb" TextMode="Date" runat="server"></asp:TextBox>
                </p>
                <p class="card-text">
                    <asp:Label ID="Label7" runat="server" Text="Numar total de runde"></asp:Label>
                    <asp:TextBox ID="NrRunde_tb" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"   
                                                    ControlToValidate="NrRunde_tb" ErrorMessage="Introduceti numar impar"   
                                                    ValidationExpression="^[0-9]*[13579]$"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                                ControlToValidate="NrRunde_tb" ErrorMessage="Nu ati ales numarul de runde."/>
                </p>
                <p class="card-text">
                    <asp:Button ID="IncepeJoc_btn" runat="server" Text="Incepe jocul"  class="btn btn-primary" OnClick="IncepeJoc_btn_Click" />
                </p>
            </div>
             </div>

        </div>
        </div>
</asp:Content>
