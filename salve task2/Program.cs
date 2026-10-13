using System.ComponentModel;

namespace salve_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = [];
            numbers.Add(100);
            numbers.Add(5);
            numbers.Add(8);
            numbers.Add(10);
            numbers.Add(40);
            char c;
            do
            {
                Console.WriteLine("  Menu options:");
                Console.WriteLine("  P - Print numbers");
                Console.WriteLine("  A - Add a number");
                Console.WriteLine("  M - Display mean of the numbers");
                Console.WriteLine("  S - Display the smallest number");
                Console.WriteLine("  L - Display the largest number");
                Console.WriteLine("  F - find anumber in the list");
                Console.WriteLine("  C - clear the list");
                Console.WriteLine("  O - order the list");
                Console.WriteLine("  Q - Quit");
                Console.WriteLine("  Enter your choice:");
                c = Convert.ToChar(Console.ReadLine());
                switch (c)
                {
                    case 'P':
                        print(numbers);
                        break;
                    case 'p':
                        print(numbers);
                        break;
                    case 'A':
                        add(numbers);
                        break;
                    case 'a':
                        add(numbers);

                        break;
                    case 'M':
                        mean(numbers);
                        
                        break;
                    case 'm':
                        mean(numbers);
                        break;
                    case 'S':
                        small(numbers);
                        break;
                    case 's':
                        small(numbers);
                        break;
                    case 'L':
                        large(numbers);
                        break;
                    case 'l':
                        large(numbers);
                        break;
                    case 'F':
                        find(numbers);
                        break;
                    case 'f':
                        find(numbers);
                        break;
                    case 'C':
                        numbers.Clear();
                        break;
                    case 'c':
                        numbers.Clear();
                break;
                    case 'O':
                        order(numbers);
                        break;
                    case 'o':
                       order(numbers);
                        break;
                    case 'Q':
                        Console.WriteLine("Goodbye");
                        break;
                    case 'q':
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine(" invaled charcter");
                        break;

                }
            } while (!(c == 'Q' || c == 'q'));
           
        }
        static void print(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");
                return;
            }else
            {
                Console.Write("[ ");
                for (int i=0; i<numbers.Count; i++)
                {
                    Console.Write(numbers[i]);
                    Console.Write(" ");
                  
                }
                Console.WriteLine("]");
            }
           
        }
        static void add(List<int> numbers)
        {

            bool found = true;

            int n=0;

            while (found == true)
            {
                Console.WriteLine("add the number");
                n = (Convert.ToInt32(Console.ReadLine()));
                found = false;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (n == numbers[j])
                    {
                        found = true;
                        Console.WriteLine("the number Duplicate ");
                        break;
                    }

                }
                
            }
             numbers.Add(n);
             Console.WriteLine($"{n}added");

        }
        static void mean(List<int> numbers)
        {
            double sum =0;
            for (int i = 0; i < numbers.Count; i++) {
                sum += numbers[i];
                
            }
            Console.WriteLine($"the average = {sum / numbers.Count}"); 
        }
        static void small(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("Unable to determine the smallest number - list is empty");
                return;
            }
            else
            {
                int min = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }

                }
                Console.WriteLine($"the smallest element in the list : {min}");
            }
        }
        static void large(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("Unable to determine the largest number - list is empty");
                return;
            }
            else
            {
                int max = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }

                }
                Console.WriteLine($"the smallest element in the list : {max}");
            }
        }
        static void find(List<int> numbers)
        {
            Console.WriteLine("enter number that you search it : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (n == numbers[i])
                {
                    Console.WriteLine($"the index: {i}");
                    break;
                }
            }
            Console.WriteLine("this number not found");
        }
        static void order(List<int> numbers)
        {
            List<int> num = [];
            List<int> temp = new List<int>(numbers);
            
            while( temp.Count != 0) 
            { 
                int min = temp[0];
                for (int i = 0; i < temp.Count; i++)
                { 
                    if (temp[i] < min)
                    {

                        min = temp[i];
                    }
                }
                
                  num.Add(min);
                temp.Remove(min);
               
            }
            Console.Write("[ ");
            for (int j = 0; j < num.Count; j++)
            { 
                Console.Write(num[j]);
                Console.Write(" ");

            }
            Console.WriteLine("]");
        }
    }   
}
