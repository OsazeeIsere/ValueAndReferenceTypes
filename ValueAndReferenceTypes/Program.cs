using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    struct Point
    {

        // fields of the structure
        public int x;
        public int y;

        // add 1 to the (x,y) position
        public void Increment()
        {
            x++; y++;
        }

        //subtract 1 from x and y position
        public void Decrement()
        {
            x--; y--;
        }

        //display the current position
        public void Display()
        {
            Console.WriteLine("X={0}, Y={1}", x, y);
            Console.WriteLine();
        }

        //a custom constructor
        public void CustomConstructor(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
        //Assigning two intrinsic value type results in 
        //two independent variables on the stack.
        static void ValueTypeAssignment()
        {

        }
    }
}
