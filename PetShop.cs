using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_FantasyPetShop
{
    public class PetShop
    {
        public List<FantasyPet> PetList { get; set; }

        public PetShop()
        {
            PetList = new List<FantasyPet>();
        }

        public string AddPet(FantasyPet pet)
        {
            PetList.Add(pet);
            return ($"{pet.PetName} was added to the shop.");
        }

        public void ListPets()
        {
            foreach (var pet in PetList)
            {
                pet.DescribePet();
            }
        }
    }
}
