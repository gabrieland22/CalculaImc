using CalculaImc.Domain.CalculoPessoas.Repository;
using CalculaImc.Models;
using CalculaImc.Services.Interfaces;
using CalculaImc.ViewModels.Base;
using CalculaImc.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculaImc.ViewModels
{
    public class CalculoValorImcViewModel : ViewModelBase
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                SetProperty(ref nome, value);
            }
        }

        private double valorAltura;
        public double ValorAltura
        {
            get { return valorAltura; }
            set
            {
                SetProperty(ref valorAltura, value);
                CalcularImc();
            }
        }

        private double valorPeso;
        public double ValorPeso
        {
            get { return valorPeso; }
            set
            {
                SetProperty(ref valorPeso, value);
                CalcularImc();
            }
        }

        private double valorImc;
        public double ValorImc
        {
            get { return valorImc; }
            set { SetProperty(ref valorImc, value); }
        }

        private CalculoPessoa calculoPessoa;
        public CalculoPessoa CalculoPessoa
        {
            get { return calculoPessoa; }
            set
            {
                SetProperty(ref calculoPessoa, value);
            }
        }

     

        private void CalcularImc()
        {

            if (ValorAltura > 0 && ValorPeso > 0)
            {
                ValorImc = ValorPeso / (ValorAltura * ValorAltura);
            }
        }

        public Command GravarCommand { get; }
        public Command LimparCommand { get; }
        

        private readonly ICalculoPessoaService CalculoPessoaService;
        public CalculoValorImcViewModel(ICalculoPessoaService calculoPessoaService)
        {
            GravarCommand = new Command(ExecuteGravarCommand);
            LimparCommand = new Command(ExecuteLimparCommand);
            CalculoPessoa = new CalculoPessoa();
            CalculoPessoaService = calculoPessoaService;
 
        }

        private void ExecuteLimparCommand()
        {
            Nome = string.Empty;
            ValorAltura = 0;
            ValorPeso = 0;
            ValorImc = 0;
        }



        private async void ExecuteGravarCommand(object obj)
        {
            CalculoPessoa.ValorAltura = ValorAltura;
            CalculoPessoa.ValorPeso = ValorPeso;
            CalculoPessoa.Nome = Nome;
            CalculoPessoa.ValorImc = ValorImc;

     
            CalculoPessoaService.Inserir(calculoPessoa);
            ExecuteLimparCommand();
            await App.Current.MainPage.Navigation.PushAsync(new CalculoValorImcSucessoPage());
        }

       
       

       
    }
}
