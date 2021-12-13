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
        <h2>Date jucători</h2>
        <asp:GridView ID="GridView1" runat="server" class="table table-dark table-striped" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nume" HeaderText="Nume" SortExpression="Nume" />
                <asp:BoundField DataField="Data_nasterii" HeaderText="Data_nasterii" SortExpression="Data_nasterii" />
                <asp:BoundField DataField="Data_inregistrarii" HeaderText="Data_inregistrarii" SortExpression="Data_inregistrarii" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbConnectionString1 %>" DeleteCommand="DELETE FROM [Jucatori] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Jucatori] ([Id], [Nume], [Data_nasterii], [Data_inregistrarii]) VALUES (@Id, @Nume, @Data_nasterii, @Data_inregistrarii)" ProviderName="<%$ ConnectionStrings:dbConnectionString1.ProviderName %>" SelectCommand="SELECT [Id], [Nume], [Data_nasterii], [Data_inregistrarii] FROM [Jucatori]" UpdateCommand="UPDATE [Jucatori] SET [Nume] = @Nume, [Data_nasterii] = @Data_nasterii, [Data_inregistrarii] = @Data_inregistrarii WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="Nume" Type="String" />
                <asp:Parameter DbType="Date" Name="Data_nasterii" />
                <asp:Parameter DbType="Date" Name="Data_inregistrarii" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nume" Type="String" />
                <asp:Parameter DbType="Date" Name="Data_nasterii" />
                <asp:Parameter DbType="Date" Name="Data_inregistrarii" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    <div class="container">
        <h2>Date jocuri</h2>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_joc" class="table table-dark table-striped" DataSourceID="SqlDataSource2" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="Id_joc" HeaderText="Id_joc" ReadOnly="True" SortExpression="Id_joc" />
                <asp:BoundField DataField="Tip_joc" HeaderText="Tip_joc" SortExpression="Tip_joc" />
                <asp:BoundField DataField="Jucator1" HeaderText="Jucator1" SortExpression="Jucator1" />
                <asp:BoundField DataField="Jucator2" HeaderText="Jucator2" SortExpression="Jucator2" />
                <asp:BoundField DataField="Partida_curenta" HeaderText="Partida_curenta" SortExpression="Partida_curenta" />
                <asp:BoundField DataField="Partida_totala" HeaderText="Partida_totala" SortExpression="Partida_totala" />
                <asp:BoundField DataField="Data_inceput_joc" HeaderText="Data_inceput_joc" SortExpression="Data_inceput_joc" />
                <asp:BoundField DataField="Data_sfarsit_joc" HeaderText="Data_sfarsit_joc" SortExpression="Data_sfarsit_joc" />
                <asp:BoundField DataField="Scor_jucator1" HeaderText="Scor_jucator1" SortExpression="Scor_jucator1" />
                <asp:BoundField DataField="Scor_jucator2" HeaderText="Scor_jucator2" SortExpression="Scor_jucator2" />
                <asp:BoundField DataField="Id_invingator" HeaderText="Id_invingator" SortExpression="Id_invingator" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbConnectionString1 %>" DeleteCommand="DELETE FROM [Joc] WHERE [Id_joc] = @Id_joc" InsertCommand="INSERT INTO [Joc] ([Tip_joc], [Jucator1], [Jucator2], [Partida_curenta], [Partida_totala], [Data_inceput_joc], [Data_sfarsit_joc], [Scor_jucator1], [Scor_jucator2], [Id_invingator]) VALUES (@Tip_joc, @Jucator1, @Jucator2, @Partida_curenta, @Partida_totala, @Data_inceput_joc, @Data_sfarsit_joc, @Scor_jucator1, @Scor_jucator2, @Id_invingator)" ProviderName="<%$ ConnectionStrings:dbConnectionString1.ProviderName %>" SelectCommand="SELECT [Id_joc], [Tip_joc], [Jucator1], [Jucator2], [Partida_curenta], [Partida_totala], [Data_inceput_joc], [Data_sfarsit_joc], [Scor_jucator1], [Scor_jucator2], [Id_invingator] FROM [Joc]" UpdateCommand="UPDATE [Joc] SET [Tip_joc] = @Tip_joc, [Jucator1] = @Jucator1, [Jucator2] = @Jucator2, [Partida_curenta] = @Partida_curenta, [Partida_totala] = @Partida_totala, [Data_inceput_joc] = @Data_inceput_joc, [Data_sfarsit_joc] = @Data_sfarsit_joc, [Scor_jucator1] = @Scor_jucator1, [Scor_jucator2] = @Scor_jucator2, [Id_invingator] = @Id_invingator WHERE [Id_joc] = @Id_joc">
            <DeleteParameters>
                <asp:Parameter Name="Id_joc" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Tip_joc" Type="Int32" />
                <asp:Parameter Name="Jucator1" Type="String" />
                <asp:Parameter Name="Jucator2" Type="String" />
                <asp:Parameter Name="Partida_curenta" Type="Int32" />
                <asp:Parameter Name="Partida_totala" Type="Int32" />
                <asp:Parameter DbType="Date" Name="Data_inceput_joc" />
                <asp:Parameter DbType="Date" Name="Data_sfarsit_joc" />
                <asp:Parameter Name="Scor_jucator1" Type="Int32" />
                <asp:Parameter Name="Scor_jucator2" Type="Int32" />
                <asp:Parameter Name="Id_invingator" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Tip_joc" Type="Int32" />
                <asp:Parameter Name="Jucator1" Type="String" />
                <asp:Parameter Name="Jucator2" Type="String" />
                <asp:Parameter Name="Partida_curenta" Type="Int32" />
                <asp:Parameter Name="Partida_totala" Type="Int32" />
                <asp:Parameter DbType="Date" Name="Data_inceput_joc" />
                <asp:Parameter DbType="Date" Name="Data_sfarsit_joc" />
                <asp:Parameter Name="Scor_jucator1" Type="Int32" />
                <asp:Parameter Name="Scor_jucator2" Type="Int32" />
                <asp:Parameter Name="Id_invingator" Type="Int32" />
                <asp:Parameter Name="Id_joc" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    <div class="container">
        <h2>Optiuni</h2>
        <div class="row">
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Afisare conditionata" />
            <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="Sortare crescator" />
        </div>
        <div class="container">
            <asp:Table ID="Table1" runat="server"></asp:Table>
        </div>
    </div>
</asp:Content>
