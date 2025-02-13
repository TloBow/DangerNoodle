namespace DangerNoodle;

public class Noodle 
{
    int noodleX;
    int noodleY;
    int rotation;
    int length;
    List<int[]> pastSteps = new List<int[]>();
    Board board;

    public Noodle(Board board, int rotation, int length)
    {
        this.rotation = rotation;
        this.board = board;
        this.length = length;
    }

    public void SpawnNoodle()
    {
        noodleX = board.width/2;
        noodleY = board.height/2;

        board.board[noodleX, noodleY] += 5;
    }

    public void RotationUp()
    {
        rotation = 1;
    }
    public void RotationDown()
    {
        rotation = 2;
    }
    public void RotationLeft()
    {
        rotation = 3;
    }
    public void RotationRight()
    {
        rotation = 4;
    }

    public void Move()
    {
        pastSteps.Add([noodleX, noodleY]);
        if(rotation == 1)
        {
            noodleX--;
        }
        else if(rotation == 2)
        {
            noodleX++;
        }
        else if(rotation == 3)
        {
            noodleY--;
        }
        else if(rotation == 4)
        {
            noodleY++;
        }

        if (pastSteps.Count >= length)
        {
            int[] tailPos = pastSteps[pastSteps.Count - length];

            board.board[tailPos[0], tailPos[1]] = 0;
        }

        board.board[noodleX, noodleY] += 5;

        if(board.board[noodleX, noodleY] == 6)
        {
            length++;
            board.board[noodleX, noodleY] = 5;
            board.SpawnApple();
        }

        if(board.board[noodleX, noodleY] >= 10)
        {
            board.gameEnd = true;
        }
    }


}