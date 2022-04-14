
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Libreria_internacional.net.Modelos;

namespace Libreria_internacional.net.Controladores
{
    public class Usuarios
    {

        public bool login(Usuario usuario)
        {
            bool result=false;
            List<Usuario> usuarios= new List<Usuario>();
            Usuario usuario1 = new Usuario()
            {
                User = "oscar",
                Password = "hola",
                Email = null
                 
            };
            usuarios.Add(usuario1);

            Usuario usuario2 = new Usuario();
            usuario2.User = "pepe";
            usuario2.Password = "pepe";
            usuarios.Add(usuario2);
            
            for(int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].User==usuario.User && usuarios[i].Password==usuario.Password)
                {
                    result=true;
                    break;
                }
                
            }

            return result;
        }

    }
}