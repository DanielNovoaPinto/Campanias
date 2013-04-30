<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Campania.aspx.cs" Inherits="serTI.Campania.Web.Campania.Campania" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Pagina Campania
            <asp:GridView ID="GridView1" runat="server" CellPadding="3" 
            GridLines="Vertical" Height="146px" Width="109px" BackColor="#546E96" 
            BorderColor="#465767" BorderStyle="None" BorderWidth="1px" 
            onrowcommand="GridView1_RowCommand" >
            <AlternatingRowStyle BackColor="Gainsboro" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Editar" />
            </Columns>
            <FooterStyle BackColor="#546E96" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#E4E4E4" ForeColor="Black" />
            <SelectedRowStyle BackColor="#506272" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </p>
</asp:Content>
