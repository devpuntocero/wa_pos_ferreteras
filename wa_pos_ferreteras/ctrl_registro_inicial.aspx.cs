using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wa_pos_ferreteras
{
    public partial class ctrl_registro_inicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

            }
            else
            {
                if (txt_code_user.Text != "")
                {
                    txt_password.Attributes["value"] = txt_password.Text;
                }
            }

        }
        protected void cmd_save_Click(object sender, EventArgs e)
        {
            Guid id_fempresa = Guid.NewGuid(); ;

            Guid str_iduser = Guid.NewGuid();

            string str_nameuser = txt_name_user.Text.ToUpper();
            string str_apater = txt_apater.Text.ToUpper();
            string str_amater = txt_amater.Text.ToUpper();
            string str_codeuser = txt_code_user.Text.ToLower();
            string str_password = mdl_encrypta.Encrypt(txt_password.Text.ToLower());

            string str_business_name = txt_business_name.Text.ToUpper();



            using (var insert_fiscal = new db_posEntities())
            {
                var items_fiscal = new inf_empresa
                {
                    id_estatus = 1,
                    fecha_registro = DateTime.Now,
                    razon_social = str_business_name,
                    id_empresa = id_fempresa,

                };
                insert_fiscal.inf_empresa.Add(items_fiscal);
                insert_fiscal.SaveChanges();
            }

            using (var insert_user = new db_posEntities())
            {
                var items_user = new inf_usuarios
                {
                    id_usuario = str_iduser,
                    nombres = str_nameuser,
                    a_paterno = str_apater,
                    a_materno = str_amater,
                    id_tipo_usuario = 2,
                    codigo_usuario = str_codeuser,
                    clave = str_password,
                    id_estatus = 1,
                    fecha_registro = DateTime.Now,
                    id_empresa = id_fempresa
                };
                insert_user.inf_usuarios.Add(items_user);
                insert_user.SaveChanges();
            }

            clean_text();
            lblModalTitle.Text = "POS Punto Cero";
            lblModalBody.Text = "Datos de administrador y empresa guardados con éxito";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
        private void clean_text()
        {
            txt_name_user.Text = "";
            txt_apater.Text = "";
            txt_amater.Text = "";
            txt_code_user.Text = "";
            txt_password.Text = "";
            txt_business_name.Text = "";
        }
    }
}