using System;

public class Exploring
{
    classManager cM;
    bool[,] map = new bool[13, 9];
    public int playerX = 1;
    public int playerY = 1;

    public Exploring(classManager cM)
    {
        this.cM = cM;

        //starting points, y and x cords of the player
        playerX = 6;
        playerY = 6;

        //Places the rooms
        map[6, 6] = true; // Bottom row path (center)
        map[6, 5] = true; // Start

        map[5, 4] = true;
        map[7, 4] = true;
        map[3, 4] = true;
        map[9, 4] = true;

        map[5, 3] = true;
        map[7, 3] = true;
        map[3, 3] = true;
        map[9, 3] = true;

        map[5, 2] = true;
        map[7, 2] = true;
        map[5, 5] = true;
        map[7, 5] = true;
        map[3, 2] = true;
        map[9, 2] = true;
        map[4, 4] = true;
        map[8, 4] = true;


    }



    // Draws the map (Borrowed code from Samuel, don't fully understand how it works but essential for my game)
    public void DrawMap()
    {

        for (var y = 0; y < map.GetLength(1); y++)
        {
            for (var x = 0; x < map.GetLength(0); x++)
            {
                if (map[x, y] == true)
                {
                    if (playerX == x && playerY == y)
                    {
                        Console.Write("1");
                    }

                    else
                    {
                        Console.Write("0");
                    }
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }



    // Draws the map and allows the player to move through it
    public void Update()
    {
        Console.Clear();
        DrawMap();
        string text;
        bool move = true;

        while (move)
        {
            text = Console.ReadLine();

            if (text.ToLower() == "up")
            {
                if (playerY > 0 && map[playerX, playerY - 1]) // borrowed by Samuel
                {
                    playerY--;
                    move = false;

                }
                else
                {
                    Console.WriteLine("You can't go that way");
                }
            }
            else if (text.ToLower() == "down")
            {
                Console.WriteLine("There's no turning back");
            }
            else if (text.ToLower() == "left")
            {
                if (playerX > 0 && map[playerX - 1, playerY])
                {
                    playerX--;
                    move = false;

                }
                else
                {
                    Console.WriteLine("You can't go that way");
                }
            }
            else if (text.ToLower() == "right")
            {
                if (playerX < map.GetLength(0) - 1 && map[playerX + 1, playerY])
                {
                    playerX++;
                    move = false;

                }
                else
                {
                    Console.WriteLine("You can't go that way");
                }

            }
            else
            {
                Console.WriteLine("Try again");
            }

        }
        if (move == false)
        {
            Console.Clear();
            cM.exploring.DrawMap();
            cM.decisions.Update();

        }


    }
}
