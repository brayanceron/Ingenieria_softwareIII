using System;
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
    
    public partial class Administrar_Garantia : Form
    {
        int codigo;
        public Administrar_Garantia(int codigogarantia)
        {
            InitializeComponent();
            MessageBox.Show("Solicitud de garantia codigo:  " + codigogarantia);
            codigo = codigogarantia;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            //ojo aqui esta incompleto, hayq que crear el archivo de garantias
            string codigo = metodos.generar_codigo(4, "garantia", "codgarantia");
        }

        private void Administrar_Garantia_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ///---validar que todos los campos este llenos
            if (txb_valor.Text.Equals("") ||
                txb_ubicacion.Text.Equals("")                
                )
            {
                MessageBox.Show("Debe digitar todos los campos"); return;
            }




            string valor = txb_valor.Text;
            string ubicacion = txb_ubicacion.Text;
            string consulta = "insert into garantia values ('"+codigo+"','"+valor+"','"+ubicacion+"')";
            metodos.tabla_consulta(consulta);

            MessageBox.Show("Garantia registrada exitosamente");
            this.Close();

        }

        private void txb_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
