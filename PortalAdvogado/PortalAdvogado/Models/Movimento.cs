using System;
using System.Collections.Generic;
using System.Text;

namespace PortalAdvogado.Models
{
    public class Movimento
    {
        public int codMovimento { get; set; }
        public string descMovimento { get; set; }
        public DateTime dataMovimento { get; set; }
        public List<Documento> listaDocumentos { get; set; }
    }
}
