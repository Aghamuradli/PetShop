using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class CatHouse
    {
        public List<Cat> Cats { get; set; } = new List<Cat>();
        public int CatCount { get; set; }

        public void AddCat(Cat cat)
        {
            Cats.Add(cat);
        }
        public void RemoveByNickName(string nickName)
        {

            if (Cats.Exists(c => c.NickName == nickName))
            {
                var cat = Cats.FirstOrDefault(c => c.NickName == nickName);
                Cats.Remove(cat);
            }
            else
            {
                Console.WriteLine("Pisik tapilmadi!");
            }
        }


        public CatHouse()
        {

        }
        public CatHouse(List<Cat> cats)
        {
            Cats = cats;
            CatCount = cats.Count;
        }
    }
}
