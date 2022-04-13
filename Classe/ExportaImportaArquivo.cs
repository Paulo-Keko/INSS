using INSS.Infraestrutura;
using System;
using System.Collections.Generic;

namespace INSS.Classe
{
    public class ExportaImportaArquivo : IExportaImportaArquivo
    {

        public List<TabelaInss> Importar()
        {
            try
            {
                //Criar Dados mockados para teste!!!

               List<TabelaInss> _tabela = new List<TabelaInss>();

                _tabela.Add(new TabelaInss(2011, 8.00m, 0m, 1106.90m,0m));
                _tabela.Add(new TabelaInss(2011, 9.00m, 1106.91m, 1844.83m,0m));
                _tabela.Add(new TabelaInss(2011, 11.00m, 1844.83m, 3689.66m,0m));
                _tabela.Add(new TabelaInss(2011, 0m, 3689.67m, decimal.MaxValue, 405.86m));
                _tabela.Add(new TabelaInss(2012, 7.00m, 0m, 1000.00m, 0m));
                _tabela.Add(new TabelaInss(2012, 8.00m, 1000.01m, 1500.00m, 0m));
                _tabela.Add(new TabelaInss(2012, 9.00m, 1500.01m, 3000.00m, 0m));
                _tabela.Add(new TabelaInss(2012, 11.00m, 3000.01m, 4000.00m, 0m));
                _tabela.Add(new TabelaInss(2012, 0m, 4000.01m, decimal.MaxValue,500.00m));

                return _tabela;
                }
            catch (Exception ex)
            {
                return new List<TabelaInss>();
            }
        }

        public ExportaImportaArquivo() { }
    }
}
