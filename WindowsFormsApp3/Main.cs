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
using System.IO;
using Npgsql;

namespace WindowsFormsApp3
{
    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            string[] v = { "a", "v"};

            /*
            Cliente lol = new Cliente(1, 2, "A", "B", "c", 3, "D",v);
            Console.WriteLine("Nombre: "+lol.getnombres());
            Inversionista l = new Inversionista(300,"bc","corriente", 1, 2, "A", "B", "c", 3, "D", v);
            Console.WriteLine(l.getnombres());*/
            



        }


        static ArrayList tuplas = new ArrayList();
        private void Main_Load(object sender, EventArgs e)
        {
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            //this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            //this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);




            ///--BUSCA SI HAY ALGUNA TRANSACCION PARA PAGAR HOY
            ///
            try
            {
                string cadena = "";


                string fechahoy = metodos.fecha_hoy();
                DateTime hoy = Convert.ToDateTime(fechahoy);


                string consulta = "select codcuotainversion,inversion,fechaplaneadainversion" +
                    " from cuotas_inversion  where fechaplaneadainversion = '" + fechahoy + "' ";
                NpgsqlDataReader resultados = metodos.resultados_consulta(consulta);

                while (resultados.Read())
                {
                    DateTime fplaneada = resultados.GetDateTime(2);
                    string ccuo = Convert.ToString(resultados.GetValue(0));
                    string ci = Convert.ToString(resultados.GetValue(1));

                    int dd = DateTime.Compare(hoy, fplaneada);
                    if (dd == 0)
                    {
                        Pagar_Inversion nuevo = new Pagar_Inversion();
                        Pagar_Inversion.variables(ci, ccuo);
                        nuevo.Show();

                        MessageBox.Show("Hay inversiones que se deben pagar hasta hoy");
                        cadena += "Cuota: " + ccuo + " Transaccion: " + ci + "\n";
                    }
                }


                string consulta2 = "select codcuotaprestamo,prestamo,fechaplaneadaprestamo" +
                    " from cuotas_prestamo  where fechaplaneadaprestamo = '" + fechahoy + "' ";
                NpgsqlDataReader resultados2 = metodos.resultados_consulta(consulta2);

                while (resultados2.Read())
                {
                    DateTime fplaneada = resultados2.GetDateTime(2);
                    string ccuop = Convert.ToString(resultados2.GetValue(0));
                    string cp = Convert.ToString(resultados2.GetValue(1));

                    int dd = DateTime.Compare(hoy, fplaneada);
                    if (dd == 0)
                    {
                        Pagar_Inversion nuevo = new Pagar_Inversion();
                        Pagar_Inversion.variables(cp, ccuop);
                        nuevo.Show();

                        MessageBox.Show("Hay prestamos que se deben pagar hasta hoy");
                        cadena += "Cuota: " + ccuop + " Transaccion:" + cp + "\n\n";
                    }
                }








                lbl_transaccionespagar.Text = cadena;




                ///--Rematando deudas
                //string fechahoy = metodos.fecha_hoy();
                DateTime hoy3 = Convert.ToDateTime(fechahoy);


                string consulta3 = "select codcuotainversion,inversion,fechaplaneadainversion,estadocuotainversion" +
                    " from cuotas_inversion  ";
                NpgsqlDataReader resultados3 = metodos.resultados_consulta(consulta3);

                while (resultados3.Read())
                {
                    DateTime fplaneada = resultados3.GetDateTime(2);
                    string ccuo = Convert.ToString(resultados3.GetValue(0));
                    string ci = Convert.ToString(resultados3.GetValue(1));
                    string estado = Convert.ToString(resultados3.GetValue(3));

                    int dd = DateTime.Compare(hoy3, fplaneada);
                    //if (dd > 0 && (!estado.Equals("PAGADA") || !estado.Equals("REMATADA")))
                    if (dd > 0 && estado.Equals("PENDIENTE"))
                    {
                        string act = "update cuotas_inversion set estadocuotainversion='REMATADA' " +
                            "where codcuotainversion like'" + ccuo + "'";
                        NpgsqlDataReader rem = metodos.resultados_consulta(act);
                        MessageBox.Show("Se reamato una Inversion, por falta de pagos");
                    }
                }




                DateTime hoy4 = Convert.ToDateTime(fechahoy);


                string consulta4 = "select codcuotaprestamo,prestamo,fechaplaneadaprestamo,estadocuotaprestamo" +
                    " from cuotas_prestamo  ";
                NpgsqlDataReader resultados4 = metodos.resultados_consulta(consulta4);

                while (resultados4.Read())
                {
                    DateTime fplaneada4 = resultados4.GetDateTime(2);
                    string ccuo4 = Convert.ToString(resultados4.GetValue(0));
                    string ci = Convert.ToString(resultados4.GetValue(1));
                    string estado4 = Convert.ToString(resultados4.GetValue(3));

                    int dd4 = DateTime.Compare(hoy4, fplaneada4);
                    if (dd4 > 0 && estado4.Equals("PENDIENTE"))
                    {
                        string act4 = "update cuotas_prestamo set estadocuotaprestamo='REMATADA' " +
                            "where codcuotaprestamo like'" + ccuo4 + "'";
                        NpgsqlDataReader rem4 = metodos.resultados_consulta(act4);
                        MessageBox.Show("Se reamato un Prestamo, por falta de pagos");
                    }
                }

            }
            catch { MessageBox.Show("Error inesperado..."); }





        }





        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            Informacion_Clientes nuevo = new Informacion_Clientes(2);
            nuevo.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Informacion_Clientes nuevo = new Informacion_Clientes(1);
            nuevo.Show();
     
        }

        private void btn_modificar_CLICK(object sender, EventArgs e)
        {
            Informacion_Clientes nuevo = new Informacion_Clientes(3);
            nuevo.Show();
        }

        private void btn_administrar_transacciones_CLICK(object sender, EventArgs e)
        {
            //nada

        }

        private void btn_administrar_transacciones_Click_1(object sender, EventArgs e)
        {
            Random al = new Random();
            int b = al.Next(1, 2);
            Informacion_Clientes nuevo = new Informacion_Clientes(3);
            nuevo.Show();
        }

        private void btn_administrar_cronogramas_CLICK(object sender, EventArgs e)
        {
            Generar_Cronogramas nuevo = new Generar_Cronogramas(2);
            nuevo.Show();
        }

        private void btn_cro_inv_CLICK(object sender, EventArgs e)
        {
            Generar_Cronogramas nuevo = new Generar_Cronogramas(2);
            nuevo.Show();
        }

        private void btn_cro_pres_CLICK(object sender, EventArgs e)
        {
            Generar_Cronogramas nuevo = new Generar_Cronogramas(1);
            nuevo.Show();
        }

        private void btn_admin_transac_Click(object sender, EventArgs e)
        {
            Administrar_Transaciones nuevo = new Administrar_Transaciones(2);
            nuevo.Show();            
        }

        private void btn_admin_inv_CLICK(object sender, EventArgs e)
        {
            Administrar_Transaciones nuevo = new Administrar_Transaciones(2);
            nuevo.Show();
        }

        private void btn_admin_pre_Click(object sender, EventArgs e)
        {
            Administrar_Transaciones nuevo = new Administrar_Transaciones(1);
            nuevo.Show();
        }

        private void btn_pagar_inv_CLICK(object sender, EventArgs e)
        {
            Pagar_Inversion nuevo = new Pagar_Inversion();
            nuevo.Show();
        }

        private void btn_cerrar_CLICK(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            metodos.desconectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuadros_de_dialo n = new Cuadros_de_dialo();
                n.Show();
        }





        

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
           
     
        }
        int posx = 0;
        int posy = 0;
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }
    }
}
