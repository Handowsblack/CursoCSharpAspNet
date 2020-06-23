using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Negócios
{
    public class LoginBll
    {
        // atrib's privados
        const string usuario = "Alex";
        const string senha = "123456";

        //Sintaxe Auto
        public string UsuarioLogado { get; set; }

        //private string _usuarioLogado;

        //public string UsuarioLogado
        //{
        //    get { return _usuarioLogado; }
        //    set { _usuarioLogado = value; }
        //}


        public bool Autenticar (string pUsuario, string pSenha)
        {
            if (pUsuario == usuario && pSenha == senha)
            {
                UsuarioLogado = pUsuario;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
