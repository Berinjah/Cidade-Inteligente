namespace CidadeInteligente
{
    partial class formCliente
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
            this.dtpDataInclusao = new System.Windows.Forms.DateTimePicker();
            this.lblid = new System.Windows.Forms.Label();
            this.lblInclusao = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataInclusao
            // 
            this.dtpDataInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInclusao.Location = new System.Drawing.Point(185, 47);
            this.dtpDataInclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataInclusao.Name = "dtpDataInclusao";
            this.dtpDataInclusao.Size = new System.Drawing.Size(111, 23);
            this.dtpDataInclusao.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(72, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(91, 17);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID da pessoa";
            // 
            // lblInclusao
            // 
            this.lblInclusao.AutoSize = true;
            this.lblInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInclusao.Location = new System.Drawing.Point(72, 52);
            this.lblInclusao.Name = "lblInclusao";
            this.lblInclusao.Size = new System.Drawing.Size(114, 17);
            this.lblInclusao.TabIndex = 2;
            this.lblInclusao.Text = "Data de inclusão";
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(185, 17);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 23);
            this.txbId.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(97, 96);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 34);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(31, 156);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(330, 182);
            this.dgvClientes.TabIndex = 5;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(206, 96);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 34);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // formCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 364);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblInclusao);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.dtpDataInclusao);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formCliente";
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.formCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataInclusao;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblInclusao;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnLimpar;
    }
}