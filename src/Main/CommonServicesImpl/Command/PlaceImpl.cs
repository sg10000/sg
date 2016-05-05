using System;
using CommonServices;
using CommonServicesImpl.Position;

namespace CommonServicesImpl.Command
{
    public class PlaceImpl : AbsCommand
    {
        #region Constructor
        private IPosition pos = null;

        public PlaceImpl(int x, int y, Direction d)
        {
            pos = new PositionImpl()
            {
                X = x,
                Y = y,
                Facing = d
            };
        } 
        #endregion

        #region Execute

        /// <summary>
        /// Set position
        /// </summary>
        /// <param name="toy">The toy</param>
        /// <returns>Set the new position</returns>
        public override IPosition Execute(IToy toy)
        {
            // Do nothing on toy
            // return the position set in constructor
            return pos;
        }

        #endregion
    }
}
