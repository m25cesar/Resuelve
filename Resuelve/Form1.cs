using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resuelve
{
    public partial class FormResuelve : Form
    {
        public FormResuelve()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {//864000000000
            long inicio = dateInicio.Value.Ticks;
            long final = dateFinal.Value.Ticks;
            Factura factura = new Factura("335f322f-873a-4e61-8c10-59c87899b984", inicio, final);

            string cantidad = factura.numeroFacturas();
        }
    }
}
