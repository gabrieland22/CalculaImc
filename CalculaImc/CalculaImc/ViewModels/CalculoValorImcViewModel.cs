using CalculaImc.Domain.CalculoPessoas.Repository;
using CalculaImc.Models;
using CalculaImc.Services.Interfaces;
using CalculaImc.ViewModels.Base;
using CalculaImc.Views;
using System;
using System.Collections.Generic;
using System.Text;
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
            set
            {
                SetProperty(ref valorImc, value);
            }
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

        private readonly ICalculoPessoaService CalculoPessoaService;
        public CalculoValorImcViewModel(ICalculoPessoaService calculoPessoaService)
        {
            GravarCommand = new Command(ExecuteGravarCommand);
            CalculoPessoa = new CalculoPessoa();
            CalculoPessoaService = calculoPessoaService;
        }


        private async void ExecuteGravarCommand(object obj)
        {
            CalculoPessoa.ValorAltura = ValorAltura;
            CalculoPessoa.ValorPeso = ValorPeso;
            CalculoPessoa.Nome = Nome;
            CalculoPessoa.ValorImc = ValorImc;

            // var profissionalAzureClient = new AzureRepository();
            //profissionalAzureClient.Insert(Profissional);
            CalculoPessoaService.Inserir(calculoPessoa);
            await App.Current.MainPage.Navigation.PushAsync(new CalculoValorImcSucessoPage());
        }
    }
}
