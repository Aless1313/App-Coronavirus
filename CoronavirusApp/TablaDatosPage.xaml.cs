using CoronavirusApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoronavirusApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TablaDatosPage : ContentPage
    {
        public TablaDatosPage()
        {
            InitializeComponent();
            DatosActuales datos = new GenericRepository<DatosActuales>().TraerDatos("summary").Result;

            lstDatos.ItemsSource = datos.Countries.OrderByDescending(c => c.TotalConfirmed);
        }
    }
}