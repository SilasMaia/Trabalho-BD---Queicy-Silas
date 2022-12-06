using FolhaDePagamentoQueicy.DAO;
using FolhaDePagamentoQueicy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoQueicy.Controller
{
    public class ProfessorController
    {
        public static void incluir(Professor professor)
        {
            ProfessorDAO dao = new ProfessorDAO();

            dao.IncluirProfessor(professor);

        }

        public static Professor consultar(int codigo)
        {
            ProfessorDAO dao = new ProfessorDAO();
            Professor professor = dao.ConsultarProfessores(codigo);
            return professor;
        }

        public static List<Professor> consultar()
        {
            ProfessorDAO dao = new ProfessorDAO();
            List<Professor> professores = dao.ConsultarProfessores();
            return professores;
        }

        public static int excluir(int codigo)
        {
            ProfessorDAO dao = new ProfessorDAO();
            return (dao.Excluir(codigo));
        }

        public static void  editar(Professor professor)
        {
            ProfessorDAO dao = new ProfessorDAO();
            dao.EditarProfessor(professor);
        }
    }
}
