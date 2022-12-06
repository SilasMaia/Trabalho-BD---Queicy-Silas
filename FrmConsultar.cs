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
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtHoras.Text = "";
            cmbTitulacao.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            ProfessorController controller = new ProfessorController();
            Professor professor = ProfessorController.consultar(codigo);
            if (professor != null)
            {
                txtNome.Text = professor.Nome;
                txtHoras.Text = professor.Horas.ToString();
                cmbTitulacao.SelectedItem = professor.Titulacao;
               

            }
            else
            {
                MessageBox.Show("Professor não encontrado");
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
