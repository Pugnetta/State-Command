using QuizStateMachineClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizStateMachineClassLibrary.Command
{
    public class InfoCommand : ICommand
    {
        private readonly Dictionary<string, string> _commands = new Dictionary<string, string>()
        {
            {"[Info]", "Gets you all the infos u need" },
            {"[Back]", "Goes back to the Main Menu" }
        };

        public void Execute()
        {
            Console.WriteLine("============================");           
            Console.WriteLine("Use the words marked by the squere brakets [] to navigate through the game :)) ");
            Console.WriteLine("Here's a list of general commands:");
           foreach (var info in _commands)
            {
                Console.WriteLine($"{info.Key}: {info.Value}");
            }
            Console.WriteLine("Press Any Key to continue");
            Console.WriteLine("============================");
            Console.ReadKey();
        }
    }
}
