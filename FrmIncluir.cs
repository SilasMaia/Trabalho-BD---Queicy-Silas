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
    public partial class FrmIncluir : Form
    {
        public FrmIncluir()
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();


            if (txtCodigo.Text == "" || txtNome.Text == "" || txtHoras.Text == "" || cmbTitulacao.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos as informações!");
            }
            else
            {
                professor.Codigo = int.Parse(txtCodigo.Text);
                professor.Nome = txtNome.Text;
                professor.Horas = int.Parse(txtHoras.Text);
                professor.Titulacao = cmbTitulacao.SelectedItem.ToString();
                ProfessorController.incluir(professor);
                LimparCampos();
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
