using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Cronograma
    {
        private ArrayList cuotas;
        private int codigo;
        public Transaccion transaccion;

        public Cronograma(int codigo, Transaccion transaccion)
        {
            //this.cuotas = cuotas;
            this.codigo = codigo;
            this.transaccion = transaccion;
        }

        //metodos accesores
        public ArrayList getcuotas() { return cuotas; }
        public int getcodigo() { return codigo; }
        public Transaccion gettransaccion() { return transaccion; }

        public void setcuotas(ArrayList cuotas) { this.cuotas = cuotas; }
        public void setcodigo(int codigo) { this.codigo = codigo; }
        public void settransaccion(Transaccion transaccion) { this.transaccion= transaccion; }



        private  void generar_cuotas()
        {


        }
    }
}
