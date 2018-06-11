using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalAdvogado.Views
{

    public class MenuViewMenuItem
    {
        public MenuViewMenuItem()
        {
            TargetType = typeof(MenuViewDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}