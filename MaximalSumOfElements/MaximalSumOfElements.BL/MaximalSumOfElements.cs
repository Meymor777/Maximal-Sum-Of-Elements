namespace MaximalSumOfElements.BL
{
    public static class MaximalSumOfElements
    {
        public static ResultMaximalSumOfElements ProcessFile(string fileName)
        {
            if (fileName == null)
            {
                return new ResultMaximalSumOfElements("File name is empty!");
            }

            var fileInfo = new FileInfo(fileName);      
            if (!fileInfo.Exists)
            {
                return new ResultMaximalSumOfElements("File does not exist!");
            }
            else if (fileInfo.Extension != ".txt")
            {
                return new ResultMaximalSumOfElements("File is not .txt!");
            }
            else if (fileInfo.Length == 0)
            {
                return new ResultMaximalSumOfElements("File is empty!");
            }

            var listOfFileStrings = new List<TextFileLine>();
            // Open the stream and read it back.
            using (var streamReader = File.OpenText(fileName))
            {
                var textString = "";
                while ((textString = streamReader.ReadLine()) != null)
                {
                    listOfFileStrings.Add(new TextFileLine(textString.Replace(" ", ""), listOfFileStrings.Count + 1));
                }
            }   

            return new ResultMaximalSumOfElements(listOfFileStrings);
        }
    }
}
