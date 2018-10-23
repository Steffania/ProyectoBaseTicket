<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Tickets.aspx.cs" Inherits="Tickets.Tickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Listado de Errores reportados</h2>
    <asp:SqlDataSource ID="sqlTickets" runat="server" ConnectionString="<%$ ConnectionStrings:BaseTicketConnectionString %>" SelectCommand="SELECT * FROM [vw_Tickets]"></asp:SqlDataSource>

    <dx:ASPxGridView ID="GridViewTickets" runat="server" AutoGenerateColumns="False" DataSourceID="sqlTickets" KeyFieldName="TicketId" Width="80%">
        <Columns>
            <%--  <dx:GridViewDataTextColumn FieldName="TicketId" VisibleIndex="0" ReadOnly="True">
            </dx:GridViewDataTextColumn>--%>
            <dx:GridViewDataTextColumn Caption="Nº Ticket" FieldName="Numero">
                <HeaderStyle BackColor="#638AB7" Font-Bold="True" ForeColor="White" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn Caption="Fecha" FieldName="FechaTicket" Width="10%">
                <HeaderStyle BackColor="#638AB7" Font-Bold="True" ForeColor="White" />
                <PropertiesDateEdit DisplayFormatString="d/M/yyyy HH:mm:ss">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="Area">
                <HeaderStyle BackColor="#638AB7" Font-Bold="True" ForeColor="White" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Nombre">
                <HeaderStyle BackColor="#638AB7" Font-Bold="True" ForeColor="White" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Apellido">
                <HeaderStyle BackColor="#638AB7" Font-Bold="True" ForeColor="White" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Telefono">
                <HeaderStyle BackColor="#638AB7" Font-Bold="True" ForeColor="White" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Email">
                <HeaderStyle BackColor="#638AB7" Font-Bold="True" ForeColor="White" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Descripcion">
                <HeaderStyle BackColor="#638AB7" Font-Bold="True" ForeColor="White" />
            </dx:GridViewDataTextColumn>
        </Columns>
    </dx:ASPxGridView>
</asp:Content>
