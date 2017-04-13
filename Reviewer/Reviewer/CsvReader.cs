using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer
{
    public class CsvRecord
    {
        public string searchTerm { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string bsr { get; set; }
        public string url { get; set; }

        public CsvRecord(string currentTerm, string currentTitle, string currentCategory, string currentBsr, string currentUrl)
        {
            searchTerm = currentTerm;
            title = currentTitle;
            category = currentCategory;
            bsr = currentBsr;
            url = currentUrl;
        }

        /// <summary>
        /// Parse the csv input string into the csv record members
        /// </summary>
        /// <param name="csvString"></param>
        public CsvRecord(string csvString)
        {
            var results = csvString.Split(new string[] {", "}, StringSplitOptions.None).ToList();

            searchTerm = results[0];
            title = results[1];
            category = results[2];
            bsr = results[3];
            url = results[4];
        }

        public static implicit operator CsvRecord(CsvOutputRecord outputRecord)
        {
            return new CsvRecord(outputRecord);
        }

        public CsvRecord(CsvOutputRecord outputRecord)
        {
            searchTerm = outputRecord.searchTerm;
            title = outputRecord.title;
            category = outputRecord.category;
            bsr = outputRecord.bsr;
            url = outputRecord.url;
        }

        public override bool Equals(System.Object test)
        {
            CsvRecord record = (CsvRecord)test;
            return
                bsr == record.bsr
                && searchTerm == record.searchTerm
                && url == record.url
                && category == record.category
                && title == record.title
                ;
        }
    }

    public class CsvReader
    {
        System.IO.StreamReader reader;

        /// <summary>
        /// Start reading from the beginning of a file
        /// </summary>
        /// <param name="fileName"></param>
        public CsvReader(string fileName)
        {
            reader = new System.IO.StreamReader(fileName);
            string headers = reader.ReadLine();
        }

        /// <summary>
        /// Read the line after the last record from the specified file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="lastRecord"></param>
        public CsvReader(string fileName, CsvRecord lastRecord)
        {
            reader = new System.IO.StreamReader(fileName);
            string headers = reader.ReadLine();

            bool foundLastLine = false;
            string line = reader.ReadLine();
            while(!foundLastLine && line != null)
            {
                CsvRecord currentLine = new CsvRecord(line);

                // Stop searching if we have found the last record
                if (currentLine.Equals(lastRecord))
                {
                    break;
                }

                // Move to the next line
                line = reader.ReadLine();
            }
        }

        ~CsvReader()
        {
            reader.Close();
        }

        public CsvRecord GetNextRecord()
        {
            var result = reader.ReadLine();
            if (result != null)
            {
                return new CsvRecord(result);
            }
            else
            {
                return null;
            }
        }
    }
}
