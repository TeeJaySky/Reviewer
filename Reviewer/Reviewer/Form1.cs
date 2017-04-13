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

        CsvRecord currentRecord;

        const bool ContinueFromLastProduct = true;
        const string InputFilePath = @"C:\Users\Trent\Desktop\TEmp\Outspoken Panda\Results.csv";
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
                reader = new CsvReader(InputFilePath, lastReviewedRecord);
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
            // Initialise the page with the first result
            currentRecord = reader.GetNextRecord();
            if (currentRecord != null)
            {
                webBrowser.Navigate(currentRecord.url);
                bsr.Text = currentRecord.bsr;
                searchTerm.Text = currentRecord.searchTerm;
                category.Text = currentRecord.category;
                title.Text = currentRecord.title;
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            CsvOutputRecord outputRecord = new CsvOutputRecord(currentRecord, "Yes", DateTime.Now.ToString());
            writer.Write(outputRecord.ToString());

            DisplayNextResult();
        }

        private void MaybeButton_Click(object sender, EventArgs e)
        {
            CsvOutputRecord outputRecord = new CsvOutputRecord(currentRecord, "Maybe", DateTime.Now.ToString());
            writer.Write(outputRecord.ToString());

            DisplayNextResult();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            CsvOutputRecord outputRecord = new CsvOutputRecord(currentRecord, "No", DateTime.Now.ToString());
            writer.Write(outputRecord.ToString());
            
            DisplayNextResult();
        }

    }
}
