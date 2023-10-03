using LaLista.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LaLista.BE.Class1;


namespace ListadeEnemigos.FE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string usuario;
        public string contrasena;

        private void txtburuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btcrear_Click(object sender, EventArgs e)
        {
            usuario = txtburuario.Text;
            contrasena = txtbcontrasena.Text;
        }
   
        private void btingresar_Click(object sender, EventArgs e)
        //cuando haces donle click puedes agregar el siguienete codigo//
        {
            //si el contenido del txtbox es igual a la variable usuario y contraseña,abre un nuevo formulario//

            if (txtburuario.Text == usuario && txtbcontrasena.Text == contrasena)
            {
                Form2 nuevoFormulario = new Form2();
                nuevoFormulario.Show();


            }
            else
            {
                //si no coiside muestra un mensaje de error//
                MessageBox.Show("NOMBRE DE USUARIO O CONTRAEÑA INCORRECTA");
            }
        }
    }
    }
