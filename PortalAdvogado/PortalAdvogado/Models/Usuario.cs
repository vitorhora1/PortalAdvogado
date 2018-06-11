using System;
using System.Collections.Generic;
using System.Text;

namespace PortalAdvogado.Models
{
    public class Usuario
    {
        public string nome { get; private set; }
        public string oab { get; private set; }

        public Usuario(string nome, string oab)
        {
            this.nome = nome;
            this.oab = oab;
        }
    }
}
