using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Transaccion_credito : Transaccion
    {
        private string fechaprobacion;
        private string fechainicio;
        private string fechatermino;
        //private string fechasolicitud;
        private Garantia garantia;
        private Fiador fiador;


        public Transaccion_credito(string fecha_aprobacion, string fecha_inicio, string fechatermino, Garantia garantia, Fiador fiador
            , Cronograma cronogramapagos, int codigo, string estado, Cliente cliente, string fechasolicitud,int monto, float tasa)
            : base(cronogramapagos, codigo, estado, cliente, fechasolicitud, monto, tasa)
        {
            this.fechaprobacion = fecha_aprobacion;
            this.fechainicio = fecha_inicio;
            this.fechatermino = fechatermino;
            //this.fechasolicitud = fecha_solicitud;
            this.garantia = garantia;
            this.fiador = fiador;
        }


        public string getfechaprovacion() { return fechaprobacion; }
        public string getfechainicio() { return fechainicio; }
        public string getfechatermino() { return fechatermino; }
        //public string getfechasolicitud() { return fechasolicitud; }
        public Garantia getgarantia() { return garantia; }
        public Fiador getfiador() { return fiador; }

        public void setfechaprovacion(string fecha) { this.fechaprobacion = fecha; }
        public void setfechainicio(string fecha) { this.fechainicio= fecha; }
        public void setfechatermino(string fecha) { this.fechatermino= fecha; }
        //public void setfechasolicitud(string fecha) { this.fechasolicitud = fecha; }
        public void setgarantia(Garantia garantia) { this.garantia = garantia; }
        public void setfiador(Fiador fiador) { this.fiador = fiador; }

        public void pagar_credito()
        {
            //HAcer
        }
        public void gestionar_garantia()
        {
            //HAcer
        }
    }
}
