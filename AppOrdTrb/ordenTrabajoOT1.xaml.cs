using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppOrdTrb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ordenTrabajoOT1 : ContentPage
    {
        public ordenTrabajoOT1()
        {
            InitializeComponent();
        }
        public IList<string> slcCliente => new List<string> { "Adrian", "Carlos", "Pedro" };

        public IList<string> slcEstado => new List<string> { "Reparacion", "Ingresado" };

        public IList<string> slcEquipo => new List<string> { "Tablet", "Celular", "Laptop" };

        private void btnSave4_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnBack4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}