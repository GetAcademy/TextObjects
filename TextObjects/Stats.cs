namespace TextObjects
{
    internal class Stats
    {
        public int NumberCount;
        public int Sum;
        public int Max;
        public int Min;

        public Stats(int numberCount, int sum, int max, int min)
        {
            NumberCount = numberCount;
            Sum = sum;
            Max = max;
            Min = min;
        }

        public void Show()
        {
            Console.WriteLine($"Ant: {NumberCount}");
            Console.WriteLine($"Sum: {Sum}");
            Console.WriteLine($"Max: {Max}");
            Console.WriteLine($"Min: {Min}");
            Console.WriteLine();
        }
    }
}
