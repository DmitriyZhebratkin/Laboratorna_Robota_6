using System;

namespace Lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dish dish = new Dish();
            Info[] dishes = { new Borsch { }, new TortNapoleon() };
            foreach(var item in dishes)
            {
                dish.CheckText(item);
                dish.Ingredients(item);
                Console.WriteLine();
            }
        }
    }
}
