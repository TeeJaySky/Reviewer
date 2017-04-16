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
        public struct Record
        {
            public string searchTerm { get; set; }
            public string title { get; set; }
            public string category { get; set; }
            public string bsr { get; set; }
            public string url { get; set; }
            public string imageLocation { get; set; }
            public string result { get; set; }
            public string dateStamp { get; set; }

            public override string ToString()
            {
                return ToCsv(searchTerm, title, category, bsr, url, imageLocation, result, dateStamp);
            }
        }

        public List<Record> Records = new List<Record>();

        public static string ToCsv(params string[] inputs)
        {
            return string.Join(", ", inputs);
        }

        public CsvOutputRecord(List<CsvRecord> records, string res, string date)
        {
            foreach(var record in records)
            {
                Records.Add(new Record
                {
                    searchTerm = record.searchTerm
                    , title = record.title
                    , category = record.category
                    , bsr = record.bsr
                    , url = record.url
                    , imageLocation = record.imageLocation
                    , result = res
                    , dateStamp = date
                });
            }
            
        }

        /// <summary>
        /// Parse the csv input string into the csv record members
        /// </summary>
        /// <param name="csvString"></param>
        public CsvOutputRecord(string csvString)
        {
            var results = csvString.Split(new string[] { ", " }, StringSplitOptions.None).ToList();

            Records.Add(new Record{
                searchTerm = results[0]
                , title = results[1]
                , category = results[2]
                , bsr = results[3]
                , url = results[4]
                , imageLocation = results[5]
                , result = results[6]
                , dateStamp = results[7]
            });
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
                Write(CsvOutputRecord.ToCsv("Search Term", "Title", "Category", "BSR", "URL", "Image Location", "Decision", "Date of decision"));
            }
        }

        /// <summary>
        /// Todo: overwrite a previous decision that was made in the output file
        /// </summary>
        /// <param name="output"></param>
        public void ModifyLine(string output)
        {

        }

        public void Write(CsvOutputRecord record)
        {
            using (var writer = new System.IO.StreamWriter(outputFile, true, System.Text.Encoding.ASCII))
            {
                foreach(var rec in record.Records)
                {
                    writer.WriteLine(rec.ToString());
                }
            }
        }

        /// <summary>
        /// Write to the next line in the output file
        /// </summary>
        /// <param name="output"></param>
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

        public bool RecordHasBeenReviewed(CsvRecord record)
        {
            using (var reader = new System.IO.StreamReader(outputFile))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    CsvOutputRecord lineRecord = new CsvOutputRecord(line);

                    if (record.title == lineRecord.Records.First().title)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
