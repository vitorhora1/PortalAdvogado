using System;
using System.Collections.Generic;
using System.Text;

namespace PortalAdvogado.Models
{
    public class Documento
    {
        public string idDocumento { get; set; }
        public string tipoDocumento { get; set; }
        public string nomeDocumento { get; set; }
        public byte[] conteudoDocumento { get; set; }
        public string descDocumentoFormatado
        {
            get
            {
                return string.Format("({0}) {1}", tipoDocumento, nomeDocumento);
            }
        }
    }
}
