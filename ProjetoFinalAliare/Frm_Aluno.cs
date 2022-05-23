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

        private void Btn_Consulta_Click(object sender, EventArgs e)
        {
            try
            {
                using(var context = new Context())
                {
                    dataGridView1.DataSource = context.Aluno.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                var alunos = context.Aluno.ToList();
                foreach (var aluno in alunos)
                {
                    if (aluno.Matricula == int.Parse(Txb_Matricula.Text))
                    {
                        context.Aluno.Remove(aluno);
                        context.SaveChanges();
                    }
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var alunos = new List<Aluno>();
                var selectedAluno = dataGridView1.SelectedRows[0].DataBoundItem as Aluno;
                Txb_Matricula.Text = selectedAluno.Matricula.ToString();
                Txb_Nome.Text = selectedAluno.Nome.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message + " - " + ex.Source);
            }
        }
    }
}
