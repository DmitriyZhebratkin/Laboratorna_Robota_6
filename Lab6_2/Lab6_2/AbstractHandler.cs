using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_1
{
    public class AbstractHandler
    {
        public void Handler(Document file_name)
        {
            string lines = file_name.Read();

            if (lines.Contains(".txt"))
            {
                Console.WriteLine("Формат документа - .txt");
            }
            else if (lines.Contains(".doc"))
            {
                Console.WriteLine("Формат документа - .doc");
            }
            else if (lines.Contains(".pdf"))
            {
                Console.WriteLine("Формат документа - .pdf");
            }
            else
            {
                Console.WriteLine("Формат документа неизвестен");
            }

        }
    }
}
