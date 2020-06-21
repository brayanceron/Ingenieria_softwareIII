using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace WindowsFormsApp3.clases
{
    class Cronograma_prestamo : Cronograma
    {
        //private int codtransaccion;

        public Cronograma_prestamo(/*int codtransaccion,*/  int codigo, Transaccion transaccion)
            : base( codigo, transaccion)
        {
            //this.codtransaccion = codtransaccion;
            this.transaccion = transaccion;
            
        }

        public void generar_cuotas(string codigo_transaccion, int tiempo) //0jo hay que obtener el
        //codigo de la transaccion del objeto transaccion con el metodo materializar TRANSACCION 
        {
            string consulta = "select fechainicioprestamo,fechaterminoprestamo,tasaprestamo,montoprestamo" +
                " from transacciones_prestamo  where codprestamo like'" + codigo_transaccion + "' ";
            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();
            


            DateTime fechainicio = resultados.GetDateTime(0) ;
            DateTime fechatermino = resultados.GetDateTime(1);


            int totaldias = ((fechatermino - fechainicio).Days);
            int num_cuotas = totaldias / tiempo;

           
            string codigo_crono = Convert.ToString(this.getcodigo());



            DateTime fecha_cuota = fechainicio;
            string fecha_planeada;


            long codigo_cuota;
            string estado;

            int montototal = Convert.ToInt32(resultados.GetString(3));
            float tasa = (resultados.GetFloat(2));
            double tasa1 = (resultados.GetDouble(2) / 100);
            //double montofinal = montototal * (1 +Math.Pow() (tasa1 / 100)) ^ num_cuotas;

            double anualidad = montototal * ((tasa1) / (1 - Math.Pow((1 + tasa1), (-1) * num_cuotas)));

            //MessageBox.Show("presesnte="+montototal);
            //string comprobante; //el comprobante es un codigo o cheque
            //string modalidadpago;
            //string fecha_efectiva=null;

            for (int i = 1; i <= num_cuotas; i++)
            {
                ///--aqui se calculala fecha de la transaccion
                fecha_cuota = fecha_cuota.AddDays(tiempo);
                fecha_planeada = fecha_cuota.ToString("dd/MM/yyyy");
                
                codigo_cuota = metodos.generar_codigocuota(10,"cuotas_prestamo", "codcuotaprestamo");
                estado = "PENDIENTE";
                //string monto = Convert.ToString(montofinal / num_cuotas); //Aqui hay que calcular el precio de la cuota
                string monto = Convert.ToString(Math.Round(anualidad, 2));
                string consulta2 = "insert into cuotas_prestamo " +                                                    // modalidd,comprobante                           fecha efectiva        
                    " values('"+ codigo_cuota+ "','"+ codigo_crono + "','" + codigo_transaccion+"','"+monto+"','"+tasa+"',"+ "null,null,'"+estado +"','"+fecha_planeada+"',null)";
                metodos.ejecutar_consulta(consulta2);
                
            }


            

        }

        

    }
}
