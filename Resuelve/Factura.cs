using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Resuelve
{
    class Factura
    {
        private string id;
        private long fechaInicio;
        private long fechaFinal;

        public Factura(string id, long fechaInicio, long fechaFinal)
        {
            this.id = id;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
        }

        public string numeroFacturas()
        {
            DateTime dateInicio = new DateTime(this.fechaInicio);
            DateTime dateFinal = new DateTime(this.fechaFinal);

            string urlFacturas = "http://34.209.24.195/facturas";
            string url = urlFacturas + "?id=" + this.id + "&start=" + dateInicio.ToString("yyyy-MM-dd") + "&finish=" + dateFinal.ToString("yyyy-MM-dd");

            WebClient client = new WebClient();
            string res = client.DownloadString(url);

            return res;
        }
    }
}
