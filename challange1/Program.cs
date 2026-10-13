namespace challange1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ticket price: ");
            int TicketPrice = Convert.ToInt32(Console.ReadLine());
            double FinalPrice = TicketPrice;
            if (Age < 12)
            {
                FinalPrice = TicketPrice * .50;
            }

            if (FinalPrice > 500)
            {
                Console.WriteLine($" final price:{FinalPrice}\n Expensive Ticket ");
            }else
            {
                Console.WriteLine($" final price:{FinalPrice}\n Normal Ticket ");
            }
            
        }
    }
}
