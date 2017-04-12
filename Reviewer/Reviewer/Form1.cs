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
        public Form1()
        {
            InitializeComponent();

            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);

            textBox1.Text = @"C:\Users\Trent\Desktop\TEmp\Outspoken Panda\Results.csv";

            using(System.IO.StreamReader reader = new System.IO.StreamReader(textBox1.Text))
            {
                int lineNumber = 0;
                string line;
                while((line = reader.ReadLine())!= null)
                {
                    lineNumber++;

                    if (lineNumber == 1)
                    {
                        continue;
                    }

                    if (lineNumber == 2)
                    {
                        var results = line.Split(',').ToList();

                        searchTerm.Text = results[0];
                        title.Text = results[1];
                        category.Text = results[2];
                        bsr.Text = results[3];
                        url.Text = results[4];

                        DisplayWebPage(url.Text); ;

                        break;
                    }
                }
            }
        }

        public void DisplayWebPage(string url)
        {
            webBrowser.Navigate(url);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        // Detect all numeric characters at the form level and consume 1, 
        // 4, and 7. Note that Form.KeyPreview must be set to true for this
        // event handler to be called.
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 10)
            {
                Console.WriteLine("test");
            }
            //if (e.KeyChar >= 48 && e.KeyChar <= 57)
            //{
            //    MessageBox.Show("Form.KeyPress: '" +
            //        e.KeyChar.ToString() + "' pressed.");

            //    switch (e.KeyChar)
            //    {
            //        case (char)49:
            //        case (char)52:
            //        case (char)55:
            //            MessageBox.Show("Form.KeyPress: '" +
            //                e.KeyChar.ToString() + "' consumed.");
            //            e.Handled = true;
            //            break;
            //    }
            //}
        }


    }
}
