//Create instances of every class
//Make a while loop that handles which state the game is in 
//Create enum with all three states of the game


public class classManager
{
    //instances
    public Start start;
    public Decisions decisions;
    public Exploring exploring;

    public States currentState;

    public classManager()
    {
        start = new(this);
        decisions = new(this);
        exploring = new(this);

    }

    //decides which state for the game to be in
    public void SetState()
    {
        while (1 != 2)
        {
            if (currentState == States.start)
            {
                start.Update();
            }
            else if (currentState == States.exploring)
            {
                exploring.Update();
            }
            else if (currentState == States.decisions)
            {
                decisions.Update();
            }

        }
    }



    //an enum for all the states
    public enum States
    {
        decisions, exploring, start
    }
}