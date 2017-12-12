<%@ Page Title="" Language="C#" MasterPageFile="~/master_pos.Master" AutoEventWireup="true" CodeBehind="ctrl_panel.aspx.cs" Inherits="wa_pos_ferreteras.ctrl_panel" %>

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
                                <a href="ctrl_menu.aspx">
                                    <img alt="" src="images/ico_back.png" /></a>
                            </div>
                            <div class="col-md-1">
                                <a href="ctrl_acceso.aspx">
                                    <img alt="" src="images/ico_exit.png" /></a>
                            </div>
                            <br />
                            <div class="col-md-10">
                                <p class="text-right">
                                    <asp:Label ID="lbl_bienvenida" runat="server" Text="Bienvenid@: "></asp:Label>
                                    <asp:LinkButton ID="lkb_fusuario" runat="server" OnClick="lkb_fuser_Click" Text=""></asp:LinkButton>
                                    <i class="fa fa-pencil" aria-hidden="true"></i>
                                    <asp:Label ID="lbl_idfusuario" runat="server" Text="" Visible="false"></asp:Label>
                                    <br />
                                    <asp:Label ID="lbl_perfil" runat="server" Text="Perfil: "></asp:Label>
                                    <asp:Label ID="lbl_perfilusuario" runat="server" Text=""></asp:Label>
                                    <br />
                                    <asp:Label ID="lbl_empresa" runat="server" Text="Empresa: "></asp:Label>
                                    <asp:LinkButton ID="lkb_razonsocial" runat="server" OnClick="lkb_razonsocial_Click" Text=""></asp:LinkButton>
                                    <i class="fa fa-pencil" aria-hidden="true"></i>
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-2">
                                <div class="sidebar-nav">
                                    <div class="navbar navbar-default" role="navigation">
                                        <div class="navbar-header">
                                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-navbar-collapse">
                                                <span class="sr-only">Toggle navigation</span>
                                                <span class="icon-bar"></span>
                                                <span class="icon-bar"></span>
                                                <span class="icon-bar"></span>
                                            </button>
                                            <span class="visible-xs navbar-brand">Sidebar menu</span>
                                        </div>
                                        <div class="navbar-collapse collapse sidebar-navbar-collapse">
                                            <ul class="nav navbar-nav text-left">
                                                <li>
                                                    <h4><i class="fa fa-tachometer" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_panel" runat="server" OnClick="lkb_panel_Click" Text=" Panel"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-bar-chart" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_reportes" runat="server" OnClick="lkb_reportes_Click" Text=" Reportes"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-shopping-cart" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="Ventas" runat="server" OnClick="Ventas_Click" Text=" Ventas"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-credit-card" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_gastos" runat="server" OnClick="lkb_gastos_Click" Text=" Gastos"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-truck" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_recepcion" runat="server" OnClick="lkb_recepcion_Click" Text=" Recepción"></asp:LinkButton></h4>
                                                </li>

                                                <li>
                                                    <h4><i class="fa fa-road" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_entregas" runat="server" OnClick="lkb_entregas_Click" Text=" Entregas"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-cube" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_inventario" runat="server" OnClick="lkb_inventario_Click" Text=" Inventario"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-cubes" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_kits" runat="server" OnClick="lkb_kits_Click" Text=" Kits"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-money" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_rprecios" runat="server" OnClick="lkb_rprecios_Click" Text=" Regla de precios"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-shopping-basket" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_clientes" runat="server" OnClick="lkb_clientes_Click" Text=" Clientes"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-product-hunt" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_proveedores" runat="server" OnClick="lkb_proveedores_Click" Text=" Proveedores"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-building" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_contribuyentes" runat="server" OnClick="lkb_contribuyentes_Click" Text=" Contribuyentes"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-users" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_usarios" runat="server" OnClick="lkb_usarios_Click" Text=" Usuarios"></asp:LinkButton></h4>
                                                </li>
                                                <li>
                                                    <h4><i class="fa fa-gear" aria-hidden="true"></i>
                                                        <asp:LinkButton ID="lkb_config" runat="server" OnClick="lkb_config_Click" Text=" Configuración"></asp:LinkButton></h4>
                                                </li>
                                            </ul>
                                        </div>
                                        <!--/.nav-collapse -->
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-10">
                                <div class="panel panel-default" id="pnl_usuarios" runat="server" visible="false">
                                    <div class="panel-heading">
                                        <h3>Control de Usuarios</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="col-md-3 text-center" id="div_administrator" runat="server">
                                            <asp:CheckBox CssClass="checkbox-inline" ID="chkb_administrator" runat="server" Text="Administrador" AutoPostBack="True" OnCheckedChanged="chkb_administrator_CheckedChanged" />
                                            <asp:Image CssClass="img-responsive" ID="img_administrator" runat="server" ImageUrl="~/images/teamwork/png/businessman.png" Width="32" Height="32" />
                                        </div>
                                        <div class="col-md-3 text-center" id="div_supervisor" runat="server">
                                            <asp:CheckBox CssClass="checkbox-inline" ID="chkb_supervisor" runat="server" Text="Supervisor" AutoPostBack="True" OnCheckedChanged="chkb_supervisor_CheckedChanged" />
                                            <asp:Image CssClass="img-responsive" ID="img_supervisor" runat="server" ImageUrl="~/images/teamwork/png/businesswoman.png" Width="32" Height="32" />
                                        </div>
                                        <div class="col-md-3 text-center" id="div_ejecutivo" runat="server">
                                            <asp:CheckBox CssClass="checkbox-inline" ID="chkb_ejecutivo" runat="server" Text="Ejecutivo" AutoPostBack="True" OnCheckedChanged="chkb_ejecutivo_CheckedChanged" />
                                            <asp:Image CssClass="img-responsive" ID="img_ejecutivo" runat="server" ImageUrl="~/images/teamwork/png/businessmen.png" Width="32" Height="32" />
                                        </div>
                                        <div class="col-md-3 text-center" id="div_vendedor" runat="server">
                                            <asp:CheckBox CssClass="checkbox-inline" ID="chkb_vendedor" runat="server" Text="Vendedor" AutoPostBack="True" OnCheckedChanged="chkb_vendedor_CheckedChanged" />
                                            <asp:Image CssClass="img-responsive" ID="img_vendedor" runat="server" ImageUrl="~/images/teamwork/png/teamwork-1.png" Width="32" Height="32" />
                                        </div>
                                        <br />
                                        <div class="col-md-12 text-right">
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_agrea_usuario" runat="server" Text="Agregar" AutoPostBack="True" OnCheckedChanged="rb_agrea_usuario_CheckedChanged" />
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_edita_usuario" runat="server" Text="Editar" AutoPostBack="True" OnCheckedChanged="rb_edita_usuario_CheckedChanged" />
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_elimina_usuario" runat="server" Text="Eliminar" AutoPostBack="True" OnCheckedChanged="rb_elimina_usuario_CheckedChanged" />
                                        </div>
                                        <div class="col-md-offset-3 col-md-6">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_buscar" runat="server" placeholder="Buscar" Visible="false"></asp:TextBox>
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="cmd_busca_usuario" runat="server" Text="Ir" Visible="false" OnClick="cmd_busca_usuario_Click" />
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <asp:GridView CssClass="table" ID="gv_usuarios" runat="server" AutoGenerateColumns="False" AllowPaging="true" OnPageIndexChanging="gv_usuarios_PageIndexChanging">
                                                <Columns>
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="chk_usuario" runat="server" onclick="CheckOne(this)" OnCheckedChanged="chk_usuario_CheckedChanged" AutoPostBack="true" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="codigo_usuario" HeaderText="ID de Usuario" SortExpression="codigo_usuario" Visible="true" />
                                                    <asp:BoundField DataField="desc_estatus" HeaderText="Estatus" SortExpression="desc_estatus" />
                                                    <asp:BoundField DataField="nombres" HeaderText="Nombre de Usuario" SortExpression="nombres" />
                                                    <asp:BoundField DataField="a_paterno" HeaderText="Apellido Paterno" SortExpression="a_paterno" />
                                                    <asp:BoundField DataField="a_materno" HeaderText="Apellido Materno" SortExpression="a_materno" />
                                                </Columns>
                                            </asp:GridView>
                                            <br />
                                        </div>
                                        <div class="col-md-2">

                                            <asp:Image CssClass="center-block img-responsive" ID="Image1" runat="server" ImageUrl="~/images/teamwork/png/curriculum.png" Width="128" Height="128" />
                                        </div>
                                        <div class="col-md-5">
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_name_user" runat="server" Text="*Nombre(s)"></asp:Label></h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_name_user" runat="server" placeholder="Capturar Nombre(s)"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_name_user" runat="server" Visible="false"
                                                ControlToValidate="txt_name_user"
                                                ErrorMessage="Campo Requerido"
                                                ForeColor="orange">
                                            </asp:RequiredFieldValidator>
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_apater" runat="server" Text="*Apellido Paterno"></asp:Label></h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_apater" runat="server" placeholder="Capturar Apellido Paterno"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_apater" runat="server" Visible="false"
                                                ControlToValidate="txt_apater"
                                                ErrorMessage="Campo Requerido"
                                                ForeColor="orange">
                                            </asp:RequiredFieldValidator>
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_amater" runat="server" Text="*Apellido Materno"></asp:Label></h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_amater" runat="server" placeholder="Capturar Apellido Materno"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_amater" runat="server" Visible="false"
                                                ControlToValidate="txt_amater"
                                                ErrorMessage="Campo Requerido"
                                                ForeColor="orange">
                                            </asp:RequiredFieldValidator>
                                        </div>
                                        <div class="col-md-5">
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_code_user" runat="server" Text="*Usuario"></asp:Label></h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_code_user" runat="server" placeholder="Capturar Usuario"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_email_im" runat="server" Visible="false"
                                                ControlToValidate="txt_code_user"
                                                ErrorMessage="Campo Requerido"
                                                ForeColor="orange">
                                            </asp:RequiredFieldValidator>
                                            <h5>
                                                <asp:Label CssClass="control-label" ID="lbl_password" runat="server" Text="*Contraseña"></asp:Label></h5>
                                            <asp:TextBox CssClass="form-control" ID="txt_password" runat="server" placeholder="Capturar Contraseña" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfv_password" runat="server" Visible="false"
                                                ControlToValidate="txt_password"
                                                ErrorMessage="Campo Requerido"
                                                ForeColor="orange">
                                            </asp:RequiredFieldValidator>
                                        </div>
                                        <div class="col-md-12 text-right">
                                            <asp:Button CssClass="btn" ID="cmd_guarda_usuario" runat="server" Text="Guardar" OnClick="cmd_guarda_usuario_Click" />
                                        </div>
                                    </div>
                                    <div class="panel-footer"></div>
                                </div>
                                <div class="panel panel-default" id="pnl_empresa" runat="server" visible="false">
                                    <div class="panel-heading">
                                        <h3>Control de Empresa</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="col-md-12 text-right">
                                            <asp:CheckBox CssClass="checkbox-inline" ID="chkb_editar_empresa" runat="server" AutoPostBack="true" Text="Editar" OnCheckedChanged="chkb_editar_empresa_CheckedChanged" />
                                        </div>
                                        <div class="row" id="div_empresa" runat="server" visible="true">
                                            <div class="col-md-2">
                                                <asp:Image CssClass="center-block img-responsive" ID="img_empresa" runat="server" ImageUrl="~/images/teamwork/png/process.png" Width="128" Height="128" />
                                            </div>
                                            <div class="col-md-6">
                                                <asp:TextBox CssClass="form-control" ID="txt_business_name" runat="server" placeholder="Capturar nombre de Empresa" Visible="True"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_business_name" runat="server" Visible="false"
                                                    ControlToValidate="txt_business_name"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_phone" runat="server" placeholder="Capturar Teléfono"></asp:TextBox>
                                                <ajaxToolkit:MaskedEditExtender ID="txt_phone_MaskedEditExtender" runat="server" TargetControlID="txt_phone" Mask="(52) 99.99.99.99.99.99 ext 99999" />
                                                <asp:RequiredFieldValidator ID="rfv_phone" runat="server" Visible="false"
                                                    ControlToValidate="txt_phone"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_email" runat="server" placeholder="Capturar Email"></asp:TextBox>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_street" runat="server" placeholder="Capturar Calle"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_street" runat="server" Visible="false"
                                                    ControlToValidate="txt_street"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_cp" runat="server" placeholder="Capturar Código Postal" MaxLength="6"></asp:TextBox>
                                                    <ajaxToolkit:MaskedEditExtender ID="txt_cp_MaskedEditExtender" runat="server" TargetControlID="txt_cp" Mask="99999" />
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="cmd_vcp" runat="server" Text="validar" OnClick="cmd_vcp_Click" />
                                                    </span>
                                                </div>
                                                <asp:RequiredFieldValidator ID="rfv_cp" runat="server" Visible="false"
                                                    ControlToValidate="txt_cp"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:DropDownList CssClass="form-control" ID="ddl_colony" runat="server" ToolTip="Seleccionar colonia"></asp:DropDownList>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_municipality" runat="server" placeholder="Capturar Municipio" Enabled="false"></asp:TextBox>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_state" runat="server" placeholder="Capturar Estado" Enabled="false"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-md-12 text-right">
                                                <asp:Button CssClass="btn" ID="cmd_guarda_empresa" runat="server" Text="Guardar" OnClick="cmd_guarda_empresa_Click" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel-footer"></div>
                                </div>
                                <div class="panel panel-default" id="pnl_contribuyentes" runat="server" visible="false">
                                    <div class="panel-heading">
                                        <h3>Control de Contribuyentes</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="col-md-12 text-right">
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_agregar_contribuyentes" runat="server" Text="Agregar" AutoPostBack="True" OnCheckedChanged="rb_agregar_contribuyentes_CheckedChanged" />
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_editar_contribuyentes" runat="server" Text="Editar" AutoPostBack="True" OnCheckedChanged="rb_editar_contribuyentes_CheckedChanged" />
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_eliminar_contribuyentes" runat="server" Text="Eliminar" AutoPostBack="True" OnCheckedChanged="rb_eliminar_contribuyentes_CheckedChanged" />
                                        </div>
                                        <div class="col-md-offset-3 col-md-6">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_buscar_contribuyentes" runat="server" placeholder="Buscar" Visible="false"></asp:TextBox>
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="cmd_buscar_contribuyentes" runat="server" Text="Ir" Visible="false" OnClick="cmd_buscar_contribuyentes_Click" />
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <asp:GridView CssClass="table" ID="gv_contribuyentes" runat="server" AutoGenerateColumns="False" AllowPaging="true" OnPageIndexChanging="gv_contribuyentes_PageIndexChanging">
                                                <Columns>
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="chk_contribuyentes" runat="server" onclick="CheckOne(this)" OnCheckedChanged="chk_contribuyentes_CheckedChanged" AutoPostBack="true" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="rfc" HeaderText="RFC" SortExpression="rfc" Visible="true" />
                                                    <asp:BoundField DataField="desc_tipo_rfc" HeaderText="Tipo RFC" SortExpression="desc_tipo_rfc" />
                                                    <asp:BoundField DataField="razon_social" HeaderText="Razón Social" SortExpression="razon_social" />
                                                    <asp:BoundField DataField="fecha_registro" HeaderText="Fecha de Registro" SortExpression="fecha_registro" DataFormatString="{0:dd/MM/yyyy}" />
                                                </Columns>
                                            </asp:GridView>
                                            <br />
                                        </div>

                                        <div class="row" id="div2" runat="server" visible="true">
                                            <div class="col-md-2">
                                                <asp:Image CssClass="center-block img-responsive" ID="img_contribuyentes" runat="server" ImageUrl="~/images/teamwork/png/transfer.png" Width="128" Height="128" />
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <asp:DropDownList CssClass="form-control" ID="ddl_tiporfc_contribuyentes" runat="server" ToolTip="Seleccionar tipo RFC"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfv_tiporfc_contribuyentes" runat="server" Visible="false"
                                                        ErrorMessage="Campo Requerido"
                                                        ControlToValidate="ddl_tiporfc_contribuyentes" InitialValue="0"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_rfc_contribuyentes" runat="server" placeholder="RFC"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfv_rfc_contribuyentes" runat="server" Visible="false"
                                                        ControlToValidate="txt_rfc_contribuyentes"
                                                        ErrorMessage="Campo Requerido"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_rs_contribuyentes" runat="server" placeholder="Capturar Razón Social" Visible="True"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfv_rs_contribuyentes" runat="server" Visible="false"
                                                        ControlToValidate="txt_rs_contribuyentes"
                                                        ErrorMessage="Campo Requerido"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_telefono_contribuyentes" runat="server" placeholder="Capturar Teléfono"></asp:TextBox>
                                                    <ajaxToolkit:MaskedEditExtender ID="me_telefono_contribuyentes" runat="server" TargetControlID="txt_telefono_contribuyentes" Mask="(52) 99.99.99.99.99.99 ext 99999" />
                                                    <asp:RequiredFieldValidator ID="rfv_telefono_contribuyentes" runat="server" Visible="false"
                                                        ControlToValidate="txt_telefono_contribuyentes"
                                                        ErrorMessage="Campo Requerido"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_contribuyentes" runat="server" placeholder="Capturar Email"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:TextBox CssClass="form-control" ID="txt_calle_contribuyentes" runat="server" placeholder="Capturar Calle"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_calle_contribuyentes" runat="server" Visible="false"
                                                    ControlToValidate="txt_calle_contribuyentes"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_cp_contribuyentes" runat="server" placeholder="Capturar Código Postal" MaxLength="6"></asp:TextBox>
                                                    <ajaxToolkit:MaskedEditExtender ID="me_cp_contribuyentes" runat="server" TargetControlID="txt_cp_contribuyentes" Mask="99999" />
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="cmd_vcp_contribuyentes" runat="server" Text="validar" OnClick="cmd_vcp_contribuyentes_Click" />
                                                    </span>
                                                </div>
                                                <asp:RequiredFieldValidator ID="rfv_vcp_contribuyentes" runat="server" Visible="false"
                                                    ControlToValidate="txt_cp_contribuyentes"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:DropDownList CssClass="form-control" ID="ddl_colonia_contribuyentes" runat="server" ToolTip="Seleccionar colonia"></asp:DropDownList>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_municipio_contribuyentes" runat="server" placeholder="Capturar Municipio" Enabled="false"></asp:TextBox>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_estado_contribuyentes" runat="server" placeholder="Capturar Estado" Enabled="false"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-md-12 text-right">
                                                <asp:Button CssClass="btn" ID="cmd_guarda_contribuyentes" runat="server" Text="Guardar" OnClick="cmd_guarda_contribuyentes_Click" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel-footer"></div>
                                </div>
                                <div class="panel panel-default" id="pnl_proveedores" runat="server" visible="false">
                                    <div class="panel-heading">
                                        <h3>Control de Proveedores</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="col-md-12 text-right">
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_agregar_proveedores" runat="server" Text="Agregar" AutoPostBack="True" OnCheckedChanged="rb_agregar_proveedores_CheckedChanged" />
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_editar_proveedores" runat="server" Text="Editar" AutoPostBack="True" OnCheckedChanged="rb_editar_proveedores_CheckedChanged" />
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_eliminar_proveedores" runat="server" Text="Eliminar" AutoPostBack="True" OnCheckedChanged="rb_eliminar_proveedores_CheckedChanged" />
                                        </div>
                                        <div class="col-md-offset-3 col-md-6">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_buscar_proveedores" runat="server" placeholder="Buscar" Visible="false"></asp:TextBox>
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="cmd_buscar_proveedores" runat="server" Text="Ir" Visible="false" OnClick="cmd_buscar_proveedores_Click" />
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <asp:GridView CssClass="table" ID="gv_proveedores" runat="server" AutoGenerateColumns="False" AllowPaging="true" OnPageIndexChanging="gv_proveedores_PageIndexChanging">
                                                <Columns>
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="chk_proveedores" runat="server" onclick="CheckOne(this)" OnCheckedChanged="chk_proveedores_CheckedChanged" AutoPostBack="true" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="rfc" HeaderText="RFC" SortExpression="rfc" Visible="true" />
                                                    <asp:BoundField DataField="desc_tipo_rfc" HeaderText="Tipo RFC" SortExpression="desc_tipo_rfc" />
                                                    <asp:BoundField DataField="razon_social" HeaderText="Razón Social" SortExpression="razon_social" />
                                                    <asp:BoundField DataField="fecha_registro" HeaderText="Fecha de Registro" SortExpression="fecha_registro" DataFormatString="{0:dd/MM/yyyy}" />
                                                </Columns>
                                            </asp:GridView>
                                            <br />
                                        </div>

                                        <div class="row" id="div1" runat="server" visible="true">
                                            <div class="col-md-2">
                                                <asp:Image CssClass="center-block img-responsive" ID="img_proveedores" runat="server" ImageUrl="~/images/teamwork/png/chat.png" Width="128" Height="128" />
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <asp:DropDownList CssClass="form-control" ID="ddl_tiporfc_proveedores" runat="server" ToolTip="Seleccionar tipo RFC"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfv_tiporfc_proveedores" runat="server" Visible="false"
                                                        ErrorMessage="Campo Requerido"
                                                        ControlToValidate="ddl_tiporfc_proveedores" InitialValue="0"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_rfc_proveedores" runat="server" placeholder="RFC"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfv_rfc_proveedores" runat="server" Visible="false"
                                                        ControlToValidate="txt_rfc_proveedores"
                                                        ErrorMessage="Campo Requerido"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_rs_proveedores" runat="server" placeholder="Capturar Razón Social" Visible="True"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfv_rs_proveedores" runat="server" Visible="false"
                                                        ControlToValidate="txt_rs_proveedores"
                                                        ErrorMessage="Campo Requerido"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_telefono_proveedores" runat="server" placeholder="Capturar Teléfono"></asp:TextBox>
                                                    <ajaxToolkit:MaskedEditExtender ID="me_telefono_proveedores" runat="server" TargetControlID="txt_telefono_proveedores" Mask="(52) 99.99.99.99.99.99 ext 99999" />
                                                    <asp:RequiredFieldValidator ID="rfv_telefono_proveedores" runat="server" Visible="false"
                                                        ControlToValidate="txt_telefono_proveedores"
                                                        ErrorMessage="Campo Requerido"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_proveedores" runat="server" placeholder="Capturar Email"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:TextBox CssClass="form-control" ID="txt_calle_proveedores" runat="server" placeholder="Capturar Calle"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_calle_proveedores" runat="server" Visible="false"
                                                    ControlToValidate="txt_calle_proveedores"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_cp_proveedores" runat="server" placeholder="Capturar Código Postal" MaxLength="6"></asp:TextBox>
                                                    <ajaxToolkit:MaskedEditExtender ID="me_cp_proveedores" runat="server" TargetControlID="txt_cp_proveedores" Mask="99999" />
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="cmd_vcp_proveedores" runat="server" Text="validar" OnClick="cmd_vcp_proveedores_Click" />
                                                    </span>
                                                </div>
                                                <asp:RequiredFieldValidator ID="rfv_vcp_proveedores" runat="server" Visible="false"
                                                    ControlToValidate="txt_cp_proveedores"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:DropDownList CssClass="form-control" ID="ddl_colonia_proveedores" runat="server" ToolTip="Seleccionar colonia"></asp:DropDownList>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_municipio_proveedores" runat="server" placeholder="Capturar Municipio" Enabled="false"></asp:TextBox>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_estado_proveedores" runat="server" placeholder="Capturar Estado" Enabled="false"></asp:TextBox>
                                            </div>

                                        </div>
                                        <div class="row">
                                            <h3 class="text-center">Contacto de Proveedor</h3>
                                            <div class="col-md-2">
                                            </div>
                                            <div class="col-md-5">
                                                <asp:TextBox CssClass="form-control" ID="txt_nombres_contactoproveedores" runat="server" placeholder="Capturar Nombre(s)"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_nombres_contactoproveedores" runat="server" Visible="false"
                                                    ControlToValidate="txt_nombres_contactoproveedores"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_apaterno_contactoproveedores" runat="server" placeholder="Capturar Apellido Paterno"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_apaterno_contactoproveedores" runat="server" Visible="false"
                                                    ControlToValidate="txt_apaterno_contactoproveedores"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_amaterno_contactoproveedores" runat="server" placeholder="Capturar Apellido Materno"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_amaterno_contactoproveedores" runat="server" Visible="false"
                                                    ControlToValidate="txt_amaterno_contactoproveedores"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                            </div>
                                            <div class="col-md-5">
                                                <asp:TextBox CssClass="form-control" ID="txt_telefono_contactoproveedores" runat="server" placeholder="Capturar Teléfono"></asp:TextBox>
                                                <ajaxToolkit:MaskedEditExtender ID="me_telefono_contactoproveedores" runat="server" TargetControlID="txt_telefono_proveedores" Mask="(52) 99.99.99.99.99.99 ext 99999" />
                                                <asp:RequiredFieldValidator ID="rfv_telefono_contactoproveedores" runat="server" Visible="false"
                                                    ControlToValidate="txt_telefono_contactoproveedores"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_email_contactoproveedores" runat="server" placeholder="Capturar Email"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-md-12 text-right">
                                                <asp:Button CssClass="btn" ID="cmd_guarda_proveedores" runat="server" Text="Guardar" OnClick="cmd_guarda_proveedores_Click" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel-footer"></div>
                                </div>
                                <div class="panel panel-default" id="pnl_clientes" runat="server" visible="false">
                                    <div class="panel-heading">
                                        <h3>Control de Clientes</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="col-md-12 text-right">
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_agregar_clientes" runat="server" Text="Agregar" AutoPostBack="True" OnCheckedChanged="rb_agregar_clientes_CheckedChanged" />
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_editar_clientes" runat="server" Text="Editar" AutoPostBack="True" OnCheckedChanged="rb_editar_clientes_CheckedChanged" />
                                            <asp:RadioButton CssClass="radio-inline" ID="rb_eliminar_clientes" runat="server" Text="Eliminar" AutoPostBack="True" OnCheckedChanged="rb_eliminar_clientes_CheckedChanged" />
                                        </div>
                                        <div class="col-md-offset-3 col-md-6">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_buscar_clientes" runat="server" placeholder="Buscar" Visible="false"></asp:TextBox>
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="cmd_buscar_clientes" runat="server" Text="Ir" Visible="false" OnClick="cmd_buscar_clientes_Click" />
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <asp:GridView CssClass="table" ID="gv_clientes" runat="server" AutoGenerateColumns="False" AllowPaging="true" OnPageIndexChanging="gv_clientes_PageIndexChanging">
                                                <Columns>
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="chk_clientes" runat="server" onclick="CheckOne(this)" OnCheckedChanged="chk_clientes_CheckedChanged" AutoPostBack="true" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="rfc" HeaderText="RFC" SortExpression="rfc" Visible="true" />
                                                    <asp:BoundField DataField="desc_tipo_rfc" HeaderText="Tipo RFC" SortExpression="desc_tipo_rfc" />
                                                    <asp:BoundField DataField="razon_social" HeaderText="Razón Social" SortExpression="razon_social" />
                                                    <asp:BoundField DataField="fecha_registro" HeaderText="Fecha de Registro" SortExpression="fecha_registro" DataFormatString="{0:dd/MM/yyyy}" />
                                                </Columns>
                                            </asp:GridView>
                                            <br />
                                        </div>

                                        <div class="row" id="div3" runat="server" visible="true">
                                            <div class="col-md-2">
                                                <asp:Image CssClass="center-block img-responsive" ID="img_clientes" runat="server" ImageUrl="~/images/teamwork/png/teamwork.png" Width="128" Height="128" />
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <asp:DropDownList CssClass="form-control" ID="ddl_tiporfc_clientes" runat="server" ToolTip="Seleccionar tipo RFC"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfv_tiporfc_clientes" runat="server" Visible="false"
                                                        ErrorMessage="Campo Requerido"
                                                        ControlToValidate="ddl_tiporfc_clientes" InitialValue="0"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_rfc_clientes" runat="server" placeholder="RFC"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfv_rfc_clientes" runat="server" Visible="false"
                                                        ControlToValidate="txt_rfc_clientes"
                                                        ErrorMessage="Campo Requerido"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_rs_clientes" runat="server" placeholder="Capturar Razón Social" Visible="True"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfv_rs_clientes" runat="server" Visible="false"
                                                        ControlToValidate="txt_rs_clientes"
                                                        ErrorMessage="Campo Requerido"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_telefono_clientes" runat="server" placeholder="Capturar Teléfono"></asp:TextBox>
                                                    <ajaxToolkit:MaskedEditExtender ID="me_telefono_clientes" runat="server" TargetControlID="txt_telefono_clientes" Mask="(52) 99.99.99.99.99.99 ext 99999" />
                                                    <asp:RequiredFieldValidator ID="rfv_telefono_clientes" runat="server" Visible="false"
                                                        ControlToValidate="txt_telefono_clientes"
                                                        ErrorMessage="Campo Requerido"
                                                        ForeColor="orange">
                                                    </asp:RequiredFieldValidator>
                                                    <br />
                                                    <asp:TextBox CssClass="form-control" ID="txt_email_clientes" runat="server" placeholder="Capturar Email"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:TextBox CssClass="form-control" ID="txt_calle_clientes" runat="server" placeholder="Capturar Calle"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_calle_clientes" runat="server" Visible="false"
                                                    ControlToValidate="txt_calle_clientes"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <div class="input-group">
                                                    <asp:TextBox CssClass="form-control" ID="txt_cp_clientes" runat="server" placeholder="Capturar Código Postal" MaxLength="6"></asp:TextBox>
                                                    <ajaxToolkit:MaskedEditExtender ID="me_cp_clientes" runat="server" TargetControlID="txt_cp_clientes" Mask="99999" />
                                                    <span class="input-group-btn">
                                                        <asp:Button CssClass="btn" ID="cmd_vcp_clientes" runat="server" Text="validar" OnClick="cmd_vcp_clientes_Click" />
                                                    </span>
                                                </div>
                                                <asp:RequiredFieldValidator ID="rfv_vcp_clientes" runat="server" Visible="false"
                                                    ControlToValidate="txt_cp_clientes"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:DropDownList CssClass="form-control" ID="ddl_colonia_clientes" runat="server" ToolTip="Seleccionar colonia"></asp:DropDownList>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_municipio_clientes" runat="server" placeholder="Capturar Municipio" Enabled="false"></asp:TextBox>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_estado_clientes" runat="server" placeholder="Capturar Estado" Enabled="false"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="row">
                                            <h3 class="text-center">Contacto de Cliente</h3>
                                            <div class="col-md-2">
                                            </div>
                                            <div class="col-md-5">
                                                <asp:TextBox CssClass="form-control" ID="txt_nombres_contactoclientes" runat="server" placeholder="Capturar Nombre(s)"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_nombres_contactoclientes" runat="server" Visible="false"
                                                    ControlToValidate="txt_nombres_contactoclientes"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_apaterno_contactoclientes" runat="server" placeholder="Capturar Apellido Paterno"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_apaterno_contactoclientes" runat="server" Visible="false"
                                                    ControlToValidate="txt_apaterno_contactoclientes"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_amaterno_contactoclientes" runat="server" placeholder="Capturar Apellido Materno"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv_amaterno_contactoclientes" runat="server" Visible="false"
                                                    ControlToValidate="txt_amaterno_contactoclientes"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                            </div>
                                            <div class="col-md-5">
                                                <asp:TextBox CssClass="form-control" ID="txt_telefono_contactoclientes" runat="server" placeholder="Capturar Teléfono"></asp:TextBox>
                                                <ajaxToolkit:MaskedEditExtender ID="me_telefono_contactoclientes" runat="server" TargetControlID="txt_telefono_clientes" Mask="(52) 99.99.99.99.99.99 ext 99999" />
                                                <asp:RequiredFieldValidator ID="rfv_telefono_contactoclientes" runat="server" Visible="false"
                                                    ControlToValidate="txt_telefono_contactoclientes"
                                                    ErrorMessage="Campo Requerido"
                                                    ForeColor="orange">
                                                </asp:RequiredFieldValidator>
                                                <br />
                                                <asp:TextBox CssClass="form-control" ID="txt_email_contactoclientes" runat="server" placeholder="Capturar Email"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br />
                                        <div class="row">
                                            <div class="col-md-12 text-right">
                                                <asp:Button CssClass="btn" ID="cmd_guarda_clientes" runat="server" Text="Guardar" OnClick="cmd_guarda_clientes_Click" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel-footer"></div>
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
                            <button class="btn" data-dismiss="modal" aria-hidden="true">Ok</button>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
