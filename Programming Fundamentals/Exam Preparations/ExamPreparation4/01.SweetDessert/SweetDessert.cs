namespace _01.SweetDessert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    

    public class SweetDessert
    {
        public static void Main()
        {
            var moneyInPossession = double.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var priceOfBananas = double.Parse(Console.ReadLine());
            var priceOfEggs = double.Parse(Console.ReadLine());
            var priceOfBerriesPerKilo = double.Parse(Console.ReadLine());

            var portionOfDeserts = 6;
            var totalPortions = 0;

            if (numberOfGuests % 6 == 0)
            {
                totalPortions = numberOfGuests / portionOfDeserts;
            }
            else
            {

                totalPortions = (numberOfGuests / portionOfDeserts) + 1 ;
            }
            //1 portion = 2bananas , 4 eggs & 0.2 kilos beries

            var totalBananasNeeded = totalPortions * 2;
            var totalEggsNeeded = totalPortions * 4;
            var totalKilosBeriesNeeded = totalPortions / 5.0;

            var moneyNeededForBananas = totalBananasNeeded * priceOfBananas;
            var moneyNeededForEggs = totalEggsNeeded * priceOfEggs;
            var moneyNeededForBeries = totalKilosBeriesNeeded * priceOfBerriesPerKilo;

            var amountOfMoneyNeeded = moneyNeededForBananas + moneyNeededForEggs + moneyNeededForBeries;

            if (moneyInPossession >= amountOfMoneyNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {amountOfMoneyNeeded:F2}lv.");
            }
            else
            {
                var moneyLack = amountOfMoneyNeeded - moneyInPossession;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyLack:F2}lv more.");
            }
            
        }
    }
}
