using CalculaImc.Domain.Core.Models;
using SQLite;

namespace CalculaImc.Models
{
    [Table("CalculoPessoa")]
    public class CalculoPessoa : Entity
    {
       
        public string Nome { get; set; }
        public double ValorPeso { get; set; }
        public double ValorAltura { get; set; }
        public double ValorImc { get; set; }
    }
}
  