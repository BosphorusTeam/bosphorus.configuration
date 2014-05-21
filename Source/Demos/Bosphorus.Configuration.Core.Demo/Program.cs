using System;
using Bosphorus.Container.Castle.Facade;

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
            WindowsRunner.Run<Program>(args);
        }

        public void Run(string[] args)
        {
            string value1 = programConfiguration.Key1;
            Console.WriteLine(value1);
        }
    }
}

