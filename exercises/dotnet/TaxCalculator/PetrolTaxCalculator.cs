﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class PetrolTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            int emissions = vehicle.Co2Emissions;
            FuelType fuelType = vehicle.FuelType;

            TimeSpan timeSinceFirstRegistration = DateTime.Now - vehicle.DateOfFirstRegistration;
            TimeSpan oneYear = new TimeSpan(365, 0, 0, 0, 0);

            if (EnableStory4)
            {
                if (timeSinceFirstRegistration > oneYear)
                {
                    switch (fuelType)
                    {
                        case FuelType.Petrol:
                        case FuelType.Diesel:
                            return 140;
                        case FuelType.AlternativeFuel:
                            return 130;
                        default:
                        case FuelType.Electric:
                            return 0;
                    }
                }
            }

            if (fuelType == FuelType.Petrol)
            {
                if (emissions < 1)
                {
                    return 0;
                }
                else if (emissions < 51)
                {
                    return 10;
                }
                else if (emissions < 76)
                {
                    return 25;
                }
                else if (emissions < 91)
                {
                    return 105;
                }
                else if (emissions < 101)
                {
                    return 125;
                }
                else if (emissions < 111)
                {
                    return 145;
                }
                else if (emissions < 131)
                {
                    return 165;
                }
                else if (emissions < 151)
                {
                    return 205;
                }
                else if (emissions < 171)
                {
                    return 515;
                }
                else if (emissions < 191)
                {
                    return 830;
                }
                else if (emissions < 226)
                {
                    return 1240;
                }
                else if (emissions < 256)
                {
                    return 1760;
                }
                else
                {
                    return 2070;
                }
            }
            else if (fuelType == FuelType.Diesel)
            {
                if (emissions < 1)
                {
                    return 0;
                }
                else if (emissions < 51)
                {
                    return 25;
                }
                else if (emissions < 76)
                {
                    return 105;
                }
                else if (emissions < 91)
                {
                    return 125;
                }
                else if (emissions < 101)
                {
                    return 145;
                }
                else if (emissions < 111)
                {
                    return 165;
                }
                else if (emissions < 131)
                {
                    return 205;
                }
                else if (emissions < 151)
                {
                    return 515;
                }
                else if (emissions < 171)
                {
                    return 830;
                }
                else if (emissions < 191)
                {
                    return 1240;
                }
                else if (emissions < 226)
                {
                    return 1760;
                }
                else if (emissions < 256)
                {
                    return 2070;
                }
                else
                {
                    return 2070;
                }

            }
            else if (vehicle.FuelType == FuelType.AlternativeFuel)
            {
                if (emissions < 1)
                {
                    return 0;
                }
                else if (emissions < 51)
                {
                    return 0;
                }
                else if (emissions < 76)
                {
                    return 15;
                }
                else if (emissions < 91)
                {
                    return 95;
                }
                else if (emissions < 101)
                {
                    return 115;
                }
                else if (emissions < 111)
                {
                    return 135;
                }
                else if (emissions < 131)
                {
                    return 155;
                }
                else if (emissions < 151)
                {
                    return 195;
                }
                else if (emissions < 171)
                {
                    return 505;
                }
                else if (emissions < 191)
                {
                    return 820;
                }
                else if (emissions < 226)
                {
                    return 1230;
                }
                else if (emissions < 256)
                {
                    return 1750;
                }
                else
                {
                    return 2060;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
