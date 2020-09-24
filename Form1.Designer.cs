namespace ControleDeFinancas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvwResult = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.dvwSaldo = new System.Windows.Forms.DataGridView();
            this.txtVenc = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.lblVenc = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gpbconta = new System.Windows.Forms.GroupBox();
            this.gpbSaldo = new System.Windows.Forms.GroupBox();
            this.gpbResumo = new System.Windows.Forms.GroupBox();
            this.gpbDeletar = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvwResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvwSaldo)).BeginInit();
            this.gpbSaldo.SuspendLayout();
            this.gpbResumo.SuspendLayout();
            this.gpbDeletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvwResult
            // 
            this.dvwResult.AllowUserToAddRows = false;
            this.dvwResult.AllowUserToDeleteRows = false;
            this.dvwResult.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwResult.Location = new System.Drawing.Point(0, 19);
            this.dvwResult.Name = "dvwResult";
            this.dvwResult.ReadOnly = true;
            this.dvwResult.Size = new System.Drawing.Size(547, 135);
            this.dvwResult.TabIndex = 0;
            this.dvwResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(479, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 28);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.DarkGray;
            this.btnInserir.FlatAppearance.BorderSize = 2;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(480, 43);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(83, 28);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeletar.FlatAppearance.BorderSize = 2;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.Snow;
            this.btnDeletar.Location = new System.Drawing.Point(290, 26);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(115, 29);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.Text = "Deletar Conta";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.DarkGray;
            this.btnSomar.FlatAppearance.BorderSize = 2;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(479, 78);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(83, 28);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // dvwSaldo
            // 
            this.dvwSaldo.AllowUserToAddRows = false;
            this.dvwSaldo.AllowUserToDeleteRows = false;
            this.dvwSaldo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dvwSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwSaldo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dvwSaldo.Location = new System.Drawing.Point(6, 17);
            this.dvwSaldo.Name = "dvwSaldo";
            this.dvwSaldo.ReadOnly = true;
            this.dvwSaldo.Size = new System.Drawing.Size(155, 118);
            this.dvwSaldo.TabIndex = 6;
            this.dvwSaldo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtVenc
            // 
            this.txtVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenc.Location = new System.Drawing.Point(114, 84);
            this.txtVenc.MaxLength = 15;
            this.txtVenc.Name = "txtVenc";
            this.txtVenc.Size = new System.Drawing.Size(181, 24);
            this.txtVenc.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(114, 114);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(181, 24);
            this.txtValor.TabIndex = 9;
            this.txtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(114, 53);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(181, 24);
            this.txtDesc.TabIndex = 10;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(186, 147);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(109, 24);
            this.txtTipo.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(187, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(96, 24);
            this.txtId.TabIndex = 12;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrograma.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPrograma.Location = new System.Drawing.Point(13, 9);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(194, 18);
            this.lblPrograma.TabIndex = 13;
            this.lblPrograma.Text = "Controle de recebimento";
            // 
            // lblVenc
            // 
            this.lblVenc.AutoSize = true;
            this.lblVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenc.Location = new System.Drawing.Point(22, 84);
            this.lblVenc.Name = "lblVenc";
            this.lblVenc.Size = new System.Drawing.Size(86, 18);
            this.lblVenc.TabIndex = 15;
            this.lblVenc.Text = "Vencimento";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(22, 53);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(76, 18);
            this.lblDesc.TabIndex = 16;
            this.lblDesc.Text = "Descricao";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(22, 147);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(158, 18);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Forma de recebimento";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(22, 114);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 18);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "Valor";
            this.lblValor.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Firebrick;
            this.lblId.Location = new System.Drawing.Point(10, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(171, 18);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Digite ID para deletar:";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // gpbconta
            // 
            this.gpbconta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbconta.ForeColor = System.Drawing.Color.Teal;
            this.gpbconta.Location = new System.Drawing.Point(16, 36);
            this.gpbconta.Name = "gpbconta";
            this.gpbconta.Size = new System.Drawing.Size(285, 146);
            this.gpbconta.TabIndex = 22;
            this.gpbconta.TabStop = false;
            this.gpbconta.Text = "Inserir nova conta";
            // 
            // gpbSaldo
            // 
            this.gpbSaldo.Controls.Add(this.dvwSaldo);
            this.gpbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSaldo.ForeColor = System.Drawing.Color.Teal;
            this.gpbSaldo.Location = new System.Drawing.Point(306, 36);
            this.gpbSaldo.Name = "gpbSaldo";
            this.gpbSaldo.Size = new System.Drawing.Size(167, 146);
            this.gpbSaldo.TabIndex = 23;
            this.gpbSaldo.TabStop = false;
            this.gpbSaldo.Text = "Total a receber";
            // 
            // gpbResumo
            // 
            this.gpbResumo.Controls.Add(this.dvwResult);
            this.gpbResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResumo.ForeColor = System.Drawing.Color.Teal;
            this.gpbResumo.Location = new System.Drawing.Point(16, 188);
            this.gpbResumo.Name = "gpbResumo";
            this.gpbResumo.Size = new System.Drawing.Size(547, 166);
            this.gpbResumo.TabIndex = 24;
            this.gpbResumo.TabStop = false;
            this.gpbResumo.Text = "Resumo de contas";
            // 
            // gpbDeletar
            // 
            this.gpbDeletar.Controls.Add(this.btnDeletar);
            this.gpbDeletar.Controls.Add(this.lblId);
            this.gpbDeletar.Controls.Add(this.txtId);
            this.gpbDeletar.ForeColor = System.Drawing.Color.Firebrick;
            this.gpbDeletar.Location = new System.Drawing.Point(16, 360);
            this.gpbDeletar.Name = "gpbDeletar";
            this.gpbDeletar.Size = new System.Drawing.Size(451, 68);
            this.gpbDeletar.TabIndex = 25;
            this.gpbDeletar.TabStop = false;
            this.gpbDeletar.Text = "Deletar Conta por ID";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkGray;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(481, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 29);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.DarkGray;
            this.btnApagar.FlatAppearance.BorderSize = 2;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(479, 143);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(83, 28);
            this.btnApagar.TabIndex = 27;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 433);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblVenc);
            this.Controls.Add(this.lblPrograma);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtVenc);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gpbconta);
            this.Controls.Add(this.gpbSaldo);
            this.Controls.Add(this.gpbResumo);
            this.Controls.Add(this.gpbDeletar);
            this.Name = "Form1";
            this.Text = "Controle de contas a receber";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvwResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvwSaldo)).EndInit();
            this.gpbSaldo.ResumeLayout(false);
            this.gpbResumo.ResumeLayout(false);
            this.gpbDeletar.ResumeLayout(false);
            this.gpbDeletar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvwResult;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.DataGridView dvwSaldo;
        private System.Windows.Forms.TextBox txtVenc;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.Label lblVenc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gpbconta;
        private System.Windows.Forms.GroupBox gpbSaldo;
        private System.Windows.Forms.GroupBox gpbResumo;
        private System.Windows.Forms.GroupBox gpbDeletar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnApagar;
    }
}

