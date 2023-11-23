namespace TextObjects
{
    internal class TextEffect
    {
        public string Text { get; set; }
        public ConsoleColor Color { get; set; }
        public int Col { get; set; }
        public int Row { get; set; }
        public bool IsInverted { get; set; }
        public Case Case { get; set; }

        public TextEffect(string text, ConsoleColor color, int col, int row, bool isInverted, Case @case)
        {
            Text = text;
            Color = color;
            Col = col;
            Row = row;
            IsInverted = isInverted;
            Case = @case;
        }

        public void SwapInverted()
        {
            IsInverted = !IsInverted;
        }

        public void Double()
        {
            Text += Text;
        }

        public void Flip()
        {
            var col = Col;
            Col = Row;
            Row = col;
        }
        public void Show()
        {
            SetPosition();
            SetColor();
            var text = GetText();
            Console.Write(text);
        }

        private string GetText()
        {
            if (Case == Case.Upper) return Text.ToUpper();
            if (Case == Case.Lower) return Text.ToLower();
            return Text;
        }

        private void SetColor()
        {
            if (IsInverted)
            {
                Console.BackgroundColor = Color;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = Color;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        private void SetPosition()
        {
            Console.CursorLeft = Col;
            Console.CursorTop = Row;
        }
    }
}