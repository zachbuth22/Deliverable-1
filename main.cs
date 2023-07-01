using System;

public class Program {
  public static void Main (string[] args) {

    int instockSodas = 100;
    int instockChips = 40;
    int instockCandy = 60;

    int restockSodas = 40;
    int restockChips = 20;
    int restockCandy = 40;

    Console.WriteLine("Welcome to the Restocking Tool");

    Console.WriteLine("How may sodas have been sold today? 100 are in stock");
    int purchasedSodas = int.Parse(Console.ReadLine());
    int remainingSodas = instockSodas - purchasedSodas;

    if (purchasedSodas > instockSodas)
    {
    Console.WriteLine("That value is too high." + " Stock not adjusted.");
    }  
    if (purchasedSodas <= instockSodas)
    {
    Console.WriteLine("There are " +remainingSodas + " sodas left.");
    }

    Console.WriteLine("How many chips have been sold today? 40 are in stock");
    int purchasedChips = int.Parse(Console.ReadLine());
    int remainingChips = instockChips - purchasedChips;

    if (purchasedChips > instockChips)
    {
    Console.WriteLine("That value is too high." + " Stock not adjusted.");
    }  
    if (purchasedChips <= instockChips)
    {
    Console.WriteLine("There are " +remainingChips + " chips left.");
    }

    Console.WriteLine("How much candy has been sold today? 60 are in stock");
    int purchasedCandy = int.Parse(Console.ReadLine());
    int remainingCandy= instockCandy - purchasedCandy;

    if (purchasedCandy > instockCandy)
    {
    Console.WriteLine("That value is too high." + " Stock not adjusted.");
    }  
    if (purchasedCandy <= instockCandy)
    {
    Console.WriteLine("There are " +remainingCandy + " candy left.");
    }
    
    Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked:");

        if (remainingSodas <= restockSodas)
    {
      Console.WriteLine("Sodas need to be restocked.");
    } 

        if (remainingChips <= restockChips)
    {
      Console.WriteLine("Chips need to be restocked.");
    } 

        if (remainingCandy <= restockCandy)
    {
      Console.WriteLine("Candy needs to be restocked.");
    } 

    Console.WriteLine("Goodbye!");

    }
  }