using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace WindowsFormsApp3.clases
{
    class metodos
    {

        

        public static long generar_codigocuota(int prefijo,string tabla,string atributo)
        {
            Random ale = new Random();
            long r = ale.Next(0,1999999999);

            Boolean encontrado = false;
            string cg = prefijo + "" + r;

            while (encontrado==false)
            {
                if (buscar(tabla, atributo, Convert.ToString(cg)) == false)
                {
                    
                    encontrado = true;
                    break;
                }
                r = ale.Next(0, 1999999999);
                cg = prefijo + "" + r;
            }

            long rr = long.Parse(cg);
            return rr;
        }

        public static string generar_codigo(int prefijo, string tabla, string atributo)
        {

            Random ale = new Random();
            long r = ale.Next(1, 99998);

            Boolean encontrado = false;
            string cg = prefijo + "" + r;

            while (encontrado == false)
            {
                if (buscar(tabla, atributo, Convert.ToString(cg)) == false)
                {

                    encontrado = true;
                    break;
                }
                r = ale.Next(1, 99998);
                cg = prefijo + "" + r;
            }

            return prefijo+""+r;

        }

        


        public static string fecha_hoy()
        {
            DateTime hoy = DateTime.Today;
            String fechacadena = hoy.ToString("dd/MM/yyyy");
            return fechacadena;
        }

         
        public static void conectar()
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "User ID=postgres; Password=postgres1; Host=localhost; Port=5432; Database=prueba; commandtimeout=900";
            try
            {
                conexion.Open();
                MessageBox.Show("Conectando con la base de datos");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
        public static void desconectar()
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "User ID=postgres; Password=postgres1; Host=localhost; Port=5432; Database=prueba; commandtimeout=900";
            try
            {
                conexion.Close();
                MessageBox.Show("Cerrando conexion con la base de datos");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }


        public static DataTable tabla_consulta(string consulta)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "User ID=postgres; Password=postgres1; Host=localhost; Port=5432; Database=prueba; commandtimeout=900";
            try
            {
                conexion.Open();
                //MessageBox.Show("Ok");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);return null;
            }

            //string consulta = "select * from \"persona\"";
            NpgsqlCommand conector = new NpgsqlCommand(consulta, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            conexion.Close();
            return tabla;
            //basedatosmostrar.DataSource = tabla;
            
        }
        public static NpgsqlDataReader resultados_consulta(string consulta)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();

            conexion.ConnectionString = "User ID=postgres; Password=postgres1; Host=localhost; Port=5432; Database=prueba; commandtimeout=900";
            try
            {
                conexion.Open();
                //MessageBox.Show("Ok");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message); return null;
            }
            
            
            NpgsqlCommand conector = new NpgsqlCommand(consulta, conexion);          
            NpgsqlDataReader resultados = conector.ExecuteReader();

            
            ///-- para saber si esta nulo if (!resultados.Read()) { MessageBox.Show("Ok"); }
            /*  PARA RECORRER LOS RESULTADOS
            while (resultados.Read())
            {
                string r = resultados.GetString(0);           
                MessageBox.Show(""+r);            
                MessageBox.Show("" + resultados.FieldCount); //tamaño
            }
            */
           

            //conexion.Close();
            return resultados;
           

        }

        public static Boolean buscar(string tabla,string atributo ,string dato)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "User ID=postgres; Password=postgres1; Host=localhost; Port=5432; Database=prueba; commandtimeout=900";
            int i = 0;
            try
            {
                conexion.Open();
                //MessageBox.Show("Ok");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            try
            {

                string consulta = "select * from " + tabla + " where "+atributo+" like '"+dato+"'";
                //string consulta = "select * from inversionista";
                NpgsqlCommand conector = new NpgsqlCommand(consulta, conexion);
                NpgsqlDataReader resultados = conector.ExecuteReader();

                
                while (resultados.Read())
                {
                    i++;
                }
                //MessageBox.Show("giros: "+i);
                
                conexion.Close();
                if (i == 0) { return false; }
                else { return true; }
            }
            
            catch { conexion.Close(); return false; }
            
            
            return false;


        }

        public static Boolean actualizar(string tabla, string atributo,string nuevodato,string atributopk,string valorpk)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "User ID=postgres; Password=postgres1; Host=localhost; Port=5432; Database=prueba; commandtimeout=900";
            int i = 0;
            try
            {
                conexion.Open();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


            string consulta = "update " + tabla + " set " + atributo + " = '" + nuevodato + "'  where " + atributopk + " = '" + valorpk + "' ";
            try
            { 
               //string consulta = "select * from inversionista";
            NpgsqlCommand conector = new NpgsqlCommand(consulta, conexion);
            NpgsqlDataReader resultados = conector.ExecuteReader();
                
                return true;
            }

            catch {  return false; }

            
        }

        public static void ejecutar_consulta(string consulta)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "User ID=postgres; Password=postgres1; Host=localhost; Port=5432; Database=prueba; commandtimeout=900";
            int i = 0;
            try
            {
                conexion.Open();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            NpgsqlCommand execute = new NpgsqlCommand(consulta, conexion);
            try
            {
                execute.ExecuteNonQuery();
                //conexion.Close();
            }
            catch
            {
                conexion.Close(); MessageBox.Show("Error en la consulta");
            }
        }
    }
}
