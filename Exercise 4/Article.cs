using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Article
    {
        //string nameItem, nameStore;
        //decimal price;
        public Article(string nameItem, string nameStore, decimal price)
        {
            NameItem = nameItem;
            NameStore = nameStore;
            Price = price;
        }
        public string NameItem { get; set; }
        public string NameStore { get; set; }
        public decimal Price { get; set; }
        //public void Show()
        //{
        //    Console.WriteLine(nameTovar + " " + nameStore + "  " + price);
        //}
        ////public void Find(string nameTovar)
        //{
        //    if(this.nameTovar == nameTovar)
        //    {
        //        Console.WriteLine(nameTovar + " " + nameStore + "  " + price);
        //    }
        //    else
        //    {
        //        Console.WriteLine("No tovara!!!");
        //    }
        //}
        public void Show()
        {
            Console.WriteLine($"Name item - {NameItem} Name store - {NameStore} Price - {Price}");
        }

    }
}
