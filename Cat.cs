using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class Cat
    {
        private string nickName;

        public string NickName
        {
            get { return nickName; }
            set
            {
                if (value.Length >= 4)
                    nickName = value;
                else
                    Console.WriteLine("eror");
            }
        }

        private byte age;

        public byte Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("eror");
            }
        }
        public bool Gender { get; private set; }
        public double Energy { get; set; } = 150;
        public double Price { get; set; }
        public int MealQuantity { get; set; }



        public void Eat()
        {
            Energy++;
            Price += 0.2;

        }
        public void Sleep()
        {
            Energy++;
        }
        public void Play()
        {
            if (Energy == 0)
                Sleep();
            else
                Energy--;
        }

        public Cat()
        {

        }

        public Cat(string nickName, byte age, bool gender, double energy, double price, int mealQuantity)
        {
            NickName = nickName;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
        }
    }
}
