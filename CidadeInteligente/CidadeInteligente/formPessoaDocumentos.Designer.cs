namespace CidadeInteligente
{
    partial class formPessoaDocumentos
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblReservista = new System.Windows.Forms.Label();
            this.lblCtps = new System.Windows.Forms.Label();
            this.lblCnh = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbReservista = new System.Windows.Forms.TextBox();
            this.txbCtps = new System.Windows.Forms.TextBox();
            this.txbCnh = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgvPessoasDoc = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoasDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(109, 28);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(108, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID da pessoa";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(109, 76);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 1;
            this.lblRg.Text = "RG";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(409, 25);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 20);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF";
            // 
            // lblReservista
            // 
            this.lblReservista.AutoSize = true;
            this.lblReservista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservista.Location = new System.Drawing.Point(409, 76);
            this.lblReservista.Name = "lblReservista";
            this.lblReservista.Size = new System.Drawing.Size(89, 20);
            this.lblReservista.TabIndex = 3;
            this.lblReservista.Text = "Reservista";
            // 
            // lblCtps
            // 
            this.lblCtps.AutoSize = true;
            this.lblCtps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtps.Location = new System.Drawing.Point(705, 28);
            this.lblCtps.Name = "lblCtps";
            this.lblCtps.Size = new System.Drawing.Size(53, 20);
            this.lblCtps.TabIndex = 4;
            this.lblCtps.Text = "CTPS";
            // 
            // lblCnh
            // 
            this.lblCnh.AutoSize = true;
            this.lblCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnh.Location = new System.Drawing.Point(705, 80);
            this.lblCnh.Name = "lblCnh";
            this.lblCnh.Size = new System.Drawing.Size(46, 20);
            this.lblCnh.TabIndex = 5;
            this.lblCnh.Text = "CNH";
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(256, 21);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 27);
            this.txbId.TabIndex = 6;
            // 
            // txbRg
            // 
            this.txbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRg.Location = new System.Drawing.Point(256, 74);
            this.txbRg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(121, 27);
            this.txbRg.TabIndex = 7;
            // 
            // txbCpf
            // 
            this.txbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(535, 21);
            this.txbCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(121, 27);
            this.txbCpf.TabIndex = 8;
            // 
            // txbReservista
            // 
            this.txbReservista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReservista.Location = new System.Drawing.Point(535, 74);
            this.txbReservista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbReservista.Name = "txbReservista";
            this.txbReservista.Size = new System.Drawing.Size(121, 27);
            this.txbReservista.TabIndex = 9;
            // 
            // txbCtps
            // 
            this.txbCtps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCtps.Location = new System.Drawing.Point(797, 21);
            this.txbCtps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCtps.Name = "txbCtps";
            this.txbCtps.Size = new System.Drawing.Size(121, 27);
            this.txbCtps.TabIndex = 10;
            // 
            // txbCnh
            // 
            this.txbCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCnh.Location = new System.Drawing.Point(797, 74);
            this.txbCnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCnh.Name = "txbCnh";
            this.txbCnh.Size = new System.Drawing.Size(121, 27);
            this.txbCnh.TabIndex = 11;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(429, 137);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(87, 35);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dgvPessoasDoc
            // 
            this.dgvPessoasDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoasDoc.Location = new System.Drawing.Point(47, 196);
            this.dgvPessoasDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPessoasDoc.Name = "dgvPessoasDoc";
            this.dgvPessoasDoc.Size = new System.Drawing.Size(979, 209);
            this.dgvPessoasDoc.TabIndex = 13;
            this.dgvPessoasDoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoasDoc_CellDoubleClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(566, 137);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 35);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // formPessoaDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 439);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvPessoasDoc);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbCnh);
            this.Controls.Add(this.txbCtps);
            this.Controls.Add(this.txbReservista);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblCnh);
            this.Controls.Add(this.lblCtps);
            this.Controls.Add(this.lblReservista);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formPessoaDocumentos";
            this.Text = "Documentos";
            this.Load += new System.EventHandler(this.formPessoaDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoasDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblReservista;
        private System.Windows.Forms.Label lblCtps;
        private System.Windows.Forms.Label lblCnh;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbRg;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbReservista;
        private System.Windows.Forms.TextBox txbCtps;
        private System.Windows.Forms.TextBox txbCnh;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dgvPessoasDoc;
        private System.Windows.Forms.Button btnLimpar;
    }
}