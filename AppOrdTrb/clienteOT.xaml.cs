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
    public partial class clienteOT : ContentPage
    {
        public clienteOT()
        {
            InitializeComponent();
        }

        private void btnGet_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnPost_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new clienteOT1());
        }

        private void btnPut_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {

        }
    }
}