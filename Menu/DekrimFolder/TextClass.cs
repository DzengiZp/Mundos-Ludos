using System;

public abstract class TextEffect
{
    public abstract void DisplayEffect(string message, int durationInMillis, int intervalInMillis);
}

public class BlinkingText : TextEffect
{
    public override void DisplayEffect(string message, int durationInMillis, int intervalInMillis)
    {
        int elapsedTime = 0;

        while (elapsedTime < durationInMillis)
        {
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(intervalInMillis); 

            Console.Clear();
            Thread.Sleep(intervalInMillis); 

            elapsedTime += 2 * intervalInMillis;
        }

        Console.Clear();

    }
}