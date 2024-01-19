using System.Security.Cryptography;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {   //ObenLinks steht für die X-Koordinate des Spielfelds, Oben für die Y
            const int Links = 5, Oben = 1;
            const int Hoehe = 34, Breite = 115;
            const char HorizontalZeichen = 'I';
            const string VerticalZeichen = "II";


           
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(Links, Oben);
            Console.WriteLine(new string(HorizontalZeichen, Breite));
            Console.SetCursorPosition(Links, Hoehe);
            Console.WriteLine(new string(HorizontalZeichen, Breite));


            for (int line = Oben; line <= Hoehe; line++)
            {
                Console.SetCursorPosition(Links, line);
                Console.WriteLine(VerticalZeichen);
                Console.SetCursorPosition(Links + Breite - 1, line); //-1 cuz VerticalSymbol's length
                Console.WriteLine(VerticalZeichen);
            }


            int redo = 0;
            int sides = 20;
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                Console.Clear();



                for (int line = Oben; line <= Hoehe; line++)
                {
                    Console.SetCursorPosition(Links, line);
                    Console.WriteLine(VerticalZeichen);
                    Console.SetCursorPosition(Links + Breite - 1, line); //-1 cuz VerticalSymbol's length
                    Console.WriteLine(VerticalZeichen);
                }



                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        sides++;
                        Console.SetCursorPosition(sides, 10);
                        Console.Write("\b");
                        Console.Write("X");
                        break;
                        case ConsoleKey.LeftArrow:
                        sides--;
                        Console.SetCursorPosition(sides, 10);
                        Console.Write("X");
                        break;




                }


            } while (redo == 0);




            
            Console.ReadLine();

            
        }
    }
}