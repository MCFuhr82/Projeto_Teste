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
                    if (aluno.Matricula == 1)
                    {
                        context.Aluno.Remove(aluno);
                        context.SaveChanges();
                    }
                }
            }
            
        }
    }
}
