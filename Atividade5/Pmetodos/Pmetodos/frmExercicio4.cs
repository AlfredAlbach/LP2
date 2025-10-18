using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContaNum_Click(object sender, EventArgs e)
        {
            int comprimento = rchText.Text.Length;
            int contaNum =0 ;
            int contador =0;
            while (contador < comprimento)
            {
                if (char.IsNumber(rchText.Text[contador]))
                {
                    contaNum++;
                }
                contador++;
            }
            MessageBox.Show($"o texto tem {contaNum} números");
        }

        private void btnContaLetras_Click(object sender, EventArgs e)
        {
            int contaLetra = 0;
            foreach (var c in rchText.Text)
            {
                if (char.IsLetter(c))
                {
                    contaLetra++;
                }
            }
            MessageBox.Show($"O texto tem {contaLetra} letras!");
        }
    }
}
