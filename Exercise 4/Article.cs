using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Article
    {
        string nameTovar, nameStore;
        decimal price;
        public Article(string nameTovar, string nameStore, decimal price)
        {
            this.nameTovar = nameTovar;
            this.nameStore = nameStore;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine(nameTovar + " " + nameStore + "  " + price);
        }
        public void Find(string nameTovar)
        {
            if(this.nameTovar == nameTovar)
            {
                Console.WriteLine(nameTovar + " " + nameStore + "  " + price);
            }
            else
            {
                Console.WriteLine("No tovara!!!");
            }
        }
    }
}
