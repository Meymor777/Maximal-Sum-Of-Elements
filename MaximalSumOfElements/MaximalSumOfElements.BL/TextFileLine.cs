namespace MaximalSumOfElements.BL
{
    public class TextFileLine
    {
        public readonly string Line;
        public readonly int LineNumber;
        public readonly int SumElements;
        public readonly bool HaveError;

        public TextFileLine(string line, int lineNumber)
        {
            Line = line;
            LineNumber = lineNumber;
            var numbers = Line.Split('.', ',', '_');
            foreach (var number in numbers)
            {
                if (Int32.TryParse(number, out var value))
                {
                    SumElements += value;
                }
                else
                {
                    HaveError = true;
                    SumElements = 0;
                    break;
                }
            }
            LineNumber = lineNumber;
        }
    }
}
