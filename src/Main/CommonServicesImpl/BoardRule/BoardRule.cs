using System;
using CommonServices;

namespace CommonServicesImpl.BoardRule
{
    public class BoardRule : IBoardRule
    {
        #region IBoardRule Members

        public bool IsValidPosition(IPosition pos, IBoard board, out string error_msg)
        {
            error_msg = string.Empty;
            if (pos.X < 0)
            {
                error_msg = "X position cannot be less than 0";
                return false;
            }
            if (pos.X > board.MaximumXPosition)
            {
                error_msg = string.Format("X position cannot be more than {0}", board.MaximumXPosition);
                return false;
            }
            if (pos.Y < 0)
            {
                error_msg = "Y position cannot be less than 0";
                return false;
            }
            if (pos.Y > board.MaximumYPosition)
            {
                error_msg = string.Format("Y position cannot be more than {0}", board.MaximumYPosition);
                return false;
            }
            return true;
        }

        #endregion
    }
}
