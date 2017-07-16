﻿using System;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private int weight;
        private double calories;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.Calories = calories;
        }

        public double Calories
        {
            get { return this.calories; }
            set { this.calories = GetTotalCalories(); }
        }

        private string Type
        {
            get { return this.type; }
            set
            {
                if (!value.ToLowerInvariant().Equals("meat")
                    && !value.ToLowerInvariant().Equals("veggies")
                    && !value.ToLowerInvariant().Equals("cheese")
                    && !value.ToLowerInvariant().Equals("sauce"))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        private int Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        private double GetTypeMod()
        {
            switch (this.Type.ToLower())
            {
                case "meat":
                    return 1.2;
                case "veggies":
                    return 0.8;
                case "cheese":
                    return 1.1;
                case "sauce":
                    return 0.9;
                default:
                    return 1.0;
            }
        }

        private double GetTotalCalories() => (2 * this.Weight) * this.GetTypeMod();
    }
}