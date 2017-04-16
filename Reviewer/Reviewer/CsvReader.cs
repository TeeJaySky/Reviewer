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
        public string imageLocation { get; set; }

        public CsvRecord(string currentTerm, string currentTitle, string currentCategory, string currentBsr, string currentUrl, string imageLoc)
        {
            searchTerm = currentTerm;
            title = currentTitle;
            category = currentCategory;
            bsr = currentBsr;
            url = currentUrl;
            imageLocation = imageLoc;
        }

        /// <summary>
        /// Parse the csv input string into the csv record members
        /// </summary>
        /// <param name="csvString"></param>
        public CsvRecord(string csvString)
        {
            var results = csvString.Split(new string[] {","}, StringSplitOptions.None).ToList();

            searchTerm = results[0];
            title = results[1];
            category = results[2];
            bsr = results[3];
            url = results[4];
            imageLocation = results[5];
        }

        public static implicit operator CsvRecord(CsvOutputRecord.Record outputRecord)
        {
            return new CsvRecord(outputRecord);
        }

        public CsvRecord(CsvOutputRecord.Record outputRecord)
        {
            searchTerm = outputRecord.searchTerm;
            title = outputRecord.title;
            category = outputRecord.category;
            bsr = outputRecord.bsr;
            url = outputRecord.url;
            imageLocation = outputRecord.imageLocation;
        }

        public override bool Equals(System.Object test)
        {
            CsvRecord record = (CsvRecord)test;
            return
                bsr == record.bsr
                && searchTerm == record.searchTerm
                && url == record.url
                && imageLocation == record.imageLocation
                && category == record.category
                && title == record.title
                ;
        }
    }

    public class CsvReader
    {
        System.IO.StreamReader reader;
        string FileName;

        /// <summary>
        /// Start reading from the beginning of a file
        /// </summary>
        /// <param name="fileName"></param>
        public CsvReader(string fileName)
        {
            FileName = fileName;
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
            FileName = fileName;
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

        public List<CsvRecord> GetAllRecords(CsvRecord record)
        {
            List<CsvRecord> matchingRecords = new List<CsvRecord>();
            // Look through the file for all other records that match the url
            using (var tempReader = new System.IO.StreamReader(FileName))
            {
                string line;
                while ((line = tempReader.ReadLine()) != null)
                {
                    CsvRecord currentLine = new CsvRecord(line);

                    if(currentLine.url == record.url)
                    {
                        matchingRecords.Add(currentLine);
                    }
                }
            }

            return matchingRecords;
        }

        public List<CsvRecord> GetNextRecords()
        {
            var result = reader.ReadLine();
            if (result != null)
            {
                return GetAllRecords(new CsvRecord(result));
            }
            else
            {
                return null;
            }
        }
    }
}
