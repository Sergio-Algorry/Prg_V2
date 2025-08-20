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
        public frmInicio()
        {
            InitializeComponent();
        }
        +
        private void btIncremeto_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(lblSalida.Text);
            //numero++;
            numero = numero + 1;
            lblSalida.Text = numero.ToString();

        }
    }
}
