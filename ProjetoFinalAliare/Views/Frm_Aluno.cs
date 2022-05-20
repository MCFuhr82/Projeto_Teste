using ProjetoFinalAliare.Context;
using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalAliare
{
    public partial class Frm_Aluno : Form
    {
        public Frm_Aluno()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Btn_Consulta_Click(object sender, EventArgs e)
        {
           
        }
        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            InserirAluno();
        }

        private void InserirAluno()
        {
            var nome = Txb_Cadastro_Nome.Text;
            var cpf = Mtb_Cadastro_Cpf.Text;
            var celular = Mtb_Cadastro_Celular.Text;
            var email = Txb_Cadastro_Email.Text;
            var endereco = Txb_Cadastro_Endereco.Text;
            var cep = Txb_Cadastro_Cep.Text;
            var complemento = Txb_Cadastro_Comp.Text;

            using (var contexto = new Contexto())
            {
                var aluno = new Aluno(nome, cpf, endereco, cep, complemento, celular, email);
                contexto.Aluno.Add(aluno);
                contexto.SaveChanges();
            }

            MessageBox.Show("Aluno inserido com sucesso!");
            
        }

        private void DeletarAluno()
        {
            //Todo
        }

        private void 

    }
}
