using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoronavirusApp.Entidades;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoronavirusApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraficoMexico : ContentPage
    {
        public GraficoMexico()
        {
            InitializeComponent();

            List<EstadisticaPais> datos = new GenericRepository<List<EstadisticaPais>>().TraerDatos("dayone/country/mexico").Result;

            PlotModel grafica = new PlotModel();

            DateTimeAxis ejetiempo = new DateTimeAxis();

            LineSeries infectadosSerie = new LineSeries();
            LineSeries recuperadosSerie = new LineSeries();
            LineSeries muertosSerie = new LineSeries();

            foreach (var item in datos)
            {
                infectadosSerie.Points.Add(DateTimeAxis.CreateDataPoint(item.Date.DateTime, item.Confirmed));
                recuperadosSerie.Points.Add(DateTimeAxis.CreateDataPoint(item.Date.DateTime, item.Recovered));
                muertosSerie.Points.Add(DateTimeAxis.CreateDataPoint(item.Date.DateTime, item.Deaths));
            }

            infectadosSerie.Title = "Infectados: " + datos[datos.Count - 1].Confirmed;
            recuperadosSerie.Title = "Recuperdos: " + datos[datos.Count - 1].Recovered;
            muertosSerie.Title = "Muertos: " + datos[datos.Count - 1].Deaths; ;

            grafica.Axes.Add(ejetiempo);
            grafica.Series.Add(infectadosSerie);
            grafica.Series.Add(recuperadosSerie);
            grafica.Series.Add(muertosSerie);

            plotgrafica.Model = grafica;
        }
    }
}