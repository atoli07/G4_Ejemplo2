using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace G4_Ejemplo2
{
    public partial class sistema : Form
    {
        string password;
        public sistema()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = txtContraseña.Text;
            string url = "C:\\Users\\alexm\\Desktop\\Guia4\\Usuarios_Contraseñas" + usuario + ".txt";

            if (File.Exists(url))  //verifica que el archivo exista
            {
                MessageBox.Show("ERROR ¡Usuario ya existente!");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }

            else
            {
                File.WriteAllText(url, contra);
                MessageBox.Show("Usuario resgistrado con éxito");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = txtContraseña.Text;
            string url = "C:\\Users\\alexm\\Desktop\\Guia4\\Usuarios_Contraseñas" + usuario + ".txt";

            if (File.Exists(url))
            {
                password = File.ReadAllText(url);
                if (contra.Equals(password))
                {
                    MessageBox.Show("¡Ingreso exitoso, bienvenido!");  //login existoso
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!");  //login fallido
                }
            }

            else
            {
                MessageBox.Show("¡Usuario incorrecto!");   //usuario incorrecto
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
