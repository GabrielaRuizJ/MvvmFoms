using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmValidation
{
    public class VM_SignUp
    {
        private string lblNombreUsuario ="Introduce tu nombre de usuario";
        private string lblContraseña = "Introduce tu contraseña";
        private string mensaje;
        private string enUsuario;
        private string enContraseña;
        private bool ispassword = true;
        private bool isEnable;

        public bool IsEnable
        {
            get { return isEnable; }
            set { isEnable = value; }
        }

        public bool Password
        {
            get { return ispassword; }
            set { ispassword = value; }
        }

        public string LblContraseña
        {
            get { return lblContraseña; }
            set { lblContraseña = value; }
        }

        public string LblUsuario
        {
            get { return lblNombreUsuario; }
            set { lblNombreUsuario = value; }
        }

        public string EnUsuario
        {
            get { return enUsuario; }
            set { enUsuario = value; }
        }

        public string EnContraseña
        {
            get { return enContraseña; }
            set { enContraseña = value; }
        }


        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }


    }
}
