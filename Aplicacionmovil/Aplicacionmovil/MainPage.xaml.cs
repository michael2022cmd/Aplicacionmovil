using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aplicacionmovil
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {

//public string MiText { get; set; } = Constantes.logintitulo;

        public MainPage()

        {
            InitializeComponent();
            BindingContext = new maimodel();
        }

      

        private async void Btniniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro())   ;
        }
    }
}
