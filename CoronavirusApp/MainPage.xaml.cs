using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoronavirusApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btncurvapais_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GraficoPais());
        }

        private void btnrecomendaciones_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recomendaciones());
        }

        private void btntabla_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TablaDatosPage());
        }

        private void btncurvamxn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GraficoMexico());
        }

        private void btnsintomas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sintomas());
        }
    }
}
