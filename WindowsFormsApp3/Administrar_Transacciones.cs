using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.clases;

namespace WindowsFormsApp3
{
    public partial class Administrar_Transaciones : Form
    {
        public Administrar_Transaciones(int boton)
        {
            InitializeComponent();

            if (boton == 1) { Administrar_Transacciones.SelectedTab = tabPage1; }
            if (boton == 2) { Administrar_Transacciones.SelectedTab = tabPage2; }
        }
        static string codigogarantia = metodos.generar_codigo(4,"garantia","codgarantia");

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chbx_garantia_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void chbx_gar_CheckedChanged(object sender, EventArgs e)
        {
            
            //chbx_gar.Checked = true;
            if (chbx_gar.Checked == true)
            {
                chbx_fiador.Checked = false;
                chbx_fiador.Enabled = false;
                codigogarantia = metodos.generar_codigo(4, "garantia", "codgarantia");
                Administrar_Garantia nuevo = new Administrar_Garantia(Convert.ToInt32(codigogarantia));
                pnl_codfiador.Enabled = false;
                nuevo.Show();
                
            }

        }

        private void chbx_fiador_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_fiador.Checked == true)
            {
                chbx_gar.Checked = false;
                chbx_gar.Enabled = false;
                pnl_codfiador.Enabled = true;
            }
                
        }



        

        private void btn_registrarprestamo_Click(object sender, EventArgs e)
        {
            ///---validar que todos los campos este llenos
            if (txb_codigoclienteprest.Text.Equals("") ||
                txb_fechasolicitud.Text.Equals("") ||
                txb_monto.Text.Equals("") ||
                txb_tasa.Text.Equals("") ||
                txb_tiempopres.Text.Equals("") ||
                txb_estadopres.Text.Equals("")
                )
            {
                MessageBox.Show("Debe digitar todos los campos"); return;
            }
            try
            {
                
                DateTime c4 = Convert.ToDateTime(txb_fechasolicitud.Text);
                if(txb_estadopres.Text.Equals("APROBADO"))
                {
                    DateTime c1 = Convert.ToDateTime(txb_fechaprovacion.Text);
                    DateTime c2 = Convert.ToDateTime(txb_fechainicio.Text);
                    DateTime c3 = Convert.ToDateTime(txb_fechatermino.Text);
                }

            }
            catch { MessageBox.Show("Las Fechas no tienen el formato correcto"); return; }





            //OJO0 HAY QUE VALIDAR DE QUE FIADOR Y GARANTIA UNO DDE LOS DOS ESTEN BALIDADOS
            if (chbx_fiador.Checked == true)
            {

            }
            else if (chbx_gar.Checked == true)
            {

            }
            else { MessageBox.Show("Debe definir el soporte de la deuda");return; }
            if (txb_estadopres.Text.Equals("APROBADO"))
            {
                if (txb_fechaprovacion.Text.Equals("") ||
                txb_fechainicio.Text.Equals("") ||
                txb_fechatermino.Text.Equals("")
                )
                {
                    MessageBox.Show("Debe digitar todos los campos"); return;
                }
            }



            //validar que la fecha de termino sea mayor que la fecha de inicio
            string cronograma = null;
            string codigo_trnsac = metodos.generar_codigo(7, "transacciones_prestamo","codprestamo");
            string estado = txb_estadopres.Text;
            //string cliente;//= txb_codigoclienteprest.Text;//objeto cliente            
            string cedula = txb_codigoclienteprest.Text;///objeto cliente    se obtiene mas adelante
            string fechasolicitud = txb_fechasolicitud.Text;
            int monto = int.Parse(txb_monto.Text);
            float tasa = float.Parse(txb_tasa.Text);
            string tiempotasa = txb_tiempopres.Text;


            string fechaprobacion = txb_fechaprovacion.Text;
            string fechainicio = txb_fechainicio.Text;
            string fechatermino = txb_fechatermino.Text;


            string  fiadorcad = txb_codfiador.Text; 
            string  garantia=Convert.ToString(codigogarantia);
            
          
            



            if (chbx_fiador.Checked== true) { if (txb_codfiador.Text.Equals("")){ MessageBox.Show("Digite todos los campos"); return; } }


            //BUSCA SI EXISTE EL CLIENTE
            Boolean flag = false;
         
            if ((metodos.buscar("prestatario", "cedulaprestatario", cedula) == true))
            {
                flag = true;
            }
            else { MessageBox.Show("Prestatario No encontrado");return; }


            
            
                




            //buscando el prestatario
            NpgsqlDataReader rp= metodos.resultados_consulta("select * from prestatario where cedulaprestatario like '"+cedula+"'");
            rp.Read();
            string codigo = rp.GetString(0);


            ///--DETERMINANDO LAS FECHAS
            if (txb_estadopres.Text.Equals("APROBADO"))
            {
                //string fechainicio = txb_fechainicio.Text;
                //string fechatermino = txb_fechatermino.Text;
                DateTime cfi = Convert.ToDateTime(fechainicio);
                DateTime cff = Convert.ToDateTime(fechatermino);

                string item = txb_tiempopres.Text;
                //MessageBox.Show(item);
                int tiempo = 0;

                if (item.Equals("MENSUAL")) { tiempo = 30; }
                else if (item.Equals("BIMESTRAL")) { tiempo = 60; }
                else if (item.Equals("TRIMESTRAL")) { tiempo = 90; }
                else if (item.Equals("SEMESTRAL")) { tiempo = 181; }
                else if (item.Equals("ANUAL")) { tiempo = 365; }
                else { MessageBox.Show("ERROR INESPEDARO"); return; }


                DateTime fci = Convert.ToDateTime(fechainicio);
                DateTime fhf = Convert.ToDateTime(fechatermino);


                int totaldias = ((fhf - fci).Days);
                //MessageBox.Show("Diferencia de dias es " + totaldias);
                int num_cuotas = totaldias / tiempo;
                if (totaldias < 0) { MessageBox.Show("Fecha incorrecta, no puede ser menor que la fecha actual"); return; }

                if (num_cuotas < 5) { MessageBox.Show("El numero de cuotas es muy pequeño para aprobar la transaccion"); return; }

                if (num_cuotas > 30) { MessageBox.Show("El numero de cuotas supera la capacidad de procesamiento de la base de datos"); return; }

            }





            string sql = "insert into transacciones_prestamo values('" + codigo_trnsac + "',null,'" + codigo + "','" + fechasolicitud + "','" + monto + "','" + tasa + "','"+tiempotasa+"','" + estado + "',";


            //txb_fechaprovacion
            if (txb_fechaprovacion.Text.Equals("")) { fechaprobacion = null; sql += "null" + ","; }
            else { fechaprobacion = (txb_fechaprovacion.Text); sql += "'" + fechaprobacion + "',"; }

            if (txb_fechainicio.Text.Equals("")) {  fechainicio= null; sql += "null" + ","; }
            else { fechainicio = (txb_fechainicio.Text); sql += "'" + fechainicio + "',"; }

            if (txb_fechatermino.Text.Equals("")) { fechatermino = null; sql += "null" + ","; }
            else { fechatermino = (txb_fechatermino.Text); sql += "'" + fechatermino + "',"; }

            

            if (chbx_fiador.Checked == true)
            {
                sql += "'" + fiadorcad + "',null)";
                if (metodos.buscar("fiador", "codfiador", fiadorcad) == false) { MessageBox.Show("El fiador no ha sido encontrado"); return; }
                metodos.tabla_consulta(sql);

            }

            if (chbx_gar.Checked == true)
            {
                sql += "null,'"  + garantia+"')";
                 metodos.tabla_consulta(sql);
            }

            

            MessageBox.Show("Transacción registrada exitosamente");

            ///--vaciando cajas
            ///
            txb_codigoclienteprest.Text= ("");
            txb_fechasolicitud.Text = ("");
            txb_monto.Text = ("");
            txb_tasa.Text = ("");
            txb_tiempopres.Text = ("");
            txb_estadopres.Text = null;
            
            txb_fechaprovacion.Text = ("");
            txb_fechainicio.Text = ("");
            txb_fechatermino.Text = ("");
            this.Close();
        }
        
        private void txb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txb_estadopres.Text.Equals("ESTUDIO"))
            { pnl_aprovado.Enabled = false;
                txb_fechaprovacion.Text = "";
                txb_fechainicio.Text = "";
                txb_fechatermino.Text = "";
            }
            if (txb_estadopres.Text.Equals("APROBADO"))
            {
                pnl_aprovado.Enabled = true;           
                txb_fechaprovacion.Text = metodos.fecha_hoy();
                txb_fechainicio.Text = metodos.fecha_hoy();
            }
            if (txb_estadopres.Text.Equals("REPROBADO")) { pnl_aprovado.Enabled = false;
                txb_fechaprovacion.Text = "";
                txb_fechainicio.Text = "";
                txb_fechatermino.Text = "";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pnl_aprovado.Enabled = false;
            pnl_codfiador.Enabled = false;
            pnl_fechasinver.Enabled = false;
            txb_fechasolicitudinver.Text = metodos.fecha_hoy();
            txb_fechasolicitud.Text = metodos.fecha_hoy();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
     
        private void btn_registrarinver_Click(object sender, EventArgs e)
        {
            ///---validar que todos los campos este llenos
            if (txb_codclienteinver.Text.Equals("") ||
                txb_montoinver.Text.Equals("") ||
                txb_fechasolicitudinver.Text.Equals("") ||
                txb_tasainver.Text.Equals("") ||
                txb_tiempoinver.Text.Equals("") ||
                txb_estadoinver.Text.Equals("")
                )
            {
                MessageBox.Show("Debe digitar todos los campos"); return;
            }
            try
            {
                
                DateTime c3 = Convert.ToDateTime(txb_fechasolicitudinver.Text);
                if (txb_estadoinver.Text.Equals("APROBADO"))
                {
                    DateTime c1 = Convert.ToDateTime(txb_fecharealizacioninver.Text);
                    DateTime c2 = Convert.ToDateTime(txb_fechaterminoinver.Text);
                }
                //DateTime c4 = Convert.ToDateTime(txb_fechasolicitud.Text);
            }
            catch { MessageBox.Show("Las Fechas no tienen el formato correcto"); return; }




            if (txb_estadoinver.Text.Equals("APROBADO"))
            {
                if (txb_fecharealizacioninver.Text.Equals("") ||
                txb_fechaterminoinver.Text.Equals("") 
                )
                {
                    MessageBox.Show("Debe digitar todos los campos"); return;
                }
            }





            //validar que la fecha de termino sea mayor que la fecha de inicio
            string cronograma = null;
            string codigo_transac = metodos.generar_codigo(8,"transacciones_inversion","codinversion");
            string estado = txb_estadoinver.Text;
            string cliente ; //txb_codclienteinver.Text;//objeto cliente
            string cedula = txb_codclienteinver.Text;
            string fechasolicitud = txb_fechasolicitudinver.Text;
            int monto = int.Parse(txb_montoinver.Text);
            float tasa = float.Parse(txb_tasainver.Text);
            string tiempotasa = txb_tiempoinver.Text;
            string tiempotasainver = txb_tiempoinver.Text;

            //string fechaprobacion = txb_fechaprovacion.Text;
            string fecharealizacion = txb_fecharealizacioninver.Text;
            string fechatermino = txb_fechaterminoinver.Text;
            

            string grabar = "";

            //verificar que hay digitado todos los campos
           


            //BUSCA SI EXISTE EL CLIENTE
            Boolean flag = false;

            if ((metodos.buscar("inversionista", "cedulainversionista", cedula) == true))
            {
                flag = true;
            }
            else { MessageBox.Show("Inversionista No encontrado"); return; }



            //buscando el p
            NpgsqlDataReader rp = metodos.resultados_consulta("select * from inversionista where cedulainversionista like '" + cedula + "'");
            rp.Read();
            string codigo = rp.GetString(0);



            //DateTime cfi = Convert.ToDateTime(fechainicio);
            //DateTime cff = Convert.ToDateTime(fechatermino);





            ///--DETERMINANDO LAS FECHAS
            //string fechainicio = txb_fechainicio.Text;
            //string fechatermino = txb_fechatermino.Text;
            if (txb_estadoinver.Text.Equals("APROBADO"))
            {
                string item = txb_tiempoinver.Text;
                //MessageBox.Show(item);
                int tiempo = 0;

                if (item.Equals("MENSUAL")) { tiempo = 30; }
                else if (item.Equals("BIMESTRAL")) { tiempo = 60; }
                else if (item.Equals("TRIMESTRAL")) { tiempo = 90; }
                else if (item.Equals("SEMESTRAL")) { tiempo = 181; }
                else if (item.Equals("ANUAL")) { tiempo = 365; }
                else { MessageBox.Show("ERROR INESPEDARO"); return; }


                DateTime fci = Convert.ToDateTime(fecharealizacion);
                DateTime fhf = Convert.ToDateTime(fechatermino);


                int totaldias = ((fhf - fci).Days);
                //MessageBox.Show("Diferencia de dias es " + totaldias);
                int num_cuotas = totaldias / tiempo;
                if (totaldias < 0) { MessageBox.Show("Fecha incorrecta, no puede ser menor que la fecha actual"); return; }

                if (num_cuotas < 5) { MessageBox.Show("El numero de cuotas es muy pequeño para aprobar la transaccion"); return; }

                if (num_cuotas > 30) { MessageBox.Show("El numero de cuotas supera la capacidad de procesamiento de la base de datos"); return; }

            }



            string sql = "insert into transacciones_inversion values('" + codigo_transac + "',null,'" + codigo + "','" + fechasolicitud + "','" + monto + "','" + tasa + "','" + tiempotasa + "','" + estado + "',";


            //txb_fechaprovacion
            ///por si algun dia se exige fecha de aprovacion
            //if (txb_fechaprovacion.Text.Equals("")) { fechaprobacion = null; sql += "null" + ","; }
            //else { fechaprobacion = (txb_fechaprovacion.Text); sql += "'" + fechaprobacion + "',"; }

            if (txb_fecharealizacioninver.Text.Equals("")) { fecharealizacion = null; sql += "null" + ","; }
            else { fecharealizacion = (txb_fecharealizacioninver.Text); sql += "'" + fecharealizacion + "',"; }

            if (txb_fechaterminoinver.Text.Equals("")) { fechatermino = null; sql += "null" ; }
            else { fechatermino = (txb_fechaterminoinver.Text); sql += "'" + fechatermino+"'" ; }

            sql += ")";




            metodos.tabla_consulta(sql);

            MessageBox.Show("Transaccion registrada exitosamente");

            ///--vaciando cajas
            txb_codclienteinver.Text=("");
            txb_montoinver.Text = ("");
            txb_fechasolicitudinver.Text = ("");
            txb_tasainver.Text = ("");

            txb_tiempoinver.Text = null;
            txb_estadoinver.Text = null;

            txb_fecharealizacioninver.Text = ("");
            txb_fechaterminoinver.Text= ("");
            this.Close();
        }

        private void txb_estadoinver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txb_estadoinver.Text.Equals("ESTUDIO")) {
                pnl_fechasinver.Enabled = false;
                txb_fecharealizacioninver.Text = "";
                txb_fechaterminoinver.Text = "";
            }
            if (txb_estadoinver.Text.Equals("APROBADO"))
            {
                pnl_fechasinver.Enabled = true;
                txb_fecharealizacioninver.Text = metodos.fecha_hoy();                
            }
            if (txb_estadoinver.Text.Equals("REPROBADO")) {
                pnl_fechasinver.Enabled = false;
                txb_fecharealizacioninver.Text = "";
                txb_fechaterminoinver.Text = "";
            }
        }

        private void txb_codigoclienteprest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_monto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_tasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txb_codclienteinver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_montoinver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_fechasolicitudinver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txb_fechasolicitudinver_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_fechasolicitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void txb_fechasolicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_codigoclienteprest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_codfiador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_codclienteinver_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_montoinver_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_tasainver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
