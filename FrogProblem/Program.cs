namespace AlgoProblem;
public class Program
{
    public static int Solution(int startPosition, int stopPosition, int jumpDistance)
    {
        int distance = stopPosition - startPosition;
        int jumps = distance / jumpDistance;
        if (distance % jumpDistance != 0)
        {
            jumps++;
        }
        return jumps;
    }
    public static int getNum(string sentence)
    {
        int num;
        Console.WriteLine($"Enter the valid value for {sentence}");
        if (int.TryParse(Console.ReadLine(), out num) && num >= 0) { }
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
        while (end < start)
        {
            Console.WriteLine("Enter Destination greater than or equal to Starting Point");
            end = getNum("Ending point");
        }
        int jump = 0;
        while (jump <= 0)
        {
            jump = getNum("Jump distance");
        }
        Console.WriteLine($"\n \n \nThe frog need to jump {Solution(start, end, jump)} times to reach the destination.");
        Console.ReadLine();
    }
}