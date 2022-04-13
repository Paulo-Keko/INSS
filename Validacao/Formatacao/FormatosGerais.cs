using System.Windows.Forms;

namespace INSS.Validacao.Formatacao
{
    public class FormatosGerais
    {
        public static string ToMoney(TextBox text, string format = "C2")
        {
            double value;
            if (double.TryParse(text.Text, out value))
            {
                text.Text = value.ToString(format);
            }
            else
            {
                text.Text = "0,00";
            }

            return text.Text;
        }

        public FormatosGerais() { }
    }
}
