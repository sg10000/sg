using System;
using System.Collections.Generic;
using System.Configuration;
using CommonServices;
using CommonServicesImpl.Board;
using CommonServicesImpl.BoardRule;
using CommonServicesImpl.Command;
using CommonServicesImpl.GameRule;
using CommonServicesImpl.InputCommand;
using CommonServicesImpl.Toy;

namespace TestForMott
{
    public class GameFactory
    {
        public void StartGame()
        {
            string caseSensitiveCommands = ConfigurationManager.AppSettings["caseSensitiveCommands"];
            string commandFile = ConfigurationManager.AppSettings["commandFile"];
            bool caseSensitiveCommand = Convert.ToBoolean(caseSensitiveCommands);



            IToy toy = new Robot();
            IInputCommand inputCommands = new TextFileInputCommand(commandFile);
            IList<string> inputCommandString = inputCommands.GetInputCommands();
            IBoard board = new BoardImpl(4, 4); // Max x = 4(inclusive), max y = 4 (Inclusive) 
            IBoardRule boardRule = new BoardRule();
            IGameRule placeAsFirstCommandRule = new PlaceAsFirstCommandRule();
            List<ICommand> inputCommand = new List<ICommand>();
            foreach (var item in inputCommandString)
            {
                inputCommand.Add(CommandService.Execute(item, caseSensitiveCommand));
            }
            IList<ICommand> commandsToExecute = placeAsFirstCommandRule.GetCommandsToExecute(inputCommand);
            foreach (var cmd in commandsToExecute)
            {
                IPosition pos = cmd.Execute(toy);
                string error_msg = string.Empty;
                if (boardRule.IsValidPosition(pos, board, out error_msg) == true)
                {
                    toy.UpdateToNewPosition(pos);
                }
                else
                {
                    // The error_msg will give details
                    // No updates to toy position or facing direction
                }
            }
        }
    }
}
