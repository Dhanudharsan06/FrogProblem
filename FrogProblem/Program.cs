namespace FrogProblem;
public class Program
{
    public static int Solution(int startPosition, int stopPosition, int jumpDistance)
    {
        int distance = stopPosition - startPosition;
        int jumps = (int)Math.Ceiling((double)distance / jumpDistance);
        return jumps;
    }
    public static int getNum(string sentence)
    {
        int num;

        Console.WriteLine($"Enter the valid value for {sentence}");

        if (int.TryParse(Console.ReadLine(), out num) && num >= 0) 
        { 
        }
        else
        {

            num = getNum(sentence);
        }

        return num;
    }
    public static void Main(string[] args)
    {
        int start = getNum("Starting point");
        int end = -1;
        int jump = 0;

        while (end < start)
        {
            Console.WriteLine("Enter Destination greater than or equal to Starting Point");
            end = getNum("Ending point");
        }

        while (jump <= 0)
        {
            jump = getNum("Jump distance");
        }

        int jumpCount= Solution(start, end, jump);

        Console.WriteLine($"\n \n \nThe frog need to jump {jumpCount} times to reach the destination.");
        Console.ReadLine();
 
    }
}