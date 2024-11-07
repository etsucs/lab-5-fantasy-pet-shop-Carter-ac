using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_FantasyPetShop
{
    public class FantasyPet
    {
        public string PetName { get; set; }
        public string PetSpecies { get; set; }
        public int PetAge { get; set; }
        public decimal Price { get; set; }
        public string MagicPower { get; set; }

        public FantasyPet(string petName, string petSpecies, int petAge, decimal price, string magicPower)
        {
            PetName = petName;
            PetSpecies = petSpecies;
            PetAge = petAge;
            Price = price;
            MagicPower = magicPower;
        }

        public void DescribePet()
        {
            Console.WriteLine($"Name: {PetName}, Species: {PetSpecies}, Age: {PetAge} years, Magic Power: {MagicPower}");
        }

        public decimal DiscountPrice(decimal percent)
        {
            return Price - (Price * (percent * 100));
        }

        public void PerformMagic()
        {
            Console.WriteLine($"{PetName} performs magic: {MagicPower}!");
        }
    }
}
