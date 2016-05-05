using System.Collections.Generic;
using System.Linq;
using CommonServices;

namespace CommonServicesImpl.Util
{
    public static class RotationUtil
    {
        private readonly static List<Direction> list = new List<Direction>();

        static RotationUtil()
        {
            list.Add(Direction.NORTH);
            list.Add(Direction.EAST);
            list.Add(Direction.SOUTH);
            list.Add(Direction.WEST);
        }

        public static Direction RotateLeft(Direction d)
        {
            int currentIndexPos = list.IndexOf(d);
            int newIndexPos = currentIndexPos - 1;
            if (newIndexPos == -1)
            {
                newIndexPos = list.Count - 1;
            }
            return list.ElementAt(newIndexPos);
        }

        public static Direction RotateRight(Direction d)
        {
            int currentIndexPos = list.IndexOf(d);
            int newIndexPos = currentIndexPos + 1;
            if (newIndexPos == list.Count)
            {
                newIndexPos = 0;
            }
            return list.ElementAt(newIndexPos);
        }
    }
}
