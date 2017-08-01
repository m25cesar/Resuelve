using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Resuelve
{
    /// <summary>
    /// Clase Factura
    /// En esta clase se implementan los metodos para la comunicacion y recepcion
    /// de datos para las facturas.
    /// </summary>
    class Factura
    {
        private string id; //id de usuario
        public int peticiones; //Peticiones realizadas
        public int cantidad; //Cantidad total de facturas

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="id">id de usuario</param>
        public Factura(string id)
        {
            this.id = id;
        }

        /// <summary>
        /// Metodo para obtener la cantidad total de facturas en un rango de fechas
        /// </summary>
        /// <param name="fechaInicio">fecha de inicio</param>
        /// <param name="fechaFinal">fecha final</param>
        public void totalFacturas(long fechaInicio, long fechaFinal)
        {
            this.peticiones = 0;
            this.cantidad = numeroFacturas(fechaInicio, fechaFinal);
        }

        /// <summary>
        /// Metodo recursivo para obtener la cantidad de facturas en un rango de fechas
        /// </summary>
        /// <param name="fechaInicio">fecha de inicio</param>
        /// <param name="fechaFinal">fecha final</param>
        /// <returns>numero de facturas obtenidas en el rango de fechas</returns>
        private int numeroFacturas(long fechaInicio, long fechaFinal)
        {
            string res = peticionFacturas(fechaInicio, fechaFinal);
            int total;

            if(!int.TryParse(res,out total)) //Si la cantidad de facturas fue mayor que 100
            {
                // Se obtiene la fecha intermedia entre las 2 fechas
                long temp = fechaFinal - ((fechaFinal-fechaInicio)/2);

                //se divide el rango de fechas entre 2 para evitar un resultado mayor a 100
                total = numeroFacturas(fechaInicio, temp) + numeroFacturas(temp + 864000000000, fechaFinal);
            }

            return total;
        }

        /// <summary>
        /// Metodo para realizar las peticiones web al servidor
        /// </summary>
        /// <param name="fechaInicio">fecha de inicio</param>
        /// <param name="fechaFinal">fecha final</param>
        /// <returns>respuesta del servidor</returns>
        private string peticionFacturas(long fechaInicio, long fechaFinal)
        {
            //Se convierte la fecha a formato DateTime
            DateTime dateInicio = new DateTime(fechaInicio);
            DateTime dateFinal = new DateTime(fechaFinal);

            string urlFacturas = "http://34.209.24.195/facturas";

            //Construccion de la url
            string url = urlFacturas + "?id=" + this.id + "&start=" + dateInicio.ToString("yyyy-MM-dd") + "&finish=" + dateFinal.ToString("yyyy-MM-dd");

            //Se realiza la peticion al servidor
            WebClient client = new WebClient();
            string res = client.DownloadString(url);

            this.peticiones++; //se incrementa el contador de peticiones

            return res;
        }
    }
}
