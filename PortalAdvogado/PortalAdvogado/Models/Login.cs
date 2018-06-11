using System;
using System.Collections.Generic;
using System.Text;

namespace PortalAdvogado.Models
{
    public class Login
    {
        public string oab { get; private set; }
        public string letra { get; private set; }
        public string uf { get; private set; }
        public string senha { get; private set; }

        public Login(string oab, String letra, String uf, string senha)
        {
            this.oab = oab;
            this.letra = letra;
            this.uf = uf;
            this.senha = senha;
        }
    }
}
