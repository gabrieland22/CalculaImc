using CalculaImc.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImc.Services.Interfaces
{
    public interface ICalculoPessoaService
    {
        void Inserir(CalculoPessoa calculoPessoa);
        Task<IEnumerable<CalculoPessoa>> ObterTodos();
    }
}
