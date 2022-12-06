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
    public partial class FrmExcluir : Form
    {
        public FrmExcluir()
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
            btnExcluir.Enabled = false;
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
                btnExcluir.Enabled = true;
                btnConsultar.Enabled = false;

            }
            else
            {
                MessageBox.Show("Professor não encontrado");
            }
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            ProfessorController controller = new ProfessorController();
            if (ProfessorController.excluir(codigo) > 0)
                MessageBox.Show("Professor excluído com sucesso");
            else MessageBox.Show("Erro ao excluir o professor");
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbTitulacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
