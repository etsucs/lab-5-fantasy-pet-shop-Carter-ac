namespace Lab5_FantasyPetShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create FantasyPet objects
            FantasyPet pet1 = new FantasyPet("Flame", "Dragon", 5, 1500.00m, "Breathes fire");
            FantasyPet pet2 = new FantasyPet("Spark", "Phoenix", 3, 1200.00m, "Revives itself from ashes");
            FantasyPet pet3 = new FantasyPet("Mystic", "Unicorn", 7, 2000.00m, "Heals with its horn");

            // Create a PetShop and add pets to it
            PetShop petShop = new PetShop();
            petShop.AddPet(pet1);
            petShop.AddPet(pet2);
            petShop.AddPet(pet3);

            // Describe each pet
            pet1.DescribePet();
            pet2.DescribePet();
            pet3.DescribePet();

            // Show discounted price for one or more pets
            Console.WriteLine($"Discounted price for {pet1.PetName}: ${pet1.DiscountPrice(10):0.00}");
            Console.WriteLine($"Discounted price for {pet2.PetName}: ${pet2.DiscountPrice(15):0.00}");

            // Perform magic for one or more pets
            pet1.PerformMagic();
            pet3.PerformMagic();

            // List all pets in the shop
            petShop.ListPets();
        }
    }
}
