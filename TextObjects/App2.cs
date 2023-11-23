using System.Text.Json;

namespace TextObjects
{
    internal class App2
    {
        private static List<TextEffect> _texts;

        public static void Run()
        {
            _texts = CreateTextEffects();

            while (true)
            {
                Show(_texts);
                Console.WriteLine("Meny: 1) Flip 2) Inverter 3) Slette tekst 4) Legg til 5) Lagre fil 6) Åpne fil");
                Console.Write("Hva vil du gjøre? ");
                var cmd = Console.ReadLine();
                if (cmd == "1") Flip();
                else if (cmd == "2") Invert();
                else if (cmd == "3") Delete();
                else if (cmd == "4") Add();
                else if (cmd == "5") Save();
                else if (cmd == "6") Load();
            }
        }

        private static void Load()
        {
            var json = File.ReadAllText("text.json");
            _texts = JsonSerializer.Deserialize<List<TextEffect>>(json);
        }
        private static void Save()
        {
            var json = JsonSerializer.Serialize(_texts);
            File.WriteAllText("text.json", json);
        }

        private static void Add()
        {
            Console.Write("Skriv en tekst: ");
            var text = Console.ReadLine();
            _texts.Add(new TextEffect(text, ConsoleColor.DarkCyan, 8, 8, false, Case.Default));
        }
        private static void Delete()
        {
            var textEffect = SelectObject();
            _texts.Remove(textEffect);
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
            Console.Write($"Skriv inn indeks 0-{_texts.Count - 1}: ");
            var indexStr = Console.ReadLine();
            var index = Convert.ToInt32(indexStr);
            var textEffect = _texts[index];
            return textEffect;
        }

        private static List<TextEffect> CreateTextEffects()
        {
            return new List<TextEffect>
            {
                new TextEffect("AAAAA", ConsoleColor.Red, 5, 1, false, Case.Upper),
                new TextEffect("C", ConsoleColor.Green, 3, 3, false, Case.Lower),
                new TextEffect("BBB", ConsoleColor.Blue, 4, 2, true, Case.Default),
            };
        }

        private static void Show(List<TextEffect> texts)
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
