using System;

class Program
{
    static void Main(string[] args)
    {
    //     BaseActivity activity =new BaseActivity();
        
    //    // activity.RunCountDownMessage("Get ready", 5);
    //     activity.RunSpinnerMessage("Well done", 5);
    //     DateTime endTime = DateTime.Now.AddSeconds(15);

        BreathingActivity breathingActivity = new BreathingActivity();
        
        breathingActivity.RunActivity();
    }
}