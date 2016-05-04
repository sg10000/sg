
namespace CommonServices
{
    public interface IToy
    {
        #region X Position
        /// <summary>
        /// Represents current X position of toy robot
        /// </summary>
        int X { get; set; }
        #endregion

        #region Y Position
        /// <summary>
        /// Represents current Y position of toy robot
        /// </summary>
        int Y { get; set; }
        #endregion

        #region Facing
        /// <summary>
        /// Represents current facing direction of toy robot
        /// </summary>
        Direction Facing { get; set; }
        #endregion

        #region UpdateToNewPosition
        /// <summary>
        /// Update toy X, Y and Direction
        /// </summary>
        /// <param name="pos"></param>
        void UpdateToNewPosition(IPosition pos); 
        #endregion

        #region CurrentPositionInfo
        /// <summary>
        /// Get string rpresentation of the position
        /// </summary>
        /// <returns>The description of current position and face direction</returns>
        string CurrentPositionInfo(); 
        #endregion
    }
}
