namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GamoicaniRicxvi();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("lets try again");
                GamoicaniRicxvi();
            }
            void GamoicaniRicxvi()
            {
                Random random = new Random();
                int x = random.Next(20);
                Console.WriteLine("Gamoicanit ricxvi");
                int myNumber = -1;

                for (int i = 0; i < 5; i++)
                {
                    myNumber = GetPositiveInt();

                    if (myNumber == x)
                    {
                        Console.WriteLine("you are right");
                        return;
                    }
                    else if (myNumber > x)
                    {
                        Console.WriteLine("Its too big, lets try again");
                    }
                    else
                    {
                        Console.WriteLine("Its too little, lets try again");
                    }
                }
                Console.WriteLine("Game over, you lose");
            }
        }

        private static int GetPositiveInt()
        {
            int myNumber;
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out myNumber))
                {
                    Console.WriteLine("please choose valid number");
                }
                if (myNumber > 0)
                    return myNumber;
                Console.WriteLine("Your number should be positive");
            }
        }
    }
}