using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3
{
    class TortNapoleon : Info
    {
        public override int CookingTime => 160;
        public override void Ingredients()
        {
            Console.WriteLine("Ингридиенты:Мука,яйа,сахар,молоко");
        }
    }
}
