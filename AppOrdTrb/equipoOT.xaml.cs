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
    public partial class equipoOT : ContentPage
    {
        public equipoOT()
        {
            InitializeComponent();
        }

        private void btnGet1_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnPost1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new equipoOT1());
        }

        private void btnPut1_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDelete1_Clicked(object sender, EventArgs e)
        {

        }
    }
}