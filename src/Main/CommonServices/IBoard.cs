using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonServices
{
    public interface IBoard
    {
        #region MaximumXPosition
        /// <summary>
        /// Represents the max X value on the board that is permitted to move to (ie from 0)
        /// </summary>
        int MaximumXPosition { get; set; }
        #endregion

        #region MaximumYPosition
        /// <summary>
        /// Represents the max Y value on the board that is permitted to move to (ie from 0)
        /// </summary>
        int MaximumYPosition { get; set; }
        #endregion
    }
}
