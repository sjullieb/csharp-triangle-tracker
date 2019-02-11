using System;

namespace Trangles
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Let's check if you can make a triangle. Enter the lengths of the sides.");

      Console.WriteLine("length of the 1st side:");
      int firstSide = int.Parse(Console.ReadLine());
      Console.WriteLine("length of the 2nd side:");
      int secondSide = int.Parse(Console.ReadLine());
      Console.WriteLine("length of the 3rd side:");
      int thirdSide = int.Parse(Console.ReadLine());

      Traingle inputTriangle = new Triangle(firstSide, secondSide, thirdSide);

      inputTriangle.GetType();

    }
  }
}
