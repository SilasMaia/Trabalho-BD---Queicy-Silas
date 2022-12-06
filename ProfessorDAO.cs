using FolhaDePagamentoQueicy.Conection;
using FolhaDePagamentoQueicy.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaDePagamentoQueicy.DAO
{
    public class ProfessorDAO
    {
        public ProfessorDAO()
        {
            bool conexao = Conexao.AbrirConexao();

            if (!conexao)
                MessageBox.Show("Não conectou");
        }

        public void IncluirProfessor(Professor p)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexao.getConexao();

                // Use string interpolation to concatenate strings.
                string sql = $"insert into professor values ({p.Codigo}, '{p.Nome}', '{p.Titulacao}', {p.Horas})";
                comando.CommandText = sql;

                if (comando.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Professor incluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro: Não foi possível incluir o professor");
                }
            }
            catch (Exception ex)
            {
                //Trata exceção
                throw ex;
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public List<Professor> ConsultarProfessores()
        {
            Professor p = null;
            List<Professor> professores = new List<Professor>();


            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM professor", Conexao.getConexao());
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        p = new Professor();

                        p.Codigo = reader.GetInt32("codigo");
                        p.Nome = reader.GetString("nome");
                        p.Titulacao = reader.GetString("titulacao");
                        p.Horas = reader.GetInt32("horas");
                        professores.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                //Trata exceção
                throw ex;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return professores;

        }

        public Professor ConsultarProfessores(int codigo)
        {
            Professor professor = null;


            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM professor WHERE codigo = " + codigo, Conexao.getConexao());
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        professor = new Professor();

                        professor.Codigo = reader.GetInt32("codigo");
                        professor.Nome = reader.GetString("nome");
                        professor.Titulacao = reader.GetString("titulacao");
                        professor.Horas = reader.GetInt32("horas");
                    }
                }
            }
            catch (Exception ex)
            {
                //Trata exceção
                throw ex;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return professor;

        }

        public int  Excluir(int codigo)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();

            string sql = "delete from professor where codigo =  " + codigo;
            comando.CommandText = sql;
            int resposta = 0;
            resposta = comando.ExecuteNonQuery();
            return resposta;
        }


        public void EditarProfessor(Professor p)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexao.getConexao();

                // Use string interpolation to concatenate strings.
                string sql = $"update professor set nome = '{p.Nome}', titulacao = '{p.Titulacao}', horas = {p.Horas} where codigo = {p.Codigo}";
                comando.CommandText = sql;

                if (comando.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Professor alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro: Não foi possível editar os dados do professor");
                }
            }
            catch (Exception ex)
            {
                //Trata exceção
                throw ex;
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

    }
}
