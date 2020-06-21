using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Fiador : Cliente
    {
        private Prestatario prestatario;

        public Fiador(Prestatario prestatario, long numcedula, int codigo, string nombres, string direccion, long telefono, string modalidadpago, ArrayList transacciones)
            : base(numcedula, codigo, nombres, direccion, telefono, modalidadpago, transacciones)
        {
            this.prestatario = prestatario;
        }


        //OJO estos metodos no estan en el diagrama de clases
        public Prestatario getfiador() { return prestatario; }

        public void setprestatario(Prestatario prestatario) { this.prestatario = prestatario; }

    }
}
