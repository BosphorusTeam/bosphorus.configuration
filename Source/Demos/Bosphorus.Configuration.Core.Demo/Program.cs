using Bosphorus.BootStapper.Common;
using Bosphorus.BootStapper.Program;
using Bosphorus.BootStapper.Runner;

namespace Bosphorus.Configuration.Core.Demo
{
    public class Program: IProgram
    {
        private readonly ProgramConfiguration programConfiguration;

        public Program(ProgramConfiguration programConfiguration)
        {
            this.programConfiguration = programConfiguration;
        }

        static void Main(string[] args)
        {
            ConsoleRunner.Run<Program>(Environment.Local, Perspective.Debug, args);
        }

        public void Run(string[] args)
        {
            string value1 = programConfiguration.Key1;
            System.Console.WriteLine(value1);

            string value2 = programConfiguration.Key2;
            System.Console.WriteLine(value2);
        }
    }
}

