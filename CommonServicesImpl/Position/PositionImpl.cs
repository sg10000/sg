using CommonServices;

namespace CommonServicesImpl.Position
{
    public class PositionImpl : IPosition
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Direction Facing { get; set; }
    }
}
