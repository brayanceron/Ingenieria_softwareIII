using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Cuotas
    {
        private string fecha_planeada;
        private string fecha_efectiva;
        private int codigo;
        private string estado;
        private int monto;
        private float tasa;
        private string comprobante; //el comprobante es un codigo o cheque
        private string modalidadpago; //Mirar en el documento cheque....

        public Cuotas(string fecha_planeada, string fecha_efectiva,int codigo,string estado, int monto, float tasa, string comprobante, string modalidadpago)
        {
            this.fecha_planeada = fecha_planeada;
            this.fecha_efectiva = fecha_efectiva;
            this.codigo = codigo;
            this.estado = estado;
            this.monto = monto;
            this.tasa = tasa;
            this.comprobante = comprobante;
            this.modalidadpago = modalidadpago;
        }



        public string getfecha_planeada() { return fecha_planeada; }
        public string getfecha_efectiva() { return fecha_efectiva; }
        public int getcodigo() { return codigo; }
        public string getestado() { return estado; }
        public int getmonto() { return monto; }
        public float gettasa() { return tasa; }
        public string getcomprobante() { return comprobante; }
        public string getmodalidadpago() { return modalidadpago; }

        public void setfecha_planeada(string fecha_planeada) { this.fecha_planeada = fecha_planeada; }
        public void setfecha_efectiva(string fecha_efectiva) { this.fecha_efectiva = fecha_efectiva; }
        public void setcodigo(int codigo) { this.codigo = codigo; }
        public void setestado(string estado) { this.estado = estado; }
        public void setmonto(int monto) { this.monto = monto; }
        public void settasa(float tasa) { this.tasa = tasa; }
        public void setcomprobante(string comprobante) { this.comprobante = comprobante; }
        public void setmodalidadpago(string modalidadpago) { this.modalidadpago = modalidadpago; }

    }


    

}
