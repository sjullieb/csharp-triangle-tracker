using System;

namespace TriangleTracker
{
  class Triangle
  {
    private int FirstSide;
    private int SecondSide;
    private int ThirdSide;

    public Triangle(int firstSide, int secondSide, int thirdSide)
    {
      FirstSide = firstSide;
      SecondSide = secondSide;
      ThirdSide = thirdSide;
    }

    public string GetTriangleType()
    {
      if ((FirstSide + SecondSide <= ThirdSide) || (SecondSide + ThirdSide <= FirstSide) || (FirstSide + ThirdSide <= SecondSide))
      {
        return "It's not a triangle";
      }
      else if ((FirstSide == SecondSide) && (FirstSide == ThirdSide))
      {
        return "This is an equilateral triangle, all sides are the same length.";
      }
      else if ((FirstSide == SecondSide) || (FirstSide == ThirdSide) || (ThirdSide == SecondSide))
      {
        return "This is an isosceles triangle, two sides have the same length.";
      }
      else
      {
        return "This is a scalene triangle. All sides have different length.";
      }
    }
  }

}
