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
            conexao.ConnectionString = "Password=;Integrated Security=SSPI;User ID=;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source="; 
            conexao.Open();

            SqlCommand sqlCommand = new SqlCommand("sp_retornarPessoas", conexao);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPessoas.DataSource = dt;

            conexao.Close();

        }

        private void CadastrarPessoa(string nmPessoa, string dsEndereco, string dsEstadoCivil, string dtNascimento)
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
                stringSQl = "sp_atualizarPessoa";
            }
            else
            {
                stringSQl = "sp_inserirPessoa";
            }

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(stringSQl, conexao);
            comandaSQL.CommandType = CommandType.StoredProcedure;

            if (id != null)
            {
                comandaSQL.Parameters.AddWithValue("@idPessoa", id);
            }
            comandaSQL.Parameters.AddWithValue("@nmPessoa", nmPessoa);
            comandaSQL.Parameters.AddWithValue("@dsEndereco", dsEndereco);
            comandaSQL.Parameters.AddWithValue("@dsEstadoCivil", dsEstadoCivil);
            comandaSQL.Parameters.AddWithValue("@dtNascimento", dtNascimento);

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
            retornarUf();
            
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

        private void retornarUf()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=;Integrated Security=SSPI;User ID=;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=";
            conexao.Open();

            SqlCommand sqlCommand = new SqlCommand("sp_retornarUf", conexao);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            cbxUf.DataSource = dt;

            cbxUf.DisplayMember = "district";

            cbxUf.ValueMember = "district";

            conexao.Close();
        }
        
        private void retornarCidade(string uf)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=;Integrated Security=SSPI;User ID=;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=";
            conexao.Open();

            SqlCommand sqlCommand = new SqlCommand("sp_retornarCidades", conexao);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@district", uf);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            listView1.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                listView1.Items.Add(dr[0].ToString());
            }

            conexao.Close();
        }

        private void cbxUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            retornarCidade(cbxUf.Text);
           
        }
    }
}
