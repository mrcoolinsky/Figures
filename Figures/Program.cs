namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);

            var mainMenu = actionService.GetAllMenuActions();

            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{ mainMenu[i].Id}. {mainMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            switch(operation.KeyChar)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '6':
                    break;
                default:
                    Console.WriteLine("Action does not exist");
                    break;
            }

        }
        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Show all figures");
            actionService.AddNewAction(2, "Show figure");
            actionService.AddNewAction(3, "Delete figure");
            actionService.AddNewAction(4, "Add new figure");
            actionService.AddNewAction(5, "Reduce figure");
            actionService.AddNewAction(6, "Enlarge figure");

            return actionService;
        }
    }
}