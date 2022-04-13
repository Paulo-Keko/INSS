using INSS.Classe;
using INSS.Infraestrutura;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace INSS.Repositorio
{
    public class AliquotaDesconto: IAliquotaDesconto
    {

        private TabelaInss Aliquota(short ano, decimal salario)
        {

            decimal _aliquota = 0m;
            decimal _teto = 0m;
            TabelaInss _aliquotaVal = new TabelaInss();
            List<TabelaInss> _tabela;

            _tabela = Tabela(ano);

            if (_tabela != null && _tabela.Any())
            {
                _aliquota = _tabela.OrderByDescending(p => p.salario_sup).FirstOrDefault(x => x.salario_inf <= salario && x.salario_sup >= salario && x.ano == ano).aliquota;
                _teto = _tabela.OrderByDescending(p => p.salario_sup).FirstOrDefault(x => x.salario_inf <= salario && x.salario_sup >= salario && x.ano == ano).teto;
                _aliquotaVal = new TabelaInss(ano, _aliquota, salario, 0.0m, _teto);
            }
            else
            {
                MessageBox.Show("Tabela do INSS vazia, não foi possível obter o valor da aliquota!", "Aviso",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
            }


            return _aliquotaVal==null?new TabelaInss(): _aliquotaVal;
        }

        public decimal CalculaDesconto(short ano, decimal salario)
        {
            
            decimal _salario;
            if (Aliquota(ano, salario).aliquota == 0)
            {
                _salario = Aliquota(ano, salario).teto;
            }
            else
            {
                _salario = salario * Aliquota(ano, salario).aliquota / 100;
            }

            return _salario;
        }
        private List<TabelaInss> Tabela(short ano)
        {


            ExportaImportaArquivo _tabela = new ExportaImportaArquivo();
            List<TabelaInss> lista = _tabela.Importar();

            return lista;
        }


        public AliquotaDesconto() { }
    }
}
