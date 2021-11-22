using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3
{
    class Dish
    {
        public void Ingredients(IInfo info)
        {
            info.Ingredients();
        }
        public void CheckText(IText text)
        {
            text.ShowText();
        }
    }
}
