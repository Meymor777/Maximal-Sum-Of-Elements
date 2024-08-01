namespace MaximalSumOfElements.BL
{
    public class ResultMaximalSumOfElements
    {
        public readonly int MaximalSumOfElements;
        public readonly List<int> ListNumbersOfMaximalSumLines;
        public readonly List<TextFileLine> ListOfFileStrings;
        public readonly List<TextFileLine> ListMaximalSum;
        public readonly bool HaveError;
        public readonly string ErrorMessage;

        public ResultMaximalSumOfElements(string errorMessage)
        {
            MaximalSumOfElements = 0;
            ListNumbersOfMaximalSumLines = new List<int>();
            HaveError = true;
            ListOfFileStrings = new List<TextFileLine>();
            ListMaximalSum = new List<TextFileLine>();
            ErrorMessage = errorMessage;
        }

        public ResultMaximalSumOfElements(List<TextFileLine> listOfFileStrings)
        {
            ListOfFileStrings = listOfFileStrings.ToList();
            var listWithoutErrors = ListOfFileStrings.Where(line => !line.HaveError).ToList();
            if (listWithoutErrors.Count > 0)
            {
                MaximalSumOfElements = listWithoutErrors.Max(line => line.SumElements);
                ListMaximalSum = listWithoutErrors.Where(line => line.SumElements == MaximalSumOfElements).ToList();
            }
            else
            {
                MaximalSumOfElements = 0;
                ListMaximalSum = new List<TextFileLine>();
            }
            HaveError = false;
            ListNumbersOfMaximalSumLines = ListMaximalSum.Select(line => line.LineNumber).ToList();
            ErrorMessage = "";
        }
    }
}
