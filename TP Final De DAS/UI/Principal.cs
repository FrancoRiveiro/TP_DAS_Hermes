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
    public partial class Principal : Form
    {
        private frCatalogo catalogo;
        private frGestionUsuario gestionarCliente;
        private frGestionViajes gestionViajes;
        private frGestionEmpresa gestionEmpresa;
        public Principal()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* cosas de login
                  if (SesionManagger.SesionActiva) 
            {
                var usuario = SesionManagger.Instancia.Usuario;

               MessageBox.Show("Ya existe una sesión activa para el usuario: " + usuario.Nombre, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (usuario.Rol) 
                {
                inicioToolStripMenuItem.Visible = true;
                EmpresaToolStripMenuItem.Visible = true;
                UsuariosToolStripMenuItem.Visible = true;
                viajesToolStripMenuItem.Visible = true;

                }
                else
                {   

                    EmpresaToolStripMenuItem.Visible = false;
                    UsuariosToolStripMenuItem.Visible = false;
                    viajesToolStripMenuItem.Visible = false;
                }
                MessageBox.Show("Bienvenido " + usuario.Nombre, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ///
                foreach (Form form in this.MdiChildren)
                {
                    if (form is Catalogo catalogoForm)
                    {
                        catalogoForm.habilitadorButom();
                        break;
                    }
                }
                ///
                return;
            }
            login = new Login();
            login.Form1 = this;

            if (login.ShowDialog() == DialogResult.OK)
            {
                try 
                {
                
                var usuario = SesionManagger.Instancia.Usuario;
                    if (usuario.Rol) 
                    {
                     inicioToolStripMenuItem.Visible = true;
                      EmpresaToolStripMenuItem.Visible = true;
                     UsuariosToolStripMenuItem.Visible = true;
                     viajesToolStripMenuItem.Visible = true;

                    }
                    else
                    {
                        inicioToolStripMenuItem.Visible = true;
                        EmpresaToolStripMenuItem.Visible = false;
                        UsuariosToolStripMenuItem.Visible = false;
                        viajesToolStripMenuItem.Visible = false;
                    }


                    foreach (Form form in this.MdiChildren)
                    {
                        if (form is frCatalogo catalogoForm)
                        {
                            catalogoForm.habilitadorButom();
                            break;
                        }
                    }
                
                }
                
                catch (Exception ex) 
                {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            login =null; // Liberar el recurso del formulario de login
        }
*/
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*catalogo = new frCatalogo(usuarioActual);
            catalogo.FormClosed += new FormClosedEventHandler(cerrarForms);
            catalogo.MdiParent = this;
            catalogo.Show();*/
        }
        void cerrarForms(object sender, FormClosedEventArgs e)
        {
           // login = null;
            catalogo = null;
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionarCliente = new frGestionUsuario();
            gestionarCliente.MdiParent = this;
            gestionarCliente.Show();
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gestionViajes = new frGestionViajes(gestorV, gestorE, gestorT);
            gestionViajes.MdiParent = this;
            gestionViajes.Show();
        }

        private void gestionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gestionEmpresa = new frGestionEmpresa();
            gestionEmpresa.MdiParent = this;
            gestionEmpresa.Show();
        }
    }
}
