namespace TextObjects
{
    internal class FlexibleListDemo
    {
        public static void Run()
        {
            var list = new FlexibleList2<int>();
            while (true)
            {
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                list.Add(number);
                list.Show();
            }
        }

        public static void Run2()
        {
            var list = new FlexibleList();
            while (true)
            {
                var text = Console.ReadLine();
                list.Add(text);
                list.Show();
            }
        }

        public static void Run3()
        {
            var strings = new string[4];
            var count = 0;
            while (true)
            {
                var text = Console.ReadLine();
                if (count == strings.Length)
                {
                    var strings2 = new string[strings.Length * 2];
                    Array.Copy(strings, strings2, strings.Length);
                    strings = strings2;
                }
                strings[count] = text;
                count++;

                for (var i = 0; i < strings.Length; i++)
                {
                    Console.WriteLine($"index: {i} verdi: {strings[i] ?? "(null)"}");
                }
            }
        }
    }
}
