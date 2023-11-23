namespace TextObjects
{
    internal class App
    {
        private static TextEffect[] _texts;

        public static void Run()
        {
            _texts = CreateTextEffects();

            while (true)
            {
                Show(_texts);
                Console.WriteLine("Meny: 1) Flip 2) Inverter 3) Slette tekst");
                Console.Write("Hva vil du gjøre? ");
                var cmd = Console.ReadLine();
                if (cmd == "1") Flip();
                else if (cmd == "2") Invert();
                else if (cmd == "3") Delete();
            }
        }

        private static void Delete()
        {
            var textEffect = SelectObject();
            
        }

        private static void Invert()
        {
            var textEffect = SelectObject();
            textEffect.SwapInverted();
        }

        private static void Flip()
        {
            var textEffect = SelectObject();
            textEffect.Flip();
        }

        private static TextEffect SelectObject()
        {
            Console.Write($"Skriv inn indeks 0-{_texts.Length - 1}: ");
            var indexStr = Console.ReadLine();
            var index = Convert.ToInt32(indexStr);
            var textEffect = _texts[index];
            return textEffect;
        }

        private static TextEffect[] CreateTextEffects()
        {
            return new TextEffect[]
            {
                new TextEffect("AAAAA", ConsoleColor.Red, 5, 1, false, Case.Upper),
                new TextEffect("BBB", ConsoleColor.Blue, 4, 2, true, Case.Default),
                new TextEffect("C", ConsoleColor.Green, 3, 3, false, Case.Lower),
            };
        }

        private static void Show(TextEffect[] texts)
        {
            Console.Clear();
            foreach (var text in texts)
            {
                text.Show();
            }
            Console.SetCursorPosition(0,10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
