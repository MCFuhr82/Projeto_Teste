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
            if (Pnl_Consultar.Visible == true)
            {
                Pnl_Consultar.Visible = false;
            }
                
            Btn_Gravar.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Deletar.Enabled = false;
            Pnl_Cadastrar.Visible = true;
        }

        private void Btn_Consulta_Click(object sender, EventArgs e)
        {
            if(Pnl_Cadastrar.Visible == true)
            {
                Pnl_Cadastrar.Visible = false;
            }
            Btn_Gravar.Enabled = false;
            Btn_Editar.Enabled = true;
            Btn_Deletar.Enabled = true;
            Pnl_Consultar.Visible = true;
        }
    }
}
