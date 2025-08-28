using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frRegistro : Form
    {
        //private GestorUsuario<Cliente> gestor = new GestorUsuario<Cliente>();
        public frRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* todo lo de registro
                // Intenta crear el cliente con los datos de los textbox
                try {
                    string Nombre = this.textBox1.Text;
                    string Apellido = this.textBox2.Text;
                    string Email = this.textBox3.Text;
                    int Telefono = Convert.ToInt32(this.textBox4.Text);
                    int DNI = Convert.ToInt32(this.textBox5.Text);
                    string Contraseña = this.textBox6.Text;
                    string ContraseñaEncriptada = ContraseñaHasher.GenerarHash(Contraseña); // Encripta la contraseña antes de guardarla

                        Cliente cliente = new Cliente(Nombre, Apellido,ContraseñaEncriptada, Email, Telefono, DNI)
                    { };

                    gestor.Agregar(cliente);

                 

                    this.DialogResult = DialogResult.OK; // Indica que el registro fue exitoso
                    MessageBox.Show("Cliente registrado exitosamente");


                /////// // Actualiza la grilla de clientes en el formulario de gestión
                    
                    
                     this.Close(); // Cierra el formulario después de registrar al cliente


            }//Atrapa un error si hay un campo nulo
            catch (ArgumentNullException)
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            
            
*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
