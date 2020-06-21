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
    public partial class Generar_Cronogramas : Form
    {
        static DataTable tablacuotascred;
        static DataTable tablacuotasinver;



        public Generar_Cronogramas(int boton)
        {
            InitializeComponent();
            if (boton == 1) { tabControl1.SelectedTab = tabPage1; }
            if (boton == 2) { tabControl1.SelectedTab = tabPage2; }


            tablacuotascred = new DataTable();
            
            /*tablacuotascred.Columns.Add("CRONOGRAMA");
            tablacuotascred.Columns.Add("FCH. PLANEADA");
            tablacuotascred.Columns.Add("FCH. EFECTIVA");
            tablacuotascred.Columns.Add("COD TRANSACCION");
            tablacuotascred.Columns.Add("MONTO");
            tablacuotascred.Columns.Add("TASA");
            tablacuotascred.Columns.Add("COMPROBANTE");
            tablacuotascred.Columns.Add("MODALIDAD");
            tablacuotascred.Columns.Add("TIPO");
            tablacuotascred.Columns.Add("ESTADO");
            */
            tbl_screencredito.DataSource = tablacuotascred;
            /*
            tablacuotascred.Rows.Add("XXXX","XX/XX/XXXX", "XX/XX/XXXX", "XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXX", "XXXXX", "PAGADA"  );
            tablacuotascred.Rows.Add("XXXX","XX/XX/XXXX", "XX/XX/XXXX", "XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXX", "XXXXX", "PENDIENTE");
            */




            tablacuotasinver = new DataTable();
            /*
            tablacuotasinver.Columns.Add("CRONOGRAMA");
            tablacuotasinver.Columns.Add("FCH. PLANEADA");
            tablacuotasinver.Columns.Add("FCH. EFECTIVA");
            tablacuotasinver.Columns.Add("COD TRANSACCION");
            tablacuotasinver.Columns.Add("MONTO");
            tablacuotasinver.Columns.Add("TASA");
            tablacuotasinver.Columns.Add("COMPROBANTE");
            tablacuotasinver.Columns.Add("MODALIDAD");
            tablacuotasinver.Columns.Add("TIPO");
            tablacuotasinver.Columns.Add("NUM CUENTA");
            tablacuotasinver.Columns.Add("BANCO");
            tablacuotasinver.Columns.Add("ESTADO");
            tbl_screeninver.DataSource = tablacuotasinver;

            tablacuotasinver.Rows.Add("XXXX", "XX/XX/XXXX", "XX/XX/XXXX", "XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXX", "XXXXX",  "XXXXX", "XXXXX", "PAGADA");
            tablacuotasinver.Rows.Add("XXXX", "XX/XX/XXXX", "XX/XX/XXXX", "XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXX", "XXXXX",  "XXXXX", "XXXXX", "PENDIENTE");

    */

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        Boolean es_generadopres = false;
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //si la transaccion ya fue generada que vuelva a mostrar las cuotas
            //sino, genere las cuotas

            string busc = txb_codigotransaccion.Text;
            if (txb_codigotransaccion.Text.Equals("")) { MessageBox.Show("Digite todos los campos");return; }

            ///Validando que la transaccion exista
            if (metodos.buscar("transacciones_prestamo", "codprestamo", busc) == true) { }
            else {
                MessageBox.Show("La transaccion no fue encontrada");
                lbl_nombre.Text = "";
                lbl_codigocliente.Text = "";
                lbl_codcredito.Text = "";
                pnl_generar.Enabled = false;
                tbl_screencredito.DataSource = null;
                return;
            }




            string consulta = "select codprestatario,nombreprestatario,codprestamo,fiador,garantia,estadoprestamo,montoprestamo" +
                " from transacciones_prestamo join prestatario on(prestatario=codprestatario) where codprestamo like '"+busc+"'";
            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();
            string est = resultados.GetString(5);
            //MessageBox.Show("EStado: "+est);


            ///--si la transaccion fue aprovada
            if (est.Equals("APROBADO"))
            {
                //MessageBox.Show("La Transaccion ya ha sido aprobada");                
            }

            else{
                MessageBox.Show("La transaccion no ha sido aprobada");
                btn_cancelarpres.Enabled = false;
                btn_imprimirpres.Enabled = false;
                btn_generarcronogramaprestamo.Enabled = false;
                return;
            }


            lbl_nombre.Text = resultados.GetString(1);
            lbl_codigocliente.Text = resultados.GetString(0);
            lbl_codcredito.Text = resultados.GetString(2);


            
            pnl_generar.Enabled = true;


            //si la transaccion ya ha sido generada
            
            if (metodos.buscar("cuotas_prestamo", "prestamo", busc) == true)
            {
                MessageBox.Show("La transaccion ya ha sido generada");
                //btn_cancelarpres.Enabled = false;
                //btn_imprimirpres.Enabled = false;
                btn_generarcronogramaprestamo.Enabled = false;
                es_generadopres = true;
            }
            else { es_generadopres = false; }





            ///Todo lo que tiene que ver con la tabla

            if (es_generadopres == true)
            {
                string consulta2 = "select * from cuotas_prestamo where prestamo like'" + busc + "' order by fechaplaneadaprestamo";

                DataTable tablacuotas = metodos.tabla_consulta(consulta2);
                tbl_screencredito.DataSource = (tablacuotas);
            }
            


        }

        ///=========================================================================000

        private void generarcroprestamo_CLICK(object sender, EventArgs e)
        {
            /*string codigo_cronograma = metodos.generar_codigo(5, "cronograma_prestamo","codcronogramaprestamo"); //ojo aqui genero el codigo del cronograma...
            int codigo_transaccion = Convert.ToInt32(txb_codigotransaccion.Text);
            string codigo_transac = txb_codigotransaccion.Text;


            ///Validando que la transaccion exista
            if (metodos.buscar("transacciones_prestamo", "codprestamo", txb_codigotransaccion.Text) == true) { }
            else { MessageBox.Show("La transaccion no fue encontrada"); return; }




            //VALIDAR CTRANSACCION COMPLETA: 0j0 aqui
            

            

            string cd = txb_codigotransaccion.Text;
            string ver_comp = "select * from transacciones_prestamo where codprestamo like '" + cd + "' ";
            NpgsqlDataReader ver = metodos.resultados_consulta(ver_comp);
            ver.Read();
            int i = 0;
            Boolean b = false;
            while (i < ver.FieldCount)
            {
                //MessageBox.Show(""+ver.GetValue(i));
                string value = "" + ver.GetValue(i);



                if (i == 1) { }//puede ser nulo
                
                else if (i == 11)
                {
                    if (value.Equals(null)) { b = true; }
                }
                else if (i == 12)
                {
                    if (b == true & value.Equals(null))
                    {
                        MessageBox.Show("La transaccion no ha sido completado");
                        return;
                    }
                }
                else if (value.Equals(""))//0j0 aquie esta la clave
                {
                    MessageBox.Show("La transaccion no ha sido completado");
                    return;
                }
                else if (value.Equals(null))
                {
                    MessageBox.Show("La transaccion no ha sido completado");
                    return;
                }
                    i++;
            }
            //MessageBox.Show(""+ver.FieldCount);



            ///--determina el tiempo
            string consulta = "select tiempoprestamo from transacciones_prestamo where codprestamo like'" + codigo_transac + "' ";
            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();
            string item = resultados.GetString(0);
            
            int tiempo =0;

                    if (item.Equals("MENSUAL")) { tiempo = 30; }
                    if (item.Equals("BIMESTRAL")) { tiempo = 60; }
                    if (item.Equals("TRIMESTRAL")) { tiempo = 90; }
                    if (item.Equals("SEMESTRAL")) { tiempo = 181; }
                    if (item.Equals("ANUAL")) { tiempo = 365; }




            ///---registra en la tabla cronogramas que ya se va a generar las cuotas
            string sql = "insert into cronograma_prestamo values('" + codigo_cronograma + "','" +codigo_transac+"')";
            metodos.tabla_consulta(sql);

            new Cronograma_prestamo(Convert.ToInt32(codigo_cronograma), null).generar_cuotas(Convert.ToString(txb_codigotransaccion.Text),tiempo);




            btn_generarcronogramaprestamo.Enabled = false;
            ///Todo lo que tiene que ver con la tabla

            DataTable r= metodos.tabla_consulta("select * from cuotas_prestamo where prestamo like '"+codigo_transac+"'");
            tbl_screencredito.DataSource = r;
     

            */
        }
        
        private void Generar_Cronogramas_Load(object sender, EventArgs e)
        {
            pnl_generar.Enabled = false;
            pnl_generar2.Enabled = false;


        }

        private void txb_codigotransaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            lbl_nombre.Text = "";
            lbl_codigocliente.Text = "";
            lbl_codcredito.Text = "";
            pnl_generar.Enabled = false;
            tbl_screencredito.DataSource = null;


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            lbl_nombre2.Text = "";
            lbl_codigocliente2.Text = "";
            lbl_codinver.Text = "";
            pnl_generar2.Enabled = false;
            tbl_screeninver.DataSource = null;
        }

        Boolean es_generadoinver = false;
        private void btn_buscarinversion_Click(object sender, EventArgs e)
        {
            //si la transaccion ya fue generada que vuelva a mostrar las cuotas
            //sino, genere las cuotas

            string busc = txb_codigotransaccioninver.Text;
            if (txb_codigotransaccioninver.Text.Equals("")) { MessageBox.Show("Digite todos los campos"); return; }

            ///Validando que la transaccion exista
            if (metodos.buscar("transacciones_inversion", "codinversion", busc) == true) { }
            else {
                MessageBox.Show("La transaccion no fue encontrada");
                lbl_nombre2.Text = "";
                lbl_codigocliente2.Text = "";
                lbl_codinver.Text = "";
                pnl_generar2.Enabled = false;
                tbl_screeninver.DataSource = null;
                return;
            }




            string consulta = "select codinversionista,nombreinversionista,codinversion,estadoinversion,montoinversion" +
                " from transacciones_inversion join inversionista on(inversionista=codinversionista) where codinversion like '" + busc + "'";
            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();

            string est = resultados.GetString(3);
            //MessageBox.Show("EStado: "+est);


            ///--si la transaccion fue aprovada
            if (est.Equals("APROBADO"))
            {
                //MessageBox.Show("La Transaccion ya ha sido aprobada");                
            }

            else
            {
                MessageBox.Show("La transaccion no ha sido aprobada");
                btn_cancelarpres.Enabled = false;
                btn_imprimirpres.Enabled = false;
                btn_generarcronogramaprestamo.Enabled = false;
                return;
            }


            lbl_nombre2.Text = resultados.GetString(1);
            lbl_codigocliente2.Text = resultados.GetString(0);
            lbl_codinver.Text = resultados.GetString(2);


           
            pnl_generar2.Enabled = true;


            //si la transaccion ya ha sido generada

            if (metodos.buscar("cuotas_inversion", "inversion", busc) == true)
            {
                MessageBox.Show("La transaccion ya ha sido generada");
                //btn_cancelarinver.Enabled = false;
                //btn_imprimirinver.Enabled = false;
                btn_generarcronogramainver.Enabled = false;
                es_generadoinver = true;
            }
            else { es_generadoinver = false; }





            ///Todo lo que tiene que ver con la tabla

            if (es_generadoinver == true)
            {
                string consulta2 = "select * from cuotas_inversion where inversion like'" + busc + "' order by fechaplaneadainversion";

                DataTable tablacuotas = metodos.tabla_consulta(consulta2);
                tbl_screeninver.DataSource = (tablacuotas);
            }

            //MessageBox.Show("Ok");


        }

        private void btn_generarcronogramainver_Click(object sender, EventArgs e)
        {
            /*
            string codigo_cronograma = metodos.generar_codigo(6, "cronograma_inversion","codcronogramainversion"); //ojo aqui genero el codigo del cronograma...
            int codigo_transaccion = Convert.ToInt32(txb_codigotransaccioninver.Text);
            string codigo_transac = txb_codigotransaccioninver.Text;


            ///Validando que la transaccion exista
            if (metodos.buscar("transacciones_inversion", "codinversion", txb_codigotransaccioninver.Text) == true) { }
            else { MessageBox.Show("La transaccion no fue encontrada"); return; }




            //VALIDAR CTRANSACCION COMPLETA: 0j0 aqui


            string cd = txb_codigotransaccioninver.Text;
            string ver_comp = "select * from transacciones_inversion where codinversion like '" + cd + "' ";
            NpgsqlDataReader ver = metodos.resultados_consulta(ver_comp);
            ver.Read();
            int i = 0;
            Boolean b = false;
            while (i < ver.FieldCount)
            {
                //MessageBox.Show(""+ver.GetValue(i));
                string value = "" + ver.GetValue(i);



                if (i == 1) { }//puede ser nulo
                
                else if (value.Equals(""))//0j0 aquie esta la clave
                {
                    MessageBox.Show("La transaccion no ha sido completado");
                    return;
                }
                else if (value.Equals(null))
                {
                    MessageBox.Show("La transaccion no ha sido completado");
                    return;
                }
                i++;
            }











            ///--determina el tiempo
            string consulta = "select tiempoinversion from transacciones_inversion where codinversion like'" + codigo_transac + "' ";
            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();
            string item = resultados.GetString(0);

            //MessageBox.Show("item: " + item);

            int tiempo = 0;

            if (item.Equals("MENSUAL")) { tiempo = 30; }
            if (item.Equals("BIMESTRAL")) { tiempo = 60; }
            if (item.Equals("TRIMESTRAL")) { tiempo = 90; }
            if (item.Equals("SEMESTRAL")) { tiempo = 181; }
            if (item.Equals("ANUAL")) { tiempo = 365; }

           


            ///---registra en la tabla cronogramas que ya se va a generar las cuotas
            string sql = "insert into cronograma_inversion values('" + codigo_cronograma + "','" + codigo_transac + "')";
            metodos.tabla_consulta(sql);
                                        //ojo con estos parametros
            new Cronograma_inversion1(100,Convert.ToInt32(codigo_cronograma), null).generar_cuotas(Convert.ToString(txb_codigotransaccioninver.Text), tiempo);




            btn_generarcronogramainver.Enabled = false;
            ///Todo lo que tiene que ver con la tabla

            DataTable r = metodos.tabla_consulta("select * from cuotas_inversion where inversion like '" + codigo_transac + "'");
            tbl_screeninver.DataSource = r;
            */

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void txb_codigotransaccion_TextChanged(object sender, EventArgs e)
        {
            pnl_generar.Enabled = false;
        }

        private void txb_codigotransaccioninver_TextChanged(object sender, EventArgs e)
        {
            pnl_generar2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_cancelarpres_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelarinver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
