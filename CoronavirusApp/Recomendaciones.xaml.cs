using Android.Net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoronavirusApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recomendaciones : ContentPage
    {
       
        public IList<Monkey> Monkeys { get; private set; }

        public Recomendaciones()
        {
            InitializeComponent();

            Monkeys = new List<Monkey>();
            Monkeys.Add(new Monkey
            {
                Name = "Lava",
                Location = "tus manos con agua y con jabón",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/03/icons-web-coronavirus-10-150x150.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Acude",
                Location = "al médico solo en una urgencia",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/03/icons-web-coronavirus-13-150x150.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Tose",
                Location = "o estornuda en la parte interna de tu codo",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/03/icons-web-coronavirus-12-150x150.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "No",
                Location = "difundas noticias falsas",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/03/icons-web-coronavirus-11-150x150.png"
            });

            BindingContext = this;
        }

        async public void info_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://coronavirus.gob.mx/", BrowserLaunchMode.SystemPreferred);
        }
       
       


    }
}