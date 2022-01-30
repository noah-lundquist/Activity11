// See https://aka.ms/new-console-template for more information
using System;

public class Dice
{
    private int numberOfSides;

    
    private static Random rando = new Random();

    public Dice(int numberOfSides)
    {

        if (numberOfSides < 4 || numberOfSides > 20)
        {
            
        }

        this.numberOfSides = numberOfSides;
    }

    public int rollDie()
    {
        return rando.Next(1, numberOfSides + 1);
    }

}

public class DieTest
{
    public static void Main()
    {
        Dice d1 = new Dice(6);
        Dice d2 = new Dice(6);

        int d1Roll, d2Roll;
        int numberOfRolls = 0;

        do
        {

            d1Roll = d1.rollDie();
            d2Roll = d2.rollDie();

            Console.WriteLine("Rolled [Dice 1: " + d1Roll + ", Dice 2: " + d2Roll + "]");

            ++numberOfRolls;

        } while (d1Roll != 1 || d2Roll != 1);

        Console.WriteLine("\nIt took " + numberOfRolls + " rolls to get snake eyes!");
    }
}