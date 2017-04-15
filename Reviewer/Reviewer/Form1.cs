using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        const bool ContinueFromLastProduct = true;
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
                keepSearchingForRecord = writer.RecordHasBeenReviewed(currentRecords.First());
            }

            if (currentRecords != null)
            {
                webBrowser.Navigate(currentRecords.First().url);
                bsr.Text = currentRecords.First().bsr;
                searchTerm.Text = currentRecords.First().searchTerm;
                category.Text = currentRecords.First().category;
                title.Text = currentRecords.First().title;
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            CsvOutputRecord outputRecord = new CsvOutputRecord(currentRecords, "Yes", DateTime.Now.ToString());
            writer.Write(outputRecord);

            DisplayNextResult();
        }

        private void MaybeButton_Click(object sender, EventArgs e)
        {
            CsvOutputRecord outputRecord = new CsvOutputRecord(currentRecords, "Maybe", DateTime.Now.ToString());
            writer.Write(outputRecord);

            DisplayNextResult();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            CsvOutputRecord outputRecord = new CsvOutputRecord(currentRecords, "No", DateTime.Now.ToString());
            writer.Write(outputRecord);
            
            DisplayNextResult();
        }

    }
}
