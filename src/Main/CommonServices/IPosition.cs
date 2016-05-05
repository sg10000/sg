
namespace CommonServices
{
    public interface IPosition
    {
        #region Properties
        /// <summary>
        /// X position
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// Y Position
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Facing direction
        /// </summary>
        Direction Facing { get; set; } 
        #endregion
    }
}
