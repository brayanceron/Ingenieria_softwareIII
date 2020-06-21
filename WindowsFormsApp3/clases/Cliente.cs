using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    public class Cliente
    {
        //atributos
        private long numcedula;
        private int codigo;
        private string nombres;
        private string direccion;
        private long telefono;
        private string modalidadpago;
        public ArrayList transacciones;

        public Cliente(long numcedula, int codigo, string nombres, string direccion, long telefono, string modalidadpago, ArrayList transacciones)
        {
            this.numcedula = numcedula;
            this.codigo = codigo;
            this.nombres = nombres;
            this.direccion = direccion;
            this.telefono = telefono;
            this.modalidadpago = modalidadpago;
            this.transacciones = transacciones;
        }

        public long getnumcedula() {return numcedula;}
        public int getcodigo() { return codigo; }
        public string getnombres() { return nombres; }
        public string getdireccion() { return direccion; }
        public long gettelefono() { return telefono; }
        public string getmodalidadpago() { return modalidadpago; }
        public ArrayList gettransacciones() { return transacciones; }

        public void setnumcedula(long numcedula) { this.numcedula = numcedula; }
        public void setcodigo(int codigo) { this.codigo = codigo; }
        public void setnombres(string nombres) { this.nombres = nombres; }
        public void setdireccion(string direccion) { this.direccion = direccion; }
        public void settelefono(int telefono) { this.telefono = telefono; }
        public void setmodalidadpago(string modalidadpago) { this.modalidadpago = modalidadpago; }
        public void settransacciones(ArrayList transacciones) { this.transacciones = transacciones; }



        private Cliente consultar_info()
        {
            return this;
        }
        private void modificar_info()
        {
            
        }
    }
}
