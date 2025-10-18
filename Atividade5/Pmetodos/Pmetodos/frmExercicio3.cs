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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            char[] vetor =txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor);
            string auxiliar = new string(vetor);
            txtPalavra2.Text = auxiliar;  

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPalavra1.Text = "";
            txtPalavra2.Text = "";
        }
    }
}
