using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_Console_Application
{
    public class AllCommands
    {
        public PrintCommand Print;
        public QuitApplicationCommand QuitApplication;

        public AllCommands(ConsoleOutput output, App app)
        {
            Print = new PrintCommand(output);
            QuitApplication = new QuitApplicationCommand(app);
        }
    }
}
