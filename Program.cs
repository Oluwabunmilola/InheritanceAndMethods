using System;

namespace CLASSWORK10_05_2021
{
    class Program
    {
        static void Main(string[] args)
        {
   // Create a class named 'Shape' with a method to print "This is shape". Then create two other classes 
  //named 'Rectangle', 'Circle' inheriting the Shape class, both having a method to print "This is rectangular shape" 
 //and "This is circular shape" respectively. Create a subclass 'Square' of 'Rectangle' having a method to print "Square is a rectangle".   //Now call the method of 'Shape' and 'Rectangle' class by the object of 'Square' class./ Create a class named 'Shape' with a method to print "This is shape". Then create two other classes 
//named 'Rectangle', 'Circle' inheriting the Shape class, both having a method to print "This is rectangular shape"   //and "This is circular shape" respectively. Create a subclass 'Square' of 'Rectangle' having a method to print "Square is a rectangle". 
  //Now call the method of 'Shape' and 'Rectangle' class by the object of 'Square' class.
        Square callSquare=new Square();
        callSquare._Shape();
        callSquare._Rectangle();
        }

    }
}
