namespace TextObjects
{
    internal class FlexibleList
    {
        string[] strings = new string[4];
        int count = 0;

        public void Add(string text)
        {
            if (count == strings.Length)
            {
                var strings2 = new string[strings.Length * 2];
                Array.Copy(strings, strings2, strings.Length);
                strings = strings2;
            }
            strings[count] = text;
            count++;
        }

        public void Show()
        {
            for (var i = 0; i < strings.Length; i++)
            {
                Console.WriteLine($"index: {i} verdi: {strings[i] ?? "(null)"}");
            }
        }
    }
}
