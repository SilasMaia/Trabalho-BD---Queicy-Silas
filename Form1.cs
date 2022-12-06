using FolhaDePagamentoQueicy.Conection;
using FolhaDePagamentoQueicy.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaDePagamentoQueicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncluir frmIncluir = new FrmIncluir();
            frmIncluir.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcluir frmExcluir = new FrmExcluir();
            frmExcluir.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditar frmEditar = new FrmEditar();
            frmEditar.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.Show();
        }

        private void gerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFolhaDePagamento frmFolhaDePagamento = new FrmFolhaDePagamento();
            frmFolhaDePagamento.Show();
        }
    }
}
