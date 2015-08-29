using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public abstract class MensagemAviso
    {
        public static bool MensagemUsuario(int TipoAviso, string Aviso)
        {
            switch (TipoAviso)
            {
                case 1:
                    {
                        MessageBox.Show(Aviso + " " + "inserido com sucesso",
                                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1);
                        return true;
                    }
                case 2:
                    {
                        MessageBox.Show(Aviso + " " + "alterado com sucesso",
                                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1);
                        return true;
                    }
                case 3:
                    {
                        if (MessageBox.Show("Deseja realmente excluir?",
                                            Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            return true;
                        else
                            return false;
                    }
                case 4:
                    {
                        MessageBox.Show(Aviso + " " + "excluído com sucesso",
                                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1);
                        return true;
                    }
                default: return false;
            }
        }
    }
}