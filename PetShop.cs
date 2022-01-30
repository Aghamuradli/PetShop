using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class PetShop
    {
        public List<CatHouse> CatHouses { get; set; } = new List<CatHouse>();
        public int CatHouseCount { get; set; }

        public void Add(CatHouse catHouse)
        {
            CatHouses.Add(catHouse);
        }



        public PetShop()
        {

        }

        public PetShop(List<CatHouse> catHouses)
        {
            CatHouses = catHouses;
            CatHouseCount = catHouses.Count;
        }
    }


}
