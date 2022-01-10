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
                 <asp:GridView ID="GridView1" class="table" runat="server">
                     </asp:GridView>
             </div>
    </div>
       <div class="container">
        <h2>Date jocuri
           </h2>
           <asp:GridView ID="GridView2" class="table" runat="server">
            </asp:GridView>
       
    </div>
    <div class="container">
        <h2>Optiuni</h2>
        <div class="container">
            <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="Sortare crescator" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" CssClass="btn btn-primary" Text="Afisare conditionata" OnClick="Button3_Click" />
            
        </div>
        <div class="container">
            <asp:Button ID="Button7" runat="server" CssClass="btn btn-primary" Text="Cele mai multe jocuri jucate" OnClick="Button7_Click" />
        </div>
        <div class="container">
                <asp:Button ID="Button6" runat="server" CssClass="btn btn-primary" Text="Cel mai bun jucator de sah" OnClick="Button6_Click" />
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </div>
        <div class="container">
            <asp:TextBox ID="NumeJucator_tb" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" CssClass="btn btn-danger" Text="Afisare numar jocuri pentru fiecare jucator" OnClick="Button4_Click" />
        </div>
        <div class="container">

            <asp:Label ID="Label1" runat="server" Text="Pentru a rula functia, introduceti un nume" ForeColor="#FF5050" Visible="False"></asp:Label>

        </div>
        <div class="container">
            <asp:Label ID="Label2" runat="server" Text="Cel mai bun jucator pe categoria de varsta"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="152px">
                <asp:ListItem>&lt;10</asp:ListItem>
                <asp:ListItem>10-18</asp:ListItem>
                <asp:ListItem>19-40</asp:ListItem>
                <asp:ListItem>41-50</asp:ListItem>
                <asp:ListItem>&gt;50</asp:ListItem>
                
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button5" runat="server" class="btn btn-danger" Text="Afisare" OnClick="Button5_Click" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
        </div>
       
    </div>
</asp:Content>
