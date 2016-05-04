
namespace CommonServices
{
    public interface IBoardRule
    {
        #region IsValidPosition
        /// <summary>
        /// Validate new position to move to
        /// </summary>
        /// <param name="pos">The new position moving to</param>
        /// <param name="board"></param>
        /// <returns>False if new position not valid (cannot move to this position), True if valid</returns>
        bool IsValidPosition(IPosition pos, IBoard board, out string error_msg);
        #endregion
    }
}
