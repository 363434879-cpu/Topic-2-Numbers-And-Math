namespace Topic_2_Numbers_And_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naika
            // % = modulus operator gives the remainder of a division
            Console.WriteLine("Hello, World!");
            Console.WriteLine("I will now count my chickens:");
            // Asterix (*) is for multiplication
            Console.WriteLine("Hens " + (10 + 5 * 2));
            // Slash (/) is for division
            Console.WriteLine("Roosters " + (25 + 30 / 6));
            // shows (six6)
            Console.WriteLine("six" + 6);
            //Shows (6 + 6)
            Console.WriteLine("6 + 6");
            //Shows (66)
            Console.WriteLine("6" + 6);
            //Shows (12)
            Console.WriteLine(6 + 6);
            Console.WriteLine("Now I will count the eggs:");
            //Division shows (5) just rounds to the nearest whole number
            Console.WriteLine(11 / 2);
            //Shows (5.5)
            Console.WriteLine(11.0 / 2);
            Console.WriteLine("Is it true that 3 + 2 < 5 - 7?");
            Console.WriteLine(3 + 2 < 5 - 7);
            Console.WriteLine("What is 3 + 2? " + (3 + 2));
            Console.WriteLine("What is 5 - 7? " + (5 - 7));
            Console.WriteLine("Oh, that's why it's " + (3 + 2 < 5 - 7));
            Console.WriteLine("Press ENTER To Continue");
            Console.ReadLine();
            Console.Clear();

            //Programming Task:
            Console.WriteLine("I will now calculate my pay");
            Console.WriteLine("I earned 8 x 21");
            double pay = 8 * 21;
            Console.WriteLine(pay.ToString("C"));
            Console.WriteLine(" I will now calculate my eggs");
            Console.WriteLine(" 6/12");
            Console.WriteLine(6.0/12);

        }
    }
}
