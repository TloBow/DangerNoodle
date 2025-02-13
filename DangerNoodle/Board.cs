namespace DangerNoodle;

public class Board
{
    public int width;
    public int height;
    public int[,] board;
    public bool gameEnd;

    public void PrintBoard()
    {
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                Console.Write("[" + board[i,j] + "]");
            }
            Console.WriteLine("");
        }
    }

    public void SpawnApple()
    {
        Random random = new Random();
        int appleX, appleY;

        do
        {
            appleX = random.Next(0, width);
            appleY = random.Next(0, height);
        } while(board[appleX, appleY] >= 5);
        
        board[appleX, appleY] += 1;
    }

    public Board(int width, int height, bool gameEnd)
    {
        this.width = width;
        this.height = height;
        this.gameEnd = gameEnd;

        board = new int[width, height];
    }
}