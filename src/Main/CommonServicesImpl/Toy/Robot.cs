using System;
using CommonServices;

namespace CommonServicesImpl.Toy
{
    public class Robot : IToy
    {
        #region X Position
        /// <summary>
        /// Represents current X position of toy robot
        /// </summary>
        public int X { get; set; }
        #endregion

        #region Y Position
        /// <summary>
        /// Represents current Y position of toy robot
        /// </summary>
        public int Y { get; set; }
        #endregion

        #region Facing
        /// <summary>
        /// Represents current facing direction of toy robot
        /// </summary>
        public Direction Facing { get; set; }
        #endregion

        #region UpdateToNewPosition
        /// <summary>
        /// Updating position of toy
        /// </summary>
        /// <param name="pos">The new position</param>
        public void UpdateToNewPosition(IPosition pos)
        {
            X = pos.X;
            Y = pos.Y;
            Facing = pos.Facing;
        } 
        #endregion

        #region CurrentPositionInfo
        /// <summary>
        /// Get string rpresentation of the position
        /// </summary>
        /// <returns>The description of current position and face direction</returns>
        public string CurrentPositionInfo()
        {
            return string.Format("Output: {0},{1},{2}", X, Y, Facing.ToString());
        }
        #endregion
    }
}
