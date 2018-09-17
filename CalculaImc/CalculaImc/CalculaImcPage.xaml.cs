using CalculaImc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculaImc
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculaImcPage : ContentPage
	{
		public CalculaImcPage ()
		{
			InitializeComponent ();
            var viewModel = new CalculoValorImcViewModel();
            BindingContext = viewModel;

        }
    }
}