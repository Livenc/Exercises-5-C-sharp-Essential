using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Store
    {
        Article[] articles = new Article[10] ;

        public Article this[int index]
        {
            get    // Аксессор.
            {

                if (index >= 0 && index < articles.Length)
                    return articles[index];
                else
                {
                    return null;
                }
                //  return "Попытка обращения за пределы массива.";
                //return articles[index];
            }
            set    // Мутатор.
            {
                if (index >= 0 && index < articles.Length)
                    articles[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }
            public void Find(string name)
        {
            if (true)
            {

            }
        }
        
    }
}
