using ControladorDeNotas.entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ControladorDeNotas.Servico
{
    public class AlunoServico : Aluno
    {
        ControladorDeNotasContexto contexto = new ControladorDeNotasContexto();
        public void Cadastrar(Aluno aluno)
        {

            try
            {
                contexto.alunos.Add(aluno);
                contexto.SaveChanges();
                MessageBox.Show("Aluno Adicionado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }
        public List<Aluno> BuscarTodos()
        {
            return contexto.alunos.ToList();
        }
        public void Excluir(Aluno aluno)
        {
            int id = aluno.alunoId;
            try
            {
                aluno = contexto.alunos.FirstOrDefault
                (a => a.alunoId == id);
                if (aluno != null)
                {
                    contexto.alunos.Remove(aluno);
                    contexto.SaveChanges();
                    MessageBox.Show("Aluno removido!");
                }
                else
                {
                    MessageBox.Show("Aluno nao encontrado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            
            

        }

        public void BuscarPorId(Aluno aluno)
        {
            try
            {
                int id = aluno.alunoId;

                aluno = contexto.alunos.FirstOrDefault
                    (a => a.alunoId == id);
                if (aluno != null)
                {
                    MessageBox.Show("Aluno Encontrado: " + "Nome: " + aluno.nome + " Ra: " + aluno.ra
                        + " Nota B1: " + aluno.notaB1 + " Nota B2: " + aluno.notaB2 + " Nota Pim: " + aluno.notaPim);
                }
                else
                {
                    MessageBox.Show("Aluno nao encontrado");
                }
               
            }
            catch(Exception ex)
            {
               MessageBox.Show("ERROR" + ex.Message);
            }
            
        }
    }
}
        
