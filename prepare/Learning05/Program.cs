using System;

class Program
{
    static void Main(string[] args)
    {
        Square cuadrado = new Square("blue", 4);
   

        Rectangle rectangulo = new Rectangle("green", 4, 6);
 

        Circle circulo = new Circle("red", 2);
 
        List<Shape> ShapeList = new List<Shape>();

        ShapeList.Add(cuadrado);
        ShapeList.Add(rectangulo);
        ShapeList.Add(circulo);

        foreach (Shape forma in ShapeList)
        {
            Console.WriteLine($"The shape is {forma.GetColor()} and the area is {forma.GetArea()}.");
        }
    }
}