using QuizStateMachineClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizStateMachineClassLibrary.Command
{
    public class InvalidCommand: ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Invalid Command :)");
            Console.WriteLine("Press Any Key to continue");
            Console.ReadKey();
        }

       
    }
}
