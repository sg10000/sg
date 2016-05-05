using CommonServices;
using CommonServicesImpl.Position;

namespace CommonServicesImpl.Command
{
    public class InvalidCommandImpl : AbsCommand
    {
        #region Execute
        /// <summary>
        /// Return invalid x and y position
        /// </summary>
        /// <param name="toy">The toy</param>
        /// <returns>The new position</returns>
        public override IPosition Execute(IToy toy)
        {
            return new PositionImpl()
            {
                X = -1,
                Y = -1,
                Facing = Direction.NORTH
            };
        }
        #endregion
    }
}
