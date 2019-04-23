using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App4.Modelos;

namespace App4
{
	public partial class MainPage : ContentPage
	{

        public MainPage()
		{
			InitializeComponent();
		}

        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AlunoPage());
        }

        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new PeriodoPage());
        }

        void OnButtonClicked3(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MatriculaPage());
        }

	}
}
