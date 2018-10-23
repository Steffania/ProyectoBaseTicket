<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Nuevo.aspx.cs" Inherits="Tickets.Nuevo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxFormLayout runat="server" ID="formLayoutNuevo" CssClass="formLayout" Width="30%">
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="500" />
        <Items>
            <dx:LayoutGroup Caption="" ColCount="1" GroupBoxDecoration="None" UseDefaultPaddings="false" Paddings-PaddingTop="10">
                <Paddings PaddingTop="10px"></Paddings>
                <GroupBoxStyle>
                    <Caption Font-Bold="true" Font-Size="16" />
                </GroupBoxStyle>
                <Items>
                    <dx:LayoutItem Caption="Area">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="comboBoxArea" runat="server" DataSourceID="sqlArea" ValueField="AreaId" ValueType="System.Int32">
                                    <Columns>
                                        <dx:ListBoxColumn Caption="Id" FieldName="AreaId" Visible="false">
                                        </dx:ListBoxColumn>
                                        <dx:ListBoxColumn FieldName="Descripcion" Caption="**Selecionar**">
                                        </dx:ListBoxColumn>
                                    </Columns>
                                    <ValidationSettings SetFocusOnError="True" ErrorText="" Display="Dynamic" ErrorTextPosition="Bottom">
                                        <RequiredField IsRequired="True" ErrorText="Area es un campo requerido." />
                                    </ValidationSettings>
                                </dx:ASPxComboBox>
                                <asp:SqlDataSource ID="sqlArea" runat="server" ConnectionString="<%$ ConnectionStrings:CooperatorConnectionString %>" SelectCommand="SELECT * FROM [Area]"></asp:SqlDataSource>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Nombre" >
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox ID="TextBoxNombre" runat="server" Width="170px">
                                    <ValidationSettings SetFocusOnError="True" ErrorText="" Display="Dynamic" ErrorTextPosition="Bottom">
                                        <RequiredField IsRequired="True" ErrorText="Nombre es un campo requerido." />
                                    </ValidationSettings>
                                    <InvalidStyle BackColor="#DCE5EF" />
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Apellido" >
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox ID="TextBoxApellido" runat="server" Width="170px">
                                    <ValidationSettings SetFocusOnError="True" ErrorText="" Display="Dynamic" ErrorTextPosition="Bottom">
                                        <RequiredField IsRequired="True" ErrorText="Apellido es un campo requerido." />
                                    </ValidationSettings>
                                    <InvalidStyle BackColor="#DCE5EF" />
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Teléfono">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox ID="TextBoxTelefono" runat="server" Width="170px">
                                    <ValidationSettings SetFocusOnError="True" ErrorText="" Display="Dynamic" ErrorTextPosition="Bottom">
                                        <RequiredField IsRequired="True" ErrorText="Teléfono es un campo requerido." />
                                    </ValidationSettings>
                                    <InvalidStyle BackColor="#DCE5EF" />
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Email" >
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox ID="TextBoxEmail" runat="server" Width="170px">
                                    <ValidationSettings SetFocusOnError="True" ErrorText="" Display="Dynamic" ErrorTextPosition="Bottom">
                                        <RequiredField IsRequired="True" ErrorText="Email es un campo requerido." />
                                        <RegularExpression ErrorText="El Email es inválido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                    </ValidationSettings>
                                    <InvalidStyle BackColor="#DCE5EF" />
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Descripcion" >
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxMemo runat="server" ID="memoDescripcion" Rows="6"
                                    Text="">
                                    <ValidationSettings SetFocusOnError="True" ErrorText="" Display="Dynamic" ErrorTextPosition="Bottom">
                                        <RequiredField IsRequired="True" ErrorText="Descripcion es un campo requerido." />
                                    </ValidationSettings>
                                    <InvalidStyle BackColor="#DCE5EF" />
                                </dx:ASPxMemo>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" HorizontalAlign="Left" >
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxButton ID="btnReportar" runat="server" Text="Reportar" Width="100" OnClick="btnReportar_Click" CausesValidation="true">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
</asp:Content>
