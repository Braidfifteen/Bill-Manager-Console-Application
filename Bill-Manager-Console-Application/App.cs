using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_Console_Application
{
    // Main Application Class
    // Controls how all of the classes work together
    public class App
    {
        #region Fields

        private bool appRunning = true;
        private UserInput userInput = new UserInput(); //Invoker
        private ConsoleOutput output = new ConsoleOutput(); //Reciever
        private AllCommands commands;

        #endregion "Fields"

        // Test Constructor
        public App()
        {
            commands = new AllCommands(output, this);
            mainLoop();
        }
        #region Methods


        public void Quit()
        {
            appRunning = false;
        }

        private void mainLoop()
        {
            while (appRunning)
            {
                ICommand command = userInput.GetUserCommand(commands);
                command.Execute();
            }
        }

        #endregion "Methods"
    }
}
