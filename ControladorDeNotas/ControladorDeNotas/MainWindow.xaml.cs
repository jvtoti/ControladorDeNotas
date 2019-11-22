using ControladorDeNotas.entidade;
using ControladorDeNotas.Servico;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControladorDeNotas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        ControladorDeNotasContexto contexto = new ControladorDeNotasContexto();

        public MainWindow()
        {
            InitializeComponent();

            Aluno aluno = new Aluno();
            AlunoServico a = new AlunoServico();
            alunosDgv.ItemsSource = a.BuscarTodos();
        }

        private void cadastarBtn_Click(object sender, RoutedEventArgs e)
        {
                Aluno aluno = new Aluno();
                AlunoServico a = new AlunoServico();

                aluno.alunoId = Convert.ToInt32(alunoIdTbx.Text);
                aluno.nome = nomeTbx.Text;
                aluno.ra = raTbx.Text;
                aluno.notaB1 = Convert.ToDecimal(notaB1Tbx.Text);
                aluno.notaB2 = Convert.ToDecimal(notaB2Tbx.Text);
                aluno.notaPim = Convert.ToDecimal(notaPimTbx.Text);

                // Serviço que faz o cadastro
                a.Cadastrar(aluno);

                // Sempre ao cadastrar,  a lista de alunos é atualizada
                alunosDgv.ItemsSource = a.BuscarTodos();

            // Deixar as TextBox em Branco
            nomeTbx.Text = String.Empty;
            raTbx.Text = String.Empty;
            notaB1Tbx.Text = String.Empty;
            notaB2Tbx.Text = String.Empty;
            notaPimTbx.Text = String.Empty;
        }

        private void excluirBtn_Click(object sender, RoutedEventArgs e)
        {
            Aluno aluno = new Aluno();
            AlunoServico a = new AlunoServico();

            aluno.alunoId = Convert.ToInt32(alunoIdTbx1.Text);

            a.Excluir(aluno);

            // Sempre ao excluir,  a lista de alunos é atualizada
            alunosDgv.ItemsSource = a.BuscarTodos();

            alunoIdTbx1.Text = String.Empty;
        }

        private void PesquisarBtn_Click(object sender, RoutedEventArgs e)
        {
            Aluno aluno = new Aluno();
            AlunoServico a = new AlunoServico();
            aluno.alunoId = Convert.ToInt32(alunoIdTbx1.Text);
            a.BuscarPorId(aluno);
            alunoIdTbx1 = null;
        }

        private void relatorioBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }


