using System;
using CommonServices;
using CommonServicesImpl.Util;

namespace CommonServicesImpl.Command
{
    public abstract class AbsCommand : ICommand
    {
        #region ICommand Members

        public virtual IPosition Execute(IToy toy)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region TurnLeft
        /// <summary>
        /// Utilizes RotationUtil class - turn left
        /// </summary>
        /// <param name="d">The current direction</param>
        /// <returns>Return new direction</returns>
        protected Direction TurnLeft(Direction d)
        {
            return RotationUtil.RotateLeft(d);
        }
        #endregion

        #region TurnRight
        /// <summary>
        /// Utilizes RotationUtil class - turn right
        /// </summary>
        /// <param name="d">The current direction</param>
        /// <returns>Return new direction</returns>
        protected Direction TurnRight(Direction d)
        {
            return RotationUtil.RotateRight(d);
        }
        #endregion
    }
}
