using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Classe
{
    public class TabelaInss
    {
        public TabelaInss() { }

        public decimal aliquota { get; set; }
        public int ano { get; set; }
        public decimal salario_inf { get; set; }
        public decimal salario_sup { get; set; }
        public decimal teto { get; set; }

        public TabelaInss(int ano, decimal aliquota, decimal salarioinf, decimal salariosup,decimal teto)
        {
            this.ano = ano < 0 ? 0 : ano;
            this.aliquota = aliquota < 0 ? 0.00m : aliquota;
            this.salario_inf = salarioinf < 0 ? 0.00m : salarioinf;
            this.salario_sup = salariosup < 0 ? 0.00m : salariosup;
            this.teto = teto < 0 ? 0.00m : teto;
        }
    }
}
