using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace LaLista.BE
{

    public class Class1
    {
        public class Usuario
        {
            public string Nombre { get; set; }
            public string clave { get; set; }

            public Usuario(string nombre, string contrasena)
            {
                Nombre = nombre;
                clave = clave;
            }

            public override string ToString()
            {
                return $"Usuario: {Nombre}, Contraseña: {clave}";
            }
            internal class Lista
            {
                public string nombre { get; set; }
                public string nivel { get; set; }

            }



        }



    }
    }

  