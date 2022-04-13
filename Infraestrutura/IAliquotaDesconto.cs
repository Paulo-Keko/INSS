using INSS.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Infraestrutura
{
    public interface IAliquotaDesconto
    {
        decimal CalculaDesconto(short ano, decimal salario);

    }
}
