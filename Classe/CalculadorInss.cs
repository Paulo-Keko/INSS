using INSS.Infraestrutura;
using INSS.Repositorio;

namespace INSS.Classe
{
    public class CalculadorInss: ICalculadorInss
    {
        public decimal CalcularDesconto(int data, decimal salario)
        {
            short _ano = (short)data;
            decimal _salario = salario;

            AliquotaDesconto _aliquota = new AliquotaDesconto();
            decimal _descontosalario = _aliquota.CalculaDesconto(_ano, _salario);


            return _descontosalario;
        }

        public CalculadorInss() { }
    }
}
