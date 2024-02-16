namespace Snake
{
    internal class Program3
    {









        static void Main(string[] args)
        {
            const int LeftCords = 5, RightCords = 50, TopCords = 1;
            const int Height = 25, Width = 50;
            const char HorizontalBorder = 'I';
            const string VerticalBorder = "II";
            const int BottomCords = 25;


            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(LeftCords, TopCords);
            Console.WriteLine(new string(HorizontalBorder, Width));
            Console.SetCursorPosition(LeftCords, Height);
            Console.WriteLine(new string(HorizontalBorder, Width));


            for (int line = TopCords; line <= Height; line++)
            {
                Console.SetCursorPosition(LeftCords, line);
                Console.WriteLine(VerticalBorder);
                Console.SetCursorPosition(LeftCords + Width - 1, line); //-1 because VerticalSymbol's length
                Console.WriteLine(VerticalBorder);
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

                Console.SetCursorPosition(LeftCords, TopCords);
                Console.WriteLine(new string(HorizontalBorder, Width));
                Console.SetCursorPosition(LeftCords, Height);
                Console.WriteLine(new string(HorizontalBorder, Width));

                for (int line = TopCords; line <= Height; line++)
                {
                    Console.SetCursorPosition(LeftCords, line);
                    Console.WriteLine(VerticalBorder);
                    Console.SetCursorPosition(LeftCords + Width - 1, line); 
                    Console.WriteLine(VerticalBorder);
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


               


                if (origRow == RightCords)
                {
                    Console.SetCursorPosition(LeftCords, height);
                }

            } while (redo == 0);





            Console.ReadLine();
        }
    }
}