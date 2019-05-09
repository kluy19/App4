using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App4.Modelos;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatriculaPage : ContentPage
    {


        public MatriculaPage()
        {
            InitializeComponent();
            // para todos os alunos da lista
            foreach (Aluno aluno in Listas.Alunos)
            {
                // adicionar um elemento na caixa de seleção
                Picker.Items.Add(aluno.Matricula + " - " + aluno.Matricula);
            }
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                // adicionar um elemento na caixa de seleção
                Picker1.Items.Add(disciplina.Semestre + " - " + disciplina.Nome);
            }
        }

        // internal Disciplina[] Disciplinas { get => disciplinas; set => disciplinas = value; }

        void OnButtonClicked(object sender, EventArgs args)
        {
            /*if (Entry.Text != null &&
                Entry.Text.Length > 0 &&
                Picker.SelectedIndex >= 0 &&
                Picker1.SelectedIndex >= 0)
            {
                // pegar o aluno da lista
                Aluno aluno = Listas.Alunos.ElementAt(Picker.SelectedIndex);
                Disciplina disciplina = Listas.Disciplinas.ElementAt(Picker1.SelectedIndex);
                // alterar o periodo do aluno
                aluno.Periodo = int.Parse(Entry.Text);
            }*/
            if (Picker.SelectedIndex >= 0 &&

              Picker1.SelectedIndex >= 0)

            {

                // pegar o aluno da lista

                Aluno aluno = Listas.Alunos.ElementAt(Picker.SelectedIndex);

                // pegar a disciplina do vetor

                Disciplina disciplina = Listas.Disciplinas[Picker1.SelectedIndex];

                // verificar se o período foi preenchido

                if (Entry.Text != null &&

                    Entry.Text.Length > 0)

                {

                    // pegar o periodo da entrada

                    int periodo = int.Parse(Entry.Text);

                    // alterar o label com o valor do período a ser matriculado

                    Label.Text = aluno.Matricular(disciplina, periodo).ToString();

                }
                else
                {
                    // alterar o label com o valor da formatura
                    Label.Text = aluno.Formatura.ToString();
                }
            }

        }
    }
}
