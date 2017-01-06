using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_Console_Application
{
    public class UserInput
    {
        #region Methods

        public ICommand GetUserCommand(AllCommands commands)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
                return commands.Print;
            else if (key.Key == ConsoleKey.Escape)
                return commands.QuitApplication;
            return null;

        }

        public string GetUserString()
        {
            string userString = Console.ReadLine();
            return userString;
        }

        #endregion "Methods"
    }
}
