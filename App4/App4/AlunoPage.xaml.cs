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
	public partial class AlunoPage : ContentPage
	{
		public AlunoPage ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            // verificar as entradas
            // verificar se os campos foram preenchidos
            if (Entry1.Text != null &&
                Entry1.Text.Length > 0 &&
                Entry2.Text != null &&
                Entry2.Text.Length > 0)
            {
                // criar um aluno e adicionar na lista
                Listas.Alunos.Add(new Aluno(Entry1.Text, Entry2.Text));
                // resetar as listas
                Entry1.Text = "";
                Entry2.Text = "";
            }
        }

    }
}