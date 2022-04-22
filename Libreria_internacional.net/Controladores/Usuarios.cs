
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Libreria_internacional.net.DB;
using Libreria_internacional.net.Modelos;

namespace Libreria_internacional.net.Controladores
{
    public class Usuarios
    {//Aqui se crean y se loguean usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            DataTable dt = DataBase.fillDTStoreProcedure("spObtenerUsuarios", null);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Usuario users = new Usuario()
                {
                    User = dt.Rows[i]["usuario"].ToString(),
                    Password = dt.Rows[i]["passw"].ToString(),
                    Email = dt.Rows[i]["email"].ToString()



                };
                usuarios.Add(users);
            }
            return usuarios;
        }
        public bool login(Usuario usuario)
        {//Metodo de login
            bool result=false;

            List<Usuario> usuarios =ObtenerUsuarios();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].User==usuario.User && usuarios[i].Password==usuario.Password)
                {
                    result=true;
                    break;
                }
                
            }

            return result;
        }

        public bool Registrar(Usuario usuario)
        {
            bool result = true;

            List<Usuario> usuarios = ObtenerUsuarios();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].User == usuario.User || usuarios[i].Email == usuario.Email)
                {
                    result = false;
                    break;
                    

                }
   
            }
            if (result)
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@user", usuario.User));
                param.Add(new SqlParameter("@passw", usuario.Password));
                param.Add(new SqlParameter("@email", usuario.Email));
                DataBase.executeQuery("spIngresarUsuario", param);

            }
            return result;

        }

        public Usuario getEmail(Usuario usuario)
        {//Metodo de login
            

            List<Usuario> usuarios = ObtenerUsuarios();
            Usuario user = new Usuario();
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].User == usuario.User )
                {
                    user=usuarios[i];
                }

            }

            return user;
        }



    }
}