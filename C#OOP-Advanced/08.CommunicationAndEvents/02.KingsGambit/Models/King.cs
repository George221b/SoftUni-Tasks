﻿using System;

namespace _02.KingsGambit.Models
{

    public class King
    {
        public event EventHandler UnderAttack;

        public King(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void OnUnderAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");

            UnderAttack?.Invoke(this, new EventArgs());
        }
    }
}
