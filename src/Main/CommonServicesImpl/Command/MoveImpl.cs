using CommonServices;
using CommonServicesImpl.Position;

namespace CommonServicesImpl.Command
{
    public class MoveImpl : AbsCommand
    {
        #region Execute

        /// <summary>
        /// Move 1 step in face direction
        /// </summary>
        /// <param name="toy">The toy</param>
        /// <returns>The new position</returns>
        public override IPosition Execute(IToy toy)
        {
            int x = toy.X;
            int y = toy.Y;

            if (toy.Facing == Direction.NORTH)
            {
                y = y + 1;
            }
            else if (toy.Facing == Direction.SOUTH)
            {
                y = y - 1;
            }
            else if (toy.Facing == Direction.EAST)
            {
                x = x + 1;
            }
            else if (toy.Facing == Direction.WEST)
            {
                x = x - 1;
            }
            return new PositionImpl()
            {
                X = x,
                Y = y,
                Facing = toy.Facing
            };
        }

        #endregion
    }
}
