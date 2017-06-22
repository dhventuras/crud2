using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Utils;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string user, pwd;
            user = Utils.Tools.validaString(txtUsuario.Text, "Usuario", lblMsg);
            pwd = Utils.Tools.validaString(txtSenha.Text, "Senha", lblMsg);

            if (user == null) return;
            if (pwd == null) return;

            using (MySqlConnection conn = Sql.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT tb_acesso.Id, tb_acesso.Usuario, tb_acesso.Senha FROM tb_acesso WHERE tb_acesso.Usuario = @user AND tb_acesso.Senha = @pwd",conn))
                {
                    
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                   
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() == true)
                        {
                            Response.Redirect("TelaUsuario.aspx");
                        }
                        else
                        {
                            lblMsg.Text = "Senha incorreta!";
                        }
                    }
                }
            }
        }
    }
}