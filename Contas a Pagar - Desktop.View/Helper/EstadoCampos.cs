using System.Collections.Generic;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public abstract class EstadoCampos
    {
        public static void HabilitaCampos(List<TextBox> Caixas)
        {
            foreach (var item in Caixas)
            {
                item.ReadOnly = false;
            }
        }

        public static void DesabilitaCampos(List<TextBox> Caixas)
        {
            foreach (var item in Caixas)
            {
                item.ReadOnly = true;
            }
        }
    }
}