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
    public partial class Sintomas : ContentPage
    {
        public IList<Monkey> Monkeys { get; private set; }
        public Sintomas()
        {
            InitializeComponent();

            Monkeys = new List<Monkey>();
            Monkeys.Add(new Monkey
            {
                Name = "Tos",
                Location = "",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/03/tos-1-150x150.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Fiebre",
                Location = "",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/03/fiebre-1-150x150.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Dolor de cabeza",
                Location = "",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/03/dolor-cabeza-1-150x150.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "*Dificultad para respirar",
                Location = "(Casos graves)",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/04/respirar-100x100.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "*Dolor o ardor de garganta",
                Location = "",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/04/garganta-100x100.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "*Escurrimiento nasal",
                Location = "",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/04/escurrimiento-1-100x100.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "*Ojos rojos",
                Location = "",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/04/ojosrojos-100x100.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "*Dolores en músculos o articulaciones",
                Location = "",
                ImageUrl = "https://coronavirus.gob.mx/wp-content/uploads/2020/04/dolormuscular-100x100.png"
            });

            BindingContext = this;
        }
    }
}