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
    public partial class formPessoa : Form
    {
        string id = null; 
        public formPessoa()
        {
            InitializeComponent();
        }

        private void retornarPessoas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=123;Integrated Security=SSPI;User ID=sa123;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=DESKTOP-GAMER";
            conexao.Open();

            string comandoSQL = "SELECT idPessoa as 'ID da pessoa', nmPessoa as 'Nome completo', dsEndereco as 'Endereço', dsEstadoCivil as 'Estado Civil', dtNascimento 'Data de nascimento' FROM tb_pessoa";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPessoas.DataSource = dt;

            conexao.Close();

        }

        private void CadastrarPessoa(string nmCliente, string dsEndereco, string dsEstadoCivil, string dsDataNascimento)
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
                stringSQl = string.Concat("update tb_pessoa set nmPessoa ='", nmCliente, "', dsEndereco = '", dsEndereco, "', dsEstadoCivil = '", dsEstadoCivil, "', dtNascimento = '", dsDataNascimento, "' where idPessoa = ", id);
            }
            else
            {
                stringSQl = string.Concat("insert into tb_pessoa values ('", nmCliente, "', '", dsEndereco, "', '", dsEstadoCivil, "', '", dsDataNascimento, "')");
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
            txbNome.Text = "";
            txbEndereco.Text = "";
            cbxEstadoCivil.Text = "";
            dtpNascimento.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CadastrarPessoa(txbNome.Text, txbEndereco.Text, cbxEstadoCivil.Text, System.DateTime.Parse(dtpNascimento.Text).ToString("yyyy-MM-dd"));
            LimparCampos();
            retornarPessoas();
            MessageBox.Show("Operação efetuada com sucesso", "Cidade Inteligente");
        }

        private void formPessoa_Load(object sender, EventArgs e)
        {
            retornarPessoas();
        }

        private void dgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ao clicar duas vezes em uma celula, os valor da linhas são capturados e inseridos nos campos de cadastro
            id = dgvPessoas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbNome.Text = dgvPessoas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbEndereco.Text = dgvPessoas.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxEstadoCivil.Text = dgvPessoas.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpNascimento.Text = dgvPessoas.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
