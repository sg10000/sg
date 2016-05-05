using System.Collections.Generic;
using CommonServices;
using CommonServicesImpl.BoardRule;
using CommonServicesImpl.Command;
using CommonServicesImpl.Util;

namespace TestForMott
{
    public class EventFactoryGenerator
    {

        public List<ICommand> GetCommands(List<string> inputs, bool caseSensitive)
        {
            List<ICommand> commands = new List<ICommand>();
            foreach (var item in inputs)
            {
                ICommand c = CommandService.Execute(item, caseSensitive);
                commands.Add(c);
            }
            return commands;
        }
    }
}
