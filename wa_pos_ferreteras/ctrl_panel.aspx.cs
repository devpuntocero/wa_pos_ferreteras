using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wa_pos_ferreteras
{
    public partial class ctrl_panel : System.Web.UI.Page
    {
        #region carga
        static int int_idusuario;
        static Guid id_fuser, f_iduser, idrazonsocial;


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {
                    inf_user();

                }
                else
                {

                }
            }
            catch
            {
                Response.Redirect("ctrl_acceso.aspx");
            }
        }

        private void inf_user()
        {
            id_fuser = (Guid)(Session["ss_id_user"]);


            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_u in data_user.inf_usuarios
                                join i_tu in data_user.fact_tipo_usuarios on i_u.id_tipo_usuario equals i_tu.id_tipo_usuarios
                                join i_e in data_user.inf_empresa on i_u.id_empresa equals i_e.id_empresa
                                where i_u.id_usuario == id_fuser
                                select new
                                {
                                    i_u.nombres,
                                    i_u.a_paterno,
                                    i_u.a_materno,
                                    i_tu.desc_tipo_usuarios,
                                    i_tu.id_tipo_usuarios,
                                    i_e.razon_social,
                                    i_e.id_empresa

                                }).FirstOrDefault();

                lkb_fusuario.Text = inf_user.nombres + " " + inf_user.a_paterno + " " + inf_user.a_materno;
                lbl_perfilusuario.Text = inf_user.desc_tipo_usuarios;
                int_idusuario = inf_user.id_tipo_usuarios;
                lkb_razonsocial.Text = inf_user.razon_social;
                idrazonsocial = inf_user.id_empresa;

                switch (int_idusuario)
                {

                    case 2:


                        break;
                    case 3:

                        div_administrator.Visible = false;

                        break;
                    case 4:


                        break;
                }
            }
        }

        #endregion

        #region panel
        protected void lkb_panel_Click(object sender, EventArgs e)
        {

        }

        protected void lkb_clientes_Click(object sender, EventArgs e)
        {
            pnl_usuarios.Visible = false;
            pnl_empresa.Visible = false;
            pnl_contribuyentes.Visible = false;
            pnl_proveedores.Visible = false;
            pnl_clientes.Visible = true;

            ddl_tiporfc_clientes.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));
            ddl_colonia_clientes.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));

            rb_agregar_clientes.Checked = false;
            rb_editar_clientes.Checked = false;
            rb_eliminar_clientes.Checked = false;

            txt_buscar_clientes.Visible = false;
            cmd_buscar_clientes.Visible = false;
            gv_clientes.Visible = false;
            limpiar_clientes();

            rfv_tiporfc_clientes.Visible = false;
            rfv_rfc_clientes.Visible = false;
            rfv_rs_clientes.Visible = false;
            rfv_calle_clientes.Visible = false;
            rfv_telefono_clientes.Visible = false;
            rfv_vcp_clientes.Visible = false;

        }

        protected void lkb_inventario_Click(object sender, EventArgs e)
        {

        }

        protected void lkb_kits_Click(object sender, EventArgs e)
        {

        }

        protected void lkb_rprecios_Click(object sender, EventArgs e)
        {

        }

        protected void lkb_proveedores_Click(object sender, EventArgs e)
        {
            pnl_usuarios.Visible = false;
            pnl_empresa.Visible = false;
            pnl_contribuyentes.Visible = false;
            pnl_proveedores.Visible = true;
            pnl_clientes.Visible = false;


            ddl_tiporfc_proveedores.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));
            ddl_colonia_proveedores.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));

            rb_agregar_proveedores.Checked = false;
            rb_editar_proveedores.Checked = false;
            rb_eliminar_proveedores.Checked = false;

            txt_buscar_proveedores.Visible = false;
            cmd_buscar_proveedores.Visible = false;
            gv_proveedores.Visible = false;
            limpiar_proveedores();

            rfv_tiporfc_proveedores.Visible = false;
            rfv_rfc_proveedores.Visible = false;
            rfv_rs_proveedores.Visible = false;
            rfv_calle_proveedores.Visible = false;
            rfv_telefono_proveedores.Visible = false;
            rfv_vcp_proveedores.Visible = false;
        }

        protected void lkb_reportes_Click(object sender, EventArgs e)
        {

        }

        protected void lkb_recepcion_Click(object sender, EventArgs e)
        {

        }

        protected void Ventas_Click(object sender, EventArgs e)
        {

        }

        protected void lkb_entregas_Click(object sender, EventArgs e)
        {

        }

        protected void lkb_gastos_Click(object sender, EventArgs e)
        {

        }

        protected void lkb_usarios_Click(object sender, EventArgs e)
        {
            pnl_usuarios.Visible = true;
            pnl_empresa.Visible = false;
            pnl_contribuyentes.Visible = false;
            pnl_proveedores.Visible = false;
            pnl_clientes.Visible = false;
        }

        protected void lkb_config_Click(object sender, EventArgs e)
        {

        }

        protected void lkb_contribuyentes_Click(object sender, EventArgs e)
        {
            pnl_usuarios.Visible = false;
            pnl_empresa.Visible = false;
            pnl_contribuyentes.Visible = true;
            pnl_proveedores.Visible = false;
            pnl_clientes.Visible = false;

            ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));
            ddl_colonia_contribuyentes.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));

            rb_agregar_contribuyentes.Checked = false;
            rb_editar_contribuyentes.Checked = false;
            rb_eliminar_contribuyentes.Checked = false;

            txt_buscar_contribuyentes.Visible = false;
            cmd_buscar_contribuyentes.Visible = false;
            gv_contribuyentes.Visible = false;
            limpiar_contribuyentes();

            rfv_tiporfc_contribuyente.Visible = false;
            rfv_rfc_contribuyentes.Visible = false;
            rfv_rs_contribuyentes.Visible = false;
            rfv_calle_contribuyentes.Visible = false;
            rfv_telefono_contribuyentes.Visible = false;
            rfv_vcp_contribuyentes.Visible = false;

        }

        #endregion

        #region usuarios

        protected void cmd_busca_usuario_Click(object sender, EventArgs e)
        {
            string str_userb = txt_buscar.Text;
            int fint_idusuario = f_idusuario();

            try
            {
                using (db_posEntities data_user = new db_posEntities())
                {
                    var inf_user = (from u in data_user.inf_usuarios
                                    join est in data_user.fact_estatus on u.id_estatus equals est.id_estatus
                                    where u.nombres.Contains(str_userb)
                                    where u.id_tipo_usuario == fint_idusuario
                                    where u.id_estatus == 1

                                    select new
                                    {
                                        u.codigo_usuario,
                                        est.desc_estatus,
                                        u.fecha_nacimiento,
                                        u.nombres,
                                        u.a_paterno,
                                        u.a_materno

                                    }).ToList();

                    if (inf_user.Count == 0)
                    {
                        gv_usuarios.DataSource = inf_user;
                        gv_usuarios.DataBind();
                        gv_usuarios.Visible = true;

                        lblModalTitle.Text = "POS Punto Cero";
                        lblModalBody.Text = "Usuario no exite o tiene un perfil diferente";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                        upModal.Update();


                    }
                    else
                    {
                        gv_usuarios.DataSource = inf_user;
                        gv_usuarios.DataBind();
                        gv_usuarios.Visible = true;
                    }
                }
            }
            catch
            {
            }
        }

        protected void rb_agrea_usuario_CheckedChanged(object sender, EventArgs e)
        {
            rb_edita_usuario.Checked = false;
            rb_elimina_usuario.Checked = false;

            rfv_name_user.Visible = true;
            rfv_amater.Visible = true;
            rfv_apater.Visible = true;
            rfv_email_im.Visible = true;
            rfv_password.Visible = true;

            limpiar_infusuario();

            gv_usuarios.Visible = false;
            txt_buscar.Visible = false;
            cmd_busca_usuario.Visible = false;
        }

        private void limpiar_infusuario()
        {
            txt_buscar.Text = "";
            txt_name_user.Text = "";
            txt_apater.Text = "";
            txt_amater.Text = "";
            txt_code_user.Text = "";
            txt_password.Text = "";


        }

        protected void rb_edita_usuario_CheckedChanged(object sender, EventArgs e)
        {
            rb_agrea_usuario.Checked = false;
            rb_elimina_usuario.Checked = false;

            txt_buscar.Visible = true;
            cmd_busca_usuario.Visible = true;

            rfv_name_user.Enabled = false;
            rfv_amater.Enabled = false;
            rfv_apater.Enabled = false;
            rfv_email_im.Enabled = false;
            rfv_password.Enabled = false;

            limpiar_infusuario();

            var int_fidusuario = new int?[] { f_idusuario() };
            filtrar_infusuario(int_fidusuario);
        }

        private void filtrar_infusuario(int?[] int_fidusuario)
        {
            if (int_idusuario == 2)
            {
                using (db_posEntities data_user = new db_posEntities())
                {
                    var inf_user = (from u in data_user.inf_usuarios
                                    join e in data_user.fact_estatus on u.id_estatus equals e.id_estatus
                                    where int_fidusuario.Contains(u.id_tipo_usuario)
                                    where u.id_usuario != id_fuser
                                    where u.id_estatus == 1

                                    select new
                                    {
                                        u.codigo_usuario,
                                        e.desc_estatus,
                                        u.fecha_nacimiento,
                                        u.nombres,
                                        u.a_paterno,
                                        u.a_materno

                                    }).ToList();

                    gv_usuarios.DataSource = inf_user;
                    gv_usuarios.DataBind();
                    gv_usuarios.Visible = true;
                }
            }
            else
            {
                using (db_posEntities data_user = new db_posEntities())
                {
                    var inf_user = (from u in data_user.inf_usuarios
                                    join e in data_user.fact_estatus on u.id_estatus equals e.id_estatus
                                    where int_fidusuario.Contains(u.id_tipo_usuario)
                                    where u.id_usuario != id_fuser
                                    where u.id_estatus == 1
                                    select new
                                    {
                                        u.codigo_usuario,
                                        e.desc_estatus,
                                        u.fecha_nacimiento,
                                        u.nombres,
                                        u.a_paterno,
                                        u.a_materno

                                    }).ToList();

                    gv_usuarios.DataSource = inf_user;
                    gv_usuarios.DataBind();
                    gv_usuarios.Visible = true;
                }
            }
        }

        protected void rb_elimina_usuario_CheckedChanged(object sender, EventArgs e)
        {
            rb_agrea_usuario.Checked = false;
            rb_edita_usuario.Checked = false;

            txt_buscar.Visible = true;
            cmd_busca_usuario.Visible = true;

            rfv_name_user.Enabled = false;
            rfv_amater.Enabled = false;
            rfv_apater.Enabled = false;
            rfv_email_im.Enabled = false;
            rfv_password.Enabled = false;

            limpiar_infusuario();

            var int_fidusuario = new int?[] { f_idusuario() };
            filtrar_infusuario(int_fidusuario);

        }

        protected void chk_usuario_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gv_usuarios.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chk_usuario") as CheckBox);
                    if (chkRow.Checked)
                    {
                        row.BackColor = Color.Orange;
                        string codeuser = row.Cells[1].Text;

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var items_user = (from c in data_user.inf_usuarios
                                              where c.codigo_usuario == codeuser
                                              select c).FirstOrDefault();

                            id_fuser = items_user.id_usuario;
                        }


                        if (int_idusuario == 2)
                        {
                            using (db_posEntities data_user = new db_posEntities())
                            {
                                var inf_user = (from u in data_user.inf_usuarios
                                                where u.id_usuario == id_fuser
                                                select new
                                                {
                                                    u.nombres,
                                                    u.a_paterno,
                                                    u.a_materno,
                                                    u.codigo_usuario,
                                                    u.clave

                                                }).FirstOrDefault();


                                txt_name_user.Text = inf_user.nombres;
                                txt_apater.Text = inf_user.a_paterno;
                                txt_amater.Text = inf_user.a_materno;
                                txt_code_user.Text = inf_user.codigo_usuario;
                                txt_password.Text = inf_user.clave;
                            }
                        }
                        else
                        {
                            using (db_posEntities data_user = new db_posEntities())
                            {
                                var inf_user = (from u in data_user.inf_usuarios
                                                where u.id_usuario == id_fuser
                                                select new
                                                {
                                                    u.nombres,
                                                    u.a_paterno,
                                                    u.a_materno,
                                                    u.codigo_usuario,
                                                    u.clave

                                                }).FirstOrDefault();


                                txt_name_user.Text = inf_user.nombres;
                                txt_apater.Text = inf_user.a_paterno;
                                txt_amater.Text = inf_user.a_materno;
                                txt_code_user.Text = inf_user.codigo_usuario;
                                txt_password.Text = inf_user.clave;
                            }
                        }
                    }
                    else
                    {
                        row.BackColor = Color.White;
                    }
                }
            }
        }

        protected void cmd_guarda_usuario_Click(object sender, EventArgs e)
        {
            if (rb_agrea_usuario.Checked == false & rb_edita_usuario.Checked == false & rb_elimina_usuario.Checked == false)
            {

                lblModalTitle.Text = "POS Punto Cero";
                lblModalBody.Text = "Favor de seleccionar una acción";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                upModal.Update();

            }
            else
            {

                string str_nameuser = txt_name_user.Text.ToUpper();
                string str_apater = txt_apater.Text.ToUpper();
                string str_amater = txt_amater.Text.ToUpper();
                string str_codeuser = txt_code_user.Text.ToLower();
                string str_password = mdl_encrypta.Encrypt(txt_password.Text.ToLower());
                Guid n_iduser = Guid.NewGuid();

                if (rb_agrea_usuario.Checked)
                {

                    try
                    {
                        string str_filter_code;
                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var items_user = (from c in data_user.inf_usuarios
                                              where c.codigo_usuario == str_codeuser
                                              select c).FirstOrDefault();

                            str_filter_code = items_user.codigo_usuario.ToString();
                        }

                        if (str_codeuser == str_filter_code)
                        {
                            limpiar_infusuario();
                            lblModalTitle.Text = "POS Punto Cero";
                            lblModalBody.Text = "Usuario ya existe en la base, agregar otro usuario";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                            upModal.Update();
                        }
                    }
                    catch
                    {
                        using (var insert_user = new db_posEntities())
                        {
                            var items_user = new inf_usuarios
                            {
                                id_usuario = n_iduser,
                                nombres = str_nameuser,
                                a_paterno = str_apater,
                                a_materno = str_amater,
                                id_tipo_usuario = f_idusuario(),
                                codigo_usuario = str_codeuser,
                                clave = str_password,
                                id_estatus = 1,
                                fecha_registro = DateTime.Now,
                                id_empresa = idrazonsocial
                            };
                            insert_user.inf_usuarios.Add(items_user);
                            insert_user.SaveChanges();
                        }

                        rfv_name_user.Visible = false;
                        rfv_amater.Visible = false;
                        rfv_apater.Visible = false;
                        rfv_email_im.Visible = false;
                        rfv_password.Visible = false;
                        limpiar_infusuario();
                        rb_agrea_usuario.Checked = false;
                        rb_edita_usuario.Checked = false;
                        rb_elimina_usuario.Checked = false;

                        lblModalTitle.Text = "POS Punto Cero";
                        lblModalBody.Text = "Datos de usuario guardados con éxito";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                        upModal.Update();
                    }
                }
                else if (rb_edita_usuario.Checked)
                {


                    foreach (GridViewRow row in gv_usuarios.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[1].FindControl("chk_usuario") as CheckBox);
                            if (chkRow.Checked)
                            {
                                string codeuser = row.Cells[1].Text;

                                using (db_posEntities data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_usuarios
                                                      where c.codigo_usuario == codeuser
                                                      select c).FirstOrDefault();

                                    f_iduser = items_user.id_usuario;
                                }

                                using (var data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_usuarios
                                                      where c.id_usuario == f_iduser
                                                      select c).FirstOrDefault();

                                    items_user.nombres = str_nameuser;
                                    items_user.a_paterno = str_apater;
                                    items_user.a_materno = str_amater;
                                    items_user.codigo_usuario = str_codeuser;
                                    items_user.clave = str_password;

                                    data_user.SaveChanges();
                                }

                                limpiar_infusuario();

                                rb_agrea_usuario.Checked = false;
                                rb_edita_usuario.Checked = false;
                                rb_elimina_usuario.Checked = false;

                                gv_usuarios.Visible = false;
                                txt_buscar.Visible = false;
                                cmd_busca_usuario.Visible = false;

                                lblModalTitle.Text = "POS Punto Cero";
                                lblModalBody.Text = "Datos de usuario actualizados con éxito";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                                upModal.Update();
                            }
                        }
                    }
                }

                else if (rb_elimina_usuario.Checked)
                {
                    foreach (GridViewRow row in gv_usuarios.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chk_usuario") as CheckBox);
                            if (chkRow.Checked)
                            {
                                string codeuser = row.Cells[1].Text;

                                using (db_posEntities data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_usuarios
                                                      where c.codigo_usuario == codeuser
                                                      select c).FirstOrDefault();

                                    f_iduser = items_user.id_usuario;
                                }

                                using (var data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_usuarios
                                                      where c.id_usuario == f_iduser
                                                      select c).FirstOrDefault();

                                    items_user.id_estatus = 3;

                                    data_user.SaveChanges();
                                }
                                limpiar_infusuario();

                                rb_agrea_usuario.Checked = false;
                                rb_edita_usuario.Checked = false;
                                rb_elimina_usuario.Checked = false;

                                gv_usuarios.Visible = false;
                                txt_buscar.Visible = false;
                                cmd_busca_usuario.Visible = false;

                                lblModalTitle.Text = "POS Punto Cero";
                                lblModalBody.Text = "Datos de usuario eliminados con éxito";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                                upModal.Update();
                            }
                        }
                    }
                }
            }
        }

        protected void gv_usuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void chkb_ejecutivo_CheckedChanged(object sender, EventArgs e)
        {
            chkb_administrator.Checked = false;
            chkb_supervisor.Checked = false;
            chkb_vendedor.Checked = false;

            desactiva_filtros();


        }

        private void desactiva_filtros()
        {
            gv_usuarios.Visible = false;
            txt_buscar.Visible = false;
            cmd_busca_usuario.Visible = false;
            rb_agrea_usuario.Checked = false;
            rb_edita_usuario.Checked = false;
            rb_elimina_usuario.Checked = false;
        }

        protected void chkb_administrator_CheckedChanged(object sender, EventArgs e)
        {
            chkb_ejecutivo.Checked = false;
            chkb_supervisor.Checked = false;
            chkb_vendedor.Checked = false;
            desactiva_filtros();
        }

        protected void chkb_supervisor_CheckedChanged(object sender, EventArgs e)
        {
            chkb_administrator.Checked = false;
            chkb_ejecutivo.Checked = false;
            chkb_vendedor.Checked = false;
            desactiva_filtros();
        }

        protected void chkb_vendedor_CheckedChanged(object sender, EventArgs e)
        {
            chkb_administrator.Checked = false;
            chkb_ejecutivo.Checked = false;
            chkb_supervisor.Checked = false;
            desactiva_filtros();
        }

        protected void lkb_fuser_Click(object sender, EventArgs e)
        {

        }

        public int f_idusuario()
        {
            if (chkb_administrator.Checked)
            {
                return 2;

            }
            else if (chkb_supervisor.Checked)
            {
                return 3;

            }
            else if (chkb_ejecutivo.Checked)
            {
                return 4;

            }
            else if (chkb_vendedor.Checked)
            {
                return 5;

            }
            else
            {
                return 0;
            }
        }

        #endregion

        #region empresa

        protected void lkb_razonsocial_Click(object sender, EventArgs e)
        {
            pnl_usuarios.Visible = false;
            pnl_empresa.Visible = true;
            pnl_contribuyentes.Visible = false;
            pnl_proveedores.Visible = false;
            pnl_clientes.Visible = false;

            ddl_colony.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));
        }

        protected void cmd_guarda_empresa_Click(object sender, EventArgs e)
        {


            string str_business_name = txt_business_name.Text.ToUpper();
            string str_street = txt_street.Text.ToUpper();
            string str_cp = txt_cp.Text;
            int int_colony = Convert.ToInt32(ddl_colony.SelectedValue);
            string str_phone = txt_phone.Text;
            string str_email = txt_email.Text;

            using (var data_addressF = new db_posEntities())
            {
                var items_addressF = (from c in data_addressF.inf_empresa
                                      where c.id_empresa == idrazonsocial
                                      select c).FirstOrDefault();


                items_addressF.razon_social = str_business_name;
                items_addressF.calle = str_street;
                items_addressF.cp = str_cp;
                items_addressF.id_asenta_cpcons = int_colony;
                items_addressF.telefono = str_phone;
                items_addressF.email = str_email;

                data_addressF.SaveChanges();
            }
            chkb_editar_empresa.Checked = false;
            limpia_infempresa();

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_u in data_user.inf_usuarios
                                join i_tu in data_user.fact_tipo_usuarios on i_u.id_tipo_usuario equals i_tu.id_tipo_usuarios
                                join i_e in data_user.inf_empresa on i_u.id_empresa equals i_e.id_empresa
                                where i_u.id_usuario == id_fuser
                                select new
                                {
                                    i_u.nombres,
                                    i_u.a_paterno,
                                    i_u.a_materno,
                                    i_tu.desc_tipo_usuarios,
                                    i_tu.id_tipo_usuarios,
                                    i_e.razon_social,
                                    i_e.id_empresa

                                }).FirstOrDefault();

                lkb_fusuario.Text = inf_user.nombres + " " + inf_user.a_paterno + " " + inf_user.a_materno;
                lbl_perfilusuario.Text = inf_user.desc_tipo_usuarios;
                int_idusuario = inf_user.id_tipo_usuarios;
                lkb_razonsocial.Text = inf_user.razon_social;
                idrazonsocial = inf_user.id_empresa;
            }

            rfv_business_name.Visible = false;
            rfv_phone.Visible = false;
            rfv_street.Visible = false;
            rfv_cp.Visible = false;

            lblModalTitle.Text = "POS Punto Cero";
            lblModalBody.Text = "Datos de Empresa actualizados con éxito";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }

        protected void cmd_vcp_Click(object sender, EventArgs e)
        {
            string str_codigo = txt_cp.Text;

            datos_sepomex(str_codigo);
        }

        protected void chkb_editar_empresa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_editar_empresa.Checked)
            {
                try
                {

                    int int_colony;
                    string str_cp;

                    using (db_posEntities data_user = new db_posEntities())
                    {
                        var inf_empresa = (from i_c in data_user.inf_empresa
                                           where i_c.id_empresa == idrazonsocial
                                           select new
                                           {
                                               i_c.razon_social,
                                               i_c.calle,
                                               i_c.cp,
                                               i_c.id_asenta_cpcons,
                                               i_c.telefono,
                                               i_c.email

                                           }).FirstOrDefault();

                        txt_business_name.Text = inf_empresa.razon_social;
                        txt_street.Text = inf_empresa.calle;

                        str_cp = inf_empresa.cp;

                        txt_cp.Text = str_cp;
                        txt_phone.Text = inf_empresa.telefono;
                        txt_email.Text = inf_empresa.email;
                        int_colony = Convert.ToInt32(inf_empresa.id_asenta_cpcons);
                    }
                    using (db_posEntities db_sepomex = new db_posEntities())
                    {
                        var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                           where c.id_asenta_cpcons == int_colony
                                           where c.d_codigo == str_cp
                                           select c).ToList();

                        ddl_colony.DataSource = tbl_sepomex;
                        ddl_colony.DataTextField = "d_asenta";
                        ddl_colony.DataValueField = "id_asenta_cpcons";
                        ddl_colony.DataBind();

                        txt_municipality.Text = tbl_sepomex[0].D_mnpio;
                        txt_state.Text = tbl_sepomex[0].d_estado;

                        rfv_business_name.Visible = true;
                        rfv_phone.Visible = true;
                        rfv_street.Visible = true;
                        rfv_cp.Visible = true;
                    }
                }
                catch
                {

                }
            }
            else
            {
                limpia_infempresa();
                rfv_business_name.Visible = false;
                rfv_phone.Visible = false;
                rfv_street.Visible = false;
                rfv_cp.Visible = false;
            }
        }
        private void limpia_infempresa()
        {
            txt_business_name.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_street.Text = "";
            txt_cp.Text = "";
            ddl_colony.Items.Clear();
            ddl_colony.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));
            ddl_colony.SelectedValue = "0";
            txt_municipality.Text = "";
            txt_state.Text = "";
        }
        private void datos_sepomex(string str_codigo)
        {
            using (db_posEntities db_sepomex = new db_posEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                   where c.d_codigo == str_codigo
                                   select c).ToList();

                ddl_colony.DataSource = tbl_sepomex;
                ddl_colony.DataTextField = "d_asenta";
                ddl_colony.DataValueField = "id_asenta_cpcons";
                ddl_colony.DataBind();

                if (tbl_sepomex.Count == 1)
                {


                    txt_municipality.Text = tbl_sepomex[0].D_mnpio;
                    txt_state.Text = tbl_sepomex[0].d_estado;
                }
                if (tbl_sepomex.Count > 1)
                {

                    ddl_colony.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));

                    txt_municipality.Text = tbl_sepomex[0].D_mnpio;
                    txt_state.Text = tbl_sepomex[0].d_estado;
                }
                else if (tbl_sepomex.Count == 0)
                {

                    lblModalTitle.Text = "POS Punto Cero";
                    lblModalBody.Text = "Error de Código Postal, favor de reintentar";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                    upModal.Update();
                    limpia_infempresa();
                }
            }
        }
        #endregion

        #region contribuyentes
        protected void chkb_contribuyentes_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void cmd_vcp_contribuyentes_Click(object sender, EventArgs e)
        {
            string str_codigo = txt_cp_contribuyentes.Text;

            using (db_posEntities db_sepomex = new db_posEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                   where c.d_codigo == str_codigo
                                   select c).ToList();

                ddl_colonia_contribuyentes.DataSource = tbl_sepomex;
                ddl_colonia_contribuyentes.DataTextField = "d_asenta";
                ddl_colonia_contribuyentes.DataValueField = "id_asenta_cpcons";
                ddl_colonia_contribuyentes.DataBind();

                if (tbl_sepomex.Count == 1)
                {
                    txt_municipio_contribuyentes.Text = tbl_sepomex[0].D_mnpio;
                    txt_estado_contribuyentes.Text = tbl_sepomex[0].d_estado;
                }
                if (tbl_sepomex.Count > 1)
                {

                    ddl_colonia_contribuyentes.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));

                    txt_municipio_contribuyentes.Text = tbl_sepomex[0].D_mnpio;
                    txt_estado_contribuyentes.Text = tbl_sepomex[0].d_estado;
                }
                else if (tbl_sepomex.Count == 0)
                {

                    lblModalTitle.Text = "POS Punto Cero";
                    lblModalBody.Text = "Error de Código Postal, favor de reintentar";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                    upModal.Update();
                    limpia_infempresa();
                }
            }
        }

        protected void cmd_guarda_contribuyentes_Click(object sender, EventArgs e)
        {
            if (rb_agregar_contribuyentes.Checked == false & rb_editar_contribuyentes.Checked == false & rb_eliminar_contribuyentes.Checked == false)
            {

                lblModalTitle.Text = "POS Punto Cero";
                lblModalBody.Text = "Favor de seleccionar una acción";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                upModal.Update();

            }
            else
            {
                Guid n_fiscal = Guid.NewGuid();
                int int_idtiporfc = Convert.ToInt32(ddl_tiporfc_contribuyente.SelectedValue);
                string str_rfc = txt_rfc_contribuyentes.Text;
                string str_razonsocial = txt_rs_contribuyentes.Text;
                string str_calle = txt_calle_contribuyentes.Text.ToUpper();
                string str_cp = txt_cp_contribuyentes.Text;
                int int_colonia = Convert.ToInt32(ddl_colonia_contribuyentes.SelectedValue);
                string str_telefono = txt_telefono_contribuyentes.Text;
                string str_email = txt_email_contribuyentes.Text;
                string str_filtro_rfc;

                if (rb_agregar_contribuyentes.Checked)
                {

                    try
                    {

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var items_user = (from c in data_user.inf_fiscales
                                              where c.rfc == str_rfc
                                              select c).FirstOrDefault();

                            str_filtro_rfc = items_user.rfc.ToString();
                        }

                        if (str_rfc == str_filtro_rfc)
                        {
                            limpiar_infusuario();
                            lblModalTitle.Text = "POS Punto Cero";
                            lblModalBody.Text = "RFC ya existe en la base, agregar otro usuario";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                            upModal.Update();
                        }
                    }
                    catch
                    {
                        using (var insert_user = new db_posEntities())
                        {
                            var items_user = new inf_fiscales
                            {
                                id_fiscales = n_fiscal,
                                id_tipo_rfc = int_idtiporfc,
                                rfc = str_rfc,
                                razon_social = str_razonsocial,
                                telefono = str_telefono,
                                email = str_email,
                                calle = str_calle,
                                cp = str_cp,
                                id_tipo_fiscales = 3,
                                id_asenta_cpcons = int_colonia,
                                id_estatus = 1,
                                fecha_registro = DateTime.Now,
                                id_empresa = idrazonsocial
                            };
                            insert_user.inf_fiscales.Add(items_user);
                            insert_user.SaveChanges();
                        }

                        rfv_tiporfc_contribuyente.Visible = false;
                        rfv_rfc_contribuyentes.Visible = false;
                        rfv_rs_contribuyentes.Visible = false;
                        rfv_calle_contribuyentes.Visible = false;
                        rfv_telefono_contribuyentes.Visible = false;
                        rfv_vcp_contribuyentes.Visible = false;

                        limpiar_contribuyentes();

                        rb_agregar_contribuyentes.Checked = false;
                        rb_editar_contribuyentes.Checked = false;
                        rb_eliminar_contribuyentes.Checked = false;

                        lblModalTitle.Text = "POS Punto Cero";
                        lblModalBody.Text = "Datos de Contribuyente guardados con éxito";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                        upModal.Update();
                    }
                }
                else if (rb_editar_contribuyentes.Checked)
                {
                    foreach (GridViewRow row in gv_contribuyentes.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[1].FindControl("chk_contribuyentes") as CheckBox);
                            if (chkRow.Checked)
                            {
                                string fid = row.Cells[1].Text;

                                using (db_posEntities data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.rfc == fid
                                                      select c).FirstOrDefault();

                                    f_iduser = items_user.id_fiscales;
                                }

                                using (var data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.id_fiscales == f_iduser
                                                      select c).FirstOrDefault();

                                    items_user.id_tipo_rfc = int_idtiporfc;
                                    items_user.rfc = str_rfc;
                                    items_user.razon_social = str_razonsocial;
                                    items_user.telefono = str_telefono;
                                    items_user.email = str_email;
                                    items_user.calle = str_calle;
                                    items_user.cp = str_cp;
                                    items_user.id_asenta_cpcons = int_colonia;

                                    data_user.SaveChanges();
                                }

                                limpiar_contribuyentes();

                                rb_agregar_contribuyentes.Checked = false;
                                rb_editar_contribuyentes.Checked = false;
                                rb_eliminar_contribuyentes.Checked = false;

                                gv_usuarios.Visible = false;
                                txt_buscar.Visible = false;
                                cmd_busca_usuario.Visible = false;

                                lblModalTitle.Text = "POS Punto Cero";
                                lblModalBody.Text = "Datos de Contribuyente actualizados con éxito";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                                upModal.Update();
                            }
                        }
                    }
                }

                else if (rb_eliminar_contribuyentes.Checked)
                {
                    foreach (GridViewRow row in gv_contribuyentes.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chk_contribuyentes") as CheckBox);
                            if (chkRow.Checked)
                            {
                                string fid = row.Cells[1].Text;

                                using (db_posEntities data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.rfc == fid
                                                      select c).FirstOrDefault();

                                    f_iduser = items_user.id_fiscales;
                                }

                                using (var data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.id_fiscales == f_iduser
                                                      select c).FirstOrDefault();

                                    items_user.id_estatus = 3;


                                    data_user.SaveChanges();
                                }

                                limpiar_contribuyentes();

                                rb_agregar_contribuyentes.Checked = false;
                                rb_editar_contribuyentes.Checked = false;
                                rb_eliminar_contribuyentes.Checked = false;

                                gv_usuarios.Visible = false;
                                txt_buscar.Visible = false;
                                cmd_busca_usuario.Visible = false;

                                lblModalTitle.Text = "POS Punto Cero";
                                lblModalBody.Text = "Datos de Contribuyente eliminados con éxito";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                                upModal.Update();
                            }
                        }
                    }
                }
            }
        }

        private void limpiar_contribuyentes()
        {
            ddl_tiporfc_contribuyente.Items.Clear();
            ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));
            ddl_tiporfc_contribuyente.SelectedValue = "0";
            txt_rfc_contribuyentes.Text = "";
            txt_rs_contribuyentes.Text = "";
            txt_telefono_contribuyentes.Text = "";
            txt_email_contribuyentes.Text = "";
            txt_calle_contribuyentes.Text = "";
            txt_cp_contribuyentes.Text = "";
            ddl_colonia_contribuyentes.Items.Clear();
            ddl_colonia_contribuyentes.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));
            ddl_colonia_contribuyentes.SelectedValue = "0";
            txt_municipio_contribuyentes.Text = "";
            txt_estado_contribuyentes.Text = "";
        }

        protected void rb_agregar_contribuyentes_CheckedChanged(object sender, EventArgs e)
        {
            rb_editar_contribuyentes.Checked = false;
            rb_eliminar_contribuyentes.Checked = false;

            txt_buscar_contribuyentes.Visible = false;
            cmd_buscar_contribuyentes.Visible = false;
            gv_contribuyentes.Visible = false;

            using (db_posEntities db_sepomex = new db_posEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.fact_tipo_rfc
                                   select c).ToList();

                ddl_tiporfc_contribuyente.DataSource = tbl_sepomex;
                ddl_tiporfc_contribuyente.DataTextField = "desc_tipo_rfc";
                ddl_tiporfc_contribuyente.DataValueField = "id_tipo_rfc";
                ddl_tiporfc_contribuyente.DataBind();
                ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));

                rfv_tiporfc_contribuyente.Visible = true;
                rfv_rfc_contribuyentes.Visible = true;
                rfv_rs_contribuyentes.Visible = true;
                rfv_calle_contribuyentes.Visible = true;
                rfv_telefono_contribuyentes.Visible = true;
                rfv_vcp_contribuyentes.Visible = true;
                limpiar_contribuyentes();
            }
        }

        protected void rb_editar_contribuyentes_CheckedChanged(object sender, EventArgs e)
        {
            rb_agregar_contribuyentes.Checked = false;
            rb_eliminar_contribuyentes.Checked = false;

            txt_buscar_contribuyentes.Visible = true;
            cmd_buscar_contribuyentes.Visible = true;

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_f in data_user.inf_fiscales
                                join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                where i_f.id_tipo_fiscales == 3
                                where i_f.id_estatus == 1
                                select new
                                {
                                    i_f.rfc,
                                    i_tf.desc_tipo_rfc,
                                    i_f.razon_social,
                                    i_f.fecha_registro

                                }).ToList();

                gv_contribuyentes.DataSource = inf_user;
                gv_contribuyentes.DataBind();
                gv_contribuyentes.Visible = true;
            }

            limpiar_contribuyentes();

            rfv_tiporfc_contribuyente.Visible = false;
            rfv_rfc_contribuyentes.Visible = false;
            rfv_rs_contribuyentes.Visible = false;
            rfv_calle_contribuyentes.Visible = false;
            rfv_telefono_contribuyentes.Visible = false;
            rfv_vcp_contribuyentes.Visible = false;
        }

        protected void rb_eliminar_contribuyentes_CheckedChanged(object sender, EventArgs e)
        {
            rb_editar_contribuyentes.Checked = false;
            rb_agregar_contribuyentes.Checked = false;
            txt_buscar_contribuyentes.Visible = true;
            cmd_buscar_contribuyentes.Visible = true;

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_f in data_user.inf_fiscales
                                join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                where i_f.id_tipo_fiscales == 3
                                where i_f.id_estatus == 1
                                select new
                                {
                                    i_f.rfc,
                                    i_tf.desc_tipo_rfc,
                                    i_f.razon_social,
                                    i_f.fecha_registro

                                }).ToList();

                gv_contribuyentes.DataSource = inf_user;
                gv_contribuyentes.DataBind();
                gv_contribuyentes.Visible = true;
            }
            limpiar_contribuyentes();
            rfv_tiporfc_contribuyente.Visible = false;
            rfv_rfc_contribuyentes.Visible = false;
            rfv_rs_contribuyentes.Visible = false;
            rfv_calle_contribuyentes.Visible = false;
            rfv_telefono_contribuyentes.Visible = false;
            rfv_vcp_contribuyentes.Visible = false;
        }

        protected void cmd_buscar_contribuyentes_Click(object sender, EventArgs e)
        {
            string str_userb = txt_buscar_contribuyentes.Text;

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_f in data_user.inf_fiscales
                                join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                where i_f.razon_social.Contains(str_userb)
                                where i_f.id_tipo_fiscales == 3
                                where i_f.id_estatus == 1
                                select new
                                {
                                    i_f.rfc,
                                    i_tf.desc_tipo_rfc,
                                    i_f.razon_social,
                                    i_f.fecha_registro

                                }).ToList();

                gv_contribuyentes.DataSource = inf_user;
                gv_contribuyentes.DataBind();
                gv_contribuyentes.Visible = true;
            }
        }

        protected void gv_contribuyentes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void chk_contribuyentes_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gv_contribuyentes.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chk_contribuyentes") as CheckBox);
                    if (chkRow.Checked)
                    {
                        row.BackColor = Color.Orange;
                        string fid = row.Cells[1].Text;

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var items_user = (from c in data_user.inf_fiscales
                                              where c.rfc == fid
                                              select c).FirstOrDefault();

                            id_fuser = items_user.id_fiscales;
                        }

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var inf_user = (from i_f in data_user.inf_fiscales
                                            join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                            where i_f.id_tipo_fiscales == 3
                                            where i_f.id_estatus == 1
                                            select new
                                            {
                                                i_f.id_tipo_rfc,
                                                i_tf.desc_tipo_rfc,
                                                i_f.rfc,
                                                i_f.razon_social,
                                                i_f.telefono,
                                                i_f.email,
                                                i_f.calle,
                                                i_f.cp,
                                                i_f.id_asenta_cpcons,


                                            }).ToList();

                            using (db_posEntities db_sepomex = new db_posEntities())
                            {
                                var tbl_sepomex = (from c in db_sepomex.fact_tipo_rfc
                                                   select c).ToList();
                                ddl_tiporfc_contribuyente.DataSource = tbl_sepomex;
                                ddl_tiporfc_contribuyente.DataTextField = "desc_tipo_rfc";
                                ddl_tiporfc_contribuyente.DataValueField = "id_tipo_rfc";
                                ddl_tiporfc_contribuyente.DataBind();
                                ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));
                            }
                            ddl_tiporfc_contribuyente.SelectedValue = inf_user[0].id_tipo_rfc.ToString();

                            txt_rfc_contribuyentes.Text = inf_user[0].rfc;
                            txt_rs_contribuyentes.Text = inf_user[0].razon_social;
                            txt_telefono_contribuyentes.Text = inf_user[0].telefono;
                            txt_email_contribuyentes.Text = inf_user[0].email;
                            txt_calle_contribuyentes.Text = inf_user[0].calle;
                            txt_cp_contribuyentes.Text = inf_user[0].cp;

                            int int_fidasenta = inf_user[0].id_asenta_cpcons.Value;
                            string str_fcp = inf_user[0].cp.ToString();
                            using (db_posEntities db_sepomex = new db_posEntities())
                            {
                                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                                   where c.id_asenta_cpcons == int_fidasenta
                                                   where c.d_codigo == str_fcp
                                                   select c).ToList();

                                ddl_colonia_contribuyentes.DataSource = tbl_sepomex;
                                ddl_colonia_contribuyentes.DataTextField = "d_asenta";
                                ddl_colonia_contribuyentes.DataValueField = "id_asenta_cpcons";
                                ddl_colonia_contribuyentes.DataBind();

                                txt_municipio_contribuyentes.Text = tbl_sepomex[0].D_mnpio;
                                txt_estado_contribuyentes.Text = tbl_sepomex[0].d_estado;
                            }
                        }
                    }
                    else
                    {
                        row.BackColor = Color.White;
                    }
                }
            }
        }
        #endregion

        #region proveedores
        protected void chkb_proveedores_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void cmd_vcp_proveedores_Click(object sender, EventArgs e)
        {
            string str_codigo = txt_cp_proveedores.Text;

            using (db_posEntities db_sepomex = new db_posEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                   where c.d_codigo == str_codigo
                                   select c).ToList();

                ddl_colonia_proveedores.DataSource = tbl_sepomex;
                ddl_colonia_proveedores.DataTextField = "d_asenta";
                ddl_colonia_proveedores.DataValueField = "id_asenta_cpcons";
                ddl_colonia_proveedores.DataBind();

                if (tbl_sepomex.Count == 1)
                {
                    txt_municipio_proveedores.Text = tbl_sepomex[0].D_mnpio;
                    txt_estado_proveedores.Text = tbl_sepomex[0].d_estado;
                }
                if (tbl_sepomex.Count > 1)
                {

                    ddl_colonia_proveedores.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));

                    txt_municipio_proveedores.Text = tbl_sepomex[0].D_mnpio;
                    txt_estado_proveedores.Text = tbl_sepomex[0].d_estado;
                }
                else if (tbl_sepomex.Count == 0)
                {

                    lblModalTitle.Text = "POS Punto Cero";
                    lblModalBody.Text = "Error de Código Postal, favor de reintentar";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                    upModal.Update();
                    limpia_infempresa();
                }
            }
        }

        protected void cmd_guarda_proveedores_Click(object sender, EventArgs e)
        {
            if (rb_agregar_proveedores.Checked == false & rb_editar_proveedores.Checked == false & rb_eliminar_proveedores.Checked == false)
            {

                lblModalTitle.Text = "POS Punto Cero";
                lblModalBody.Text = "Favor de seleccionar una acción";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                upModal.Update();

            }
            else
            {
                Guid n_fiscal = Guid.NewGuid();
                int int_idtiporfc = Convert.ToInt32(ddl_tiporfc_contribuyente.SelectedValue);
                string str_rfc = txt_rfc_proveedores.Text;
                string str_razonsocial = txt_rs_proveedores.Text;
                string str_calle = txt_calle_proveedores.Text.ToUpper();
                string str_cp = txt_cp_proveedores.Text;
                int int_colonia = Convert.ToInt32(ddl_colonia_proveedores.SelectedValue);
                string str_telefono = txt_telefono_proveedores.Text;
                string str_email = txt_email_proveedores.Text;
                string str_filtro_rfc;

                if (rb_agregar_proveedores.Checked)
                {

                    try
                    {

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var items_user = (from c in data_user.inf_fiscales
                                              where c.rfc == str_rfc
                                              select c).FirstOrDefault();

                            str_filtro_rfc = items_user.rfc.ToString();
                        }

                        if (str_rfc == str_filtro_rfc)
                        {
                            limpiar_infusuario();
                            lblModalTitle.Text = "POS Punto Cero";
                            lblModalBody.Text = "RFC ya existe en la base, agregar otro usuario";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                            upModal.Update();
                        }
                    }
                    catch
                    {
                        using (var insert_user = new db_posEntities())
                        {
                            var items_user = new inf_fiscales
                            {
                                id_fiscales = n_fiscal,
                                id_tipo_rfc = int_idtiporfc,
                                rfc = str_rfc,
                                razon_social = str_razonsocial,
                                telefono = str_telefono,
                                email = str_email,
                                calle = str_calle,
                                cp = str_cp,
                                id_tipo_fiscales = 2,
                                id_asenta_cpcons = int_colonia,
                                id_estatus = 1,
                                fecha_registro = DateTime.Now,
                                id_empresa = idrazonsocial
                            };
                            insert_user.inf_fiscales.Add(items_user);
                            insert_user.SaveChanges();
                        }

                        rfv_tiporfc_contribuyente.Visible = false;
                        rfv_rfc_proveedores.Visible = false;
                        rfv_rs_proveedores.Visible = false;
                        rfv_calle_proveedores.Visible = false;
                        rfv_telefono_proveedores.Visible = false;
                        rfv_vcp_proveedores.Visible = false;

                        limpiar_proveedores();

                        rb_agregar_proveedores.Checked = false;
                        rb_editar_proveedores.Checked = false;
                        rb_eliminar_proveedores.Checked = false;

                        lblModalTitle.Text = "POS Punto Cero";
                        lblModalBody.Text = "Datos de Contribuyente guardados con éxito";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                        upModal.Update();
                    }
                }
                else if (rb_editar_proveedores.Checked)
                {
                    foreach (GridViewRow row in gv_proveedores.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[1].FindControl("chk_proveedores") as CheckBox);
                            if (chkRow.Checked)
                            {
                                string fid = row.Cells[1].Text;

                                using (db_posEntities data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.rfc == fid
                                                      select c).FirstOrDefault();

                                    f_iduser = items_user.id_fiscales;
                                }

                                using (var data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.id_fiscales == f_iduser
                                                      select c).FirstOrDefault();

                                    items_user.id_tipo_rfc = int_idtiporfc;
                                    items_user.rfc = str_rfc;
                                    items_user.razon_social = str_razonsocial;
                                    items_user.telefono = str_telefono;
                                    items_user.email = str_email;
                                    items_user.calle = str_calle;
                                    items_user.cp = str_cp;
                                    items_user.id_asenta_cpcons = int_colonia;

                                    data_user.SaveChanges();
                                }

                                limpiar_proveedores();

                                rb_agregar_proveedores.Checked = false;
                                rb_editar_proveedores.Checked = false;
                                rb_eliminar_proveedores.Checked = false;

                                gv_usuarios.Visible = false;
                                txt_buscar.Visible = false;
                                cmd_busca_usuario.Visible = false;

                                lblModalTitle.Text = "POS Punto Cero";
                                lblModalBody.Text = "Datos de Contribuyente actualizados con éxito";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                                upModal.Update();
                            }
                        }
                    }
                }

                else if (rb_eliminar_proveedores.Checked)
                {
                    foreach (GridViewRow row in gv_proveedores.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chk_proveedores") as CheckBox);
                            if (chkRow.Checked)
                            {
                                string fid = row.Cells[1].Text;

                                using (db_posEntities data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.rfc == fid
                                                      select c).FirstOrDefault();

                                    f_iduser = items_user.id_fiscales;
                                }

                                using (var data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.id_fiscales == f_iduser
                                                      select c).FirstOrDefault();

                                    items_user.id_estatus = 3;


                                    data_user.SaveChanges();
                                }

                                limpiar_proveedores();

                                rb_agregar_proveedores.Checked = false;
                                rb_editar_proveedores.Checked = false;
                                rb_eliminar_proveedores.Checked = false;

                                gv_usuarios.Visible = false;
                                txt_buscar.Visible = false;
                                cmd_busca_usuario.Visible = false;

                                lblModalTitle.Text = "POS Punto Cero";
                                lblModalBody.Text = "Datos de Contribuyente eliminados con éxito";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                                upModal.Update();
                            }
                        }
                    }
                }
            }
        }

        private void limpiar_proveedores()
        {
            ddl_tiporfc_contribuyente.Items.Clear();
            ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));
            ddl_tiporfc_contribuyente.SelectedValue = "0";
            txt_rfc_proveedores.Text = "";
            txt_rs_proveedores.Text = "";
            txt_telefono_proveedores.Text = "";
            txt_email_proveedores.Text = "";
            txt_calle_proveedores.Text = "";
            txt_cp_proveedores.Text = "";
            ddl_colonia_proveedores.Items.Clear();
            ddl_colonia_proveedores.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));
            ddl_colonia_proveedores.SelectedValue = "0";
            txt_municipio_proveedores.Text = "";
            txt_estado_proveedores.Text = "";
        }

        protected void rb_agregar_proveedores_CheckedChanged(object sender, EventArgs e)
        {
            rb_editar_proveedores.Checked = false;
            rb_eliminar_proveedores.Checked = false;

            txt_buscar_proveedores.Visible = false;
            cmd_buscar_proveedores.Visible = false;
            gv_proveedores.Visible = false;

            using (db_posEntities db_sepomex = new db_posEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.fact_tipo_rfc

                                   select c).ToList();

                ddl_tiporfc_contribuyente.DataSource = tbl_sepomex;
                ddl_tiporfc_contribuyente.DataTextField = "desc_tipo_rfc";
                ddl_tiporfc_contribuyente.DataValueField = "id_tipo_rfc";
                ddl_tiporfc_contribuyente.DataBind();
                ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));

                rfv_tiporfc_contribuyente.Visible = true;
                rfv_rfc_proveedores.Visible = true;
                rfv_rs_proveedores.Visible = true;
                rfv_calle_proveedores.Visible = true;
                rfv_telefono_proveedores.Visible = true;
                rfv_vcp_proveedores.Visible = true;
                limpiar_proveedores();
            }
        }

        protected void rb_editar_proveedores_CheckedChanged(object sender, EventArgs e)
        {
            rb_agregar_proveedores.Checked = false;
            rb_eliminar_proveedores.Checked = false;

            txt_buscar_proveedores.Visible = true;
            cmd_buscar_proveedores.Visible = true;

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_f in data_user.inf_fiscales
                                join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                where i_f.id_tipo_fiscales == 2
                                where i_f.id_estatus == 1
                                select new
                                {
                                    i_f.rfc,
                                    i_tf.desc_tipo_rfc,
                                    i_f.razon_social,
                                    i_f.fecha_registro

                                }).ToList();

                gv_proveedores.DataSource = inf_user;
                gv_proveedores.DataBind();
                gv_proveedores.Visible = true;
            }

            limpiar_proveedores();

            rfv_tiporfc_contribuyente.Visible = false;
            rfv_rfc_proveedores.Visible = false;
            rfv_rs_proveedores.Visible = false;
            rfv_calle_proveedores.Visible = false;
            rfv_telefono_proveedores.Visible = false;
            rfv_vcp_proveedores.Visible = false;
        }

        protected void rb_eliminar_proveedores_CheckedChanged(object sender, EventArgs e)
        {
            rb_editar_proveedores.Checked = false;
            rb_agregar_proveedores.Checked = false;
            txt_buscar_proveedores.Visible = true;
            cmd_buscar_proveedores.Visible = true;

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_f in data_user.inf_fiscales
                                join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                where i_f.id_tipo_fiscales == 2
                                where i_f.id_estatus == 1
                                select new
                                {
                                    i_f.rfc,
                                    i_tf.desc_tipo_rfc,
                                    i_f.razon_social,
                                    i_f.fecha_registro

                                }).ToList();

                gv_proveedores.DataSource = inf_user;
                gv_proveedores.DataBind();
                gv_proveedores.Visible = true;
            }
            limpiar_proveedores();
            rfv_tiporfc_contribuyente.Visible = false;
            rfv_rfc_proveedores.Visible = false;
            rfv_rs_proveedores.Visible = false;
            rfv_calle_proveedores.Visible = false;
            rfv_telefono_proveedores.Visible = false;
            rfv_vcp_proveedores.Visible = false;
        }

        protected void cmd_buscar_proveedores_Click(object sender, EventArgs e)
        {
            string str_userb = txt_buscar_proveedores.Text;

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_f in data_user.inf_fiscales
                                join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                where i_f.razon_social.Contains(str_userb)
                                where i_f.id_tipo_fiscales == 2
                                where i_f.id_estatus == 1
                                select new
                                {
                                    i_f.rfc,
                                    i_tf.desc_tipo_rfc,
                                    i_f.razon_social,
                                    i_f.fecha_registro

                                }).ToList();

                gv_proveedores.DataSource = inf_user;
                gv_proveedores.DataBind();
                gv_proveedores.Visible = true;
            }
        }

        protected void gv_proveedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void chk_proveedores_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gv_proveedores.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chk_proveedores") as CheckBox);
                    if (chkRow.Checked)
                    {
                        row.BackColor = Color.Orange;
                        string fid = row.Cells[1].Text;

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var items_user = (from c in data_user.inf_fiscales
                                              where c.rfc == fid
                                              select c).FirstOrDefault();

                            id_fuser = items_user.id_fiscales;
                        }

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var inf_user = (from i_f in data_user.inf_fiscales
                                            join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                            where i_f.id_tipo_fiscales == 2
                                            where i_f.id_estatus == 1
                                            select new
                                            {
                                                i_f.id_tipo_rfc,
                                                i_tf.desc_tipo_rfc,
                                                i_f.rfc,
                                                i_f.razon_social,
                                                i_f.telefono,
                                                i_f.email,
                                                i_f.calle,
                                                i_f.cp,
                                                i_f.id_asenta_cpcons,


                                            }).ToList();

                            using (db_posEntities db_sepomex = new db_posEntities())
                            {
                                var tbl_sepomex = (from c in db_sepomex.fact_tipo_rfc
                                                   select c).ToList();
                                ddl_tiporfc_contribuyente.DataSource = tbl_sepomex;
                                ddl_tiporfc_contribuyente.DataTextField = "desc_tipo_rfc";
                                ddl_tiporfc_contribuyente.DataValueField = "id_tipo_rfc";
                                ddl_tiporfc_contribuyente.DataBind();
                                ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));
                            }
                            ddl_tiporfc_contribuyente.SelectedValue = inf_user[0].id_tipo_rfc.ToString();

                            txt_rfc_proveedores.Text = inf_user[0].rfc;
                            txt_rs_proveedores.Text = inf_user[0].razon_social;
                            txt_telefono_proveedores.Text = inf_user[0].telefono;
                            txt_email_proveedores.Text = inf_user[0].email;
                            txt_calle_proveedores.Text = inf_user[0].calle;
                            txt_cp_proveedores.Text = inf_user[0].cp;

                            int int_fidasenta = inf_user[0].id_asenta_cpcons.Value;
                            string str_fcp = inf_user[0].cp.ToString();
                            using (db_posEntities db_sepomex = new db_posEntities())
                            {
                                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                                   where c.id_asenta_cpcons == int_fidasenta
                                                   where c.d_codigo == str_fcp
                                                   select c).ToList();

                                ddl_colonia_proveedores.DataSource = tbl_sepomex;
                                ddl_colonia_proveedores.DataTextField = "d_asenta";
                                ddl_colonia_proveedores.DataValueField = "id_asenta_cpcons";
                                ddl_colonia_proveedores.DataBind();

                                txt_municipio_proveedores.Text = tbl_sepomex[0].D_mnpio;
                                txt_estado_proveedores.Text = tbl_sepomex[0].d_estado;
                            }
                        }
                    }
                    else
                    {
                        row.BackColor = Color.White;
                    }
                }
            }
        }
        #endregion

        #region clientes
        protected void chkb_clientes_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void cmd_vcp_clientes_Click(object sender, EventArgs e)
        {
            string str_codigo = txt_cp_clientes.Text;

            using (db_posEntities db_sepomex = new db_posEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                   where c.d_codigo == str_codigo
                                   select c).ToList();

                ddl_colonia_clientes.DataSource = tbl_sepomex;
                ddl_colonia_clientes.DataTextField = "d_asenta";
                ddl_colonia_clientes.DataValueField = "id_asenta_cpcons";
                ddl_colonia_clientes.DataBind();

                if (tbl_sepomex.Count == 1)
                {
                    txt_municipio_clientes.Text = tbl_sepomex[0].D_mnpio;
                    txt_estado_clientes.Text = tbl_sepomex[0].d_estado;
                }
                if (tbl_sepomex.Count > 1)
                {

                    ddl_colonia_clientes.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));

                    txt_municipio_clientes.Text = tbl_sepomex[0].D_mnpio;
                    txt_estado_clientes.Text = tbl_sepomex[0].d_estado;
                }
                else if (tbl_sepomex.Count == 0)
                {

                    lblModalTitle.Text = "POS Punto Cero";
                    lblModalBody.Text = "Error de Código Postal, favor de reintentar";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                    upModal.Update();
                    limpia_infempresa();
                }
            }
        }

        protected void cmd_guarda_clientes_Click(object sender, EventArgs e)
        {
            if (rb_agregar_clientes.Checked == false & rb_editar_clientes.Checked == false & rb_eliminar_clientes.Checked == false)
            {

                lblModalTitle.Text = "POS Punto Cero";
                lblModalBody.Text = "Favor de seleccionar una acción";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                upModal.Update();

            }
            else
            {
                Guid n_fiscal = Guid.NewGuid();
                int int_idtiporfc = Convert.ToInt32(ddl_tiporfc_contribuyente.SelectedValue);
                string str_rfc = txt_rfc_clientes.Text;
                string str_razonsocial = txt_rs_clientes.Text;
                string str_calle = txt_calle_clientes.Text.ToUpper();
                string str_cp = txt_cp_clientes.Text;
                int int_colonia = Convert.ToInt32(ddl_colonia_clientes.SelectedValue);
                string str_telefono = txt_telefono_clientes.Text;
                string str_email = txt_email_clientes.Text;
                string str_filtro_rfc;

                if (rb_agregar_clientes.Checked)
                {

                    try
                    {

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var items_user = (from c in data_user.inf_fiscales
                                              where c.rfc == str_rfc
                                              select c).FirstOrDefault();

                            str_filtro_rfc = items_user.rfc.ToString();
                        }

                        if (str_rfc == str_filtro_rfc)
                        {
                            limpiar_infusuario();
                            lblModalTitle.Text = "POS Punto Cero";
                            lblModalBody.Text = "RFC ya existe en la base, agregar otro usuario";
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                            upModal.Update();
                        }
                    }
                    catch
                    {
                        using (var insert_user = new db_posEntities())
                        {
                            var items_user = new inf_fiscales
                            {
                                id_fiscales = n_fiscal,
                                id_tipo_rfc = int_idtiporfc,
                                rfc = str_rfc,
                                razon_social = str_razonsocial,
                                telefono = str_telefono,
                                email = str_email,
                                calle = str_calle,
                                cp = str_cp,
                                id_tipo_fiscales = 2,
                                id_asenta_cpcons = int_colonia,
                                id_estatus = 1,
                                fecha_registro = DateTime.Now,
                                id_empresa = idrazonsocial
                            };
                            insert_user.inf_fiscales.Add(items_user);
                            insert_user.SaveChanges();
                        }

                        rfv_tiporfc_contribuyente.Visible = false;
                        rfv_rfc_clientes.Visible = false;
                        rfv_rs_clientes.Visible = false;
                        rfv_calle_clientes.Visible = false;
                        rfv_telefono_clientes.Visible = false;
                        rfv_vcp_clientes.Visible = false;

                        limpiar_clientes();

                        rb_agregar_clientes.Checked = false;
                        rb_editar_clientes.Checked = false;
                        rb_eliminar_clientes.Checked = false;

                        lblModalTitle.Text = "POS Punto Cero";
                        lblModalBody.Text = "Datos de Contribuyente guardados con éxito";
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                        upModal.Update();
                    }
                }
                else if (rb_editar_clientes.Checked)
                {
                    foreach (GridViewRow row in gv_clientes.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[1].FindControl("chk_clientes") as CheckBox);
                            if (chkRow.Checked)
                            {
                                string fid = row.Cells[1].Text;

                                using (db_posEntities data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.rfc == fid
                                                      select c).FirstOrDefault();

                                    f_iduser = items_user.id_fiscales;
                                }

                                using (var data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.id_fiscales == f_iduser
                                                      select c).FirstOrDefault();

                                    items_user.id_tipo_rfc = int_idtiporfc;
                                    items_user.rfc = str_rfc;
                                    items_user.razon_social = str_razonsocial;
                                    items_user.telefono = str_telefono;
                                    items_user.email = str_email;
                                    items_user.calle = str_calle;
                                    items_user.cp = str_cp;
                                    items_user.id_asenta_cpcons = int_colonia;

                                    data_user.SaveChanges();
                                }

                                limpiar_clientes();

                                rb_agregar_clientes.Checked = false;
                                rb_editar_clientes.Checked = false;
                                rb_eliminar_clientes.Checked = false;

                                gv_usuarios.Visible = false;
                                txt_buscar.Visible = false;
                                cmd_busca_usuario.Visible = false;

                                lblModalTitle.Text = "POS Punto Cero";
                                lblModalBody.Text = "Datos de Contribuyente actualizados con éxito";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                                upModal.Update();
                            }
                        }
                    }
                }

                else if (rb_eliminar_clientes.Checked)
                {
                    foreach (GridViewRow row in gv_clientes.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chk_clientes") as CheckBox);
                            if (chkRow.Checked)
                            {
                                string fid = row.Cells[1].Text;

                                using (db_posEntities data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.rfc == fid
                                                      select c).FirstOrDefault();

                                    f_iduser = items_user.id_fiscales;
                                }

                                using (var data_user = new db_posEntities())
                                {
                                    var items_user = (from c in data_user.inf_fiscales
                                                      where c.id_fiscales == f_iduser
                                                      select c).FirstOrDefault();

                                    items_user.id_estatus = 3;


                                    data_user.SaveChanges();
                                }

                                limpiar_clientes();

                                rb_agregar_clientes.Checked = false;
                                rb_editar_clientes.Checked = false;
                                rb_eliminar_clientes.Checked = false;

                                gv_usuarios.Visible = false;
                                txt_buscar.Visible = false;
                                cmd_busca_usuario.Visible = false;

                                lblModalTitle.Text = "POS Punto Cero";
                                lblModalBody.Text = "Datos de Contribuyente eliminados con éxito";
                                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                                upModal.Update();
                            }
                        }
                    }
                }
            }
        }

        private void limpiar_clientes()
        {
            ddl_tiporfc_contribuyente.Items.Clear();
            ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));
            ddl_tiporfc_contribuyente.SelectedValue = "0";
            txt_rfc_clientes.Text = "";
            txt_rs_clientes.Text = "";
            txt_telefono_clientes.Text = "";
            txt_email_clientes.Text = "";
            txt_calle_clientes.Text = "";
            txt_cp_clientes.Text = "";
            ddl_colonia_clientes.Items.Clear();
            ddl_colonia_clientes.Items.Insert(0, new ListItem("Seleccionar Colonia", "0"));
            ddl_colonia_clientes.SelectedValue = "0";
            txt_municipio_clientes.Text = "";
            txt_estado_clientes.Text = "";
        }

        protected void rb_agregar_clientes_CheckedChanged(object sender, EventArgs e)
        {
            rb_editar_clientes.Checked = false;
            rb_eliminar_clientes.Checked = false;

            txt_buscar_clientes.Visible = false;
            cmd_buscar_clientes.Visible = false;
            gv_clientes.Visible = false;

            using (db_posEntities db_sepomex = new db_posEntities())
            {
                var tbl_sepomex = (from c in db_sepomex.fact_tipo_rfc

                                   select c).ToList();

                ddl_tiporfc_contribuyente.DataSource = tbl_sepomex;
                ddl_tiporfc_contribuyente.DataTextField = "desc_tipo_rfc";
                ddl_tiporfc_contribuyente.DataValueField = "id_tipo_rfc";
                ddl_tiporfc_contribuyente.DataBind();
                ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));

                rfv_tiporfc_contribuyente.Visible = true;
                rfv_rfc_clientes.Visible = true;
                rfv_rs_clientes.Visible = true;
                rfv_calle_clientes.Visible = true;
                rfv_telefono_clientes.Visible = true;
                rfv_vcp_clientes.Visible = true;
                limpiar_clientes();
            }
        }

        protected void rb_editar_clientes_CheckedChanged(object sender, EventArgs e)
        {
            rb_agregar_clientes.Checked = false;
            rb_eliminar_clientes.Checked = false;

            txt_buscar_clientes.Visible = true;
            cmd_buscar_clientes.Visible = true;

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_f in data_user.inf_fiscales
                                join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                where i_f.id_tipo_fiscales == 2
                                where i_f.id_estatus == 1
                                select new
                                {
                                    i_f.rfc,
                                    i_tf.desc_tipo_rfc,
                                    i_f.razon_social,
                                    i_f.fecha_registro

                                }).ToList();

                gv_clientes.DataSource = inf_user;
                gv_clientes.DataBind();
                gv_clientes.Visible = true;
            }

            limpiar_clientes();

            rfv_tiporfc_contribuyente.Visible = false;
            rfv_rfc_clientes.Visible = false;
            rfv_rs_clientes.Visible = false;
            rfv_calle_clientes.Visible = false;
            rfv_telefono_clientes.Visible = false;
            rfv_vcp_clientes.Visible = false;
        }

        protected void rb_eliminar_clientes_CheckedChanged(object sender, EventArgs e)
        {
            rb_editar_clientes.Checked = false;
            rb_agregar_clientes.Checked = false;
            txt_buscar_clientes.Visible = true;
            cmd_buscar_clientes.Visible = true;

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_f in data_user.inf_fiscales
                                join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                where i_f.id_tipo_fiscales == 2
                                where i_f.id_estatus == 1
                                select new
                                {
                                    i_f.rfc,
                                    i_tf.desc_tipo_rfc,
                                    i_f.razon_social,
                                    i_f.fecha_registro

                                }).ToList();

                gv_clientes.DataSource = inf_user;
                gv_clientes.DataBind();
                gv_clientes.Visible = true;
            }
            limpiar_clientes();
            rfv_tiporfc_contribuyente.Visible = false;
            rfv_rfc_clientes.Visible = false;
            rfv_rs_clientes.Visible = false;
            rfv_calle_clientes.Visible = false;
            rfv_telefono_clientes.Visible = false;
            rfv_vcp_clientes.Visible = false;
        }

        protected void cmd_buscar_clientes_Click(object sender, EventArgs e)
        {
            string str_userb = txt_buscar_clientes.Text;

            using (db_posEntities data_user = new db_posEntities())
            {
                var inf_user = (from i_f in data_user.inf_fiscales
                                join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                where i_f.razon_social.Contains(str_userb)
                                where i_f.id_tipo_fiscales == 2
                                where i_f.id_estatus == 1
                                select new
                                {
                                    i_f.rfc,
                                    i_tf.desc_tipo_rfc,
                                    i_f.razon_social,
                                    i_f.fecha_registro

                                }).ToList();

                gv_clientes.DataSource = inf_user;
                gv_clientes.DataBind();
                gv_clientes.Visible = true;
            }
        }

        protected void gv_clientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void chk_clientes_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gv_clientes.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chk_clientes") as CheckBox);
                    if (chkRow.Checked)
                    {
                        row.BackColor = Color.Orange;
                        string fid = row.Cells[1].Text;

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var items_user = (from c in data_user.inf_fiscales
                                              where c.rfc == fid
                                              select c).FirstOrDefault();

                            id_fuser = items_user.id_fiscales;
                        }

                        using (db_posEntities data_user = new db_posEntities())
                        {
                            var inf_user = (from i_f in data_user.inf_fiscales
                                            join i_tf in data_user.fact_tipo_rfc on i_f.id_tipo_rfc equals i_tf.id_tipo_rfc
                                            where i_f.id_tipo_fiscales == 2
                                            where i_f.id_estatus == 1
                                            select new
                                            {
                                                i_f.id_tipo_rfc,
                                                i_tf.desc_tipo_rfc,
                                                i_f.rfc,
                                                i_f.razon_social,
                                                i_f.telefono,
                                                i_f.email,
                                                i_f.calle,
                                                i_f.cp,
                                                i_f.id_asenta_cpcons,


                                            }).ToList();

                            using (db_posEntities db_sepomex = new db_posEntities())
                            {
                                var tbl_sepomex = (from c in db_sepomex.fact_tipo_rfc
                                                   select c).ToList();
                                ddl_tiporfc_contribuyente.DataSource = tbl_sepomex;
                                ddl_tiporfc_contribuyente.DataTextField = "desc_tipo_rfc";
                                ddl_tiporfc_contribuyente.DataValueField = "id_tipo_rfc";
                                ddl_tiporfc_contribuyente.DataBind();
                                ddl_tiporfc_contribuyente.Items.Insert(0, new ListItem("Seleccionar tipo RFC", "0"));
                            }
                            ddl_tiporfc_contribuyente.SelectedValue = inf_user[0].id_tipo_rfc.ToString();

                            txt_rfc_clientes.Text = inf_user[0].rfc;
                            txt_rs_clientes.Text = inf_user[0].razon_social;
                            txt_telefono_clientes.Text = inf_user[0].telefono;
                            txt_email_clientes.Text = inf_user[0].email;
                            txt_calle_clientes.Text = inf_user[0].calle;
                            txt_cp_clientes.Text = inf_user[0].cp;

                            int int_fidasenta = inf_user[0].id_asenta_cpcons.Value;
                            string str_fcp = inf_user[0].cp.ToString();
                            using (db_posEntities db_sepomex = new db_posEntities())
                            {
                                var tbl_sepomex = (from c in db_sepomex.inf_sepomex
                                                   where c.id_asenta_cpcons == int_fidasenta
                                                   where c.d_codigo == str_fcp
                                                   select c).ToList();

                                ddl_colonia_clientes.DataSource = tbl_sepomex;
                                ddl_colonia_clientes.DataTextField = "d_asenta";
                                ddl_colonia_clientes.DataValueField = "id_asenta_cpcons";
                                ddl_colonia_clientes.DataBind();

                                txt_municipio_clientes.Text = tbl_sepomex[0].D_mnpio;
                                txt_estado_clientes.Text = tbl_sepomex[0].d_estado;
                            }
                        }
                    }
                    else
                    {
                        row.BackColor = Color.White;
                    }
                }
            }
        }
        #endregion
    }
}