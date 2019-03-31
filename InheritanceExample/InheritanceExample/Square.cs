using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Square : Shape
    {
        public decimal Side { get; set; }

        public Square()
        {
            Side = 1;
        }

        public Square(decimal side, string color): base(color)
        {
            this.Side = side;
        }

        public override void Display()
        {
            Console.WriteLine("\nSquare information");
            base.Display();
            Console.WriteLine("Side: {0}", Side);
        }

        public override void ComputeArea()
        {
            Area = Side * Side;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}
