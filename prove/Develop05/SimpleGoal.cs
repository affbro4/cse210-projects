class SimpleGoal : BaseGoal
{


    public SimpleGoal(string name, string description, int points, bool complete, string goalType)
    : base(name, description, points, complete, goalType)
    {
    }
    public SimpleGoal() : base("Simple Goal")
    {
        
    }

    public override int RecordEvent()
    {

        // TODO !!!!!!
        return 0;
    }

}