using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer
{
    public class CsvOutputRecord
    {
        public string searchTerm { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string bsr { get; set; }
        public string url { get; set; }
        public string result { get; set; }
        public string dateStamp { get; set; }

        public static string ToCsv(params string[] inputs)
        {
            return string.Join(", ", inputs);
        }

        public override string ToString()
        {
            return ToCsv(searchTerm, title, category, bsr, url, result, dateStamp);
        }

        public CsvOutputRecord(CsvRecord record, string res, string date)
        {
            searchTerm = record.searchTerm;
            title = record.title;
            category = record.category;
            bsr = record.bsr;
            url = record.url;
            result = res;
            dateStamp = date;
        }

        /// <summary>
        /// Parse the csv input string into the csv record members
        /// </summary>
        /// <param name="csvString"></param>
        public CsvOutputRecord(string csvString)
        {
            var results = csvString.Split(new string[] { ", " }, StringSplitOptions.None).ToList();

            searchTerm = results[0];
            title = results[1];
            category = results[2];
            bsr = results[3];
            url = results[4];
            result = results[5];
            dateStamp = results[6];
        }
    }

    public class CsvWriter
    {
        string outputFile;

        public CsvWriter(string outputFilePath)
        {
            outputFile = outputFilePath;

            IEnumerable<string> lines = new List<string>();
            if(File.Exists(outputFile))
            {
                lines = File.ReadLines(outputFile);
            }

            if(lines.ToList().Count == 0)
            {
                Write(CsvOutputRecord.ToCsv("Search Term", "Title", "Category", "BSR", "URL", "Decision", "Date of decision"));
            }
        }

        public void Write(string output)
        {
            using (var writer = new System.IO.StreamWriter(outputFile, true, System.Text.Encoding.ASCII))
            {
                writer.WriteLine(output);
            }
        }

        public CsvOutputRecord GetLastOutputRecord()
        {
            var lines = File.ReadLines(outputFile);

            if (lines.ToList().Count == 0 || lines.ToList().Count == 1)
            {
                return null;
            }

            string lastRecord = lines.Last();
            return new CsvOutputRecord(lastRecord);
        }
    }
}
