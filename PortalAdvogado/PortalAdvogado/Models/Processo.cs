using System;
using System.Collections.Generic;
using System.Text;

namespace PortalAdvogado.Models
{
    public class Processo
    {
        public string numeroProcessoTJSE { get; set; }
        public string numeroUnico { get; set; }
        public string autor { get; set; }
        public string reu { get; set; }
        public string assunto { get; set; }
        public string dataDistribuicao { get; set; }
        public string localizacao { get; set; }
    }
}
