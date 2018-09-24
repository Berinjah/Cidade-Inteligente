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

        private void retornarDocumentoPessoa()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=;Integrated Security=SSPI;User ID=;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source="; 
            conexao.Open();

            SqlCommand sqlCommand = new SqlCommand("sp_retornarDocumentoPessoa", conexao);

            sqlCommand.CommandType = CommandType.StoredProcedure;

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
            conexao.ConnectionString = "Password=;Integrated Security=SSPI;User ID=;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=";

            //abrir conexão
            conexao.Open();

            //condições para definir se é um update ou um insert
            string stringSQl = null;
            if (id != null)//caso o valor da variavel id não seja nulo, a operação sera o update
            //o valor de id deixará de ser nulo quando o usuário clicar na tabela com a intenção de fazer uma alteração nos dados
            {
                stringSQl = "sp_atualizarDocumentoPessoa";
            }
            else
            {
                stringSQl = "sp_inserirDocumentoPessoa";
            }

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(stringSQl, conexao);
            comandaSQL.CommandType = CommandType.StoredProcedure;

            if (id != null)
            {
                comandaSQL.Parameters.AddWithValue("@idPessoaDocumento", id);
            }
            comandaSQL.Parameters.AddWithValue("@idPessoa", idPessoa);
            comandaSQL.Parameters.AddWithValue("@nrRg", nrRg);
            comandaSQL.Parameters.AddWithValue("@nrCpf", nrCpf);
            comandaSQL.Parameters.AddWithValue("@nrReservista", nrReservista);
            comandaSQL.Parameters.AddWithValue("@nrCarteiraTrabalho", nrCarteiraTrabalho);
            comandaSQL.Parameters.AddWithValue("@nrCnh", nrCnh);

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
            retornarDocumentoPessoa();
            MessageBox.Show("Operação efetuada com sucesso", "Cidade Inteligente");
        }

        private void formPessoaDocumentos_Load(object sender, EventArgs e)
        {
            retornarDocumentoPessoa();
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
