class BreathingActivity : BaseActivity
{

    public BreathingActivity() : base ()
    {
    }

    public void RunActivity()
    {
        // call StartActivity() Method

        RunCountDownMessage("Get Ready", 5);
        StartTimer();
       // DateTime endTime = DateTime.Now.AddSeconds(20); // delete later 
        //while (DateTime.Now < endTime)
        while(! HasTimerExpired()) 
        {   
            RunCountDownMessage("Breath In", 4);
            RunCountDownMessage("Breath Out", 6);
        }

        // CALL EndActivity()


    }
}