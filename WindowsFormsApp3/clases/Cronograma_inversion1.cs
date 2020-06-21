using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Npgsql;

namespace WindowsFormsApp3.clases
{
    class Cronograma_inversion1 : Cronograma
    {
        private int cuentabanco;
        //private int codtransaccion;

        public Cronograma_inversion1(int cuenta_banco, int codigo, Transaccion transaccion)
            :base(codigo,transaccion)
        {
            this.cuentabanco = cuenta_banco;
        }

        public int getcuentabanco() { return cuentabanco; }
        public void setcuentabanco(int cuenta) { this.cuentabanco= cuenta; }



        public void generar_cuotas(string codigo_transaccion, int tiempo) //0jo hay que obtener el
                                                                          //codigo de la transaccion del objeto transaccion con el metodo materializar TRANSACCION 
        {
            string consulta = "select fecharealizacioninversion,fechaterminoinversion,tasainversion,montoinversion" +
                " from transacciones_inversion  where codinversion like'" + codigo_transaccion + "' ";
            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();


            string consulta2 = "select numcuentainversionista,bancoinversionista,tipocuentainversionista from" +
                " inversionista join transacciones_inversion on (codinversionista=inversionista)  where codinversion like'" + codigo_transaccion + "' ";
            NpgsqlDataReader result_cliente = metodos.resultados_consulta(consulta2);
            result_cliente.Read();

            //string numcuenta = result_cliente.GetString(0);
            //string banco = result_cliente.GetString(1);
            //string tipocuenta = result_cliente.GetString(2);

            



            DateTime fechainicio = resultados.GetDateTime(0);
            DateTime fechatermino = resultados.GetDateTime(1);


            int totaldias = ((fechatermino - fechainicio).Days);
            int num_cuotas = totaldias / tiempo;


            string codigo_crono = Convert.ToString(this.getcodigo());



            DateTime fecha_cuota = fechainicio;
            string fecha_planeada;

            long codigo_cuota;
            string estado;

            int montototal = Convert.ToInt32(resultados.GetString(3)) ;
            
            float tasa = resultados.GetFloat(2);
            //int montofinal = montototal * (1 + (tasa / 100)) ^ num_cuotas;
            double tasa1 = (resultados.GetDouble(2) / 100);
            double anualidad = montototal * ((tasa1) / (1 - Math.Pow((1+tasa1),(-1)*num_cuotas)));
            //string comprobante; //el comprobante es un codigo o cheque
            //string modalidadpago;
            //string fecha_efectiva=null;

            for (int i = 1; i <= num_cuotas; i++)
            {
                ///--aqui se calculala fecha de la transaccion
                fecha_cuota = fecha_cuota.AddDays(tiempo);
                fecha_planeada = fecha_cuota.ToString("dd/MM/yyyy");

                //codigo_cuota = metodos.generar_codigo();
                codigo_cuota = metodos.generar_codigocuota(11,"cuotas_inversion", "codcuotainversion");
                estado = "PENDIENTE";
                //string monto = Convert.ToString(montofinal/num_cuotas); //Aqui hay que calcular el precio de la cuota
                string monto = Convert.ToString(Math.Round(anualidad,2));
                string consulta3 = "insert into cuotas_inversion " +                                                                 // modalidd,comprobante                           fecha efectiva        
                    " values('" + codigo_cuota + "','" + codigo_crono + "','" + codigo_transaccion + "','" + monto + "','" + tasa + "'," + "null,null,'" + estado + "',null,null,null,'" + fecha_planeada + "',null)";
                metodos.ejecutar_consulta(consulta3);

            }





        }



    }
}
