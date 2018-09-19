using CalculaImc.ViewModels;
using CommonServiceLocator;
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
	public partial class CalculoPessoasPage : ContentPage
	{
		public CalculoPessoasPage ()
		{
			InitializeComponent ();
        
            var viewModel = ServiceLocator.Current.GetInstance<PessoasPageViewModel>();
            BindingContext = viewModel;
        }
	}
}