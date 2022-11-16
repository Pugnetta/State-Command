using QuizStateMachineClassLibrary.Abstract;
using QuizStateMachineClassLibrary.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizStateMachineClassLibrary.State
{
    public class MainMenuState : IState
    {
        private StateManager _manager;

        public MainMenuState(StateManager stateManager)
        {
            _manager = stateManager;
        }

        public ICommand GetCommand()
        {
            var command = Console.ReadLine().ToLower();
            switch (command)
            {
                case "cane":
                    return new SwitchStateCommand(_manager, new QuizStateCane(_manager, this));
                case "info":
                    return new InfoCommand();
                default:
                    return new InvalidCommand();
            }

        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the QuizGame. Please select the quiz u'd like to play!");
            Console.WriteLine("Quiz:[Cane]");
            Console.WriteLine("Quiz:[Gatto]");
            Console.WriteLine("\nType [Info] to get a command list and some guide lines!");
        }
    }
}
