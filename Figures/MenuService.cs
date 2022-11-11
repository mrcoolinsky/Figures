using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class MenuService
    {
        public List<Menu> MyMenu { get; set; }
        public List<Menu> GetMenu()
        {
            return MyMenu;
        }

    }

}
