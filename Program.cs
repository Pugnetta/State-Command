using QuizStateMachineClassLibrary.State;

StateManager x = new StateManager();
x.Run(new MainMenuState(x));