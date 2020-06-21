using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Inversionista : Cliente
    {
        private string numcuenta;
        private string banco;
        private string tipocuenta;

        public Inversionista(string numcuenta, string banco, string tipocuenta, long numcedula, int codigo, string nombres, string direccion, long telefono, string modalidadpago, ArrayList transacciones)
            :base(numcedula,codigo,nombres,direccion,telefono,modalidadpago,transacciones) //: base (int numcedula, int codigo, string nombres, string apellidos, string direccion, int telefono, string modalidadpago, strin
        {

            this.numcuenta = numcuenta;
            this.banco = banco;
            this.tipocuenta = tipocuenta;

        }


        public string getnumcuenta() { return numcuenta; }
        public string getbanco() { return banco; }
        public string gettipocuenta() { return tipocuenta; }

        public void setnumcuenta(string numcuenta) { this.numcuenta = numcuenta; }
        public void setbanco(string banco) { this.banco = banco; }
        public void settipocuenta(string tipocuenta) { this.tipocuenta = tipocuenta; }


    }
}
