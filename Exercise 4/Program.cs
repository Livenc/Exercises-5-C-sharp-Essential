namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store  = new Store();
           
            store[0] = new Article("Grechka", "ATB", 60);
            store[1] = new Article("Manka", "Lind", 30);
            store[2] = new Article("Voda", "Skaska", 20);
            store[3] = new Article("Chips", "klass", 10);
            store[4] = new Article("Moloko", "Lomn", 10);
            store[5] = new Article("Spichki", "ATB", 50);
            store[6] = new Article("Vodka", "322", 80);
            store[7] = new Article("Lemon", "ATB", 44);
            for (int i = 0; i <8; i++)
            {
               store[i].Show();
            }
            store[].Find
            Console.ReadLine();
        }
    }
}