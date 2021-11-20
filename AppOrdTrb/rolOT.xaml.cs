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
    public partial class rolOT : ContentPage
    {
        public rolOT()
        {
            InitializeComponent();
        }

        private void btnGet3_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnPost3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new rolOT1());
        }

        private void btnPut3_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDelete3_Clicked(object sender, EventArgs e)
        {

        }
    }
}