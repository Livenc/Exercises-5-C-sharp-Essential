namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store  = new Store(  new Article("Grechka", "ATB", 60),
            new Article("Manka", "Lind", 30),
             new Article("Voda", "Skaska", 20),
            new Article("Chips", "klass", 10),
             new Article("Moloko", "Lomn", 10),
            new Article("Spichki", "ATB", 50),
             new Article("Vodka", "322", 80),
             new Article("Lemon", "ATB", 44));

            // store.Show();
            
            do
            {
                Console.Write("Input index item : ");
                if (Int32.TryParse(Console.ReadLine(),out int index))
                {
                    store[index].Show();
                    break;
                }
                else
                {

                    Console.WriteLine("Not a number");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            } while (true);
            
            Console.Write("Input name item : ");

            store[Console.ReadLine()].Show();
            
            Console.ReadLine();
        }
    }
}