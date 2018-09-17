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
            conexao.ConnectionString = "Password=123;Integrated Security=SSPI;User ID=sa123;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=DESKTOP-GAMER";
            conexao.Open();

            string comandoSQL = "SELECT idFuncionario as 'ID do funcionário', idPessoa as 'ID da pessoa', nmCargo as 'Cargo', nrSalario as 'Salário', nrRamal as 'Ramal' FROM tb_funcionario";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvFuncionarios.DataSource = dt;

            conexao.Close();

        }

        private void CadastrarFuncionario(string idPessoa, string dsCargo, string nrSalario, string nrRamal)
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
                stringSQl = string.Concat("update tb_funcionario set idPessoa = '", idPessoa, "', nmCargo = '", dsCargo, "', nrSalario = '", nrSalario, "', nrRamal = '", nrRamal, "' where idFuncionario =", id);
            }
            else
            {
                stringSQl = string.Concat("insert into tb_funcionario values ('", idPessoa, "', '", dsCargo, "', '", nrSalario, "', '", nrRamal, "')");
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
