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
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cliqueCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TelaUsuario.aspx");// Tem a função de redirecionar para a tela indicada pelas as aspas.
            
        }

        protected void cliqueCadastrar_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            string nome = Utils.Tools.validaString(txtNome.Text, "Nome", lblMsg);
            string endereco = Utils.Tools.validaString(txtEndereco.Text, "Endereco", lblMsg);
            string bairro = Utils.Tools.validaString(txtBairro.Text, "Bairro", lblMsg);
            string cep = Utils.Tools.validaString(txtCep.Text, "Cep", lblMsg);
            string telefone = Utils.Tools.validaString(txtTelefone.Text, "Telefone", lblMsg);
            string email = Utils.Tools.validaString(txtEmail.Text, "Email", lblMsg);
            
            if (nome == null) return;
            if (endereco == null) return;
            if (bairro == null) return;
            if (cep == null) return;
            if (telefone == null) return;
            if (email == null) return;


            using (MySqlConnection conn = Sql.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `tb_cliente` (`Nome`, `Endereço`, `Bairro`, `Cep`, `Telefone`, `Email`) VALUES (@nome, @endereco, @bairro, @cep, @telefone, @email)", conn))
                {
                   
                    
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@email", email);
                    
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        lblMsg.Text = "Erro ao Inserir";
                    }
                    else
                    {
                        lblMsg.Text = "Inserido com Sucesso!";
                    }
                }
            }
        }
    }
}