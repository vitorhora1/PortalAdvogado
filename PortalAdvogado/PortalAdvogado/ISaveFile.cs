using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PortalAdvogado
{
    public interface ISaveFile
    {
        Task<string> SaveFile(string filename, byte[] bytes);
    }
}
