using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CidadeInteligente
{
    public partial class formCliente : Form
    {
        string id = null;
        public formCliente()
        {
            InitializeComponent();
        }

        private void retornarPessoas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=123;Integrated Security=SSPI;User ID=sa123;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=DESKTOP-GAMER";
            conexao.Open();

            string comandoSQL = "SELECT idCliente as 'ID do cliente', idPessoa as 'ID da pessoa', dtInclusao as 'Data de inclusão' FROM tb_cliente";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvClientes.DataSource = dt;

            conexao.Close();

        }

        private void CadastrarCliente(string idPessoa, string dtDataInclusao)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=123;Integrated Security=SSPI;User ID=sa123;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=DESKTOP-GAMER";

            //abrir conexão
            conexao.Open();

            //condições para definir se é um update ou um insert
            string stringSQl = null;
            if (id != null)//caso o valor da variavel id não seja nulo, a operação sera o update
            //o valor de id deixará de ser nulo quando o usuário clicar na tabela com a intenção de fazer uma alteração nos dados
            {
                stringSQl = string.Concat("update tb_cliente set idPessoa = '", idPessoa, "', dtInclusao = '", dtDataInclusao, "' where idCliente = ", id);
            }
            else
            {
                stringSQl = string.Concat("insert into tb_cliente values ('", idPessoa, "', '", dtDataInclusao, "')");
            }
            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(stringSQl, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void LimparCampos()
        {
            id = null;
            txbId.Text = "";
            dtpDataInclusao.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CadastrarCliente(txbId.Text, System.DateTime.Parse(dtpDataInclusao.Text).ToString("yyyy-MM-dd"));
            LimparCampos();
            retornarPessoas();
            MessageBox.Show("Operação efetuada com sucesso", "Cidade Inteligente");
        }

        private void formCliente_Load(object sender, EventArgs e)
        {
            retornarPessoas();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ao clicar duas vezes em uma celula, os valor da linhas são capturados e inseridos nos campos de cadastro
            id = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbId.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpDataInclusao.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
