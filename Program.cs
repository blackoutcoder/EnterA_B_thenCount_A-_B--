using System;

namespace EnterA_B_thenCount_A___B__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Modifyer modifyer = new Modifyer();
            modifyer.Reader();
            modifyer.Increase();
            modifyer.Decrease();
        }

        public class Modifyer
        {
            int a, b;

            public void Reader()
            {
                Console.WriteLine("Enter A and press Enter...");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter A and press Enter...");
                b = Convert.ToInt32(Console.ReadLine());
            }
            public void Increase()
            {
                a++;
                Console.WriteLine(a);
            }
            public void Decrease()
            {
                b--;
                Console.WriteLine(b);
            }
        }
    }
}
