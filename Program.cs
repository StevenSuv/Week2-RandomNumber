using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int MyRandomNumber = rnd.Next(1, 11);

            //programm genereerib juhuslikku numbrit 1-10
            //programm kontrollib, kas genereeritud number on suurem kui 5
            //kui number on suurem, kui 5, siis konsool kuvab "Random number is {MyRandomNumber}, see on suurem, kui 5
            //kui number on 5, siis konsool kuvab "Random number is 5"

            Console.WriteLine($"The computer has generated the number: {MyRandomNumber}");

            if(MyRandomNumber > 5)
            {
                Console.WriteLine($"Random number is {MyRandomNumber}, which is bigger than 5");
            }
            else if (MyRandomNumber < 5)
            {
                Console.WriteLine($"Random number is {MyRandomNumber}, which is smaller than 5");
            }
            else
            {
                Console.WriteLine("Random number is 5");
            }

        }
    }
}
