﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master_pos.Master" AutoEventWireup="true" CodeBehind="ctrl_acceso.aspx.cs" Inherits="wa_pos_ferreteras.ctrl_acceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h1 class="text-center">Control de Acceso</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Image CssClass="center-block img-responsive img-rounded animated bounceInLeft" ID="Image1" runat="server" ImageUrl="~/images/teamwork/png/networking.png" Width="128" />
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4 center-block">
                </div>
                 <div class="col-md-4">
                    <div class="form-group">
                        <h5>
                            <asp:Label CssClass="control-label" ID="lbl_code_user" runat="server" Text="*Usuario"></asp:Label></h5>
                        <asp:TextBox CssClass="form-control" ID="txt_code_user" runat="server" TabIndex="1" placeholder="Capturar Usuario"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_email_im" runat="server"
                            ControlToValidate="txt_code_user"
                            ErrorMessage="Campo Requerido"
                            ForeColor="orange">
                        </asp:RequiredFieldValidator>
                        <h5>
                            <asp:Label CssClass="control-label" ID="lbl_password" runat="server" Text="*Contraseña"></asp:Label></h5>
                        <asp:TextBox CssClass="form-control" ID="txt_password" runat="server" TabIndex="3" placeholder="Capturar Contraseña" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_password" runat="server"
                            ControlToValidate="txt_password"
                            ErrorMessage="Campo Requerido"
                            ForeColor="orange">
                        </asp:RequiredFieldValidator>
                    </div>
                    <div class="row">
                        <div class="col-md-6 text-center">
                            <a href="ctrl_registro_inicial.aspx">
                                <h6>
                                    <asp:Label CssClass="control-label" ID="lbl_registro" runat="server" Text="Registrar" Visible="false"></asp:Label></h6>
                            </a>
                        </div>
                        <div class="col-md-6 text-right">
                            <asp:Button CssClass="btn" ID="cmd_login" runat="server" Text="Entrar" TabIndex="4" OnClick="cmd_login_Click" />
                        </div>
                    </div>
                <div class="col-md-4 center-block">
                </div>
                
            </div>
            
        </div>
    </div>
    <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                            <h4 class="modal-title">
                                <asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="lblModalBody" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="modal-footer">
                            <button class="btn" data-dismiss="modal" aria-hidden="true">Ok</button>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
