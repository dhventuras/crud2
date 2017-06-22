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
    public partial class TelaExcluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;

            if (IsPostBack == false)
            {
                id = Utils.Tools.validaInt(Request.QueryString["id"], "ID", lblResultado);
                if (id == -1) return;
                Listar(id);
            }
            else
            {
                
            }
        }
        public void Listar(int idt)
        {
            using (MySqlConnection conn = Sql.OpenConnection())
            {
                
                using (MySqlCommand cmd = new MySqlCommand("SELECT tb_cliente.Nome FROM tb_cliente WHERE tb_cliente.Id = @id ", conn))
                {
                    
                    cmd.Parameters.AddWithValue("@id", idt);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() == true)
                        {
                            msg.InnerHtml = "Você tem Certeza que Deseja Apagar o(a)" + reader.GetString(0) + "?";
                        }
                        else
                        {
                            lblResultado.Text = "Registro não Encontrado";
                        }
                    }
                }
            }
        }

        protected void BtnSim_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Sql.OpenConnection())
            {
                // Cria um comando para atualizar um registro da tabela
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tb_cliente WHERE Id = @id", conn))
                {
                    int id = Utils.Tools.validaInt(Request.QueryString["id"], "ID", lblResultado);
                    if (id == -1) return;

                    cmd.Parameters.AddWithValue("@id", id);
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        lblResultado.Text = "Erro ao deletarr";
                        sucesso.Visible = false;
                        pergunta.Visible = false;
                    }
                    else
                    {
                        sucesso.Visible = true;
                        pergunta.Visible = false;
                    }
                }
            }
        }

        protected void BtnNao_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            string URL = string.Format("VisualizarAlterar.aspx?id={0}",
                                Uri.EscapeDataString(id));
            Response.Redirect(URL);
        }

        protected void BtnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TelaUsuario.aspx");
        }
    }
}