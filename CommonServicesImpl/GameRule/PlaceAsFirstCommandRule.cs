using System;
using System.Collections.Generic;
using CommonServices;
using CommonServicesImpl.Command;

namespace CommonServicesImpl.GameRule
{
    public class PlaceAsFirstCommandRule : IGameRule
    {
        #region IGameRule Members

        public IList<ICommand> GetCommandsToExecute(List<ICommand> commands)
        {
            List<ICommand> result = new List<ICommand>();
            bool requiredPlaceCommandFound = false;
            for (int i = 0; i < commands.Count; i++)
            {
                ICommand cmd = commands[i];
                if (requiredPlaceCommandFound == false)
                {                    
                    Type t = cmd.GetType();
                    if (t == typeof(PlaceImpl))
                    {
                        requiredPlaceCommandFound = true;
                        result.Add(cmd);
                    }
                }
                else
                {
                    result.Add(cmd);
                }
            }
            return result;
        }

        #endregion
    }
}
