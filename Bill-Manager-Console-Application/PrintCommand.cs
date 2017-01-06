namespace Bill_Manager_Console_Application
{
    public class PrintCommand : ICommand
    {
        private ConsoleOutput consoleOutput;
        private string outputData = "Print Command";

        public PrintCommand(ConsoleOutput output)
        {
            consoleOutput = output;
        }

        public void Execute()
        {
            consoleOutput.Print(outputData);
        }
    }
}
