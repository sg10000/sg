using System;
using CommonServices;
using CommonServicesImpl.Position;
using CommonServicesImpl.Util;

namespace CommonServicesImpl.Command
{
    public class LeftImpl : AbsCommand
    {
        #region Execute
        /// <summary>
        /// Rotate direction 90 degrees to left
        /// </summary>
        /// <param name="toy">The toy</param>
        /// <returns>The new position</returns>
        public override IPosition Execute(IToy toy)
        {
            return new PositionImpl()
            {
                X = toy.X,
                Y = toy.Y,
                Facing = TurnLeft(toy.Facing)
            };
        } 
        #endregion
    }
}
