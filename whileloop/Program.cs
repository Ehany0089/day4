namespace whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            
            while (i <= n)
            {
                if (i % 3 == 0) 
                    Console.WriteLine(i);
                
               
                
                i++;
            }
        
        }
    }
}
