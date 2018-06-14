using System;
using System.Collections.Generic;
using System.Text;

namespace PortalAdvogado.Models
{
    public class Parte
    {
        public string nomeParte { get; set; }
        public string tipoParte { get; set; }
        public List<Advogado> listaAdvogados { get; set; }
    }
}
