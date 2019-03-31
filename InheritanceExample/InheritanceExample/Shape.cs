using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    abstract class Shape
    {
        //data members
        public string Color { get; set; }
        public decimal Area { get; set; }

        //constructors
        public Shape()
        {
            this.Color = "black";
            this.Area = 0;
        }

        public Shape(string color)
        {
            this.Color = color;
        }

        public Shape(string c, int a)
        {
            Color = c;
            Area = a;
        }

        //methods
        public virtual void Display()
        {
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Area: {0}", Area);
        }

        public abstract void ComputeArea();

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
}
