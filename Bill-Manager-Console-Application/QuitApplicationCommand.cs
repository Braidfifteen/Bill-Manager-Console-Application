using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_Console_Application
{
    public class QuitApplicationCommand : ICommand
    {
        private App app;

        public QuitApplicationCommand(App app)
        {
            this.app = app;
        }

        public void Execute()
        {
            app.Quit();
        }
    }
}
