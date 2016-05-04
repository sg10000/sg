using System.Collections.Generic;

namespace TestForMott
{
    public class TestInputCommand
    {
        public List<string> Command_A()
        {
            List<string> c = new List<string>();
            c.Add("PLACE 0,0,NORTH");
            c.Add("MOVE");
            c.Add("REPORT");
            return c;
        }

        public List<string> Command_B()
        {
            List<string> c = new List<string>();
            c.Add("PLACE 0,0,NORTH");
            c.Add("LEFT");
            c.Add("REPORT");
            return c;
        }

        public List<string> Command_C()
        {
            List<string> c = new List<string>();
            c.Add("PLACE 1,2,EAST");
            c.Add("MOVE");
            c.Add("MOVE");
            c.Add("LEFT");
            c.Add("MOVE");
            c.Add("REPORT");
            return c;
        }






        public List<string> Command_01()
        {
            List<string> c = new List<string>();
            c.Add("MOVE");
            c.Add("PLACE 3,4,EAST");
            c.Add("MOVE");
            c.Add("MOVE");
            c.Add("LEFT");
            c.Add("LEFT");
            c.Add("LEFT");
            c.Add("MOVE");
            c.Add("MOVE");
            c.Add("MOVE");
            c.Add("RIGHT");
            c.Add("REPORT");
            return c;
        }
    }
}



/*
a)
PLACE 0,0,NORTH 
MOVE 
REPORT 

Output: 0,1,NORTH

b)
PLACE 0,0,NORTH 
LEFT 
REPORT 

Output: 0,0,WEST

c)
PLACE 1,2,EAST 
MOVE 
MOVE 
LEFT 
MOVE 
REPORT

Output: 3,3,NORTH

*/