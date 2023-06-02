public class Start
{
    classManager cM;



    public Start(classManager cM)
    {
        this.cM = cM;
    }
    public void Update()
    {
        cM.exploring.DrawMap();
        System.Console.WriteLine("Welcome to my text based decision making journey, where your ending depends on what decisions you make.");
        System.Console.WriteLine("Write up to go up, right to go right, left to go left and down to go down.");
        System.Console.WriteLine("Press enter to play the game.");
        Console.ReadLine();
        cM.currentState = classManager.States.exploring;
        cM.SetState();
    }
}