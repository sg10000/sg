using System.Collections.Generic;

namespace CommonServices
{
    public interface IGameRule
    {
        #region GetCommandsToExecute
        /// <summary>
        /// Checks the input commands and rebuild only the commands to execute
        /// </summary>
        /// <param name="commands">Input commands</param>
        /// <returns>The commands to execute</returns>
        IList<ICommand> GetCommandsToExecute(List<ICommand> commands);  
        #endregion
    }
}
