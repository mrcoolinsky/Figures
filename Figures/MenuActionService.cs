using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class MenuActionService
    {
        private List<MenuAction> menuActions = new();
        
        public void AddNewAction(int id, string name)
        {
            MenuAction menuAction = new MenuAction() { Id = id, Name = name };
            menuActions.Add(menuAction);
        }

        public List<MenuAction> GetAllMenuActions()
        {
            List <MenuAction> result = new List<MenuAction> ();

            foreach(var menuAction in menuActions)
            {
              result.Add(menuAction);
            }
            return menuActions;
        }
       
    }

}
