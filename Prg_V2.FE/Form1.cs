using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg_V2.FE
{
    public partial class frmInicio : Form
    {
        int YAntes = 0;
        int XAntes = 10;

        int YDespues = 0;
        int XDespues = 10;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btIncremetoAntes_Click(object sender, EventArgs e)
        {
            //++X Incrementa antes
            lblYAntesInicio.Text = YAntes.ToString();
            lblXAntesInicio.Text = XAntes.ToString();

            YAntes = ++XAntes; // Pre-incremento


            lblYAntesFin.Text = YAntes.ToString();
            lblXantesFin.Text = XAntes.ToString();
        }

        private void btIncrementoDespues_Click(object sender, EventArgs e)
        {
            //X++ Incrementa despues
            lblYDespuesInicio.Text = YDespues.ToString();
            lblXDespuesInicio.Text = XDespues.ToString();

            YDespues = XDespues++; // Post-incremento


            lblYDespuesFin.Text = YDespues.ToString();
            lblXDespuesFin.Text = XDespues.ToString();
        }
    }
}
