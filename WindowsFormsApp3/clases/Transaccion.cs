using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Transaccion
    {
        private Cronograma cronogramapagos;
        private int codigo;
        private string estado;
        private Cliente cliente;
        private string fechasolicitud;
        private int monto;
        private float tasa;

        //private Cliente cliente;

        public Transaccion(Cronograma cronogramapagos, int codigo, string estado, Cliente cliente, string fechasolicitud, int monto, float tasa)
        {
            this.cronogramapagos = cronogramapagos;
            this.codigo = codigo;
            this.estado = estado;
            this.cliente = cliente;
            this.fechasolicitud = fechasolicitud;
            this.monto = monto;
            this.tasa = tasa;
        }


        //Metodos accesores
        public Cronograma getcronogramapagos() { return cronogramapagos; }
        public int getcodigo() { return codigo; }
        public string getestado() { return estado; }
        public Cliente getcliente() { return cliente; }
        public string getfechasolicitud() { return fechasolicitud; }
        public int getmonto() { return monto; }
        public float gettasa() { return tasa; }

        public void setcronogramapagos(Cronograma cronograma) { this.cronogramapagos = cronograma; }
        public void setcodigo(int codigo) { this.codigo = codigo;}
        public void setestado(string estado) { this.estado = estado; }
        public void setcliente(Cliente cliente) { this.cliente = cliente; }
        public void setfechasolicitud(string fechasolicitud) { this.fechasolicitud = fechasolicitud; }
        public void setmonto(int monto) { this.monto = monto; }
        public void settasa(float tasa) { this.tasa = tasa; }




        private void generar_cronograma()
        {
            //Nada por ahora
        }
        private void registrar_transaccion()
        {
            //Nada por ahora
        }
        private void modificar_transaccion()
        {
            //Nada por ahora
        }
    }
}
