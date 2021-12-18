<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Functions3.aspx.cs" Inherits="WebProjectPBD.Functions3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="container">
        <header class="d-flex justify-content-center py-3">
            <ul class="nav nav-pills">
                <li class="nav-item"><a href="Homepage.aspx" class="nav-link">Overview</a></li>
                <li class="nav-item"><a href="Functions3.aspx" class="nav-link active" aria-current="page">Functions</a></li>
            </ul>
        </header> 
             <div class="container justify-content-center">
                  <h2>Date jucători
                   </h2>
                 <asp:GridView ID="GridView1" runat="server">
                     </asp:GridView>
             </div>
    </div>
       <div class="container">
        <h2>Date jocuri
           </h2>
           <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
       
    </div>
    <div class="container">
        <h2>Optiuni</h2>
        <div class="row">
            <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="Sortare crescator" OnClick="Button2_Click" />
             <asp:Button ID="Button3" runat="server" CssClass="btn btn-primary" Text="Afisare conditionata" OnClick="Button3_Click" />
        </div>
    </div>
</asp:Content>
