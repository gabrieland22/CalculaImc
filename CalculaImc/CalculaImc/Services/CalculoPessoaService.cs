

using CalculaImc.Domain.CalculoPessoas.Repository;
using CalculaImc.Models;
using CalculaImc.Services.Interfaces;

namespace CalculaImc.Services
{
    public class CalculoPessoaService : ICalculoPessoaService
    {
        private readonly ICalculoPessoaRepository CalculoPessoaRepository;

        public CalculoPessoaService(ICalculoPessoaRepository calculoPessoaRepository)
        {
            CalculoPessoaRepository = calculoPessoaRepository;
        }

        public void Inserir(CalculoPessoa calculoPessoa)
        {
            CalculoPessoaRepository.Insert(calculoPessoa);
        }
    }
}