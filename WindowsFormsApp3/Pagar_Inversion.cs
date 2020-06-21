using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.clases;
using Npgsql;

namespace WindowsFormsApp3
{
    public partial class Pagar_Inversion : Form
    {
        public Pagar_Inversion()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //validar que se haya pasado por codigo de transaccion y no por otro dato
        //ArrayList cuota;
        Boolean es_inversion=false;
        Boolean flagprest = false;
        Boolean flaginver = false;
        string codigocuota;
        private void btn_buscarpagar_cLICK(object sender, EventArgs e)
        {
            string busc = txb_codigotransaccionpagar.Text;

             flagprest = false;
             flaginver = false;
             //codigocuota = "";

            ///--verifica si no esta lleno el campo

            if (txb_codigotransaccionpagar.Text.Equals("")) { MessageBox.Show("Digite todos los campos"); return; }

            ///Validando que la transaccion exista
            if (metodos.buscar("transacciones_prestamo", "codprestamo", busc) == true) { flagprest = true; }
            else if (metodos.buscar("transacciones_inversion", "codinversion", busc) == true) { flaginver = true; }
            else { MessageBox.Show("La transaccion no fue encontrada"); return; }


            if (flagprest == true)
            {
                string cns = "select codcuotaprestamo,estadocuotaprestamo from cuotas_prestamo where prestamo like '" + busc + "' order by fechaplaneadaprestamo";
                NpgsqlDataReader rst = metodos.resultados_consulta(cns);
               

                //determinando la cuota              
                int numcuotas = rst.FieldCount;
                int i = 1;
                Boolean toda = false;
                while (rst.Read())
                {
                    string currentcuota = "" + rst.GetValue(0);
                    string currentestado = "" + rst.GetValue(1);
                    if (currentestado.Equals("PENDIENTE"))
                    {
                        toda = true;
                        codigocuota = currentcuota;
                        break;
                    }
                    if (currentestado.Equals("REMATADA"))
                    {
                        MessageBox.Show("La deuda ha sido Rematada ");
                        return;
                    }


                    i++;
                }
                if (toda == false)
                {
                    MessageBox.Show("La Transaccion ya a sido pagada en su totalidad");
                    return;
                }


                //poniendo en las cajas

                string consulta = "select nombreprestatario,direccionprestatario," +
                    "valorcuotaprestamo,fechaplaneadaprestamo,tasacuotaprestamo,estadocuotaprestamo" +
               " from transacciones_prestamo  join prestatario on(prestatario=codprestatario) join cuotas_prestamo on(codprestamo=prestamo) where codprestamo like '" + busc + "'";

                NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
                resultados.Read();


                lbl_nombre.Text = resultados.GetValue(0)+"";
                lbl_direccion.Text = resultados.GetValue(1)+"";
                lbl_fchefectiva.Text = metodos.fecha_hoy() + "   (hoy)";
                lbl_cuota.Text = codigocuota + "  " + i + "/" + numcuotas + "  Pagadas";
                lbl_valor.Text = resultados.GetValue(2) + " $";
                lbl_tasa.Text = resultados.GetValue(4) + " %";
                lbl_estado.Text = resultados.GetValue(5)+"";
                lbl_fchplaneada.Text = resultados.GetValue(3)+"";
                //lbl_modalidad.Text = "";  //corregir modalidad no va en el menu
                //lbl_comprobante.Text = Convert.ToString(cuota[9]); //corregir comprobante no va en el menu
                

                pnl_pagar.Enabled = true;
                pnl_pagobancario.Enabled = false; //ojo solo para las inversiones si se habilida pero solo si es de tio bancaria
            }
            else if (flaginver == true)
            {
                string cns = "select codcuotainversion,estadocuotainversion from cuotas_inversion where inversion like '" + busc + "' order by fechaplaneadainversion";
                NpgsqlDataReader rst = metodos.resultados_consulta(cns);


                //determinando la cuota              
                int numcuotas = rst.FieldCount;
                int i = 1;
                Boolean toda = false;
                while (rst.Read())
                {
                    string currentcuota = "" + rst.GetValue(0);
                    string currentestado = "" + rst.GetValue(1);
                    if (currentestado.Equals("PENDIENTE"))
                    {
                        toda = true;
                        codigocuota = currentcuota;
                        break;
                    }
                    if (currentestado.Equals("REMATADA"))
                    {
                        MessageBox.Show("La deuda ha sido Rematada ");
                        return;
                    }


                    i++;
                }
                if (toda == false)
                {
                    MessageBox.Show("La Transaccion ya a sido pagada en su totalidad");
                    return;
                }


                //poniendo en las cajas

                string consulta = "select nombreinversionista,direccioninversionista," +
                    "valorcuotainversion,fechaplaneadainversion,tasacuotainversion,estadocuotainversion" +
               " from transacciones_inversion  join inversionista on(inversionista=codinversionista) join cuotas_inversion on(codinversion=inversion) where codinversion like '" + busc + "'";

                NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);
                resultados.Read();


                lbl_nombre.Text = resultados.GetValue(0) + "";
                lbl_direccion.Text = resultados.GetValue(1) + "";
                lbl_fchefectiva.Text = metodos.fecha_hoy() + "   (hoy)";
                lbl_cuota.Text = codigocuota + "  " + i + "/" + numcuotas + "  Pagadas";
                lbl_valor.Text = resultados.GetValue(2) + " $";
                lbl_tasa.Text = resultados.GetValue(4) + " %";
                lbl_estado.Text = resultados.GetValue(5) + "";
                lbl_fchplaneada.Text = resultados.GetValue(3) + "";
                //lbl_modalidad.Text = "";  //corregir modalidad no va en el menu
                //lbl_comprobante.Text = Convert.ToString(cuota[9]); //corregir comprobante no va en el menu


                pnl_pagar.Enabled = true;
                //pnl_pagobancario.Enabled = false; //ojo solo para las inversiones si se habilida pero solo si es de tio bancaria

                string bancarios = "select numcuentainversionista,bancoinversionista,tipocuentainversionista from inversionista join transacciones_inversion on(codinversionista=inversionista) where codinversion like '" + busc + "'";
                NpgsqlDataReader rbanca = metodos.resultados_consulta(bancarios);
                rbanca.Read();
                numcuenta = rbanca.GetValue(0)+"";
                banco = rbanca.GetValue(1) + "";
                tipocuenta = rbanca.GetValue(2) + "";
            }

            //MessageBox.Show("Cuota a pagar: "+codigocuota+" Prestamo: "+busc);
              

            
        }


        string numcuenta, tipocuenta, banco;


        static string ct = null;
        static string ccu=null;
        public static void variables(string ct2, string ccu2)
        {
            ct = ct2;
            ccu = ccu2;
        }
        

        private void Pagar_Inversion_Load(object sender, EventArgs e)
        {
            pnl_pagar.Enabled = false;
            if (ct != null) { txb_codigotransaccionpagar.Text = ct; }
        }

        private void btn_pagartransaccion_Click(object sender, EventArgs e)
        {
            /*
            ///---validar que todos los campos este llenos
            if (cbx_modalidad.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar todos los campos"); return;
            }
            


            //validar toda la informacion anterior
            string fechaefectiva = metodos.fecha_hoy();
            string comprobante = txb_comprobante.Text;
            string modalidad = cbx_modalidad.Text;

            if (flagprest == true)
            {
                string consulta="update cuotas_prestamo " +
                    " set estadocuotaprestamo = 'PAGADA', comprobante='"+comprobante+
                    "' , modalidad = '"+modalidad+"', fechaefectivaprestamo='"+fechaefectiva+"' " +
                    "where codcuotaprestamo like '"+codigocuota+"'";
                metodos.resultados_consulta(consulta);
                MessageBox.Show("Transaccion pagada exitosamente");
                //MessageBox.Show("pagada");
            }

            else if (flaginver == true)
            {
                //Si es por modalidad bancaria solo para inversionistas
                if (cbx_modalidad.Text.Equals("BANCARIA"))
                {
                    ///---validar que todos los campos este llenos
                    
                        if (txb_numerocuenta.Text.Equals("") ||
                        txb_banco.Text.Equals("") ||
                        cbx_tipocuenta.Text.Equals("")
                        )
                        {
                            MessageBox.Show("Debe digitar todos los campos"); return;
                        }
                    
                    


                    string nc = txb_numerocuenta.Text;
                    string b = txb_banco.Text;
                    string tc = cbx_tipocuenta.Text;

                    string consulta = "update cuotas_inversion " +
                    " set estadocuotainversion = 'PAGADA', fechaefectivainversion='" + fechaefectiva + "', " +
                    " numcuenta='"+nc+"', tipocuenta='"+tc+"', banco='"+b+"' " +
                    "where codcuotainversion like '" + codigocuota + "'";
                    metodos.resultados_consulta(consulta);

                }
                else
                {
                    if (txb_comprobante.Text.Equals(""))
                    {
                        MessageBox.Show("Debe digitar todos los campos"); return;
                        return;
                    }
                    string consulta = "update cuotas_inversion " +
                    " set estadocuotainversion = 'PAGADA', comprobante='" + comprobante +
                    "' , modalidad = '" + modalidad + "', fechaefectivainversion='" + fechaefectiva + "' " +
                    "where codcuotainversion like '" + codigocuota + "'";
                    metodos.resultados_consulta(consulta);
                }


                MessageBox.Show("Transaccion pagada exitosamente");


            }
            //cerrando la seccion de pagos....
            Close();
            */
        }

        private void txb_codigotransaccionpagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_numerocuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cbx_modalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
               
            if (flaginver == true && cbx_modalidad.Text.Equals("BANCARIA"))
            {
                pnl_pagobancario.Enabled = true;
                txb_comprobante.Enabled = false;

                txb_numerocuenta.Text = numcuenta;
                txb_banco.Text = banco;
                cbx_tipocuenta.Text = tipocuenta;
                //cbx_tipocuenta.SelectedText = tipocuenta;
                cbx_tipocuenta.SelectedValue = tipocuenta;
                //cbx_tipocuenta.SelectedItem = tipocuenta;
            }
            else
            {
                pnl_pagobancario.Enabled = false;
                txb_comprobante.Enabled = true;

                txb_numerocuenta.Text = "";
                txb_banco.Text = "";
                cbx_tipocuenta.Text = "";
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
