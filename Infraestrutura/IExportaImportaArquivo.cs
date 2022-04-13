using INSS.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Infraestrutura
{
    public interface IExportaImportaArquivo
    {

        /// <summary>
        /// Deve ler e Gravar o arquivo
        /// </summary>
        List<TabelaInss> Importar();
    }
}
