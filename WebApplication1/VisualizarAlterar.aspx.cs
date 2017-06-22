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
    public partial class VisualizarAlterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;

            if (IsPostBack == false)
            {
                id = Utils.Tools.validaInt(Request.QueryString["id"], "ID", lblMsg);
                if (id == -1) return;
                Listar(id);
            }
            else
            {
                // O usuário clicou em um botão, ou realizou alguma ação!
            }
        }

        public void Listar(int idt)
        {
            using (MySqlConnection conn = Sql.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                    tb_cliente.Id,
                    tb_cliente.Nome,
                    tb_cliente.`Endereço`,
                    tb_cliente.Bairro,
                    tb_cliente.Cep,
                    tb_cliente.Telefone,
                    tb_cliente.Email
                    FROM tb_cliente
                    WHERE tb_cliente.Id = @id", conn))
                {


                    cmd.Parameters.AddWithValue("@id", idt);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() == true)
                        {
                            int id = reader.GetInt32(0);
                            string nome = reader.GetString(1);
                            string endereco = reader.GetString(2);
                            string bairro = reader.GetString(3);
                            string cep = reader.GetString(4);
                            string telefone = reader.GetString(5);
                            string email = reader.GetString(6);
                           
                           

                            txtNome.Text = nome;
                            txtEndereco.Text = endereco;
                            txtBairro.Text = bairro;
                            txtCep.Text = cep;
                            txtTelefone.Text = telefone;
                            txtEmail.Text = email;                           
                            
                        }
                        else
                        {
                            lblMsg.Text = "Registro não Encontrado";
                        }
                    }                    
                }
            }
        }

        protected void Salvar_Click(object sender, EventArgs e)
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
                using (MySqlCommand cmd = new MySqlCommand(@"UPDATE `tb_cliente`
                    SET `Nome` = @nome,
                     `Endereço` = @endereco,
                     `Bairro` = @bairro,
                     `Cep` = @cep,
                     `Telefone` = @telefone,
                     `Email` = @email
                    WHERE
                        (`Id` = @id)", conn))
                {

                    cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@email", email);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        lblMsg.Text = "Erro ao Alterar";
                    }
                    else
                    {
                        lblMsg.Text = "Salvo com Sucesso!";
                    }
                }
            }
        }

        protected void cliqueCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TelaUsuario.aspx");
        }

        protected void Deletar_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string nome = txtNome.Text;

            string URL = string.Format("TelaExcluir.aspx?id={0}&n={1}",
                                Uri.EscapeDataString(id), Uri.EscapeDataString(nome));
            Response.Redirect(URL);
        }
    }
}