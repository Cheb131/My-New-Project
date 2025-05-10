using System;

public class StopWatch
{
    private int _starTime;
    public int starTime
    {
        get { return _starTime; }
        set { _starTime = value; }
    }
    private int _endTime;
    public int endTime
    {
        get { return _endTime; }
        set { _endTime = value; }
    }
    public StopWatch()
    {
        starTime = 0;
        endTime = 0;
    }
    public void Start()
    {
        starTime = DateTime.Now.Millisecond;
    }
    public void Stop()
    {
        endTime = DateTime.Now.Millisecond;
    }
    public int GetElapsedTime()
    {
        return endTime - starTime;
    }
    public static void Main()
    {
        StopWatch stopWatch = new StopWatch();
        stopWatch.Start();
        for (int i = 0; i <= 100000; i++)
        {
            Console.WriteLine(i);
        }
        stopWatch.Stop();
        Console.WriteLine("Elapsed Time: " + stopWatch.GetElapsedTime());
    }
}
