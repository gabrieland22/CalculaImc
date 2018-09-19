using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculaImc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculoValorImcSucessoPage : ContentPage
    {
        public CalculoValorImcSucessoPage()
        {
            InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}