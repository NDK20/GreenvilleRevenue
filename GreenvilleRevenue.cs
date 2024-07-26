using System;

namespace GreenvilleRevenue 
{
  class Program {
    public static void Main (string[] args) {
      DisplayMotto();
      DisplayMenu();
    }
    public static void DisplayMotto()
    {
      Console.WriteLine("************************************************");
      Console.WriteLine("*  The stars shine in Greenville.  *");
      Console.WriteLine("************************************************");
    }
    public static void DisplayMenu()
    {
      while (true)
      {
        Console.WriteLine("\nPlease Enter the following number below from the following menu:");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");

        string userInput = Console.ReadLine();
        if (userInput == "1")
        {
          CalculateRevenue();
        }
        else if (userInput == "2")
        {
          ExitProgram();
          break;
        }
        else
        {
          Console.WriteLine("Invalid Input");
        }
      }
    }
    public static void CalculateRevenue()
    {
      Console.WriteLine("Enter the number of contestants last year: ");
      int lastYear = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the number of contestants this year: ");
      int thisYear = Convert.ToInt32(Console.ReadLine());

      int revenue = thisYear * 25;
      bool isBigEvent = thisYear >= lastYear;

      Console.WriteLine($"\nLast year's competition had {lastYear} contestants, and this year's has {thisYear}");
      Console.WriteLine($"Revenue expected this year is {revenue}.");
      Console.WriteLine($"\nIt is {isBigEvent} that this year's competition is the biggest.");
    }
    static void ExitProgram()
    {
      Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
    }
  }
}
