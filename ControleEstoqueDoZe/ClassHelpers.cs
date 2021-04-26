using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueDoZe
{
    class ClassHelpers
    {
        //Evento para tratar quando o campo está em foco.
        public static void CampoEventoEnter(object sender, System.EventArgs e)
        {
            if(sender is TextBoxBase txt)
            {
                txt.BackColor = Color.FromArgb(245, 245, 245);
                //txt.BackColor = Color.FromArgb(255,0,0);

            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.FromArgb(245, 245, 245);

            }else if (sender is RadioButton rb)
            {
                rb.BackColor = SystemColors.ActiveBorder;

            }else if (sender is ListBox lb)
            {
                lb.BackColor = Color.FromArgb(245, 245, 245);

            }else if (sender is DataGridView dgv)
            {
                dgv.BackColor = SystemColors.ActiveBorder;
            }
            else if (sender is ButtonBase bb)
            {
                bb.BackColor = Color.FromArgb(84, 84, 84);
            }
        }
        public static void CampoEventoLeave(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.FromArgb(255, 255, 255);
                //txt.BackColor = Color.FromArgb(255,0,0);

            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = SystemColors.InactiveBorder;

            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.FromArgb(255, 255, 255);

            }
            else if (sender is ListBox lb)
            {
                lb.BackColor = Color.FromArgb(255, 255, 255);

            }
            else if (sender is DataGridView dgv)
            {
                dgv.BackColor = SystemColors.InactiveBorder;
            }
            else if (sender is ButtonBase bb)
            {
                bb.BackColor = Color.FromArgb(44, 44, 44);
            }
        }

        //FUNÇÃO QUE CAPTURA O EVENTO DE UMA TELA
        public static void FormEventoKeyDown(object sender, KeyEventArgs e)
        {
            Control x = (Control)sender;
            Form form = x.FindForm();

            if(e.KeyCode == Keys.Enter)
            {
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);

            }else if (e.KeyCode == Keys.Escape)
            {
                form.Close();
            }
        }

    }
}
