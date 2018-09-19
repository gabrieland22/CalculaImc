using CalculaImc.Models;
using CalculaImc.Services;
using CalculaImc.Services.Interfaces;
using CalculaImc.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculaImc.ViewModels
{
    public class PessoasPageViewModel : ViewModelBase
    {
       

        public ObservableCollection<CalculoPessoa> CalculoPessoas { get; set; }
        private bool atualizando;
        public bool Atualizando

        {
            get { return atualizando; }
            set { SetProperty(ref atualizando, value); }
        }

        private CalculoPessoa calculoPessoa;
        public CalculoPessoa CalculoPessoa
        {
            get { return calculoPessoa; }
            set
            {
                SetProperty(ref calculoPessoa, value);

                if (calculoPessoa != null)
                    App.Current.MainPage.DisplayAlert(calculoPessoa.Nome, "IMC: "+calculoPessoa.ValorImc, "ok");
            }
        }

        public Command AtualizarDadosCommand { get; }

        private readonly ICalculoPessoaService CalculoPessoaService;
        public PessoasPageViewModel(ICalculoPessoaService calculoPessoaService)
        {
            CalculoPessoaService = calculoPessoaService;
            CalculoPessoas = new ObservableCollection<CalculoPessoa>();
            ObterCalculoPessoas();
            AtualizarDadosCommand = new Command(ExecuteAtualizarDadosCommand);
        }

        private async void ExecuteAtualizarDadosCommand()
        {
            Atualizando = true;
            await ObterCalculoPessoas();
            Atualizando = false;
        }

        private async Task ObterCalculoPessoas()
        {
            var calculoPessoas = await CalculoPessoaService.ObterTodos();

            if (CalculoPessoas.Count > 0)
            {
                CalculoPessoas.Clear();
            }

            foreach (var calculoPessoa in calculoPessoas)
            {
                CalculoPessoas.Add(calculoPessoa);
            }
        }

    }
}
