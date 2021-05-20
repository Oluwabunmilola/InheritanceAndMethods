using System;

namespace CLASSWORK10_05_2021
{
    public class Shape 
    {
      public void _Shape()
{
Console.WriteLine("This is a shape parent class");
}

    }
    public class Rectangle: Shape 
    {
public void _Rectangle()
{

Console.WriteLine("This is a rectangle child class");
}
    }
    public class Circle : Shape
    {
public void _Circle()
{

Console.WriteLine("This is a circle child class");
}
    }
    public class Square : Rectangle
    {
public void _Square()
{

Console.WriteLine("This is a subclass for square class");
}
    }
}