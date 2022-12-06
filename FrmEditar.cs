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
    public partial class FrmEditar : Form
    {
        public FrmEditar()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtHoras.Text = "";
            cmbTitulacao.SelectedIndex = -1;
            btnConsultar.Enabled = true;
            btnEditar.Enabled = false;
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
                btnEditar.Enabled = true;
                btnConsultar.Enabled = false;
                txtNome.Enabled = true;
                txtHoras.Enabled = true;
                cmbTitulacao.Enabled = true;

            }
            else
            {
                MessageBox.Show("Professor não encontrado");
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Codigo = int.Parse(txtCodigo.Text);
            professor.Nome = txtNome.Text;
            professor.Horas = int.Parse(txtHoras.Text);
            professor.Titulacao = cmbTitulacao.Text;



            ProfessorController.editar(professor);


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
