namespace ConsoleApp4
{
    internal class Program
    {





        



        static void Main(string[] args)
        {
            const int Links = 5, Rechts = 50, Oben = 1;
            const int Hoehe = 25, Breite = 50;
            const char HorizontalZeichen = 'I';
            const string VerticalZeichen = "II";
            const int Unten = 25;


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
            int height = 10;
            int speedX = 0;
            int speedY = 0;
            int origRow = -1;
            int origCol = -1;
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                Console.Clear();

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



                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        sides++;
                        Console.SetCursorPosition(sides, height);
                        Console.Write("\b");
                        Console.Write("X");
                        speedX += 1;
                        origRow = Console.CursorLeft;
                        origCol = Console.CursorTop;
                        break;
                    case ConsoleKey.LeftArrow:
                        sides--;
                        Console.SetCursorPosition(sides, height);
                        Console.Write("X");
                        speedX -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        height++;
                        Console.SetCursorPosition(sides, height);
                        Console.Write("X");
                        break;
                    case ConsoleKey.UpArrow:
                        height--;
                        Console.SetCursorPosition(sides, height);
                        Console.Write("X");
                        break;
 
            


            
                
                }


             // origRow = Console.CursorLeft;


             if(origRow == Rechts)
                {
                    Console.SetCursorPosition(Links, height);
                }  

            } while (redo == 0);





            Console.ReadLine();
        }
    }
}