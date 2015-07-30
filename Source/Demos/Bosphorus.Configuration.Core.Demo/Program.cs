using System;
using Bosphorus.BootStapper.Common;
using Bosphorus.BootStapper.Program;
using Bosphorus.BootStapper.Runner.Console;
using Environment = Bosphorus.BootStapper.Common.Environment;

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
            Console.WriteLine(value1);

            string value2 = programConfiguration.Key2;
            Console.WriteLine(value2);
        }
    }
}

