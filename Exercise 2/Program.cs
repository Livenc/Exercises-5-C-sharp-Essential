namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght;
            do
            {
                Console.Write("Input langht of array :");
                if (!Int32.TryParse(Console.ReadLine(), out arrayLenght))
                {                
                    Console.WriteLine("Ne Chislo");
                    Thread.Sleep(1000);
                }
                else
                {
                    break;
                }
                Console.Clear();
            } while (true);
            int[] arrayRandom = new int[arrayLenght];
            Random random = new Random();
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = random.Next(1, 100);
                Console.WriteLine(arrayRandom[i]);     
            }
            Console.WriteLine("Max : "+arrayRandom.Max() );
            Console.WriteLine("Min : " + arrayRandom.Min());
            Console.WriteLine("Sum : " + arrayRandom.Sum());
            Console.WriteLine("Average : " + arrayRandom.Average());
            Console.Write("Even number : ");
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                
                if (arrayRandom[i] % 2 == 0)
                {
                    Console.Write($" {arrayRandom[i]} " );
                }
            }
            Console.ReadLine();
        }
    }
}
