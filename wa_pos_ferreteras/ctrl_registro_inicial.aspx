<%@ Page Title="" Language="C#" MasterPageFile="~/master_pos.Master" AutoEventWireup="true" CodeBehind="ctrl_registro_inicial.aspx.cs" Inherits="wa_pos_ferreteras.ctrl_registro_inicial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="section">
                <div class="container">
                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-1">
                                <a href="ctrl_acceso.aspx">
                                    <img alt="" src="images/ico_exit.png" /></a>
                            </div>
                            <br />
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h3 class="text-center">Registro de administrador y empresa</h3>
                            </div>
                            <div class="col-md-4">
                                <asp:Image CssClass="center-block img-responsive" ID="Image1" runat="server" ImageUrl="~/images/teamwork/png/process.png" Width="128" Height="128" />
                            </div>
                            <div class="col-md-4">
                                <h5>
                                    <asp:Label CssClass="control-label" ID="lbl_business_name" runat="server" Text="*Empresa" Visible="True"></asp:Label></h5>
                                <asp:TextBox CssClass="form-control" ID="txt_business_name" runat="server" placeholder="Capturar nombre de empresa" Visible="True"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv_business_name" runat="server"
                                    ControlToValidate="txt_business_name"
                                    ErrorMessage="Campo Requerido"
                                    ForeColor="orange">
                                </asp:RequiredFieldValidator>
                                <h5>
                                    <asp:Label CssClass="control-label" ID="lbl_name_user" runat="server" Text="*Nombre(s)"></asp:Label></h5>
                                <asp:TextBox CssClass="form-control" ID="txt_name_user" runat="server" placeholder="Capturar Nombre(s)"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv_name_user" runat="server"
                                    ControlToValidate="txt_name_user"
                                    ErrorMessage="Campo Requerido"
                                    ForeColor="orange">
                                </asp:RequiredFieldValidator>
                                <h5>
                                    <asp:Label CssClass="control-label" ID="lbl_apater" runat="server" Text="*Apellido Paterno"></asp:Label></h5>
                                <asp:TextBox CssClass="form-control" ID="txt_apater" runat="server" placeholder="Capturar Apellido Paterno"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv_apater" runat="server"
                                    ControlToValidate="txt_apater"
                                    ErrorMessage="Campo Requerido"
                                    ForeColor="orange">
                                </asp:RequiredFieldValidator>
                                <h5>
                                    <asp:Label CssClass="control-label" ID="lbl_amater" runat="server" Text="*Apellido Materno"></asp:Label></h5>
                                <asp:TextBox CssClass="form-control" ID="txt_amater" runat="server" placeholder="Capturar Apellido Materno"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv_amater" runat="server"
                                    ControlToValidate="txt_amater"
                                    ErrorMessage="Campo Requerido"
                                    ForeColor="orange">
                                </asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-4">
                                <h5>
                                    <asp:Label CssClass="control-label" ID="lbl_code_user" runat="server" Text="*Usuario"></asp:Label></h5>
                                <asp:TextBox CssClass="form-control" ID="txt_code_user" runat="server" placeholder="Capturar Usuario"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv_email_im" runat="server"
                                    ControlToValidate="txt_code_user"
                                    ErrorMessage="Campo Requerido"
                                    ForeColor="orange">
                                </asp:RequiredFieldValidator>
                                <h5>
                                    <asp:Label CssClass="control-label" ID="lbl_password" runat="server" Text="*Contraseña"></asp:Label></h5>
                                <asp:TextBox CssClass="form-control" ID="txt_password" runat="server" placeholder="Capturar Contraseña" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv_password" runat="server"
                                    ControlToValidate="txt_password"
                                    ErrorMessage="Campo Requerido"
                                    ForeColor="orange">
                                </asp:RequiredFieldValidator>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-12 text-right">
                                    <asp:Button CssClass="btn" ID="cmd_save" runat="server" Text="Guardar" OnClick="cmd_save_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>
                            <h4 class="modal-title">
                                <asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="lblModalBody" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="modal-footer">
                            <button class="btn" data-dismiss="modal" aria-hidden="true" onclick="window.location.href='/ctrl_acceso.aspx'">Ok </button>
                        </div>
                    </div>
                </ContentTemplate>

            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
