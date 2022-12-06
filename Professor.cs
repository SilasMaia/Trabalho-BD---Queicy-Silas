using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoQueicy.Model
{
    public class Professor
    {
        private int codigo;
        private String nome;
        private String titulacao;
        private int horas;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Titulacao { get => titulacao; set => titulacao = value; }
        public int Horas { get => horas; set => horas = value; }

        public Professor()
        {
        }


        public double calcularSalarioBruto()
        {
            double salario = 0;

            if (titulacao == "Especialista")
                salario = 4.5 * 44.50 * horas;
            else if (titulacao == "Mestre")
                salario = 4.5 * 55.50 * horas;
            else salario = 4.5 * 65.0 * horas;
            return salario;
        }

        public double calcularINSS()
        {
            return 0.085 * calcularSalarioBruto();
        }

        public double calcularIR()
        {
            return 0.15 * (calcularSalarioBruto() - calcularINSS());
        }

        public double calcularSalarioLiquido()
        {
            return calcularSalarioBruto() - calcularINSS() - calcularIR();
        }
    }
}
