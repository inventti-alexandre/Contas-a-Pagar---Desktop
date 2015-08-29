using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public abstract class MensagemErro
    {
        public static bool Erro(string message)
        {
            if (message != null)
            {
                MessageBox.Show("Houve um erro na hora de realizar a operação" + " = " + message,
                                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                return true;
        }
    }
}