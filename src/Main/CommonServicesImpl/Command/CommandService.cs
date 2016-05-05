using System;
using CommonServices;
using CommonServicesImpl.Command;

namespace CommonServicesImpl.Command
{
    public class CommandService
    {
        private static readonly char[] delimiterChars = { ' ', ',' };

        public static ICommand Execute(string cmd, bool caseSensitiveCommand)
        {
            if (string.IsNullOrWhiteSpace(cmd))
            {
                return new InvalidCommandImpl();
            }

            string[] words = cmd.Trim().Split(delimiterChars);

            if (words.Length == 1)
            {
                // Can only be : LEFT, MOVE, REPORT, RIGHT
                string command = caseSensitiveCommand == true ? words[0] : words[0].ToUpper();
                if (command == "LEFT")
                {
                    return new LeftImpl();
                }
                if (command == "MOVE")
                {
                    return new MoveImpl();
                }
                if (command == "RIGHT")
                {
                    return new RightImpl();
                }
                if (command == "REPORT")
                {
                    return new ReportImpl();
                }
            }
            else if (words.Length == 4)
            {
                // Can only be : PLACE X Y Direction
                string command = caseSensitiveCommand == true ? words[0] : words[0].ToUpper();
                int x = -1;
                int y = -1;
                if (command == "PLACE")
                {
                    try
                    {
                        // Get X 
                        x = int.Parse(words[1]);

                        // Get Y
                        y = int.Parse(words[2]);

                        string direction = caseSensitiveCommand == true ? words[3] : words[3].ToUpper();
                        if (direction == "NORTH")
                        {
                            return new PlaceImpl(x, y, Direction.NORTH);
                        }
                        if (direction == "EAST")
                        {
                            return new PlaceImpl(x, y, Direction.EAST);
                        }
                        if (direction == "SOUTH")
                        {
                            return new PlaceImpl(x, y, Direction.SOUTH);
                        }
                        if (direction == "WEST")
                        {
                            return new PlaceImpl(x, y, Direction.WEST);
                        }

                    }
                    catch (Exception ex)
                    {
                        // do nothing - will return invalidcommandimpl below                        
                    }
                }
            }

            // Invalid command
            return new InvalidCommandImpl();
        }
    }
}
