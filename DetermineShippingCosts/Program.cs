using System;

namespace DetermineShippingCosts
{
    public class Program
    {
        static void Main(string[] args)
        {
            // instantiate Shipping class
            Shipping ship = new Shipping();

            // Run all branches
            CalculateCosts(0, 150, "Ground", true, ship);
            CalculateCosts(0, 150, "Ground", false, ship);
            CalculateCosts(0, 15000, "Ground", true, ship);
            CalculateCosts(0, 150, "InStore", true, ship);
            CalculateCosts(0, 150, "NextDayAir", true, ship);
            CalculateCosts(0, 150, "SecondayDayAir", true, ship);
            CalculateCosts(0, 150, "FakeMethod", true, ship);
        }

        static void CalculateCosts(double totalPrice,
                                    double orderPrice,
                                    string orderType,
                                    bool payForShipping,
                                    Shipping ship)
        {
            totalPrice = ship.ShippingCosts(payForShipping, orderType, orderPrice);
            totalPrice += orderPrice;

            Console.WriteLine("Total costs for shipping with " + orderType + " is: " + totalPrice);
        }
    }
}
