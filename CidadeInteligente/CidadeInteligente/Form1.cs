using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CidadeInteligente
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            formPessoa pessoa = new formPessoa();
            pessoa.MdiParent = this;
            pessoa.Show();
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPessoaDocumentos pessoaDoc = new formPessoaDocumentos();
            pessoaDoc.MdiParent = this;
            pessoaDoc.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFuncionario funcionario = new formFuncionario();
            funcionario.MdiParent = this;
            funcionario.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCliente cliente = new formCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }
    }
}
