using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Garantia
    {
        private int valor;
        private int codigo;
        private string ubicacion;

        public Garantia(int valor, int codigo, string ubicacion)
        {
            this.valor = valor;
            this.codigo = codigo;
            this.ubicacion = ubicacion;
        }



        public int getvalor() { return valor; }
        public int getcodigo() { return codigo; }
        public string getubicacion() { return ubicacion; }

        public void setvalor(int valor) { this.valor = valor; }
        public void setcodigp(int codigo) { this.codigo = codigo; }
        public void setubicacion(string ubicacion) { this.ubicacion = ubicacion; }

    }
}
