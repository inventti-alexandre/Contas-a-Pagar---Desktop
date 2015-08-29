using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public abstract class ValidacaoNumericos
    {
        public static void NumericKeyPress(KeyPressEventArgs e)
        {
            if (((int)(e.KeyChar) < 48 | (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 13 && (int)e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }
    }
}