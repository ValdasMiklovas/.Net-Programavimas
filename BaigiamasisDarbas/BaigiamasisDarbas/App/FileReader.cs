using System.Collections.Generic;
using System.IO;


namespace BaigiamasisDarbas.App
{
    public class FileReader
    {
        public List<string[]> CsvReader(string csvFile)
        {
            using (var reader = new StreamReader(csvFile))
            {
                List<string[]> csvValue = new List<string[]>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    csvValue.Add(values);
                }
                return csvValue;
            }
        }
    }
}
