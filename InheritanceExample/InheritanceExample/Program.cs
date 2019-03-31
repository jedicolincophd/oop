using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] sh = new Shape[4];
            sh[0] = new Rectangle("red", 10, 5);
            sh[1] = new Square(3,"yellow");
            sh[2] = new Square(8,"blue");
            sh[3] = new Rectangle("green", 5, 2);

            foreach (Shape s in sh)
            {
                s.ComputeArea();
                s.Draw();
                s.Display();
                Console.WriteLine("---------");
            }
            Console.ReadKey();
        }
    }
}
