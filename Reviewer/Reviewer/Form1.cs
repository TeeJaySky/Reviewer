using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reviewer
{
    public partial class Form1 : Form
    {
        CsvReader reader;
        CsvWriter writer;

        List<CsvRecord> currentRecords;
        List<Task> buttonClickTasks = new List<Task>();

        const bool ContinueFromLastProduct = false;
        const string InputFilePath = @"C:\Users\Trent\Desktop\TEmp\Outspoken Panda\ResultsSorted.csv";
        const string OutputFilePath = @"C:\Users\Trent\Desktop\TEmp\Outspoken Panda\ParsedResults.csv";

        public Form1()
        {
            InitializeComponent();

            // Create the writer which will output the decisions made
            writer = new CsvWriter(OutputFilePath);

            var lastReviewedRecord = writer.GetLastOutputRecord();
            if (ContinueFromLastProduct && lastReviewedRecord != null)
            {
                // Read from the last product that was reviewed
                reader = new CsvReader(InputFilePath, lastReviewedRecord.Records.First());
            }
            else
            {
                // Read from the beginning of input file
                reader = new CsvReader(InputFilePath);
            }

            DisplayNextResult();
        }

        public void DisplayNextResult()
        {
            bool keepSearchingForRecord = true;
            while(keepSearchingForRecord)
            {
                currentRecords = reader.GetNextRecords();

                if(currentRecords != null)
                {
                    keepSearchingForRecord = writer.RecordHasBeenReviewed(currentRecords.First());
                }
                else
                {
                    keepSearchingForRecord = false;
                }
            }

            if (currentRecords != null)
            {
                // Do not load the webpage by default to make the review process faster
                //webBrowser.Navigate(currentRecords.First().url);
                bsr.Text = currentRecords.First().bsr;
                searchTerm.Text = currentRecords.First().searchTerm;
                category.Text = currentRecords.First().category;
                title.Text = currentRecords.First().title;
                ProductImage.ImageLocation = currentRecords.First().imageLocation;
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        public void CopyImageToFolder(string result)
        {
            // Move the image to the yes subfolder
            var path = Path.GetDirectoryName(currentRecords.First().imageLocation);
            var fileName = Path.GetFileName(currentRecords.First().imageLocation);

            var newPath = Path.Combine(path, result);

            System.IO.Directory.CreateDirectory(newPath);

            string newFilePath = Path.Combine(newPath, fileName);
            if(File.Exists(currentRecords.First().imageLocation))
            {
                File.Move(currentRecords.First().imageLocation, newFilePath);
            }
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            if (currentRecords != null)
            {
                // Write the output record to the file synchronously
                string result = "Yes";
                CsvOutputRecord outputRecord = new CsvOutputRecord(currentRecords, result, DateTime.Now.ToString());
                writer.Write(outputRecord);

                // Asynchronously copy the file to the new folder
                var task = Task.Factory.StartNew(() => {
                    CopyImageToFolder(result);
                });

                buttonClickTasks.Add(task);

                DisplayNextResult();
            }
        }

        private void MaybeButton_Click(object sender, EventArgs e)
        {
            if (currentRecords != null)
            {
                // Write the output record to the file synchronously
                string result = "Maybe";
                CsvOutputRecord outputRecord = new CsvOutputRecord(currentRecords, result, DateTime.Now.ToString());
                writer.Write(outputRecord);

                // Asynchronously copy the file to the new folder
                var task = Task.Factory.StartNew(() =>
                {
                    CopyImageToFolder(result);
                });

                buttonClickTasks.Add(task);

                DisplayNextResult();
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            if (currentRecords != null)
            {
                // Write the output record to the file synchronously
                string result = "No";
                CsvOutputRecord outputRecord = new CsvOutputRecord(currentRecords, result, DateTime.Now.ToString());
                writer.Write(outputRecord);

                // Asynchronously copy the file to the new folder
                var task = Task.Factory.StartNew(() =>
                {
                    CopyImageToFolder(result);
                });

                buttonClickTasks.Add(task);

                DisplayNextResult();
            }
        }

        private void LoadWebpage_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(currentRecords.First().url);
        }
    }
}
