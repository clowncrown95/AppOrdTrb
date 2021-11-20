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
    public partial class equipoOT1 : ContentPage
    {
        public equipoOT1()
        {
            InitializeComponent();
        }

        private void btnSave1_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnBack1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}