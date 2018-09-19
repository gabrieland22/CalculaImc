using CalculaImc.Domain.CalculoPessoas.Repository;
using CalculaImc.Infra.Data.Repository;
using CalculaImc.Models;

namespace CalcFreelancer.Infra.Data.Repository
{
    public class CalculoPessoaRepository : SqLiteRepository<CalculoPessoa>, ICalculoPessoaRepository
    {
    }
}
