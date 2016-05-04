using System.Collections.Generic;

namespace CommonServices
{
    public interface IInputCommand
    {
        #region GetInputCommands
        /// <summary>
        /// Extract the commands from user input
        /// </summary>
        /// <returns>A list of commands from user</returns>
        IList<string> GetInputCommands(); 
        #endregion
    }
}
