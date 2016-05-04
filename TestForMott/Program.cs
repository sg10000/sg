using System;
using System.Collections.Generic;
using CommonServices;
using CommonServicesImpl.GameRule;
using CommonServicesImpl.BoardRule;
using CommonServicesImpl.Toy;
using CommonServicesImpl.Util;
using CommonServicesImpl.Command;
using CommonServicesImpl.Board;

namespace TestForMott
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameFactory factory = new GameFactory();
            factory.StartGame();
            Console.ReadLine();
        }
    }
}
