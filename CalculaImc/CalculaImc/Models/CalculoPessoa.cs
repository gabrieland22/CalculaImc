using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaImc.Models
{   
    [DataTable("CalculoPessoa")]
    class CalculoPessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public double ValorPeso { get; set; }
        public double ValorAltura { get; set; }
        public double ValorImc { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Version]
        public string Version { get; set; }
    }
}
