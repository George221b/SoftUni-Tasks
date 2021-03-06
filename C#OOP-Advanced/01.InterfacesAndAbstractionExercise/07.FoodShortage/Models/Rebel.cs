﻿using _07.FoodShortage.Interfaces;

namespace _07.FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Group { get; private set; }
        public int FoodAmount { get; private set; }

        public void BuyFood()
        {
            this.FoodAmount += 5;
        }
    }
}
