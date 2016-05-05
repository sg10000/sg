
namespace CommonServices
{
    public interface ICommand
    {
        #region Execute
        /// <summary>
        /// Get new position
        /// </summary>
        /// <param name="toy">The toy object</param>
        /// <returns>The new position following execution of the command</returns>
        IPosition Execute(IToy toy); 
        #endregion
    }
}
