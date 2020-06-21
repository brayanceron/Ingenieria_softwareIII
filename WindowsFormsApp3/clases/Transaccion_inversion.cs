using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Transaccion_inversion : Transaccion
    {
        private string fecharealizacion;
        private string fechatermino;

        public Transaccion_inversion(string fecharealizacion, string fechatermino, Cronograma cronogramapagos, int codigo, string estado, Cliente cliente, string fechasolicitud, int monto, float tasa)
            :base(cronogramapagos,codigo,estado,cliente,fechasolicitud,monto,tasa) 
        {
            this.fecharealizacion = fecharealizacion;
            this.fechatermino = fechatermino;
        }


        public string getfecharealizacion() { return fecharealizacion; }
        public string getfechatermino() { return fechatermino; }

        public void setfecharealizacion(string fecha) { this.fecharealizacion= fecha; }
        public void setfechatermino(string fecha) { this.fechatermino = fecha; }






        private void pagar_inversion()
        {
          //HACer
        }
    }
}
