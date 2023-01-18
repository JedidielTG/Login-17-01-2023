using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        static int intentos = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // user = "jedi"
            // password = "12345"
            //necesitammos el susuario y contrasena
            string usuario = tbuser.Text;
            string password = tbcontrasena.Text;


            if (this.tbuser.Text == "jedi" && this.tbcontrasena.Text == "toto12")
            {

                pictureBox1.Image = new Bitmap(@"C:\Users\GARDIEL\source\repos\Login\Login\compass-g3197e2328_1280.jpg");
                MessageBox.Show(" Bienvenido ");
            }
            else if (intentos > 0 && intentos == 3)
            {
                intentos = 3;
                aviso.Text = "Solo tienes " + Convert.ToString(intentos) + " intentos mas";
                MessageBox.Show(" Usuario O contresena incorrectos ");
                intentos--;
            }
            else if (this.tbuser.Text == "jedi" && this.tbcontrasena.Text == "toto12")
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\GARDIEL\source\repos\Login\Login\compass-g3197e2328_1280.jpg");
                MessageBox.Show(" Bienvenido ");

            }
            else if (intentos > 0 && intentos == 2)
            {
                intentos = 2;
                aviso.Text = "Solo tienes " + Convert.ToString(intentos) + " intentos mas";
                MessageBox.Show("Usuario O contresena incorrectos");
                intentos--;
            }
            else if (this.tbuser.Text == "jedi" && this.tbcontrasena.Text == "toto12")
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\GARDIEL\source\repos\Login\Login\compass-g3197e2328_1280.jpg");
                MessageBox.Show("Bienvenido");
            }
            else if (intentos > 0 && intentos == 1)
            {
                intentos = 1;
                aviso.Text = "Solo tienes " + Convert.ToString(intentos) + " intentos mas";
                MessageBox.Show("Usuario O contresena incorrectos");
                intentos--;
            }
            else if (intentos == 0) 
            {
                MessageBox.Show("Se procede a bloquear boton de entreda");
                aviso.Text = "Sin ningun intento llame a soporte";
                button1.Enabled = false;

            }


        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
