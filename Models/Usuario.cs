using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Usuario
    {
        public List<UsuarioModel> listaUsuario = new List<UsuarioModel>();

        public Usuario()
        {
            listaUsuario.Add(new UsuarioModel
            {
                nome = "Marcio",
                sobrenome = "Braga",
                endereco = "Rua piracanjuba, 100",
                email = "marciobraga@gmail.com",
                nascimento = Convert.ToDateTime("05/09/1975")

            });

            listaUsuario.Add(new UsuarioModel
            {

                nome = "Myke",
                sobrenome = "Tyson",
                endereco = "Rua da Tortura, 34",
                email = "tyson@gmail.com",
                nascimento = Convert.ToDateTime("13/08/1990")

            });

            listaUsuario.Add(new UsuarioModel
            {

                nome = "Debora Fonseca",
                sobrenome = "Cabrini",
                endereco = "Rua da Matriz, 103",
                email = "debfon@gmail.com",
                nascimento = Convert.ToDateTime("04/03/1988")
                
            });
        }

        public void CriaUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuario.Add(usuarioModelo);
        }

        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach (UsuarioModel usuario in listaUsuario)
            {
                if (usuario.email == usuarioModelo.email)
                {
                    listaUsuario.Remove(usuario);
                    listaUsuario.Add(usuarioModelo);
                    break;
                }
            }
        }

        public UsuarioModel GetUsuario(string Email)
        {
            UsuarioModel _usuarioModel = null;

            foreach (UsuarioModel _usuario in listaUsuario)
                if (_usuario.email == Email)
                    _usuarioModel = _usuario;

            return _usuarioModel;

        }

        public void DeletarUsuario(String Email)
        {
            foreach (UsuarioModel _usuario in listaUsuario)
            {
                if (_usuario.email == Email)
                {
                    listaUsuario.Remove(_usuario);

                    break;
                }
            }
        }
    }

        
}