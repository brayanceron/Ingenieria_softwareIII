using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.clases;

namespace WindowsFormsApp3
{
    public partial class Informacion_Clientes : Form
    {
        static DataTable tabla;


        public Informacion_Clientes(int boton)
        {
            InitializeComponent();
            

            if (boton == 1) { tabControl1.SelectedTab = tabPage1; }
            if (boton == 2) { tabControl1.SelectedTab = tabPage2; }
            if (boton == 3) { tabControl1.SelectedTab = tabPage3; }
            //tabControl1.SelectedTab = tabPage3;

            /*
            tabla = new DataTable();
            pnl_consultar.Enabled = false;
            tabla.Columns.Add("FCH SOLICITUD");
            tabla.Columns.Add("MONTO");
            tabla.Columns.Add("TASA");
            tabla.Columns.Add("COD TRANSACCION");
            tabla.Columns.Add("TIPO");
            tabla.Columns.Add("ESTADO");
            tbl_screen.DataSource = tabla;
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main ventana = new Main();
            ventana.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void Informacion_Clientes_Load(object sender, EventArgs e)
        {
            pnl_modificardatos.Enabled = false;
            pnl_modificartransacciones.Enabled = false;
            pnl_modificardatostransaccion.Enabled = false;
            pnl_modificarfechas.Enabled = false;

            /*
            tabla.Rows.Add("XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXXX", "APROBADO");
            tabla.Rows.Add("XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXXX", "REPROVADO");
            tabla.Rows.Add("XXXXXX", "XXXXXX $", "X.X %", "XXXXXX", "XXXXXX", "ESTUDIO");
            */
        }

        private void chbx_inver_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_inver.Checked == true)
            {
                pnl_inversionista.Enabled = true;
                chbx_prest.Checked = false;
                chbx_fiad.Checked = false;
            }
        }

        private void chbx_prest_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_prest.Checked == true)
            {
                pnl_inversionista.Enabled = false;
                chbx_inver.Checked = false;
                chbx_fiad.Checked = false;
            }
                
        }

        private void chbx_fiad_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_fiad.Checked == true)
            {
                pnl_inversionista.Enabled = false;
                chbx_inver.Checked = false;
                chbx_prest.Checked = false;
            }
            
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ///--validando que los campos esten llenos
            if (txb_cedula.Text.Equals("") ||
                txb_nombres.Text.Equals("") ||
                txb_direccion.Text.Equals("") ||
                txb_telefono.Text.Equals("") ||
                cbx_modalidad.Text.Equals("")
                )
            {
                MessageBox.Show("Debe digitar todos los campos");return;
            }
            if(chbx_prest.Checked==false &&
               chbx_inver.Checked == false &&
               chbx_fiad.Checked == false)
            {
                MessageBox.Show("Debe Definir el tipo de cliente"); return;
            }




            long cedula = long.Parse(txb_cedula.Text);
            //int codigo = metodos.generar_codigo();
            string nombre = txb_nombres.Text;
            string direccion = txb_direccion.Text;
            long telefono = long.Parse(txb_telefono.Text);
            string modalidad = cbx_modalidad.Text;
            ArrayList transacciones = new ArrayList();

            string tipo_cliente;

            
            if (chbx_prest.Checked) {
                if (metodos.buscar("prestatario", "cedulaprestatario", Convert.ToString(cedula)) == true) { MessageBox.Show("Este cliente ya se encuentra registrado"); return; }
                string codigo = metodos.generar_codigo(1,"prestatario","codprestatario");
                string sql = "insert into prestatario values('" + codigo + "','" + cedula + "','" + nombre + "','" + direccion + "','" + telefono + "','" + modalidad + "')";
                metodos.tabla_consulta(sql);
                
            }

            if(chbx_inver.Checked) {
                if (metodos.buscar("inversionista", "cedulainversionista", Convert.ToString(cedula)) == true) { MessageBox.Show("Este cliente ya se encuentra registrado"); return; }
                tipo_cliente = chbx_inver.Text;
                string codigo = metodos.generar_codigo(2, "inversionista", "codinversionista");
                string numcuenta ;
                string banco = null;
                string tipocuenta = null;
                string sql = "insert into inversionista values('" + codigo + "','" + cedula + "','" + nombre + "','" + direccion + "','" + telefono + "','" + modalidad + "',";

                if (txb_numcuenta.Text.Equals("")) { numcuenta = null; sql += "null" + ","; }
                else { numcuenta = (txb_numcuenta.Text);sql += "'" + numcuenta + "',"; }
                
                if (txb_banco.Text.Equals("")) { banco = null; sql += "null" + ","; }
                else { banco = txb_banco.Text; sql += "'" + banco + "',"; }

                if (txb_tipocuenta.Text.Equals("")) { tipocuenta  = null; sql += "null" + ")"; }
                else { tipocuenta = (txb_tipocuenta.Text); sql += "'" + tipocuenta + "')"; }
                
                //string sql = "insert into inversionista values('" + codigo + "','" + cedula + "','" + nombre + "','" + direccion + "','" + telefono + "','" + modalidad + "','" + numcuenta +"','" + banco + "','" +  tipocuenta+"')";

                metodos.tabla_consulta(sql);
            }

            if(chbx_fiad.Checked) {
                if (metodos.buscar("fiador", "cedulafiador", Convert.ToString(cedula)) == true) { MessageBox.Show("Este cliente ya se encuentra regsitrado"); return; }
                string codigo = metodos.generar_codigo(3, "prestatario", "codprestatario");
                string sql = "insert into fiador values('" + codigo + "','" + cedula + "','" + nombre + "','" + direccion + "','" + telefono + "','" + modalidad + "')";
               metodos.tabla_consulta(sql);
            }



            MessageBox.Show("Cliente registrado exitosamente");
            txb_cedula.Text=("");
            txb_nombres.Text=("");
            txb_direccion.Text=("");
            txb_telefono.Text=("");
            cbx_modalidad.Text=null;
            
            txb_numcuenta.Text = "";
            txb_banco.Text = "";
            txb_tipocuenta.Text = "";



        }


       






        //=====================================================================

        
        
        //======================================================================






        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //modificar("data\\hola.txt", "1085335942", "000000000000");

        }


        static ArrayList datosviejos = new ArrayList();
        static string b = ""; //0jito::: aqui esta la variable b y la lista de datos viejos



        ArrayList datos_viejos;
        private void cajas_modificar(string consulta,Boolean es_inver,Boolean es_pres,Boolean es_fiad)
        {
            datosviejos.Clear();


            chb_inver.Checked = false;
            chb_fiad.Checked = false;
            chb_pres.Checked = false;

            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();

            pnl_modificardatos.Enabled = true;
            pnl_modificarinvercionista.Enabled = false;
            txb_nombresmodificar.Text = resultados.GetString(0);      datosviejos.Add(resultados.GetString(0));
            txb_direccionmodificar.Text= resultados.GetString(1);     datosviejos.Add(resultados.GetString(1));
            txb_telefonomodificar.Text= resultados.GetString(2);      datosviejos.Add(resultados.GetString(2));


            if (es_fiad == true)
            {
                //chb_inver.Checked = false;
                chb_fiad.Checked = true;
                //chb_pres.Checked = false;
                pnl_modificartransacciones.Enabled = false;

            }
            if (es_pres == true) {
                //chb_inver.Checked =false;
                //chb_fiad.Checked = false;
                chb_pres.Checked = true;
                pnl_modificartransacciones.Enabled = true;
            }

            
            
            if (es_inver == true) {
                chb_inver.Checked = true;
                //chb_fiad.Checked = false;
                //chb_pres.Checked = false;
                txb_numcuentamodificar.Text = resultados.GetString(3);   datosviejos.Add(resultados.GetString(3));
                txb_bancomodificar.Text = resultados.GetString(4);       datosviejos.Add(resultados.GetString(4));
                /*txb_tipocuentamodificar.SelectedItem = resultados.GetString(5);  datosviejos.Add(resultados.GetString(5));*/
                pnl_modificarinvercionista.Enabled = true;
                pnl_modificartransacciones.Enabled = true;
            }

            /*
            if (es_fiad == true & es_pres == false & es_fiad == false)
            {
                //chb_inver.Checked = false;
                chb_fiad.Checked = true;
                //chb_pres.Checked = false;
                pnl_modificartransacciones.Enabled = false;

            }
            */
            //if(es_fiad==true & )
            //lbl_nombres.Text = resultados.GetString(2);

        }

        string buscar_mod = "";
        string tipo_clie = "";
        Boolean es_prest = false;
        Boolean es_inver = false;
        Boolean es_fiad = false;
        private void btn_buscarmodificar_Click(object sender, EventArgs e)
        {
            string cc = txb_cedulamodificar.Text;
            string cd = txb_codigomodificar.Text;
            

            Boolean flag = false;

            es_prest = false;
            es_inver = false;
            es_fiad = false;

            ///--verifica si no estan llenos los dos campos
            if (txb_codigomodificar.Text.Equals("") && txb_cedulamodificar.Text.Equals(""))
            {
                MessageBox.Show("Debe  digitar alguno de los campos");
                return;
            }



            ///--verifi si esta lleno alguno de los 2 campos y
            ///--busca por codigo si estan llenos los 2 y si encontro el cliente
            ///
            tbl_screen.DataSource = null; //corregir porque hay que limpiar la tabla

            if (!txb_cedulamodificar.Text.Equals("") &&
              (metodos.buscar("fiador", "cedulafiador", cc) == true))
            {
                buscar_mod = cc; flag = true;
                string consulta2 = "select nombrefiador,direccionfiador,telefonofiador from fiador where cedulafiador like '" + cc + "'";
                tipo_clie = "fiador";
                es_fiad = true;
                cajas_modificar(consulta2, false, false,true);
            }

            if (!txb_codigomodificar.Text.Equals("") &&
              (metodos.buscar("fiador", "codfiador", cd) == true))
            {
                buscar_mod = cd; flag = true;
                string consulta2 = "select nombrefiador,direccionfiador,telefonofiador from fiador where codfiador like '" + cd + "'";
                tipo_clie = "fiador";
                es_fiad = true;
                cajas_modificar(consulta2, false, false,true);
            }
                    


            if (!txb_cedulamodificar.Text.Equals("") &&
              (metodos.buscar("prestatario", "cedulaprestatario", cc) == true))
            {
                buscar_mod = cc; flag = true;
                string consulta2 = "select nombreprestatario,direccionprestatario,telefonoprestatario from prestatario where cedulaprestatario like '" + cc + "'";
                                tipo_clie = "prestatario";
                es_prest = true;
                cajas_modificar(consulta2, false, true,es_fiad);
            }

            if (!txb_codigomodificar.Text.Equals("") &&
              (metodos.buscar("prestatario", "codprestatario", cd) == true))
            {
                buscar_mod = cd; flag = true;
                string consulta2 = "select nombreprestatario,direccionprestatario,telefonoprestatario from prestatario where codprestatario like '" + cd + "'";
                
                tipo_clie = "prestatario";
                es_prest = true;
                cajas_modificar(consulta2, false, true,es_fiad);
            }



            if (!txb_cedulamodificar.Text.Equals("") &&
               (metodos.buscar("inversionista", "cedulainversionista", cc) == true))
            {
                buscar_mod = cc; flag = true;
                string consulta2 = "select nombreinversionista,direccioninversionista,telefonoinversionista,numcuentainversionista,bancoinversionista,tipocuentainversionista from inversionista where cedulainversionista like'" + cc + "'";
                tipo_clie = "inversionista";
                es_inver = true;
                cajas_modificar(consulta2, true, es_prest, es_fiad);
            }

            if (!txb_codigomodificar.Text.Equals("") &&
               (metodos.buscar("inversionista", "codinversionista", cd) == true))
            {
                buscar_mod = cd; flag = true;
                string consulta2 = "select nombreinversionista,direccioninversionista,telefonoinversionista,numcuentainversionista,bancoinversionista,tipocuentainversionista from inversionista where codinversionista like'" + cd + "'";
                tipo_clie = "inversionista";
                es_inver = true;
                cajas_modificar(consulta2, true, es_prest, es_fiad);
            }




            if (flag == false)
            {
                MessageBox.Show("No se encontro el Cliente");
                lbl_nombres.Text = "";
                lbl_codigo.Text = "";
                lbl_cedula.Text = "";
                return;
            }
            

        }


        ///-------------------------------------
        ///

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        static string codigos = "";
        //btn_buscarconsultar_Click
        private void btn_buscarconsultar_Click_1(object sender, EventArgs e)
        {
            string cc = txb_cedulaconsultar.Text;
            string cd = txb_codigoconsultar.Text;
            string b="";
            codigos = "";
            Boolean flag = false;

           

            ///--verifica si no estan llenos los dos campos
            if (txb_codigoconsultar.Text.Equals("") && txb_cedulaconsultar.Text.Equals(""))
            {
                MessageBox.Show("Debe  digitar alguno de los campos");
                return;
            }



            ///--verifi si esta lleno alguno de los 2 campos y
            ///--busca por codigo si estan llenos los 2 y si encontro el cliente
            ///
            tbl_screen.DataSource = null; //corregir porque hay que limpiar la tabla

            DataTable mytabla = new DataTable();
            mytabla = null;
            if (!txb_cedulaconsultar.Text.Equals("") &&
              (metodos.buscar("fiador", "cedulafiador", cc) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from fiador where cedulafiador like '" + cc + "'";
                codigos += " Fiador: ";
                viz(consulta);
                string consulta2 = "select * from fiador join transacciones_prestamo on (codfiador=fiador)where cedulafiador like '" + cc + "'";
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }

            if (!txb_codigoconsultar.Text.Equals("") &&
              (metodos.buscar("fiador", "codfiador", cd) == true))
            {
                b = cd; flag = true;
                codigos += " Fiador: ";
                string consulta = "select * from fiador where codfiador like '" + cd + "'";
                viz(consulta);
                string consulta2 = "select * from fiador join transacciones_prestamo on (codfiador=fiador)where codfiador like '" + cd + "'";
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                
                //tbl_screen.Rows.Add (metodos.tabla_consulta(consulta2));
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }


            if (!txb_cedulaconsultar.Text.Equals("") &&
              (metodos.buscar("prestatario", "cedulaprestatario", cc) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from prestatario where cedulaprestatario like '" + cc + "'";
                codigos += "   Prestatario: ";
                viz(consulta);
                string consulta2 = "select * from prestatario join transacciones_prestamo on (codprestatario=prestatario)where cedulaprestatario like '" + cc + "'";
                //if (metodos.tabla_consulta(consulta2) != null)
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                //tbl_screen.Rows.Add(metodos.tabla_consulta(consulta2));
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }
            if (!txb_codigoconsultar.Text.Equals("") &&
              (metodos.buscar("prestatario", "codprestatario", cd) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from prestatario where codprestatario like '" + cd + "'";
                codigos += "   Prestatario: ";
                viz(consulta);
                string consulta2 = "select * from prestatario join transacciones_prestamo on (codprestatario=prestatario)where codprestatario like '" + cd + "'";
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                //tbl_screen.Rows.Add ( metodos.tabla_consulta(consulta2));
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }


            if (!txb_cedulaconsultar.Text.Equals("") &&
               (metodos.buscar("inversionista", "cedulainversionista", cc) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from inversionista where cedulainversionista like '"+cc+"'";
                codigos += "   Inversionista: ";
                viz(consulta);
                string consulta2 = "select * from inversionista join transacciones_inversion on (codinversionista=inversionista)where cedulainversionista like '" + cc + "'";                
                tbl_screen.DataSource= metodos.tabla_consulta(consulta2);
                //tbl_screen.Rows.Add( metodos.tabla_consulta(consulta2));
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }
            if (!txb_codigoconsultar.Text.Equals("") &&
               (metodos.buscar("inversionista", "codinversionista", cd) == true))
            {
                b = cd; flag = true;
                string consulta = "select * from inversionista where codinversionista like '" + cd + "'";
                codigos += "   Inversionista: ";
                viz(consulta);
                string consulta2 = "select * from inversionista join transacciones_inversion on (codinversionista=inversionista)where codinversionista like '" + cd + "'";
                //tbl_screen.Rows.Add(metodos.tabla_consulta(consulta2));
                tbl_screen.DataSource = metodos.tabla_consulta(consulta2);
                pnl_consultar.Enabled = true;
                if (mytabla == null) { mytabla = metodos.tabla_consulta(consulta2); }
                else { mytabla.Merge(metodos.tabla_consulta(consulta2)); }

            }

            tbl_screen.DataSource = mytabla;
            



            if (flag == false )
            {
                MessageBox.Show("No se encontró el Cliente");
                lbl_nombres.Text = "";
                lbl_codigo.Text = "";
                lbl_cedula.Text = "";
                tbl_screen.DataSource = null;
                return;
            }
           


            ///--si no encuentra el cliente con ninguno de los 2 campos termina

        }
        
        private void viz(string consulta)
        {
            NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
            resultados.Read();
            lbl_nombres.Text = resultados.GetString(2);
            codigos += resultados.GetString(0);
            //lbl_codigo.Text = resultados.GetString(0);
            lbl_codigo.Text = codigos;
            lbl_cedula.Text = resultados.GetString(1);
        }





        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txb_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_numcuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_cedulaconsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_codigoconsultar.Text = "";
            pnl_consultar.Enabled = false;
            lbl_nombres.Text = "";
            lbl_codigo.Text = "";
            lbl_cedula.Text = "";
            tbl_screen.DataSource = null;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_codigoconsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_cedulaconsultar.Text = "";
            pnl_consultar.Enabled = false;
            lbl_nombres.Text = "";
            lbl_codigo.Text = "";
            lbl_cedula.Text = "";
            tbl_screen.DataSource = null;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_cedulamodificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_codigomodificar.Text = "";
        
        pnl_modificardatos.Enabled = false;
            pnl_modificartransacciones.Enabled = false;

            ///--vaciando cajas
            txb_nombresmodificar.Text = ("");
            txb_direccionmodificar.Text = ("");
            txb_telefonomodificar.Text = ("");

            txb_numcuentamodificar.Text = ("");
            txb_bancomodificar.Text = ("");
            txb_tipocuentamodificar.Text = ("");
            ///--vaciando cajas
            txb_modificarmonto.Text = ("");
            txb_modificartasa.Text = ("");
            cbx_modificartiempo.Text = ("");
            cbx_modificarestado.Text = ("");

            txb_modificar_fechaaprobacion.Text = ("");
            txb_modificar_fechainicio.Text = ("");
            txb_modificar_fechafinalizacion.Text = ("");
            txb_codigotransaccionmodificar.Text = "";


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_codigomodificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_cedulamodificar.Text = "";
            pnl_modificardatos.Enabled = false;
            pnl_modificartransacciones.Enabled = false;


            ///--vaciando cajas
            txb_nombresmodificar.Text = ("");
            txb_direccionmodificar.Text = ("");
            txb_telefonomodificar.Text = ("");

            txb_numcuentamodificar.Text = ("");
            txb_bancomodificar.Text = ("");
            txb_tipocuentamodificar.Text = ("");
            ///--vaciando cajas
            txb_modificarmonto.Text = ("");
            txb_modificartasa.Text = ("");
            cbx_modificartiempo.Text = ("");
            cbx_modificarestado.Text = ("");

            txb_modificar_fechaaprobacion.Text = ("");
            txb_modificar_fechainicio.Text = ("");
            txb_modificar_fechafinalizacion.Text = ("");
            txb_codigotransaccionmodificar.Text = "";

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///--vaciando cajas
            txb_modificarmonto.Text = ("");
            txb_modificartasa.Text = ("");
            cbx_modificartiempo.Text = null;
            cbx_modificarestado.Text = null;
            pnl_modificardatostransaccion.Enabled = false;
            if(pnl_modificardatostransaccion.Enabled == false) { btn_modificar_transaccion.Enabled = false; }

            

            txb_modificar_fechaaprobacion.Text = ("");
            txb_modificar_fechainicio.Text = ("");
            txb_modificar_fechafinalizacion.Text = ("");
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbx_modalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                //e.Handled = true;
            
        }

        private void txb_cedulaconsultar_TextChanged(object sender, EventArgs e)
        {
            txb_codigoconsultar.Text = "";
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            
            ///---validar que todos los campos este llenos
            if (txb_nombresmodificar.Text.Equals("") ||
                txb_direccionmodificar.Text.Equals("") ||
                txb_telefonomodificar.Text.Equals("")                 
                )
            {
                MessageBox.Show("Debe digitar todos los campos");return;
            }
            


            ArrayList datosnuevos = new ArrayList();
            string n=txb_nombresmodificar.Text;         datosnuevos.Add(n);
            string d =txb_direccionmodificar.Text;      datosnuevos.Add(d);
            string tl =txb_telefonomodificar.Text;      datosnuevos.Add(tl);
            string nc =txb_numcuentamodificar.Text;     datosnuevos.Add(nc);
            string bc =txb_bancomodificar.Text;         datosnuevos.Add(bc);
            string tc =txb_tipocuentamodificar.Text;    datosnuevos.Add(tc);

            int i = 0;
            //MessageBox.Show("prestatario: " + es_prest + " inver: " + es_inver + " fiadro: " + es_fiad);

            foreach (string item in datosviejos)
               {
                if (i < (datosnuevos.Count) && !item.Equals(datosnuevos[i]))
                {
                    //MessageBox.Show("Son iguales");
                    //if (tipo_clie.Equals("inversionista"))
                    if (es_inver==true)
                        {
                        //NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
                        if (txb_numcuentamodificar.Text.Equals("") ||
                            txb_bancomodificar.Text.Equals("") ||
                            txb_tipocuentamodificar.Text.Equals("") ||
                            txb_tipocuentamodificar.Text.Equals(null) ||
                            txb_tipocuentamodificar.SelectedValue==null
                            )
                        {
                            MessageBox.Show("Debe digitar los todos campos de la informacion bancaria");return ;
                        }
                        if (i == 0) { string consulta = "update inversionista set nombreinversionista='"+datosnuevos[i]+"' where cedulainversionista like '"+buscar_mod+"' or codinversionista like '"+buscar_mod+"'"; metodos.tabla_consulta(consulta); }
                        if (i == 1) { string consulta = "update inversionista set direccioninversionista='" + datosnuevos[i] + "' where cedulainversionista like '" + buscar_mod + "' or codinversionista like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 2) { string consulta = "update inversionista set telefonoinversionista='" + datosnuevos[i] + "' where cedulainversionista like '" + buscar_mod + "' or codinversionista like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                        
                        if (i == 3) { string consulta = "update inversionista set numcuentainversionista='" + datosnuevos[i] + "' where cedulainversionista like '" + buscar_mod + "' or codinversionista like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 4) { string consulta = "update inversionista set bancoinversionista='" + datosnuevos[i] + "' where cedulainversionista like '" + buscar_mod + "' or codinversionista like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 5) { string consulta = "update inversionista set tipocuentainversionista='" + datosnuevos[i] + "' where cedulainversionista like '" + buscar_mod + "' or codinversionista like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                        if(es_prest == false & es_fiad == false) { break; }
                    }
                    //if (tipo_clie.Equals("prestatario"))
                   if (es_prest == true)
                        {
                         //if (i == 0) { string consulta = "update prestatario set nombreprestatario = 'BRAYAN 0NP'    where cedulaprestatario like '1085335942' or codprestatario like '1085335942'";metodos.ejecutar_consulta(consulta); }
                        if (i == 0) { string consulta = "update \"prestatario\" set \"nombreprestatario\"='" + datosnuevos[i] + "' where \"cedulaprestatario\" like '" + buscar_mod + "' or \"codprestatario\" like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 1) { string consulta = "update prestatario set direccionprestatario = '" + datosnuevos[i] + "' where cedulaprestatario like '" + buscar_mod + "' or codprestatario like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }                    
                        if (i == 2) { string consulta = "update prestatario set telefonoprestatario ='" + datosnuevos[i] + "' where cedulaprestatario like '" + buscar_mod + "' or codprestatario like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                        if ( es_fiad == true) { break; }
                    }
                    //  update prestatario set direccionprestatario = 'PASTO NARIÑO' where cedulaprestatario like '1085335942';
                    //if (tipo_clie.Equals("fiador"))
                    if (es_fiad == true)
                    {
                        if (i == 0) { string consulta = "update fiador set nombrefiador='" + datosnuevos[i] + "' where cedulafiadorlike '" + buscar_mod + "' or codfiador like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 1) { string consulta = "update fiador set direccionfiador='" + datosnuevos[i] + "' where cedulafiador like '" + buscar_mod + "' or codfiador like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 2) { string consulta = "update fiador set telefonofiador='" + datosnuevos[i] + "' where cedulafiador like '" + buscar_mod + "' or codfiador like '" + buscar_mod + "'"; metodos.tabla_consulta(consulta); }
                    }

                }
                i++;
            }
            //0jo0000 falta hacer cuando un cliente es fiador inversionista o prestatario ala vez hay que modificar ambos registros




            datosviejos.Clear();
            //b = "";
            //Hay que limpiar las cajas
            txb_nombresmodificar.Text = "";
            txb_telefonomodificar.Text = "";
            txb_direccionmodificar.Text = "";
            txb_numcuentamodificar.Text = "";
            txb_bancomodificar.Text = "";
            txb_tipocuentamodificar.Text = null;
            txb_codigomodificar.Text = "";
            txb_cedulamodificar.Text = "";
            
            pnl_modificardatos.Enabled = false;
            pnl_modificartransacciones.Enabled = false;

            MessageBox.Show("Cliente modificado exitosamente");
            ///--vaciando cajas
            txb_nombresmodificar.Text=("");
            txb_direccionmodificar.Text=("");
            txb_telefonomodificar.Text=("");

            txb_numcuentamodificar.Text=("");
            txb_bancomodificar.Text=("");
            txb_tipocuentamodificar.Text=null;

            txb_modificarmonto.Text = ("");
            txb_modificartasa.Text = ("");
            cbx_modificartiempo.Text = null;
            cbx_modificarestado.Text = null;

            txb_modificar_fechaaprobacion.Text = ("");
            txb_modificar_fechainicio.Text = ("");
            txb_modificar_fechafinalizacion.Text = ("");

            //metodos.desconectar();
            this.Close();
            
        }
        Boolean flagprest = false;
        Boolean flaginver = false;
        static ArrayList datosviejos_transacciones=new ArrayList();
        private void btn_buscartransaccionmodificar_Click(object sender, EventArgs e)
        {
            string busct = txb_codigotransaccionmodificar.Text;
            
            flagprest = false;
            flaginver = false;
            datosviejos_transacciones.Clear();
            ///--verifica si no esta lleno el campo

            if (txb_codigotransaccionmodificar.Text.Equals("")) { MessageBox.Show("Digite todos los campos"); return; }

            ///Validando que la transaccion exista
            if (metodos.buscar("transacciones_prestamo", "codprestamo", busct) == true) { flagprest = true; }
            else if (metodos.buscar("transacciones_inversion", "codinversion", busct) == true) { flaginver = true; }
            else { MessageBox.Show("La transaccion no fue encontrada"); return; }


            if (flagprest == true)
            {                
                string consulta = "select montoprestamo,tasaprestamo,tiempoprestamo,estadoprestamo," +
                    "fechaprobacionprestamo,fechainicioprestamo,fechaterminoprestamo,prestatario" +
                " from transacciones_prestamo  where codprestamo like '" + busct + "'";

                NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
                resultados.Read();

                string monto= resultados.GetString(0);
                string tasa = resultados.GetString(1);
                string tiempo = resultados.GetString(2);
                string estado = resultados.GetString(3);

                string fchaprovacion="";
                string fchinicio="";
                string fchtermino="";
                if (estado.Equals("ESTUDIO") || estado.Equals("REPROBADO")) { }
                else
                {
                  
                        DateTime fch1 = resultados.GetDateTime(4);
                        fchaprovacion = Convert.ToString(fch1);
                   
                        DateTime fch2 = resultados.GetDateTime(5);
                        fchinicio = Convert.ToString(fch2);
                    
                        DateTime fch3 = resultados.GetDateTime(6);
                        fchtermino = Convert.ToString(fch3);
                    
                }
                string prestatario = resultados.GetString(7);
                //buscando el prestatario
                try
                {
                    string cns="select * from transacciones_prestamo join prestatario on(prestatario=codprestatario) where codprestamo like '"+busct+"' and (codprestatario like '"+buscar_mod+"' or cedulaprestatario like '"+buscar_mod+"')";
                    //string cns = "select * from prestatario where codprestatario like '" + buscar_mod + "' or cedulaprestatario like '" + buscar_mod + "' ";
                    NpgsqlDataReader rst = metodos.resultados_consulta(cns);
                    rst.Read();
                    string cliente = rst.GetString(0);
                }
                catch
                {
                    MessageBox.Show("La transaccion No pertenece a este cliente"); flagprest=false; return;
                }

                txb_modificarmonto.Text = monto;    datosviejos_transacciones.Add(monto);
                txb_modificartasa.Text = tasa;      datosviejos_transacciones.Add(tasa);
                cbx_modificartiempo.Text = tiempo;  datosviejos_transacciones.Add(tiempo);

                if (estado.Equals("REMATADA"))
                {
                    MessageBox.Show("La Transaccion ha sido Rematada"); return;
                }
                if (estado.Equals("APROBADO"))
                {
                    MessageBox.Show("La Transaccion Ya ha sido aprovada"); pnl_modificardatostransaccion.Enabled = false; flagprest = false; return;
                }
                cbx_modificarestado.Text = estado;  datosviejos_transacciones.Add(estado);

                txb_modificar_fechaaprobacion.Text = fchaprovacion; datosviejos_transacciones.Add(fchaprovacion);
                txb_modificar_fechainicio.Text = fchinicio;         datosviejos_transacciones.Add(fchinicio);
                txb_modificar_fechafinalizacion.Text = fchtermino;  datosviejos_transacciones.Add(fchtermino);
            }

            if (flaginver == true)
            {
                string consulta = "select montoinversion,tasainversion,tiempoinversion,estadoinversion," +
                    "fecharealizacioninversion,fechaterminoinversion,inversionista" +
                " from transacciones_inversion  where codinversion like '" + busct + "'";

                NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
                resultados.Read();

                string monto = resultados.GetString(0);
                string tasa = resultados.GetString(1);
                string tiempo = resultados.GetString(2);
                string estado = resultados.GetString(3);

                string fchrealizacion = "";
                string fchtermino = "";
                if (estado.Equals("ESTUDIO") || estado.Equals("REPROBADO")) { }
                else
                {
                   
                        DateTime fch1 = resultados.GetDateTime(4);
                        fchrealizacion = Convert.ToString(fch1);
                   
                        DateTime fch2 = resultados.GetDateTime(5);
                        fchtermino = Convert.ToString(fch2);
                    
                }
                string inversionista = resultados.GetString(6);
                //buscando el prestatario
                //MessageBox.Show("rrr: "+buscar_mod);

                try
                {
                    //string cns = "select * from inversionista where codinversionista like '" + buscar_mod + "' or cedulainversionista like '" + buscar_mod + "' ";
                    string cns = "select * from transacciones_inversion join inversionista on(inversionista=codinversionista) where codinversion like '" + busct + "' and (codinversionista like '" + buscar_mod + "' or cedulainversionista like '" + buscar_mod + "')";
                    NpgsqlDataReader rst = metodos.resultados_consulta(cns);
                    rst.Read();
                    string cliente = rst.GetString(0);
                }
                catch
                {
                    MessageBox.Show("La transaccion No pertenece a este cliente"); flaginver = false; return;
                }
                

                txb_modificarmonto.Text = monto;    datosviejos_transacciones.Add(monto);
                txb_modificartasa.Text = tasa;      datosviejos_transacciones.Add(tasa);
                cbx_modificartiempo.Text = tiempo;  datosviejos_transacciones.Add(tiempo);

                if (estado.Equals("REMATADA"))
                {
                    MessageBox.Show("La Transaccion ha sido Rematada"); return;
                }

                if (estado.Equals("APROBADO"))
                {
                    MessageBox.Show("La Transaccion Ya ha sido aprovada"); pnl_modificardatostransaccion.Enabled = false; flaginver = false; return;
                }
                cbx_modificarestado.Text = estado; datosviejos_transacciones.Add(estado);

                txb_modificar_fechaaprobacion.Text = fchrealizacion;    datosviejos_transacciones.Add(fchrealizacion);
                txb_modificar_fechainicio.Text = fchrealizacion;        datosviejos_transacciones.Add(fchrealizacion);
                txb_modificar_fechafinalizacion.Text = fchtermino;      datosviejos_transacciones.Add(fchtermino);
            }


            pnl_modificardatostransaccion.Enabled = true;
            btn_modificar_transaccion.Enabled = true;

        }

        private void cbx_modificarestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_modificarestado.Text.Equals("ESTUDIO"))
            {
                pnl_modificarfechas.Enabled = false;
                txb_modificar_fechaaprobacion.Text = "";
                txb_modificar_fechafinalizacion.Text = "";
                txb_modificar_fechainicio.Text = "";

            }
            if (cbx_modificarestado.Text.Equals("APROBADO"))
            {
                pnl_modificarfechas.Enabled = true;
                txb_modificar_fechaaprobacion.Text = metodos.fecha_hoy();
                txb_modificar_fechainicio.Text = metodos.fecha_hoy();
            }
            if (cbx_modificarestado.Text.Equals("REPROBADO"))
            {
                pnl_modificarfechas.Enabled = false;
                txb_modificar_fechaaprobacion.Text = "";
                txb_modificar_fechafinalizacion.Text = "";
                txb_modificar_fechainicio.Text = "";
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_transaccion_Click(object sender, EventArgs e)
        {
            
            ///---validar que todos los campos este llenos
            if (txb_modificarmonto.Text.Equals("") ||
                txb_modificartasa.Text.Equals("") ||
                cbx_modificartiempo.Text.Equals("") ||
                cbx_modificarestado.Text.Equals("")
                )
            {
                MessageBox.Show("Debe digitar todos los campos"); return;
            }
            try
            {
                if (cbx_modificarestado.Text.Equals("APROBADO"))
                {
                    DateTime c1 = Convert.ToDateTime(txb_modificar_fechaaprobacion.Text);
                    DateTime c2 = Convert.ToDateTime(txb_modificar_fechainicio.Text);
                    DateTime c3 = Convert.ToDateTime(txb_modificar_fechafinalizacion.Text);

                }
                //DateTime c4 = Convert.ToDateTime(txb_fechasolicitud.Text);
            }
            catch { MessageBox.Show("Las Fechas no tienen el formato correcto"); return; }




            if (cbx_modificarestado.Text.Equals("APROBADO"))
            {
                if (txb_modificar_fechaaprobacion.Text.Equals("") ||
                txb_modificar_fechainicio.Text.Equals("") ||
                txb_modificar_fechafinalizacion.Text.Equals("")
                )
                {
                    MessageBox.Show("Debe digitar todos los campos"); return;
                }
            }



            ///--DETERMINANDO LAS FECHAS
            if (cbx_modificarestado.Text.Equals("APROBADO"))
            {
                //string fechainicio = txb_fechainicio.Text;
                //string fechatermino = txb_fechatermino.Text;
                DateTime cfa = Convert.ToDateTime(txb_modificar_fechaaprobacion.Text);
                DateTime cfi = Convert.ToDateTime(txb_modificar_fechainicio.Text);
                DateTime cff = Convert.ToDateTime(txb_modificar_fechafinalizacion.Text);

                string item = cbx_modificartiempo.Text;
                //MessageBox.Show(item);
                int tiempo = 0;

                if (item.Equals("MENSUAL")) { tiempo = 30; }
                else if (item.Equals("BIMESTRAL")) { tiempo = 60; }
                else if (item.Equals("TRIMESTRAL")) { tiempo = 90; }
                else if (item.Equals("SEMESTRAL")) { tiempo = 181; }
                else if (item.Equals("ANUAL")) { tiempo = 365; }
                else { MessageBox.Show("ERROR INESPEDARO"); return; }


               

                int totaldias = ((cff - cfi).Days);
                //MessageBox.Show("Diferencia de dias es " + totaldias);
                int num_cuotas = totaldias / tiempo;
                if (totaldias < 0) { MessageBox.Show("Fecha incorrecta, no puede ser menor que la fecha actual"); return; }

                if (num_cuotas < 5) { MessageBox.Show("El número de cuotas es muy pequeño para aprobar la transacción"); return; }

                if (num_cuotas > 30) { MessageBox.Show("El número de cuotas supera la capacidad de procesamiento de la base de datos"); return; }

            }




            //validar que la fecha de termino sea mayor que la fecha de inicio

            string codigo = txb_codigotransaccionmodificar.Text;

            ArrayList datosnuevos = new ArrayList();
            string m = txb_modificarmonto.Text; datosnuevos.Add(m);
            string tsi = txb_modificartasa.Text; datosnuevos.Add(tsi);
            string t = cbx_modificartiempo.Text; datosnuevos.Add(t);
            string es = cbx_modificarestado.Text; datosnuevos.Add(es);
            string fa=null, fi=null, ff=null;
            if (!txb_modificar_fechaaprobacion.Equals("") && !txb_modificar_fechafinalizacion.Equals("") && cbx_modificarestado.SelectedItem.Equals("APROBADO"))
            {
                fa = txb_modificar_fechaaprobacion.Text; datosnuevos.Add(fa);
                fi = txb_modificar_fechainicio.Text; datosnuevos.Add(fi);
                ff = txb_modificar_fechafinalizacion.Text; datosnuevos.Add(ff);
            }
            
            int i = 0;
            foreach (string item in datosviejos_transacciones)
            {
                if (i < (datosnuevos.Count) && !item.Equals(datosnuevos[i]))
                {
                    //MessageBox.Show("Son iguales");
                    if (flaginver == true)
                    {
                        ///monto tasa tiempo
                        if (i == 0) { string consulta = "update transacciones_inversion set montoinversion='" + datosnuevos[i] + "' where codinversion like '" + codigo +"'"; metodos.tabla_consulta(consulta); }
                        if (i == 1) { string consulta = "update transacciones_inversion set tasainversion='" + datosnuevos[i] + "' where codinversion like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 2) { string consulta = "update transacciones_inversion set tiempoinversion='" + datosnuevos[i] + "' where codinversion like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 3) { string consulta = "update transacciones_inversion set estadoinversion='" + datosnuevos[i] + "' where codinversion like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                        if (datosnuevos.Count>4)
                        {
                            if (fa == null | fi == null | ff == null) { }
                            else
                            {
                                if (i == 4) { string consulta = "update transacciones_inversion set fecharealizacioninversion='" + datosnuevos[i] + "' where codinversion like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                                if (i == 6) { string consulta = "update transacciones_inversion set fechaterminoinversion='" + datosnuevos[i] + "' where codinversion like '" + codigo + "'"; metodos.tabla_consulta(consulta); }                            
                            }
                        }
                    }
                    else if (flagprest)
                    {
                        if (i == 0) { string consulta = "update transacciones_prestamo set montoprestamo ='" + datosnuevos[i] + "' where codprestamo like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 1) { string consulta = "update transacciones_prestamo set tasaprestamo ='" + datosnuevos[i] + "' where codprestamo like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 2) { string consulta = "update transacciones_prestamo set tiempoprestamo ='" + datosnuevos[i] + "' where codprestamo like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                        if (i == 3) { string consulta = "update transacciones_prestamo set estadoprestamo ='" + datosnuevos[i] + "' where codprestamo like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                        if (datosnuevos.Count > 4)
                        {
                            //MessageBox.Show("Aqui ok");
                            if (fa == null | fi == null | ff == null) { }
                            else
                            {
                                if (i == 4) { string consulta = "update transacciones_prestamo set fechaprobacionprestamo='" + datosnuevos[i] + "' where codprestamo like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                                if (i == 5) { string consulta = "update transacciones_prestamo set fechainicioprestamo='" + datosnuevos[i] + "' where codprestamo like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                                if (i == 6) { string consulta = "update transacciones_prestamo set fechaterminoprestamo='" + datosnuevos[i] + "' where codprestamo like '" + codigo + "'"; metodos.tabla_consulta(consulta); }
                            }
                        }
                    }
                }
                i++;
            }

             //0j0 hp: si se apruvea la transaccion debe estar totalmente completada, tener encuenta que todos los campos deben esta completados

            ///--vaciando cajas
            txb_codigotransaccionmodificar.Text = "";
            txb_modificarmonto.Text = "";
            txb_modificartasa.Text = "";
            cbx_modificartiempo.Text = null;
            cbx_modificarestado.Text = null;            
            cbx_modificarestado.SelectedText = null;


            txb_modificar_fechaaprobacion.Text = "";
            fi = txb_modificar_fechainicio.Text = "";
            txb_modificar_fechafinalizacion.Text = "";
            btn_modificar_transaccion.Enabled = false;

            pnl_modificardatostransaccion.Enabled = false;

            MessageBox.Show("La transacción ha sido modificado exitosamente");
            
            ///--vaciando cajas
            txb_modificarmonto.Text = ("");
            txb_modificartasa.Text = ("");
            cbx_modificartiempo.Text = null;
            cbx_modificarestado.Text = null;

            txb_modificar_fechaaprobacion.Text=("");
            txb_modificar_fechainicio.Text = ("");
            txb_modificar_fechafinalizacion.Text = ("");

            txb_nombresmodificar.Text = ("");
            txb_direccionmodificar.Text = ("");
            txb_telefonomodificar.Text = ("");

            txb_numcuentamodificar.Text = ("");
            txb_bancomodificar.Text = ("");
            txb_tipocuentamodificar.Text = null;

            txb_codigomodificar.Text = "";
            txb_cedulamodificar.Text = "";
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_modalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void txb_modificar_fechafinalizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscartransaccionmodificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txb_modificarmonto.Text = "";
            txb_modificartasa.Text = "";
            cbx_modificartiempo.Text = "";
            cbx_modificartiempo.SelectedText = "";
            cbx_modificartiempo.SelectedValue = "";
            cbx_modificartiempo.SelectedItem = "";

            cbx_modificarestado.Text = "";
            cbx_modificarestado.SelectedText = "";
            cbx_modificarestado.SelectedValue = "";
            cbx_modificarestado.SelectedItem = "";

            txb_modificar_fechaaprobacion.Text = "";
            txb_modificar_fechainicio.Text = "";
            txb_modificar_fechafinalizacion.Text = "";
        }

        private void chb_fiad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_pres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_codigoconsultar_TextChanged(object sender, EventArgs e)
        {
            txb_cedulaconsultar.Text = "";
        }

        private void txb_codigomodificar_TextChanged(object sender, EventArgs e)
        {
            txb_cedulamodificar.Text = "";
        }

        private void txb_cedulamodificar_TextChanged(object sender, EventArgs e)
        {
            txb_codigomodificar.Text = "";
        }
    }
    
}
