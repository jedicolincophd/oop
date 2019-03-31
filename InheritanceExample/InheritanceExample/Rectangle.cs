using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Rectangle : Shape
    {
        //data members
        public decimal Length { get; set; }

        public decimal Width { get; set; }

        //constructors
        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }

        public Rectangle(string color, decimal l, decimal w): base(color)
        {
            this.Length = l;
            this.Width = w;
        }

        //setters and getters


        //methods
        public override void Display()
        {
            Console.WriteLine("\nRectangle information: ");
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Width: {0}", Width);
        }

        public override void ComputeArea()
        {
            Area = Length * Width;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
