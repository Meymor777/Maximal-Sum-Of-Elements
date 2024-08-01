using MaximalSumOfElements.BL;

namespace MaximalSumOfElements.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine("Enter file name:");
                Console.WriteLine(arg);
                Console.WriteLine();
                var result = BL.MaximalSumOfElements.ProcessFile(arg);
                PaintResultInConsole(result);
            }
            while (true)
            {
                Console.WriteLine("Enter file name:");
                var fileName = Console.ReadLine();
                Console.WriteLine();
                var result = BL.MaximalSumOfElements.ProcessFile(fileName);
                PaintResultInConsole(result);
            }
        }

        public static void PaintResultInConsole(ResultMaximalSumOfElements resultMaximalSumOfElements)
        {
            if (resultMaximalSumOfElements.HaveError)
            {
                Console.WriteLine(resultMaximalSumOfElements.ErrorMessage);
                Console.WriteLine();
                return;
            }
            var maxLineLength = resultMaximalSumOfElements.ListOfFileStrings.Max(line => line.Line.Length);
            var sizeLineNumber = resultMaximalSumOfElements.ListOfFileStrings.Count.ToString().Length;
            var sizeSum = resultMaximalSumOfElements.MaximalSumOfElements.ToString().Length;

            Console.WriteLine("File text:");
            foreach (var line in resultMaximalSumOfElements.ListOfFileStrings)
            {
                Console.Write("(");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(line.LineNumber.ToString().PadLeft(sizeLineNumber));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(") - [{0}] -> (", line.Line.PadRight(maxLineLength));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(line.SumElements.ToString().PadLeft(sizeSum));
                Console.ForegroundColor = ConsoleColor.White;

                if (line.HaveError)
                {
                    Console.WriteLine(") Error");
                }
                else
                {
                    Console.WriteLine(")");
                }
            }
            Console.WriteLine();

            Console.Write("Maximal sum of elements - ");
            foreach (var line in resultMaximalSumOfElements.ListMaximalSum)
            {
                Console.Write("(");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(line.LineNumber.ToString().PadLeft(sizeLineNumber));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(") ");
            }


            Console.Write("-> (");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(resultMaximalSumOfElements.MaximalSumOfElements);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(")");
            Console.WriteLine();
        }
    }
}
