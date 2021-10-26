using System;

namespace projekt_věk
{
    class Program
    {
        static void Main(string[] args)
        {
            double rok;
            double vek;

             
            Console.WriteLine("Zadej rok narození. ");
            Double.TryParse(Console.ReadLine(), out rok);
            vek = DateTime.Now.Year - rok;
            if (vek < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ještě si se nenarodil.");

            }
            else if (vek < 15)
            {
                Console.WriteLine();
                Console.WriteLine("Jsi ještě dítě :D");
            }
            else if (vek < 19)
            {
                Console.WriteLine();
                Console.WriteLine("Pravděpodobně jsi student");
            }
            else if (vek < 26)
            {
                Console.WriteLine();
                Console.WriteLine("Nejlepší léta");
            }
            else if (vek < 50)
            {
                Console.WriteLine();
                Console.WriteLine("Užívej dokud můžeš");
            }
            else if (vek < 80)
            {
                Console.WriteLine();
                Console.WriteLine("Jste důchodce");
            }
            
           
                    

        }

    }

}
