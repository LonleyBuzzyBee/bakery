using System;
using System.Linq;
using System.Collections.Generic;
using BakeryContents.Models;


namespace TheBakery
{
  public class Program
  {
    public static void Main()
    {
      Bread breadModel1 = new Bread("Baguette", 3, 1);
      Bread breadModel2 = new Bread("Sourdough", 4, 1);
      Pastry pastryModel = new Pastry("Danish", 2,1);


      Console.WriteLine("Here are your options at our bakery!");
      Console.WriteLine(breadModel1.BreadType + " " + "Cost: $" + breadModel1.BreadCost);
      Console.WriteLine(breadModel2.BreadType + " " + "Cost: $" + breadModel2.BreadCost);
      Console.WriteLine("Bread deal: Buy 2 get 20% off!");
      Console.WriteLine(pastryModel.PastryType + " " + "Cost: $" + pastryModel.PastryCost);
      Console.WriteLine("Pastry deal: half off all orders!");
      Console.WriteLine("Which item would you like? Don't want anything, response Exit");
      string input = Console.ReadLine();
      string response = input.ToLower();
      System.Threading.Thread.Sleep(2000);
      if(response == "exit")
      {
        Console.WriteLine("Goodbye");
      }
      else if(!(response == "baguette" || response == "danish"|| response == "sourdough"))
      {
        Console.WriteLine("Sorry we're out of stock!");
      }
      else
      {

      while (response == "baguette" || response == "danish"|| response == "sourdough")
      {
        Console.WriteLine("You choose: " + response);
       

         if(response == "baguette")
        {
          Console.WriteLine("How many would you like?");
          string stringAmountB = Console.ReadLine();
          int amountB = int.Parse(stringAmountB);
          Bread bread = new Bread("Baguette", 3, amountB);
          Console.WriteLine("Your Total before deal: $" + bread.CostBeforeDeal());
          Console.WriteLine("Your total after deal: $" + bread.DealApplied());
          System.Threading.Thread.Sleep(2000);
          Main();
          break;
        }
          else if (response == "danish")
          {
            Console.WriteLine("How many would you like?");
            string stringAmountP = Console.ReadLine();
            int amountP = int.Parse(stringAmountP);
            Pastry pastry = new Pastry("Danish", 2, amountP);
            Console.WriteLine("Your Total before deal: $" + pastry.CostBeforeDeal());
            Console.WriteLine("Your total after deal: $" + pastry.DealApplied());
            Main();
            System.Threading.Thread.Sleep(2000);
            break;
      
          }
          else if (response == "sourdough")
          {
            Console.WriteLine("How many would you like?");
            string stringAmountP = Console.ReadLine();
            int amountP = int.Parse(stringAmountP);
            Bread bread = new Bread("Sourdough", 4, amountP);
            Console.WriteLine("Your Total before deal: $" + bread.CostBeforeDeal());
            Console.WriteLine("Your total after deal: $" + bread.DealApplied());
            System.Threading.Thread.Sleep(2000);
            Main();
            break;
          }
        
         System.Threading.Thread.Sleep(2000);
      }

  
      }

    }
  }
}