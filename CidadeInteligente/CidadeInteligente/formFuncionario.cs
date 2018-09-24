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
    public partial class formFuncionario : Form
    {
        string id = null;
        public formFuncionario()
        {
            InitializeComponent();
        }

        private void retornarPessoas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=;Integrated Security=SSPI;User ID=;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=";
            conexao.Open();

            SqlCommand sqlCommand = new SqlCommand("sp_retornarFuncionarios", conexao);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvFuncionarios.DataSource = dt;

            conexao.Close();

        }

        private void CadastrarFuncionario(string idPessoa, string nmCargo, string nrSalario, string nrRamal)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=;Integrated Security=SSPI;User ID=;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=";

            //abrir conexão
            conexao.Open();

            //condições para definir se é um update ou um insert
            string stringSQl = null;
            if (id != null)//caso o valor da variavel id não seja nulo, a operação sera o update
            //o valor de id deixará de ser nulo quando o usuário clicar na tabela com a intenção de fazer uma alteração nos dados
            {
                stringSQl = "sp_atualizarFuncionario";
            }
            else
            {
                stringSQl = "sp_inserirFuncionario";
            }
            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(stringSQl, conexao);
            comandaSQL.CommandType = CommandType.StoredProcedure;

            if (id != null)
            {
                comandaSQL.Parameters.AddWithValue("@idFuncionario", id);
            }
            comandaSQL.Parameters.AddWithValue("@idPessoa", idPessoa);
            comandaSQL.Parameters.AddWithValue("@nmCargo", nmCargo);
            comandaSQL.Parameters.AddWithValue("@nrSalario", nrSalario);
            comandaSQL.Parameters.AddWithValue("@nrRamal", nrRamal);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void LimparCampos()
        {
            id = null;
            txbId.Text = "";
            txbCargo.Text = "";
            txbSalario.Text = "";
            txbRamal.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario(txbId.Text, txbCargo.Text, txbSalario.Text.Replace(",","."), txbRamal.Text);
            LimparCampos();
            retornarPessoas();
            MessageBox.Show("Operação efetuada com sucesso", "Cidade Inteligente");
        }

        private void formFuncionario_Load(object sender, EventArgs e)
        {
            retornarPessoas();
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ao clicar duas vezes em uma celula, os valor da linhas são capturados e inseridos nos campos de cadastro
            id = dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbId.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbCargo.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txbSalario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txbRamal.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
