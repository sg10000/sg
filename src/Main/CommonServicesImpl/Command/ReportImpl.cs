using System;
using CommonServices;
using CommonServicesImpl.Position;

namespace CommonServicesImpl.Command
{
    public class ReportImpl : AbsCommand
    {
        #region Execute
        /// <summary>
        /// Get current toy position without modification 
        /// </summary>
        /// <param name="toy">The toy</param>
        /// <returns>The position</returns>
        public override IPosition Execute(IToy toy)
        {
            IPosition pos =new PositionImpl()
            {
                X = toy.X,
                Y = toy.Y,
                Facing = toy.Facing
            };
            Console.WriteLine(toy.CurrentPositionInfo());
            return pos;
        } 
        #endregion
    }
}
