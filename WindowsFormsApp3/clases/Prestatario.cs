using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Prestatario : Cliente
    {
        private Fiador fiador;
        private Garantia garantia;

        public Prestatario(Fiador fiador, Garantia garantia, long numcedula, int codigo, string nombres, string direccion, long telefono, string modalidadpago, ArrayList transacciones)
            : base(numcedula, codigo, nombres, direccion, telefono, modalidadpago, transacciones)
        {
            this.fiador = fiador;
            this.garantia = garantia;
        }
        

        public Fiador getfiador() { return fiador; }
        public Garantia getgarantia() { return garantia; }

        public void setfiador(Fiador fiador) { this.fiador = fiador; }
        public void setgarantia(Garantia garantia) { this.garantia = garantia; }
    }
}
