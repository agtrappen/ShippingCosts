using System;
using System.Collections.Generic;
using System.Text;

namespace DetermineShippingCosts
{
    public class Shipping
    {
        public double ShippingCosts(bool calculateShippingConsts, string typeOfShippingCosts, double totalprice)
        {
            double result = 0;

            if(calculateShippingConsts == true)
            {
                if(totalprice > 1500)
                {
                    result = 0;
                }
                else
                {
                    switch (typeOfShippingCosts)
                    {
                        case "Ground":
                            result = 100;
                            break;
                        case "InStore":
                            result = 50;
                            break;
                        case "NextDayAir":
                            result = 250;
                            break;
                        case "SecondayDayAir":
                            result = 125;
                            break;
                        default:
                            result = 0;
                            break;
                    }
                }
            }
            else 
            {
                result = 0;
            }

            return result;
        }
    }
}
