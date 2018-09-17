namespace CidadeInteligente
{
    partial class formPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.cbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 82);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(80, 20);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(423, 82);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(159, 20);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "Data de nascimento";
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viúvo(a)"});
            this.cbxEstadoCivil.Location = new System.Drawing.Point(612, 34);
            this.cbxEstadoCivil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(121, 28);
            this.cbxEstadoCivil.TabIndex = 4;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "";
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(612, 78);
            this.dtpNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(121, 27);
            this.dtpNascimento.TabIndex = 5;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(115, 34);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(267, 27);
            this.txbNome.TabIndex = 6;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndereco.Location = new System.Drawing.Point(115, 80);
            this.txbEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(267, 27);
            this.txbEndereco.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(284, 137);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(84, 35);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(51, 194);
            this.dgvPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.Size = new System.Drawing.Size(685, 197);
            this.dgvPessoas.TabIndex = 9;
            this.dgvPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoas_CellDoubleClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(415, 137);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 35);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // formPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 431);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvPessoas);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.cbxEstadoCivil);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formPessoa";
            this.Text = "Cadastro de Pessoa";
            this.Load += new System.EventHandler(this.formPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.ComboBox cbxEstadoCivil;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.Button btnLimpar;
    }
}