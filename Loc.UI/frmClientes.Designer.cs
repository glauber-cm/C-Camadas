namespace Loc.UI
{
    partial class frmClientes
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
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.grbEndereco = new System.Windows.Forms.GroupBox();
            this.grbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grbEndereco.SuspendLayout();
            this.grbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(65, 19);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(307, 20);
            this.txtCep.TabIndex = 13;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(9, 22);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(26, 13);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "Cep";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(65, 46);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(632, 20);
            this.txtEndereco.TabIndex = 15;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(7, 49);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 14;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(65, 72);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(307, 20);
            this.txtBairro.TabIndex = 19;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(9, 74);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 18;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(423, 72);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(274, 20);
            this.txtCidade.TabIndex = 21;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(377, 74);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 20;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(9, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(65, 97);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(90, 21);
            this.cmbEstado.TabIndex = 23;
            // 
            // grbEndereco
            // 
            this.grbEndereco.Controls.Add(this.txtCep);
            this.grbEndereco.Controls.Add(this.cmbEstado);
            this.grbEndereco.Controls.Add(this.lblCep);
            this.grbEndereco.Controls.Add(this.lblEstado);
            this.grbEndereco.Controls.Add(this.lblEndereco);
            this.grbEndereco.Controls.Add(this.txtCidade);
            this.grbEndereco.Controls.Add(this.txtEndereco);
            this.grbEndereco.Controls.Add(this.lblCidade);
            this.grbEndereco.Controls.Add(this.lblBairro);
            this.grbEndereco.Controls.Add(this.txtBairro);
            this.grbEndereco.Location = new System.Drawing.Point(12, 121);
            this.grbEndereco.Name = "grbEndereco";
            this.grbEndereco.Size = new System.Drawing.Size(704, 124);
            this.grbEndereco.TabIndex = 25;
            this.grbEndereco.TabStop = false;
            this.grbEndereco.Text = "Endereço";
            // 
            // grbDadosPessoais
            // 
            this.grbDadosPessoais.Controls.Add(this.lblSexo);
            this.grbDadosPessoais.Controls.Add(this.cmbSexo);
            this.grbDadosPessoais.Controls.Add(this.txtDataNasc);
            this.grbDadosPessoais.Controls.Add(this.lblDataNasc);
            this.grbDadosPessoais.Controls.Add(this.txtTelefone);
            this.grbDadosPessoais.Controls.Add(this.lblTelefone);
            this.grbDadosPessoais.Controls.Add(this.txtEmail);
            this.grbDadosPessoais.Controls.Add(this.lblEmail);
            this.grbDadosPessoais.Controls.Add(this.txtCpf);
            this.grbDadosPessoais.Controls.Add(this.lblCpf);
            this.grbDadosPessoais.Controls.Add(this.txtNome);
            this.grbDadosPessoais.Controls.Add(this.lblNome);
            this.grbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.grbDadosPessoais.Name = "grbDadosPessoais";
            this.grbDadosPessoais.Size = new System.Drawing.Size(704, 103);
            this.grbDadosPessoais.TabIndex = 26;
            this.grbDadosPessoais.TabStop = false;
            this.grbDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(324, 74);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 23;
            this.lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(365, 71);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 22;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(55, 72);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(163, 20);
            this.txtDataNasc.TabIndex = 21;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(5, 75);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(49, 13);
            this.lblDataNasc.TabIndex = 20;
            this.lblDataNasc.Text = "Dt. Nasc";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(542, 48);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(154, 20);
            this.txtTelefone.TabIndex = 19;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(495, 51);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(55, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(431, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(5, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(542, 19);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(154, 20);
            this.txtCpf.TabIndex = 15;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(509, 22);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(23, 13);
            this.lblCpf.TabIndex = 14;
            this.lblCpf.Text = "Cpf";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(431, 20);
            this.txtNome.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 251);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(704, 150);
            this.dgvCliente.TabIndex = 27;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNovo.Location = new System.Drawing.Point(13, 407);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(110, 407);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeletar.Location = new System.Drawing.Point(202, 407);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 30;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(554, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmar.Location = new System.Drawing.Point(642, 407);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 32;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 473);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.grbDadosPessoais);
            this.Controls.Add(this.grbEndereco);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.grbEndereco.ResumeLayout(false);
            this.grbEndereco.PerformLayout();
            this.grbDadosPessoais.ResumeLayout(false);
            this.grbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox grbEndereco;
        private System.Windows.Forms.GroupBox grbDadosPessoais;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtDataNasc;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}