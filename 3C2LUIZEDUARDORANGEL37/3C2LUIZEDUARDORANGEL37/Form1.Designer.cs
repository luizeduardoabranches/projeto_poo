namespace _3C2LUIZEDUARDORANGEL37
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
            this.btn_form_calculo = new System.Windows.Forms.Button();
            this.txt_operacoes = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.grp_inf_pessoais = new System.Windows.Forms.GroupBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_teleco = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_agencia = new System.Windows.Forms.TextBox();
            this.lbl_agencia = new System.Windows.Forms.Label();
            this.txt_nmr_conta = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_nome_titular = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.grp_operacoes = new System.Windows.Forms.GroupBox();
            this.rdb_investir = new System.Windows.Forms.RadioButton();
            this.rdb_depositar = new System.Windows.Forms.RadioButton();
            this.rdb_sacar = new System.Windows.Forms.RadioButton();
            this.grp_investimento = new System.Windows.Forms.GroupBox();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.lbl_juros = new System.Windows.Forms.Label();
            this.txt_tempo_investido = new System.Windows.Forms.TextBox();
            this.txt_juros = new System.Windows.Forms.TextBox();
            this.txt_valor_investido = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.btn_calcular_investimento = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.grp_inf_pessoais.SuspendLayout();
            this.grp_operacoes.SuspendLayout();
            this.grp_investimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_form_calculo
            // 
            this.btn_form_calculo.Location = new System.Drawing.Point(6, 126);
            this.btn_form_calculo.Name = "btn_form_calculo";
            this.btn_form_calculo.Size = new System.Drawing.Size(186, 23);
            this.btn_form_calculo.TabIndex = 0;
            this.btn_form_calculo.Text = "Calcular";
            this.btn_form_calculo.UseVisualStyleBackColor = true;
            this.btn_form_calculo.Click += new System.EventHandler(this.btn_form_calculo_Click);
            // 
            // txt_operacoes
            // 
            this.txt_operacoes.Location = new System.Drawing.Point(6, 96);
            this.txt_operacoes.Name = "txt_operacoes";
            this.txt_operacoes.Size = new System.Drawing.Size(186, 20);
            this.txt_operacoes.TabIndex = 1;
            this.txt_operacoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_operacoes_KeyPress);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Enabled = false;
            this.txt_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.Location = new System.Drawing.Point(12, 417);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(410, 33);
            this.txt_resultado.TabIndex = 2;
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grp_inf_pessoais
            // 
            this.grp_inf_pessoais.Controls.Add(this.txt_saldo);
            this.grp_inf_pessoais.Controls.Add(this.lbl_saldo);
            this.grp_inf_pessoais.Controls.Add(this.txt_telefone);
            this.grp_inf_pessoais.Controls.Add(this.lbl_teleco);
            this.grp_inf_pessoais.Controls.Add(this.txt_endereco);
            this.grp_inf_pessoais.Controls.Add(this.lbl_endereco);
            this.grp_inf_pessoais.Controls.Add(this.txt_agencia);
            this.grp_inf_pessoais.Controls.Add(this.lbl_agencia);
            this.grp_inf_pessoais.Controls.Add(this.txt_nmr_conta);
            this.grp_inf_pessoais.Controls.Add(this.lbl_numero);
            this.grp_inf_pessoais.Controls.Add(this.txt_nome_titular);
            this.grp_inf_pessoais.Controls.Add(this.lbl_nome);
            this.grp_inf_pessoais.Controls.Add(this.btn_cadastrar);
            this.grp_inf_pessoais.Location = new System.Drawing.Point(12, 12);
            this.grp_inf_pessoais.Name = "grp_inf_pessoais";
            this.grp_inf_pessoais.Size = new System.Drawing.Size(200, 366);
            this.grp_inf_pessoais.TabIndex = 3;
            this.grp_inf_pessoais.TabStop = false;
            this.grp_inf_pessoais.Text = "Informações pessoais";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(7, 285);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(183, 20);
            this.txt_saldo.TabIndex = 12;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(7, 269);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(37, 13);
            this.lbl_saldo.TabIndex = 11;
            this.lbl_saldo.Text = "Saldo:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(7, 246);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(183, 20);
            this.txt_telefone.TabIndex = 10;
            // 
            // lbl_teleco
            // 
            this.lbl_teleco.AutoSize = true;
            this.lbl_teleco.Location = new System.Drawing.Point(7, 230);
            this.lbl_teleco.Name = "lbl_teleco";
            this.lbl_teleco.Size = new System.Drawing.Size(52, 13);
            this.lbl_teleco.TabIndex = 9;
            this.lbl_teleco.Text = "Telefone:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(7, 190);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(183, 20);
            this.txt_endereco.TabIndex = 8;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(7, 174);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(56, 13);
            this.lbl_endereco.TabIndex = 7;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // txt_agencia
            // 
            this.txt_agencia.Location = new System.Drawing.Point(7, 142);
            this.txt_agencia.Name = "txt_agencia";
            this.txt_agencia.Size = new System.Drawing.Size(183, 20);
            this.txt_agencia.TabIndex = 6;
            // 
            // lbl_agencia
            // 
            this.lbl_agencia.AutoSize = true;
            this.lbl_agencia.Location = new System.Drawing.Point(7, 126);
            this.lbl_agencia.Name = "lbl_agencia";
            this.lbl_agencia.Size = new System.Drawing.Size(94, 13);
            this.lbl_agencia.TabIndex = 5;
            this.lbl_agencia.Text = "Agência da conta:";
            // 
            // txt_nmr_conta
            // 
            this.txt_nmr_conta.Location = new System.Drawing.Point(7, 96);
            this.txt_nmr_conta.Name = "txt_nmr_conta";
            this.txt_nmr_conta.Size = new System.Drawing.Size(183, 20);
            this.txt_nmr_conta.TabIndex = 4;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(7, 77);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(92, 13);
            this.lbl_numero.TabIndex = 3;
            this.lbl_numero.Text = "Número da conta:";
            // 
            // txt_nome_titular
            // 
            this.txt_nome_titular.Location = new System.Drawing.Point(7, 43);
            this.txt_nome_titular.Name = "txt_nome_titular";
            this.txt_nome_titular.Size = new System.Drawing.Size(183, 20);
            this.txt_nome_titular.TabIndex = 2;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(7, 27);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(81, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome do titular:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(7, 328);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(187, 23);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // grp_operacoes
            // 
            this.grp_operacoes.Controls.Add(this.rdb_investir);
            this.grp_operacoes.Controls.Add(this.rdb_depositar);
            this.grp_operacoes.Controls.Add(this.rdb_sacar);
            this.grp_operacoes.Controls.Add(this.btn_form_calculo);
            this.grp_operacoes.Controls.Add(this.txt_operacoes);
            this.grp_operacoes.Enabled = false;
            this.grp_operacoes.Location = new System.Drawing.Point(228, 12);
            this.grp_operacoes.Name = "grp_operacoes";
            this.grp_operacoes.Size = new System.Drawing.Size(200, 162);
            this.grp_operacoes.TabIndex = 4;
            this.grp_operacoes.TabStop = false;
            this.grp_operacoes.Text = "Operações";
            // 
            // rdb_investir
            // 
            this.rdb_investir.AutoSize = true;
            this.rdb_investir.Location = new System.Drawing.Point(6, 73);
            this.rdb_investir.Name = "rdb_investir";
            this.rdb_investir.Size = new System.Drawing.Size(59, 17);
            this.rdb_investir.TabIndex = 2;
            this.rdb_investir.TabStop = true;
            this.rdb_investir.Text = "Investir";
            this.rdb_investir.UseVisualStyleBackColor = true;
            this.rdb_investir.CheckedChanged += new System.EventHandler(this.rdb_investir_CheckedChanged);
            // 
            // rdb_depositar
            // 
            this.rdb_depositar.AutoSize = true;
            this.rdb_depositar.Location = new System.Drawing.Point(6, 50);
            this.rdb_depositar.Name = "rdb_depositar";
            this.rdb_depositar.Size = new System.Drawing.Size(70, 17);
            this.rdb_depositar.TabIndex = 1;
            this.rdb_depositar.TabStop = true;
            this.rdb_depositar.Text = "Depositar";
            this.rdb_depositar.UseVisualStyleBackColor = true;
            this.rdb_depositar.CheckedChanged += new System.EventHandler(this.rdb_depositar_CheckedChanged);
            // 
            // rdb_sacar
            // 
            this.rdb_sacar.AutoSize = true;
            this.rdb_sacar.Location = new System.Drawing.Point(6, 27);
            this.rdb_sacar.Name = "rdb_sacar";
            this.rdb_sacar.Size = new System.Drawing.Size(53, 17);
            this.rdb_sacar.TabIndex = 0;
            this.rdb_sacar.TabStop = true;
            this.rdb_sacar.Text = "Sacar";
            this.rdb_sacar.UseVisualStyleBackColor = true;
            this.rdb_sacar.CheckedChanged += new System.EventHandler(this.rdb_sacar_CheckedChanged);
            // 
            // grp_investimento
            // 
            this.grp_investimento.Controls.Add(this.lbl_tempo);
            this.grp_investimento.Controls.Add(this.lbl_juros);
            this.grp_investimento.Controls.Add(this.txt_tempo_investido);
            this.grp_investimento.Controls.Add(this.txt_juros);
            this.grp_investimento.Controls.Add(this.txt_valor_investido);
            this.grp_investimento.Controls.Add(this.lbl_valor);
            this.grp_investimento.Controls.Add(this.btn_calcular_investimento);
            this.grp_investimento.Location = new System.Drawing.Point(228, 180);
            this.grp_investimento.Name = "grp_investimento";
            this.grp_investimento.Size = new System.Drawing.Size(200, 198);
            this.grp_investimento.TabIndex = 5;
            this.grp_investimento.TabStop = false;
            this.grp_investimento.Text = "Investimento";
            this.grp_investimento.Visible = false;
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Location = new System.Drawing.Point(8, 101);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(141, 13);
            this.lbl_tempo.TabIndex = 6;
            this.lbl_tempo.Text = "Tempo investido(em meses):";
            // 
            // lbl_juros
            // 
            this.lbl_juros.AutoSize = true;
            this.lbl_juros.Location = new System.Drawing.Point(8, 62);
            this.lbl_juros.Name = "lbl_juros";
            this.lbl_juros.Size = new System.Drawing.Size(99, 13);
            this.lbl_juros.TabIndex = 5;
            this.lbl_juros.Text = "Taxa de juros(a/m):";
            // 
            // txt_tempo_investido
            // 
            this.txt_tempo_investido.Location = new System.Drawing.Point(6, 117);
            this.txt_tempo_investido.Name = "txt_tempo_investido";
            this.txt_tempo_investido.Size = new System.Drawing.Size(186, 20);
            this.txt_tempo_investido.TabIndex = 1;
            this.txt_tempo_investido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tempo_investido_KeyPress);
            // 
            // txt_juros
            // 
            this.txt_juros.Location = new System.Drawing.Point(6, 78);
            this.txt_juros.Name = "txt_juros";
            this.txt_juros.Size = new System.Drawing.Size(186, 20);
            this.txt_juros.TabIndex = 3;
            this.txt_juros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_juros_KeyPress);
            // 
            // txt_valor_investido
            // 
            this.txt_valor_investido.Location = new System.Drawing.Point(6, 39);
            this.txt_valor_investido.Name = "txt_valor_investido";
            this.txt_valor_investido.Size = new System.Drawing.Size(186, 20);
            this.txt_valor_investido.TabIndex = 4;
            this.txt_valor_investido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_investido_KeyPress);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(8, 22);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_valor.TabIndex = 2;
            this.lbl_valor.Text = "Valor:";
            // 
            // btn_calcular_investimento
            // 
            this.btn_calcular_investimento.Location = new System.Drawing.Point(8, 160);
            this.btn_calcular_investimento.Name = "btn_calcular_investimento";
            this.btn_calcular_investimento.Size = new System.Drawing.Size(186, 23);
            this.btn_calcular_investimento.TabIndex = 0;
            this.btn_calcular_investimento.Text = "Calcular";
            this.btn_calcular_investimento.UseVisualStyleBackColor = true;
            this.btn_calcular_investimento.Click += new System.EventHandler(this.btn_calcular_investimento_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(13, 398);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(68, 13);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "Resultado ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 462);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.grp_investimento);
            this.Controls.Add(this.grp_operacoes);
            this.Controls.Add(this.grp_inf_pessoais);
            this.Controls.Add(this.txt_resultado);
            this.Name = "Form1";
            this.Text = "Operações bancárias";
            this.grp_inf_pessoais.ResumeLayout(false);
            this.grp_inf_pessoais.PerformLayout();
            this.grp_operacoes.ResumeLayout(false);
            this.grp_operacoes.PerformLayout();
            this.grp_investimento.ResumeLayout(false);
            this.grp_investimento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_form_calculo;
        private System.Windows.Forms.TextBox txt_operacoes;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.GroupBox grp_inf_pessoais;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lbl_teleco;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox txt_agencia;
        private System.Windows.Forms.Label lbl_agencia;
        private System.Windows.Forms.TextBox txt_nmr_conta;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_nome_titular;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.GroupBox grp_operacoes;
        private System.Windows.Forms.RadioButton rdb_investir;
        private System.Windows.Forms.RadioButton rdb_depositar;
        private System.Windows.Forms.RadioButton rdb_sacar;
        private System.Windows.Forms.GroupBox grp_investimento;
        private System.Windows.Forms.Label lbl_juros;
        private System.Windows.Forms.TextBox txt_juros;
        private System.Windows.Forms.TextBox txt_valor_investido;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_calcular_investimento;
        private System.Windows.Forms.TextBox txt_tempo_investido;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

