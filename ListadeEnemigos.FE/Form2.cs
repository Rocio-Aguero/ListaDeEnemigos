using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaLista.BE;

namespace ListadeEnemigos.FE
{
    public partial class Form2 : Form
    {
        List<Lista> Milista = new List<Lista>();
        public Form2()
        {
            InitializeComponent();
            //hasta que no escribas algo no se abrira la consulta y eliminar//
            tslconsulta.Enabled = false;
            tsleliminar.Enabled = false;
        }

        private void tslagregar_Click(object sender, EventArgs e)
        {
            if (Validarnombre() == false)
            {
                return;
            }
            if (Validarodio() == false)
            {
                return;
            }
            //creamos el objeto de la clase lista//
            Lista MiEnemigo = new Lista();
            MiEnemigo.nombre = txtnombre.Text;
            MiEnemigo.nivel = cmbOdio.SelectedItem.ToString();
            Milista.Add(MiEnemigo);
            dgvLista.DataSource = null;
            dgvLista.DataSource = Milista;
            limpiarcontroles();
            txtnombre.Focus();
            tslconsulta.Enabled = true;


        }
        //validar odio//
        private bool Validarodio()
        {
            if (string.IsNullOrEmpty(cmbOdio.Text))
            {
                error.SetError(cmbOdio, "seleccione el numero de odio");
                return false;
            }
            else
            {
                error.SetError(cmbOdio, "");
                return true;
            }
        }

        //validar el nombre//
        private bool Validarnombre()
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                error.SetError(txtnombre, "ingrese nombre");
                return false;
            }
            else
            {
                error.SetError(txtnombre, "");
                return true;
            }
        }

        //metodo para limpiar los controles//

        private void limpiarcontroles()
        {
            txtnombre.Clear();
            cmbOdio.SelectedIndex = 0;
        }


        private void tslEliminar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                error.SetError(txtnombre, "debes consulta si esta en la lista");
                limpiarcontroles();
                txtnombre.Focus();
                tsleliminar.Enabled = false;
            }
            else
            {
                error.SetError(txtnombre, "");
                DialogResult respuesta = MessageBox.Show("¿estas seguro de eliminarlo?", "confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.Yes)
                {
                    foreach(Lista mienemigo in Milista)
                    {
                        if (mienemigo.nombre == txtnombre.Text)
                        {
                            Milista.Remove(mienemigo);
                            break;
                        }
                    }
                    limpiarcontroles();
                    dgvLista.DataSource = null;
                    dgvLista.DataSource = Milista;
                }
                
            }

        }

        private void tslSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //eventos  de la op consulta//
        private void tslconsulta_Click(object sender, EventArgs e)
        {
            if (Validarnombre() == false)
            {
                return;
            }
            Lista mienemigo = GetEnemigos(txtnombre.Text);
            if (mienemigo == null)
            {
                error.SetError(txtnombre, "el enemigo no esta en la lista");
                limpiarcontroles();
                txtnombre.Focus();
                return;
            }
            else
            {
                error.SetError(txtnombre, "");
                txtnombre.Text = mienemigo.nombre;
                cmbOdio.SelectedItem = mienemigo.nivel;
                tsleliminar.Enabled = true;


            }
        }

        //metodo consulta de enemigos//
        private Lista GetEnemigos(string nombre)
        {
            return Milista.Find(enemigo => enemigo.nombre.Contains(nombre));
        }
    }


        }

      
          
            

      
        

