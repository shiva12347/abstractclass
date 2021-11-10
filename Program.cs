using System;
namespace abstract_class
{
    public abstract class shape
    {
        public string Color { get; set; }
        public int Thickness { get; set; }


        public abstract void Draw();

    }
    public class Line : shape

    {
        public override void Draw()
        {
            Console.WriteLine("Draw Triangle");
        }

    }
    
    public class  Rectangle   :  shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draws Circle");
        }
    }



    class Program
    {
        static void Main()
        {
            shape shape1 = new Line { Color = "red", Thickness = 1 };
            shape shape2 = new Rectangle { Color = "blue", Thickness = 2 };
            shape1.Draw();
            shape2.Draw();
        }
    }

}