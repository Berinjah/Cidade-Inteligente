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
    public partial class formPessoaDocumentos : Form
    {
        string id = null; 
        public formPessoaDocumentos()
        {
            InitializeComponent();
        }

        private void retornarPessoas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=123;Integrated Security=SSPI;User ID=sa123;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=DESKTOP-GAMER";
            conexao.Open();

            string comandoSQL = "SELECT idPessoaDocumento as 'ID dos documentos pessoais', idPessoa as 'ID da pessoa', nrRg as 'RG', nrCpf as 'CPF', nrReservista 'Reservista', nrCarteiraTrabalho 'CTPS', nrCnh 'CNH' FROM tb_pessoaDocumento";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPessoasDoc.DataSource = dt;

            conexao.Close();

        }

        private void CadastrarDocumentos(string idPessoa, string nrRg, string nrCpf, string nrReservista, string nrCarteiraTrabalho, string nrCnh)
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
                stringSQl = string.Concat("update tb_pessoaDocumento set idPessoa = '", idPessoa, "', nrRg =  '", nrRg, "', nrCpf = '", nrCpf, "', nrReservista = '", nrReservista, "', nrCarteiraTrabalho = '", nrCarteiraTrabalho, "', nrCnh = '", nrCnh, "' where idPessoaDocumento = ", id);
            }
            else
            {
                stringSQl = string.Concat("insert into tb_pessoaDocumento values ('", idPessoa, "', '", nrRg, "', '", nrCpf, "', '", nrReservista, "', '", nrCarteiraTrabalho, "', '", nrCnh, "')");
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
            txbRg.Text = "";
            txbCpf.Text = "";
            txbReservista.Text = "";
            txbCtps.Text = "";
            txbCnh.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CadastrarDocumentos(txbId.Text, txbRg.Text, txbCpf.Text, txbReservista.Text, txbCtps.Text, txbCnh.Text);
            LimparCampos();
            retornarPessoas();
            MessageBox.Show("Operação efetuada com sucesso", "Cidade Inteligente");
        }

        private void formPessoaDocumentos_Load(object sender, EventArgs e)
        {
            retornarPessoas();
        }

        private void dgvPessoasDoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ao clicar duas vezes em uma celula, os valor da linhas são capturados e inseridos nos campos de cadastro
            id = dgvPessoasDoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbId.Text = dgvPessoasDoc.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbRg.Text = dgvPessoasDoc.Rows[e.RowIndex].Cells[2].Value.ToString();
            txbCpf.Text = dgvPessoasDoc.Rows[e.RowIndex].Cells[3].Value.ToString();
            txbReservista.Text = dgvPessoasDoc.Rows[e.RowIndex].Cells[4].Value.ToString();
            txbCtps.Text = dgvPessoasDoc.Rows[e.RowIndex].Cells[5].Value.ToString();
            txbCnh.Text = dgvPessoasDoc.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
