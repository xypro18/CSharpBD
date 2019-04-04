namespace BaseDados
{
    partial class FSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSQL));
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.cLocalidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rFeminino = new System.Windows.Forms.RadioButton();
            this.rMasculino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tMorada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gB2 = new System.Windows.Forms.GroupBox();
            this.bGravar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.cCliente = new System.Windows.Forms.ComboBox();
            this.lCliente = new System.Windows.Forms.Label();
            this.bProcurar = new System.Windows.Forms.Button();
            this.bInserir = new System.Windows.Forms.Button();
            this.bSair = new System.Windows.Forms.Button();
            this.gB1.SuspendLayout();
            this.gB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.cLocalidade);
            this.gB1.Controls.Add(this.label6);
            this.gB1.Controls.Add(this.dNascimento);
            this.gB1.Controls.Add(this.label5);
            this.gB1.Controls.Add(this.rFeminino);
            this.gB1.Controls.Add(this.rMasculino);
            this.gB1.Controls.Add(this.label4);
            this.gB1.Controls.Add(this.tMorada);
            this.gB1.Controls.Add(this.label3);
            this.gB1.Controls.Add(this.tNome);
            this.gB1.Controls.Add(this.label2);
            this.gB1.Controls.Add(this.tCliente);
            this.gB1.Controls.Add(this.label1);
            this.gB1.Enabled = false;
            this.gB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB1.Location = new System.Drawing.Point(12, 12);
            this.gB1.Name = "gB1";
            this.gB1.Size = new System.Drawing.Size(285, 350);
            this.gB1.TabIndex = 0;
            this.gB1.TabStop = false;
            this.gB1.Text = "Cliente";
            // 
            // cLocalidade
            // 
            this.cLocalidade.FormattingEnabled = true;
            this.cLocalidade.Location = new System.Drawing.Point(95, 304);
            this.cLocalidade.Name = "cLocalidade";
            this.cLocalidade.Size = new System.Drawing.Size(184, 23);
            this.cLocalidade.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Localidade:";
            // 
            // dNascimento
            // 
            this.dNascimento.CustomFormat = "";
            this.dNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNascimento.Location = new System.Drawing.Point(151, 252);
            this.dNascimento.Name = "dNascimento";
            this.dNascimento.Size = new System.Drawing.Size(128, 21);
            this.dNascimento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de nascimento:";
            // 
            // rFeminino
            // 
            this.rFeminino.AutoSize = true;
            this.rFeminino.Location = new System.Drawing.Point(173, 200);
            this.rFeminino.Name = "rFeminino";
            this.rFeminino.Size = new System.Drawing.Size(85, 19);
            this.rFeminino.TabIndex = 8;
            this.rFeminino.Text = "Feminino";
            this.rFeminino.UseVisualStyleBackColor = true;
            // 
            // rMasculino
            // 
            this.rMasculino.AutoSize = true;
            this.rMasculino.Checked = true;
            this.rMasculino.Location = new System.Drawing.Point(76, 200);
            this.rMasculino.Name = "rMasculino";
            this.rMasculino.Size = new System.Drawing.Size(91, 19);
            this.rMasculino.TabIndex = 7;
            this.rMasculino.TabStop = true;
            this.rMasculino.Text = "Masculino";
            this.rMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexo:";
            // 
            // tMorada
            // 
            this.tMorada.Location = new System.Drawing.Point(72, 147);
            this.tMorada.Name = "tMorada";
            this.tMorada.Size = new System.Drawing.Size(207, 21);
            this.tMorada.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Morada:";
            // 
            // tNome
            // 
            this.tNome.Location = new System.Drawing.Point(72, 92);
            this.tNome.Name = "tNome";
            this.tNome.Size = new System.Drawing.Size(207, 21);
            this.tNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // tCliente
            // 
            this.tCliente.Location = new System.Drawing.Point(117, 31);
            this.tCliente.Name = "tCliente";
            this.tCliente.Size = new System.Drawing.Size(162, 21);
            this.tCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Cliente:";
            // 
            // gB2
            // 
            this.gB2.Controls.Add(this.bGravar);
            this.gB2.Controls.Add(this.bCancelar);
            this.gB2.Controls.Add(this.cCliente);
            this.gB2.Controls.Add(this.lCliente);
            this.gB2.Controls.Add(this.bProcurar);
            this.gB2.Controls.Add(this.bInserir);
            this.gB2.Location = new System.Drawing.Point(303, 12);
            this.gB2.Name = "gB2";
            this.gB2.Size = new System.Drawing.Size(169, 262);
            this.gB2.TabIndex = 1;
            this.gB2.TabStop = false;
            // 
            // bGravar
            // 
            this.bGravar.Enabled = false;
            this.bGravar.Image = global::BaseDados.Properties.Resources.Gravar_2;
            this.bGravar.Location = new System.Drawing.Point(93, 164);
            this.bGravar.Name = "bGravar";
            this.bGravar.Size = new System.Drawing.Size(70, 70);
            this.bGravar.TabIndex = 5;
            this.bGravar.UseVisualStyleBackColor = true;
            this.bGravar.Click += new System.EventHandler(this.bGravar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Image = global::BaseDados.Properties.Resources.Cancelar_1;
            this.bCancelar.Location = new System.Drawing.Point(6, 164);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(70, 70);
            this.bCancelar.TabIndex = 4;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // cCliente
            // 
            this.cCliente.FormattingEnabled = true;
            this.cCliente.Location = new System.Drawing.Point(9, 109);
            this.cCliente.Name = "cCliente";
            this.cCliente.Size = new System.Drawing.Size(154, 21);
            this.cCliente.TabIndex = 3;
            this.cCliente.Visible = false;
            this.cCliente.SelectedIndexChanged += new System.EventHandler(this.cCliente_SelectedIndexChanged);
            this.cCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cCliente_KeyPress);
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Location = new System.Drawing.Point(6, 92);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(39, 13);
            this.lCliente.TabIndex = 2;
            this.lCliente.Text = "Cliente";
            this.lCliente.Visible = false;
            // 
            // bProcurar
            // 
            this.bProcurar.Image = global::BaseDados.Properties.Resources.Procurar_1;
            this.bProcurar.Location = new System.Drawing.Point(93, 19);
            this.bProcurar.Name = "bProcurar";
            this.bProcurar.Size = new System.Drawing.Size(70, 70);
            this.bProcurar.TabIndex = 1;
            this.bProcurar.UseVisualStyleBackColor = true;
            this.bProcurar.Click += new System.EventHandler(this.bProcurar_Click);
            // 
            // bInserir
            // 
            this.bInserir.Image = global::BaseDados.Properties.Resources.Inserir_1png;
            this.bInserir.Location = new System.Drawing.Point(6, 19);
            this.bInserir.Name = "bInserir";
            this.bInserir.Size = new System.Drawing.Size(70, 70);
            this.bInserir.TabIndex = 0;
            this.bInserir.UseVisualStyleBackColor = true;
            this.bInserir.Click += new System.EventHandler(this.bInserir_Click);
            // 
            // bSair
            // 
            this.bSair.Image = global::BaseDados.Properties.Resources.Sair;
            this.bSair.Location = new System.Drawing.Point(402, 292);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(70, 70);
            this.bSair.TabIndex = 6;
            this.bSair.UseVisualStyleBackColor = true;
            this.bSair.Click += new System.EventHandler(this.button5_Click);
            // 
            // FSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 373);
            this.Controls.Add(this.bSair);
            this.Controls.Add(this.gB2);
            this.Controls.Add(this.gB1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração de acesso ao SQL";
            this.Load += new System.EventHandler(this.FSQL_Load);
            this.gB1.ResumeLayout(false);
            this.gB1.PerformLayout();
            this.gB2.ResumeLayout(false);
            this.gB2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.TextBox tCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gB2;
        private System.Windows.Forms.DateTimePicker dNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rFeminino;
        private System.Windows.Forms.RadioButton rMasculino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tMorada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cLocalidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bInserir;
        private System.Windows.Forms.Button bProcurar;
        private System.Windows.Forms.Button bGravar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ComboBox cCliente;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Button bSair;
    }
}