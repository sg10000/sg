using System;
using CommonServices;

namespace CommonServicesImpl.Board
{
    public class BoardImpl : IBoard
    {
        #region BoardImpl Constructor
        public BoardImpl(int maximumX, int maximumY)
        {
            if (maximumX < 0)
            {
                throw new ArgumentException("X cannot be less than 0");
            }
            if (maximumY < 0)
            {
                throw new ArgumentException("Y cannot be less than 0");
            }

            MaximumXPosition = maximumX;
            MaximumYPosition = maximumY;
        }
        #endregion

        #region IBoard Members

        public int MaximumXPosition { get; set; }

        public int MaximumYPosition { get; set; }

        #endregion
    }
}
