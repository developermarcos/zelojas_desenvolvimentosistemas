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

        /* Estilo moeda em TextBox, usuário entra e digita somente números, ao sair é realizada a formatação R$ 10,90. 
        * Ao entrar novamente no campo, é removido o R$ e libera para editar novamente 
        * TextBox : TextBoxBase | MaskedTextBox : TextBoxBase
        * 
        * ClassFuncoes.AplicaMascaraMoeda( textBoxValor ); */
        //Função para colocar a mascara

        /* Estilo moeda em TextBox, conforme o usuário vai digitando, a formatação do campo já vai sendo realizada. 
        * TextBox : TextBoxBase | MaskedTextBox : TextBoxBase
        * 
        * ClassHelpers.AplicaMascaraMoeda2(txtValor); */
        static string valor;
        public static void Aplica_KeyPress_Mascara(object sender, KeyPressEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',') {
                e.Handled = (txt.Text.Contains(","));
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        public static void Aplica_Leave_Mascara(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            valor = txt.Text.Replace("R$", "");
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        public static void Aplica_KeyUp_Mascara(object sender, KeyEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            valor = txt.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txt.Text = "0,00" + valor;
            }
            else if (valor.Length == 1)
            {
                txt.Text = "0,0" + valor;
            }
            else if (valor.Length == 2)
            {
                txt.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txt.Text.StartsWith("0,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txt.Text.Contains("00,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txt.Text;
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txt.Select(txt.Text.Length, 0);
        }

        public static void AplicaMascaraMoeda2(TextBoxBase txt)
        {
            txt.KeyPress += Aplica_KeyPress_Mascara;
            txt.Leave += Aplica_Leave_Mascara;
            txt.KeyUp += Aplica_KeyUp_Mascara;
        }

        /*Mascaras gerais criadas por @Marcos Lima
         * CNPJ, CPF, Telefone, Data, Data Hora.
         * 
         * Modelo: ClassHelpers.nomeFunção(campoASerAlterado);
         * */
        //Fução colocar mascara

       

    }
}
