public class Decisions

{
    classManager cM;



    public Decisions(classManager cM)
    {
        this.cM = cM;

    }

    public void Update()
    {
        //Checks player coordinates and gives prompt


        if (cM.exploring.playerX == 6 && cM.exploring.playerY == 5)
        {
            Console.WriteLine("You find yourself between two doors, one red to the left and one blue to the right. \nYou know nothing about who you are and why you're here, you only know that if you walk through the red door, you will \nfind the truth. The blue one does look more appealing though...");
            Console.ReadLine();


            cM.exploring.Update();

        }
        //red door path ending
        if (cM.exploring.playerX == 5 && cM.exploring.playerY == 4)
        {
            Console.WriteLine("You walk through a dark corridor with concrete walls. You feel regret picking the red door, you have a slight feeling \n that the truth will not satisfy you. On your path to the truth, you find another door with an emergency exit sign. \nDo you want to continue forward to the truth? Or see what the emergency exit has in store?");
            Console.ReadLine();


            cM.exploring.Update();

        }
        if (cM.exploring.playerX == 3 && cM.exploring.playerY == 4)
        {
            Console.WriteLine("You walk through the emergency exit door and you are instantly greeted with an innocent, colorful and peaceful hallway. \nWhile it's still as clastrophobic as the last, you feel more comfortable in this one.");
            Console.ReadLine();


            cM.exploring.Update();

        }
        //2nd ending red door path
        if (cM.exploring.playerX == 3 && cM.exploring.playerY == 2)
        {
            Console.WriteLine("You reach the end where the corridor opens up to a small, colorful blissful area with a tree in the middle with no exit in sight. \nYou know you will spend the rest of your life here, even though you're confused you accept it.");
            Console.ReadLine();


            cM.exploring.Update();

        }
        if (cM.exploring.playerX == 5 && cM.exploring.playerY == 2)
        {
            Console.WriteLine("You reach the end of the hallway and it opens up. You see a world on fire and suddenly it all comes back to you. \nYou are filled with anger and dispair when you realise the world you came from has fallen apart. \nYou decide to venture out to the world in carange to find out more.");
            Console.ReadLine();


            cM.exploring.Update();

        }

        if (cM.exploring.playerX == 7 && cM.exploring.playerY == 4)
        {
            Console.WriteLine("You can't stand the curiousity of wondering what was behind the red door, and as you walk down the path you notice \na crack on the side of the wall. You could easily fit through this crack and explore whats behind the wall. \nDo you continue on your path, or do you explore?.");
            Console.ReadLine();


            cM.exploring.Update();

        }
        if (cM.exploring.playerX == 7 && cM.exploring.playerY == 2)
        {
            Console.WriteLine("You reach the end of the hallway and it lits up, like a light at the end of a dark tunnel. \nYou continue and you find a paradise beach with hot temperature and relaxation. You realise this will be your life, and the curiousty of the red door drives you near madness.");
            Console.ReadLine();


            cM.exploring.Update();

        }

        if (cM.exploring.playerX == 9 && cM.exploring.playerY == 4)
        {
            Console.WriteLine("This hallway is far darker and dirtier, almost looks like it's been abandoned for years. \nAt the very end of the tunnel you see a bright red light.");
            Console.ReadLine();


            cM.exploring.Update();

        }

        if (cM.exploring.playerX == 9 && cM.exploring.playerY == 2)
        {
            Console.WriteLine("You reach the end of the hallway and it opens up. You see a red monster destroying the world you realise you came from. You get filled with hopelessness since you know theres nothing you can do to defeat this monster. \nYou walk back into the hallway and sit there for the rest of your short life.");
            Console.ReadLine();


            cM.exploring.Update();

        }



    }


}