namespace DangerNoodle;

class Program
{
    static void Main(string[] args)
    {
        Board basicBoard = new Board(11, 11, false);
        Noodle noodle = new Noodle(basicBoard, 4, 3);

        noodle.SpawnNoodle();
        basicBoard.SpawnApple();

        int moveInterval = 0;

        while(basicBoard.gameEnd == false)
        {
            Console.Clear();
            basicBoard.PrintBoard();
            if(Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if(key == ConsoleKey.Enter)
                {
                    basicBoard.gameEnd = true;
                }
                else if(key == ConsoleKey.UpArrow)
                {
                    noodle.RotationUp();
                }
                else if(key == ConsoleKey.LeftArrow)
                {
                    noodle.RotationLeft();
                }
                else if(key == ConsoleKey.RightArrow)
                {
                    noodle.RotationRight();
                }
                else if(key == ConsoleKey.DownArrow)
                {
                    noodle.RotationDown();
                }
            }

            moveInterval += 50;

            if (moveInterval >= 500)
                {
                    noodle.Move();
                    moveInterval = 0;
                }
            
            Thread.Sleep(50);
        }
    }
}