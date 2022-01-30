using System;
using System.Collections.Generic;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Kady", 5, true, 130, 23, 54);
            Cat cat2 = new Cat("Lady", 6, false, 150, 12, 214);
            Cat cat3 = new Cat("Cady", 2, true, 180, 21, 26);

            //CatHouse house1 = new CatHouse(new List<Cat>() { cat1, cat2, cat3 });
            CatHouse house1 = new CatHouse();
            CatHouse house2 = new CatHouse();
            house1.AddCat(cat1);
            house1.AddCat(cat2);
            house2.AddCat(cat3);


            //PetShop petShop = new PetShop(new List<CatHouse>() { house1 });
            PetShop petShop = new PetShop();
            petShop.Add(house1);
            petShop.Add(house2);

            int i = 0;
            Console.WriteLine("Petshop");
            foreach (var catHouse in petShop.CatHouses)
            {
                i++;
                Console.WriteLine($"{i}) Cat house");
                foreach (var cat in catHouse.Cats)
                {
                    Console.WriteLine($"{cat.NickName}");
                }
            }
            try
            {
                List<string> list = null;
                list.Add("Kenan");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Xais edirik duzgun melumat daxil edin!");
            }


        }
    }
}
