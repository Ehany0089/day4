namespace loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
        for (int i = 1; i<= 15; i++ )
            {
               
                if (i % 2 != 0)
                {
                    cont += i;
                    Console.WriteLine(i);
                }
                    
          

            }
            Console.WriteLine(cont);
        }
    }
}
