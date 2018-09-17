namespace CidadeInteligente
{
    partial class formFuncionario
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
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbCargo = new System.Windows.Forms.TextBox();
            this.txbRamal = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbSalario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(56, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(108, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID da pessoa";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(332, 30);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(54, 20);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(56, 75);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(61, 20);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(332, 75);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 20);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Ramal";
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(183, 26);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 27);
            this.txbId.TabIndex = 4;
            // 
            // txbCargo
            // 
            this.txbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCargo.Location = new System.Drawing.Point(433, 26);
            this.txbCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCargo.Name = "txbCargo";
            this.txbCargo.Size = new System.Drawing.Size(324, 27);
            this.txbCargo.TabIndex = 5;
            // 
            // txbRamal
            // 
            this.txbRamal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRamal.Location = new System.Drawing.Point(433, 71);
            this.txbRamal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRamal.Name = "txbRamal";
            this.txbRamal.Size = new System.Drawing.Size(100, 27);
            this.txbRamal.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(305, 135);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(83, 37);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(60, 208);
            this.dgvFuncionarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(723, 196);
            this.dgvFuncionarios.TabIndex = 9;
            this.dgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellDoubleClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(419, 135);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 37);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbSalario
            // 
            this.txbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSalario.Location = new System.Drawing.Point(166, 72);
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.Size = new System.Drawing.Size(117, 27);
            this.txbSalario.TabIndex = 12;
            // 
            // formFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 433);
            this.Controls.Add(this.txbSalario);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbRamal);
            this.Controls.Add(this.txbCargo);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formFuncionario";
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.formFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbCargo;
        private System.Windows.Forms.TextBox txbRamal;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txbSalario;
    }
}