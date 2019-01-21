using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class PetrolTaxCalculator : TaxCalculator
    {
        public bool story5;
        public PetrolTaxCalculator(bool story5)
        {
            this.story5 = story5;
        }
        private int CheckAdditionalTaxForExpensiveVehicles(Vehicle vehicle)
        {
            var price = vehicle.ListPrice;
            var fueltype = vehicle.FuelType;
            var ageOfCar = DateTime.Now - vehicle.DateOfFirstRegistration;

            if (ageOfCar.TotalDays > 365)
            {                
                switch (fueltype)
                {
                    case FuelType.AlternativeFuel:
                        return 440;
                    case FuelType.Electric:
                        return 310;
                    default:
                        return 450;
                }
            }
            else
            {
                return 0;
            }
            
        }
        public override int CalculateTax(Vehicle vehicle)
        {
            
            int emissions = vehicle.Co2Emissions;
            int totalTax = 0;

            story5 = false;
            if (story5)
            {
                totalTax += CheckAdditionalTaxForExpensiveVehicles(vehicle);
            }

            if (vehicle.FuelType == FuelType.Petrol)
            {
                if (emissions < 1)
                {
                    totalTax += 0;
                }
                else if (emissions < 51)
                {
                    totalTax += 10;
                }
                else if (emissions < 76)
                {
                    totalTax += 25;
                }
                else if (emissions < 91)
                {
                    totalTax += 105;
                }
                else if (emissions < 101)
                {
                    totalTax += 125;
                }
                else if (emissions < 111)
                {
                    totalTax += 145;
                }
                else if (emissions < 131)
                {
                    totalTax += 165;
                }
                else if (emissions < 151)
                {
                    totalTax += 205;
                }
                else if (emissions < 171)
                {
                    totalTax += 515;
                }
                else if (emissions < 191)
                {
                    totalTax += 830;
                }
                else if (emissions < 226)
                {
                    totalTax += 1240;
                }
                else if (emissions < 256)
                {
                    totalTax += 1760;
                }
                else
                {
                    totalTax += 2070;
                }
            }
            else if (vehicle.FuelType == FuelType.AlternativeFuel)
            {
                if (emissions < 1)
                {
                    totalTax += 0;
                }
                else if (emissions < 51)
                {
                    totalTax += 0;
                }
                else if (emissions < 76)
                {
                    totalTax += 15;
                }
                else if (emissions < 91)
                {
                    totalTax += 95;
                }
                else if (emissions < 101)
                {
                    totalTax += 115;
                }
                else if (emissions < 111)
                {
                    totalTax += 135;
                }
                else if (emissions < 131)
                {
                    totalTax += 155;
                }
                else if (emissions < 151)
                {
                    totalTax += 195;
                }
                else if (emissions < 171)
                {
                    totalTax += 505;
                }
                else if (emissions < 191)
                {
                    totalTax += 820;
                }
                else if (emissions < 226)
                {
                    totalTax += 1230;
                }
                else if (emissions < 256)
                {
                    totalTax += 1750;
                }
                else
                {
                    totalTax += 2060;
                }
            }
            else
            {
                totalTax += 0;
            }

            return totalTax;
        }
    }
}
