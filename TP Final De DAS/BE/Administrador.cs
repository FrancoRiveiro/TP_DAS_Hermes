using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  class Administrador: Usuario
    {
        public Administrador(string nombre, string apellido, int dni, string contraseña, string email, bool rol,int telefono) : base(nombre, apellido, dni, contraseña, email, rol,telefono)
        {


        }
    }
}
