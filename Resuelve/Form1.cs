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
    /// <summary>
    /// Clase principal del programa
    /// </summary>
    public partial class FormResuelve : Form
    {
        public FormResuelve()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento click del boton Iniciar
        /// </summary>
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Se obtienen las fechas en formato Ticks
            long inicio = dateInicio.Value.Ticks;
            long final = dateFinal.Value.Ticks;

            //Instancia de la clase factura con el id de usuario
            Factura factura = new Factura("335f322f-873a-4e61-8c10-59c87899b984");

            //deshabilita el boton Iniciar y se cambia el cursor
            Cursor.Current = Cursors.WaitCursor;
            btnIniciar.Enabled = false;

            //Se realiza la consulta para obtener las facturas
            factura.totalFacturas(inicio, final);

            //habilita el boton Iniciar y restaura el cursor
            Cursor.Current = Cursors.Arrow;
            btnIniciar.Enabled = true;

            //Muestra el resultado en pantalla
            labelFacturas.Text = "Numero de Facturas: " + factura.cantidad;
            labelPeticiones.Text = "Numero de Peticiones: " + factura.peticiones;
        }
    }
}
