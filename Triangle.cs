using System;


class Triangle
{
   public static void IsThisTriangle(int sideOne, int sideTwo, int sideThree)
   {
        int tempOne = sideOne;
        int tempTwo = sideTwo;
        int tempThree = sideThree;

        if (tempOne == tempTwo && tempTwo == tempThree)
        {
            Console.WriteLine("That is an Equilateral Triangle");
        } 
        else if (tempOne == tempTwo || tempTwo == tempThree || tempOne == tempThree)
        {
            Console.WriteLine("That is an Isosceles Triangle");
        }
        else if (tempOne + tempTwo <= tempThree || tempOne + tempThree <= tempTwo || tempTwo + tempThree <= tempOne)
        {
            Console.WriteLine("That is not a Triangle");
        }
        else if (tempOne != tempTwo && tempTwo != tempThree && tempOne != tempThree)
        {
            Console.WriteLine("That is a Scalene Triangle");
        }
   }


   public static void Main()
    {
        Console.WriteLine("Enter Three Numbers to see what kind of Triangle they would make.");
        int sideOne = int.Parse(Console.ReadLine());
        int sideTwo = int.Parse(Console.ReadLine());
        int sideThree = int.Parse(Console.ReadLine());
        IsThisTriangle(sideOne, sideTwo, sideThree);
    }
}
