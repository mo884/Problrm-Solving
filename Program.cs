
namespace Max_distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Size: ");
            int size = 0;
            int.TryParse(Console.ReadLine(), out size);

            Dictionary<int, int> taken = new Dictionary<int, int>();
            int maxDistance = 0, maxNumber = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Number: ");
                int num = 0;
                int.TryParse(Console.ReadLine(), out num);
                if (taken.ContainsKey(num) == false)
                {
                    taken.Add(num, i);
                }
                else
                {
                    int segmentLength = i - taken[num];
                    if (segmentLength > maxDistance)
                    {
                        maxDistance = segmentLength;
                        maxNumber = num;
                    }
                    else if (segmentLength == maxDistance)
                    {
                        maxNumber = Math.Max(maxNumber, num);
                    }
                }
            }
            Console.WriteLine($"Maximum distance = {maxDistance} occured by number {maxNumber} at index [{taken[maxNumber]+1}, {maxDistance+1}]");
        }
    }
}
