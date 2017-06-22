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
    public partial class TelaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Sair_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }           

        protected void pg_cadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            string nome = Utils.Tools.validaString(txtPesquisa.Text, "Nome", lblMsg);// Aqui vai receber o texto do txtPesquisa e vai validar se é uma string caso não seja ele vai acusar erro.

            if (nome == null) return; // aqui é uma condição caso o txtPesquisa não seja preenchido.

            using (MySqlConnection conn = Sql.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(@"SELECT tb_cliente.Id 
                FROM tb_cliente WHERE tb_cliente.Nome = @nome", conn))
                {

                    cmd.Parameters.AddWithValue("@nome", nome);


                    using (MySqlDataReader reader = cmd.ExecuteReader()) // Aqui é uma validação que caso o nome não seja encontrado no select ele vai acusar registro não encontrado.
                    {                                                    // caso o nome esteja na tabela ele vai te redirecionar para outra tela.
                        if (reader.Read() == true)
                        {

                            int id = reader.GetInt32(0); // aqui vai ler o id na posição 0, pelo fato que é o primeiro parametro da do select.

                            string URL = string.Format("VisualizarAlterar.aspx?id={0}", Uri.EscapeDataString(id.ToString())); //Atrindo o que a variavel URL  vai receber e quais funções.
                            Response.Redirect(URL); // a URL é atribuidar aqui para fazer a troca de tela.
                        }
                        else
                        {
                            lblMsg.Text = "Registro não Encontrado!";
                        }
                    }
                }
            }
        }
    }
}