using FolhaDePagamentoQueicy.Controller;
using FolhaDePagamentoQueicy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaDePagamentoQueicy.GUI
{
    public partial class FrmFolhaDePagamento : Form
    {
        public FrmFolhaDePagamento()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            ProfessorController controller = new ProfessorController();
            List<Professor> professores = ProfessorController.consultar();

            foreach(Professor professor in professores)
                dataGridView1.Rows.Add(professor.Codigo, professor.Nome, 
                    professor.Horas, professor.Titulacao, 
                    professor.calcularSalarioBruto(), 
                    professor.calcularINSS(),
                    professor.calcularIR(),
                    professor.calcularSalarioLiquido()
                    );
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
