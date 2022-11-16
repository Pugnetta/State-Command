using QuizStateMachineClassLibrary.Abstract;
using QuizStateMachineClassLibrary.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizStateMachineClassLibrary.State
{
    public class QuizStateCane : IState
    {
        private StateManager _manager;
        private IState _lastState;
        public QuizStateCane(StateManager manager, IState lastState)
        {
            _manager = manager;
            _lastState = lastState;
        }

        public ICommand GetCommand()
        {
            var command = Console.ReadLine().ToLower();
            switch (command)
            {
                case "back":
                    return new SwitchStateCommand(_manager, _lastState);
                case "info":
                    return new InfoCommand();
                default:
                    return new InvalidCommand();
            }
        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine("Quiz Cane da implementare ancora :)");
           
        }
    }
}
