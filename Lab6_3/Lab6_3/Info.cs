using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3
{
    abstract class Info : IText, IInfo
    {
        public abstract int CookingTime { get; }
        public abstract void Ingredients();
        public void ShowText()
        {
            Console.WriteLine($"Название блюда:{GetType().Name} Время приготовления:{CookingTime} минут");
        }

    }
}
