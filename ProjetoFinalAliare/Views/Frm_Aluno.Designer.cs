﻿namespace ProjetoFinalAliare
{
    partial class Frm_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Aluno));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Pnl_Cadastrar = new System.Windows.Forms.Panel();
            this.Pnl_Consultar = new System.Windows.Forms.Panel();
            this.Cbx_Alunos = new System.Windows.Forms.ComboBox();
            this.Txb_Matricula = new System.Windows.Forms.TextBox();
            this.Lbl_Matricula = new System.Windows.Forms.Label();
            this.Txb_Consulta_Comp = new System.Windows.Forms.TextBox();
            this.Lbl_Consulta_Comp = new System.Windows.Forms.Label();
            this.Mtb_Consulta_Cep = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Consulta_Cep = new System.Windows.Forms.Label();
            this.Txb_Consulta_Endereco = new System.Windows.Forms.TextBox();
            this.Lbl_Consulta_Endereco = new System.Windows.Forms.Label();
            this.Txb_Consulta_Email = new System.Windows.Forms.TextBox();
            this.Mtb_Consulta_Celular = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Consulta_Celular = new System.Windows.Forms.Label();
            this.Txb_Consulta_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Consulta_Email = new System.Windows.Forms.Label();
            this.Lbl_Consulta_Nome = new System.Windows.Forms.Label();
            this.Txb_Cadastro_Comp = new System.Windows.Forms.TextBox();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Txb_Cadastro_Cep = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Txb_Cadastro_Endereco = new System.Windows.Forms.TextBox();
            this.Lbl_Endereco = new System.Windows.Forms.Label();
            this.Txb_Cadastro_Email = new System.Windows.Forms.TextBox();
            this.Mtb_Cadastro_Celular = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Celular = new System.Windows.Forms.Label();
            this.Mtb_Cadastro_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Txb_Cadastro_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Lbl_nome = new System.Windows.Forms.Label();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.Mtb_Consulta_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Consulta_Cpf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_Cadastrar.SuspendLayout();
            this.Pnl_Consultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar.Location = new System.Drawing.Point(123, 20);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(139, 50);
            this.Btn_Cadastrar.TabIndex = 2;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Btn_Consulta
            // 
            this.Btn_Consulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Consulta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consulta.Location = new System.Drawing.Point(418, 20);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(139, 50);
            this.Btn_Consulta.TabIndex = 5;
            this.Btn_Consulta.Text = "Consulta";
            this.Btn_Consulta.UseVisualStyleBackColor = false;
            this.Btn_Consulta.Click += new System.EventHandler(this.Btn_Consulta_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Editar.Enabled = false;
            this.Btn_Editar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(706, 133);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Editar.TabIndex = 7;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Deletar.Enabled = false;
            this.Btn_Deletar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deletar.Location = new System.Drawing.Point(706, 173);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Deletar.TabIndex = 8;
            this.Btn_Deletar.Text = "Deletar";
            this.Btn_Deletar.UseVisualStyleBackColor = false;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Voltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(708, 403);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.Btn_Voltar.TabIndex = 9;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Pnl_Cadastrar
            // 
            this.Pnl_Cadastrar.Controls.Add(this.Txb_Cadastro_Comp);
            this.Pnl_Cadastrar.Controls.Add(this.Lbl_Complemento);
            this.Pnl_Cadastrar.Controls.Add(this.Txb_Cadastro_Cep);
            this.Pnl_Cadastrar.Controls.Add(this.Lbl_Cep);
            this.Pnl_Cadastrar.Controls.Add(this.Txb_Cadastro_Endereco);
            this.Pnl_Cadastrar.Controls.Add(this.Lbl_Endereco);
            this.Pnl_Cadastrar.Controls.Add(this.Txb_Cadastro_Email);
            this.Pnl_Cadastrar.Controls.Add(this.Mtb_Cadastro_Celular);
            this.Pnl_Cadastrar.Controls.Add(this.Lbl_Celular);
            this.Pnl_Cadastrar.Controls.Add(this.Mtb_Cadastro_Cpf);
            this.Pnl_Cadastrar.Controls.Add(this.Txb_Cadastro_Nome);
            this.Pnl_Cadastrar.Controls.Add(this.Lbl_Email);
            this.Pnl_Cadastrar.Controls.Add(this.Lbl_Cpf);
            this.Pnl_Cadastrar.Controls.Add(this.Lbl_nome);
            this.Pnl_Cadastrar.Enabled = false;
            this.Pnl_Cadastrar.Location = new System.Drawing.Point(3, 3);
            this.Pnl_Cadastrar.Name = "Pnl_Cadastrar";
            this.Pnl_Cadastrar.Size = new System.Drawing.Size(674, 361);
            this.Pnl_Cadastrar.TabIndex = 10;
            this.Pnl_Cadastrar.Visible = false;
            // 
            // Pnl_Consultar
            // 
            this.Pnl_Consultar.Controls.Add(this.Cbx_Alunos);
            this.Pnl_Consultar.Controls.Add(this.Txb_Matricula);
            this.Pnl_Consultar.Controls.Add(this.Pnl_Cadastrar);
            this.Pnl_Consultar.Controls.Add(this.Lbl_Matricula);
            this.Pnl_Consultar.Controls.Add(this.Txb_Consulta_Comp);
            this.Pnl_Consultar.Controls.Add(this.Lbl_Consulta_Comp);
            this.Pnl_Consultar.Controls.Add(this.Mtb_Consulta_Cep);
            this.Pnl_Consultar.Controls.Add(this.Lbl_Consulta_Cep);
            this.Pnl_Consultar.Controls.Add(this.Txb_Consulta_Endereco);
            this.Pnl_Consultar.Controls.Add(this.Lbl_Consulta_Endereco);
            this.Pnl_Consultar.Controls.Add(this.Txb_Consulta_Email);
            this.Pnl_Consultar.Controls.Add(this.Mtb_Consulta_Celular);
            this.Pnl_Consultar.Controls.Add(this.Lbl_Consulta_Celular);
            this.Pnl_Consultar.Controls.Add(this.Mtb_Consulta_Cpf);
            this.Pnl_Consultar.Controls.Add(this.Txb_Consulta_Nome);
            this.Pnl_Consultar.Controls.Add(this.Lbl_Consulta_Email);
            this.Pnl_Consultar.Controls.Add(this.Lbl_Consulta_Cpf);
            this.Pnl_Consultar.Controls.Add(this.Lbl_Consulta_Nome);
            this.Pnl_Consultar.Enabled = false;
            this.Pnl_Consultar.Location = new System.Drawing.Point(12, 76);
            this.Pnl_Consultar.Name = "Pnl_Consultar";
            this.Pnl_Consultar.Size = new System.Drawing.Size(674, 361);
            this.Pnl_Consultar.TabIndex = 14;
            this.Pnl_Consultar.Visible = false;
            // 
            // Cbx_Alunos
            // 
            this.Cbx_Alunos.FormattingEnabled = true;
            this.Cbx_Alunos.Location = new System.Drawing.Point(215, 17);
            this.Cbx_Alunos.Name = "Cbx_Alunos";
            this.Cbx_Alunos.Size = new System.Drawing.Size(423, 21);
            this.Cbx_Alunos.TabIndex = 16;
            // 
            // Txb_Matricula
            // 
            this.Txb_Matricula.Location = new System.Drawing.Point(89, 19);
            this.Txb_Matricula.Name = "Txb_Matricula";
            this.Txb_Matricula.Size = new System.Drawing.Size(93, 20);
            this.Txb_Matricula.TabIndex = 15;
            // 
            // Lbl_Matricula
            // 
            this.Lbl_Matricula.AutoSize = true;
            this.Lbl_Matricula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Matricula.Location = new System.Drawing.Point(17, 20);
            this.Lbl_Matricula.Name = "Lbl_Matricula";
            this.Lbl_Matricula.Size = new System.Drawing.Size(66, 19);
            this.Lbl_Matricula.TabIndex = 14;
            this.Lbl_Matricula.Text = "Matricula";
            // 
            // Txb_Consulta_Comp
            // 
            this.Txb_Consulta_Comp.Location = new System.Drawing.Point(338, 277);
            this.Txb_Consulta_Comp.Name = "Txb_Consulta_Comp";
            this.Txb_Consulta_Comp.Size = new System.Drawing.Size(300, 20);
            this.Txb_Consulta_Comp.TabIndex = 13;
            // 
            // Lbl_Consulta_Comp
            // 
            this.Lbl_Consulta_Comp.AutoSize = true;
            this.Lbl_Consulta_Comp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consulta_Comp.Location = new System.Drawing.Point(238, 280);
            this.Lbl_Consulta_Comp.Name = "Lbl_Consulta_Comp";
            this.Lbl_Consulta_Comp.Size = new System.Drawing.Size(94, 19);
            this.Lbl_Consulta_Comp.TabIndex = 12;
            this.Lbl_Consulta_Comp.Text = "Complemento";
            // 
            // Mtb_Consulta_Cep
            // 
            this.Mtb_Consulta_Cep.Location = new System.Drawing.Point(89, 279);
            this.Mtb_Consulta_Cep.Mask = "00.000-000";
            this.Mtb_Consulta_Cep.Name = "Mtb_Consulta_Cep";
            this.Mtb_Consulta_Cep.Size = new System.Drawing.Size(87, 20);
            this.Mtb_Consulta_Cep.TabIndex = 11;
            // 
            // Lbl_Consulta_Cep
            // 
            this.Lbl_Consulta_Cep.AutoSize = true;
            this.Lbl_Consulta_Cep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consulta_Cep.Location = new System.Drawing.Point(16, 280);
            this.Lbl_Consulta_Cep.Name = "Lbl_Consulta_Cep";
            this.Lbl_Consulta_Cep.Size = new System.Drawing.Size(38, 19);
            this.Lbl_Consulta_Cep.TabIndex = 10;
            this.Lbl_Consulta_Cep.Text = "CEP";
            // 
            // Txb_Consulta_Endereco
            // 
            this.Txb_Consulta_Endereco.Location = new System.Drawing.Point(89, 229);
            this.Txb_Consulta_Endereco.Name = "Txb_Consulta_Endereco";
            this.Txb_Consulta_Endereco.Size = new System.Drawing.Size(549, 20);
            this.Txb_Consulta_Endereco.TabIndex = 9;
            // 
            // Lbl_Consulta_Endereco
            // 
            this.Lbl_Consulta_Endereco.AutoSize = true;
            this.Lbl_Consulta_Endereco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consulta_Endereco.Location = new System.Drawing.Point(16, 230);
            this.Lbl_Consulta_Endereco.Name = "Lbl_Consulta_Endereco";
            this.Lbl_Consulta_Endereco.Size = new System.Drawing.Size(67, 19);
            this.Lbl_Consulta_Endereco.TabIndex = 8;
            this.Lbl_Consulta_Endereco.Text = "Endereço";
            // 
            // Txb_Consulta_Email
            // 
            this.Txb_Consulta_Email.Location = new System.Drawing.Point(89, 176);
            this.Txb_Consulta_Email.Name = "Txb_Consulta_Email";
            this.Txb_Consulta_Email.Size = new System.Drawing.Size(549, 20);
            this.Txb_Consulta_Email.TabIndex = 7;
            // 
            // Mtb_Consulta_Celular
            // 
            this.Mtb_Consulta_Celular.Location = new System.Drawing.Point(372, 124);
            this.Mtb_Consulta_Celular.Mask = "(00) 00000-0000";
            this.Mtb_Consulta_Celular.Name = "Mtb_Consulta_Celular";
            this.Mtb_Consulta_Celular.Size = new System.Drawing.Size(98, 20);
            this.Mtb_Consulta_Celular.TabIndex = 6;
            // 
            // Lbl_Consulta_Celular
            // 
            this.Lbl_Consulta_Celular.AutoSize = true;
            this.Lbl_Consulta_Celular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consulta_Celular.Location = new System.Drawing.Point(314, 125);
            this.Lbl_Consulta_Celular.Name = "Lbl_Consulta_Celular";
            this.Lbl_Consulta_Celular.Size = new System.Drawing.Size(52, 19);
            this.Lbl_Consulta_Celular.TabIndex = 5;
            this.Lbl_Consulta_Celular.Text = "Celular";
            // 
            // Txb_Consulta_Nome
            // 
            this.Txb_Consulta_Nome.Location = new System.Drawing.Point(89, 80);
            this.Txb_Consulta_Nome.Name = "Txb_Consulta_Nome";
            this.Txb_Consulta_Nome.Size = new System.Drawing.Size(549, 20);
            this.Txb_Consulta_Nome.TabIndex = 3;
            // 
            // Lbl_Consulta_Email
            // 
            this.Lbl_Consulta_Email.AutoSize = true;
            this.Lbl_Consulta_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consulta_Email.Location = new System.Drawing.Point(16, 177);
            this.Lbl_Consulta_Email.Name = "Lbl_Consulta_Email";
            this.Lbl_Consulta_Email.Size = new System.Drawing.Size(42, 19);
            this.Lbl_Consulta_Email.TabIndex = 2;
            this.Lbl_Consulta_Email.Text = "Email";
            // 
            // Lbl_Consulta_Nome
            // 
            this.Lbl_Consulta_Nome.AutoSize = true;
            this.Lbl_Consulta_Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consulta_Nome.Location = new System.Drawing.Point(16, 81);
            this.Lbl_Consulta_Nome.Name = "Lbl_Consulta_Nome";
            this.Lbl_Consulta_Nome.Size = new System.Drawing.Size(51, 19);
            this.Lbl_Consulta_Nome.TabIndex = 0;
            this.Lbl_Consulta_Nome.Text = "Nome ";
            // 
            // Txb_Cadastro_Comp
            // 
            this.Txb_Cadastro_Comp.Location = new System.Drawing.Point(338, 216);
            this.Txb_Cadastro_Comp.Name = "Txb_Cadastro_Comp";
            this.Txb_Cadastro_Comp.Size = new System.Drawing.Size(300, 20);
            this.Txb_Cadastro_Comp.TabIndex = 13;
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Complemento.Location = new System.Drawing.Point(238, 219);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(94, 19);
            this.Lbl_Complemento.TabIndex = 12;
            this.Lbl_Complemento.Text = "Complemento";
            // 
            // Txb_Cadastro_Cep
            // 
            this.Txb_Cadastro_Cep.Location = new System.Drawing.Point(89, 218);
            this.Txb_Cadastro_Cep.Mask = "00.000-000";
            this.Txb_Cadastro_Cep.Name = "Txb_Cadastro_Cep";
            this.Txb_Cadastro_Cep.Size = new System.Drawing.Size(87, 20);
            this.Txb_Cadastro_Cep.TabIndex = 11;
            // 
            // Lbl_Cep
            // 
            this.Lbl_Cep.AutoSize = true;
            this.Lbl_Cep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cep.Location = new System.Drawing.Point(16, 219);
            this.Lbl_Cep.Name = "Lbl_Cep";
            this.Lbl_Cep.Size = new System.Drawing.Size(38, 19);
            this.Lbl_Cep.TabIndex = 10;
            this.Lbl_Cep.Text = "CEP";
            // 
            // Txb_Cadastro_Endereco
            // 
            this.Txb_Cadastro_Endereco.Location = new System.Drawing.Point(89, 170);
            this.Txb_Cadastro_Endereco.Name = "Txb_Cadastro_Endereco";
            this.Txb_Cadastro_Endereco.Size = new System.Drawing.Size(549, 20);
            this.Txb_Cadastro_Endereco.TabIndex = 9;
            // 
            // Lbl_Endereco
            // 
            this.Lbl_Endereco.AutoSize = true;
            this.Lbl_Endereco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Endereco.Location = new System.Drawing.Point(16, 171);
            this.Lbl_Endereco.Name = "Lbl_Endereco";
            this.Lbl_Endereco.Size = new System.Drawing.Size(67, 19);
            this.Lbl_Endereco.TabIndex = 8;
            this.Lbl_Endereco.Text = "Endereço";
            // 
            // Txb_Cadastro_Email
            // 
            this.Txb_Cadastro_Email.Location = new System.Drawing.Point(89, 115);
            this.Txb_Cadastro_Email.Name = "Txb_Cadastro_Email";
            this.Txb_Cadastro_Email.Size = new System.Drawing.Size(549, 20);
            this.Txb_Cadastro_Email.TabIndex = 7;
            // 
            // Mtb_Cadastro_Celular
            // 
            this.Mtb_Cadastro_Celular.Location = new System.Drawing.Point(372, 63);
            this.Mtb_Cadastro_Celular.Mask = "(00) 00000-0000";
            this.Mtb_Cadastro_Celular.Name = "Mtb_Cadastro_Celular";
            this.Mtb_Cadastro_Celular.Size = new System.Drawing.Size(98, 20);
            this.Mtb_Cadastro_Celular.TabIndex = 6;
            // 
            // Lbl_Celular
            // 
            this.Lbl_Celular.AutoSize = true;
            this.Lbl_Celular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Celular.Location = new System.Drawing.Point(314, 64);
            this.Lbl_Celular.Name = "Lbl_Celular";
            this.Lbl_Celular.Size = new System.Drawing.Size(52, 19);
            this.Lbl_Celular.TabIndex = 5;
            this.Lbl_Celular.Text = "Celular";
            // 
            // Mtb_Cadastro_Cpf
            // 
            this.Mtb_Cadastro_Cpf.Location = new System.Drawing.Point(89, 65);
            this.Mtb_Cadastro_Cpf.Mask = "000.000.000-00";
            this.Mtb_Cadastro_Cpf.Name = "Mtb_Cadastro_Cpf";
            this.Mtb_Cadastro_Cpf.Size = new System.Drawing.Size(87, 20);
            this.Mtb_Cadastro_Cpf.TabIndex = 4;
            // 
            // Txb_Cadastro_Nome
            // 
            this.Txb_Cadastro_Nome.Location = new System.Drawing.Point(89, 19);
            this.Txb_Cadastro_Nome.Name = "Txb_Cadastro_Nome";
            this.Txb_Cadastro_Nome.Size = new System.Drawing.Size(549, 20);
            this.Txb_Cadastro_Nome.TabIndex = 3;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(16, 116);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(42, 19);
            this.Lbl_Email.TabIndex = 2;
            this.Lbl_Email.Text = "Email";
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cpf.Location = new System.Drawing.Point(16, 65);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(38, 19);
            this.Lbl_Cpf.TabIndex = 1;
            this.Lbl_Cpf.Text = "CPF";
            // 
            // Lbl_nome
            // 
            this.Lbl_nome.AutoSize = true;
            this.Lbl_nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nome.Location = new System.Drawing.Point(16, 20);
            this.Lbl_nome.Name = "Lbl_nome";
            this.Lbl_nome.Size = new System.Drawing.Size(51, 19);
            this.Lbl_nome.TabIndex = 0;
            this.Lbl_nome.Text = "Nome ";
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Gravar.Enabled = false;
            this.Btn_Gravar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gravar.Location = new System.Drawing.Point(706, 93);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Gravar.TabIndex = 11;
            this.Btn_Gravar.Text = "Gravar";
            this.Btn_Gravar.UseVisualStyleBackColor = false;
            // 
            // Mtb_Consulta_Cpf
            // 
            this.Mtb_Consulta_Cpf.Location = new System.Drawing.Point(89, 126);
            this.Mtb_Consulta_Cpf.Mask = "000.000.000-00";
            this.Mtb_Consulta_Cpf.Name = "Mtb_Consulta_Cpf";
            this.Mtb_Consulta_Cpf.Size = new System.Drawing.Size(87, 20);
            this.Mtb_Consulta_Cpf.TabIndex = 4;
            // 
            // Lbl_Consulta_Cpf
            // 
            this.Lbl_Consulta_Cpf.AutoSize = true;
            this.Lbl_Consulta_Cpf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consulta_Cpf.Location = new System.Drawing.Point(16, 126);
            this.Lbl_Consulta_Cpf.Name = "Lbl_Consulta_Cpf";
            this.Lbl_Consulta_Cpf.Size = new System.Drawing.Size(38, 19);
            this.Lbl_Consulta_Cpf.TabIndex = 1;
            this.Lbl_Consulta_Cpf.Text = "CPF";
            // 
            // Frm_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.Pnl_Consultar);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Deletar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Consulta);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_Cadastrar.ResumeLayout(false);
            this.Pnl_Cadastrar.PerformLayout();
            this.Pnl_Consultar.ResumeLayout(false);
            this.Pnl_Consultar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.Button Btn_Consulta;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Deletar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Panel Pnl_Cadastrar;
        private System.Windows.Forms.Button Btn_Gravar;
        private System.Windows.Forms.MaskedTextBox Mtb_Cadastro_Cpf;
        private System.Windows.Forms.TextBox Txb_Cadastro_Nome;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_Cpf;
        private System.Windows.Forms.Label Lbl_nome;
        private System.Windows.Forms.TextBox Txb_Cadastro_Comp;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.MaskedTextBox Txb_Cadastro_Cep;
        private System.Windows.Forms.Label Lbl_Cep;
        private System.Windows.Forms.TextBox Txb_Cadastro_Endereco;
        private System.Windows.Forms.Label Lbl_Endereco;
        private System.Windows.Forms.TextBox Txb_Cadastro_Email;
        private System.Windows.Forms.MaskedTextBox Mtb_Cadastro_Celular;
        private System.Windows.Forms.Label Lbl_Celular;
        private System.Windows.Forms.Panel Pnl_Consultar;
        private System.Windows.Forms.TextBox Txb_Consulta_Comp;
        private System.Windows.Forms.Label Lbl_Consulta_Comp;
        private System.Windows.Forms.MaskedTextBox Mtb_Consulta_Cep;
        private System.Windows.Forms.Label Lbl_Consulta_Cep;
        private System.Windows.Forms.TextBox Txb_Consulta_Endereco;
        private System.Windows.Forms.Label Lbl_Consulta_Endereco;
        private System.Windows.Forms.TextBox Txb_Consulta_Email;
        private System.Windows.Forms.MaskedTextBox Mtb_Consulta_Celular;
        private System.Windows.Forms.Label Lbl_Consulta_Celular;
        private System.Windows.Forms.TextBox Txb_Consulta_Nome;
        private System.Windows.Forms.Label Lbl_Consulta_Email;
        private System.Windows.Forms.Label Lbl_Consulta_Nome;
        private System.Windows.Forms.ComboBox Cbx_Alunos;
        private System.Windows.Forms.TextBox Txb_Matricula;
        private System.Windows.Forms.Label Lbl_Matricula;
        private System.Windows.Forms.MaskedTextBox Mtb_Consulta_Cpf;
        private System.Windows.Forms.Label Lbl_Consulta_Cpf;
    }
}