namespace StarsAndStripes
{
    internal class Program
    {
        // Flag definition
        public static short FlagLength { get; } = 38;
        public static short FlagWidth { get; } = 26;
        public static short BlueLength { get; } = 23;
        public static short BlueWidth { get; } = 11;
        public static short StripeWidth { get; } = 2;
        public static short Stripes { get; } = 7;


        static void Main(string[] args)
        {
            // White grid generation
            for (short i = 0; i < FlagWidth; i++)
            {
                for (short j = 0; j < FlagLength; j++)
                {
                    Console.SetCursorPosition(j * 2, i);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("[]");
                }
                Console.WriteLine();
            }

            // Red stripes generation
            for (short stripe = 0; stripe < Stripes; stripe++)
            {
                for (short i = 0; i < StripeWidth; i++)
                {
                    for (short j = 0; j < FlagLength; j++)
                    {
                        Console.SetCursorPosition(j * 2, stripe * (StripeWidth * 2) + i);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[]");
                    }
                    Console.WriteLine();
                }
            }

            // Blue grid generation
            for (short i = 0; i < BlueWidth; i++)
            {
                for (short j = 0; j < BlueLength; j++)
                {
                    Console.SetCursorPosition(j * 2, i);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("[]");
                }
                Console.WriteLine();
            }

            // Stars generation
            short Count = 0;
            for (short i = 1; i < BlueWidth - 1; i++)
            {
                for (short j = 0; j < BlueLength - 13; j++)
                {
                    Console.SetCursorPosition(j * 4 + (Count ^ 3), i);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                }
                Count++;
                if (Count > 1) { Count = 0; }
                Console.WriteLine();
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}