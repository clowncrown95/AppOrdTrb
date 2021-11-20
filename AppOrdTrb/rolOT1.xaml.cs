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
    public partial class rolOT1 : ContentPage
    {
        public rolOT1()
        {
            InitializeComponent();
        }

        private void btnSave3_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnBack3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}