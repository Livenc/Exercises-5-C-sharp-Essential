using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Store
    {
        Article[] articles ;

        public Store(params Article[] Article)
        {
            articles = Article;
        }

        public Article this[int index]
        {
            get    // Аксессор.
            {

                if (index >= 0 && index < articles.Length)
                    return articles[index];
                else
                {
                    
                     throw new ArgumentOutOfRangeException(); 
                }
             
            }
            set    // Мутатор.
            {
                if (index >= 0 && index < articles.Length)
                    articles[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }
        public Article this[string name]
        {
            get
            {
                foreach (var article in articles)
                {
                    if(article.NameItem == name)
                    {
                        return article;
                    }
                }
                //throw new Exception("Unknown name");
                return new Article("Net tovara","",0);
            }
        }
        //public void Show()
        //{
        //    foreach (var item in articles)
        //    {
        //        Console.WriteLine(item.NameItem);
        //        Console.WriteLine(item.NameStore);
        //        Console.WriteLine(item.Price);
        //    }
        //}
        
       
        
    }
}
