using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3
{
    class Borsch : Info
    {
        public override int CookingTime => 180;
        public override void Ingredients()
        {
            Console.WriteLine("Ингридиенты: Мясо, картошка, свекла, морковь, капуста");
        }
    }
}
