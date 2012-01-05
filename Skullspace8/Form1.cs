using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Skullspace8
{
    public partial class Form1 : Form
    {
        private bool _hasPosted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skullspaceWebBrowser.Navigate("http://www.skullspace.net/2011/08-batman/herecomes9.php");

        }

        private void skullspaceWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Find the number to set
            if (skullspaceWebBrowser.Document != null)
            {
                if (!_hasPosted)
                {
                    HtmlElementCollection strong = skullspaceWebBrowser.Document.GetElementsByTagName("strong");
                    string strongText = strong[0].InnerText;
                    string numberString = strongText.Substring(16, strongText.IndexOf(' ', 16) - 16);
                    sequenceNumberLabel.Text = numberString;
                    int number = Convert.ToInt32(numberString);

                    HtmlElementCollection inputs = skullspaceWebBrowser.Document.GetElementsByTagName("input");

                    HtmlElement answerInput = inputs.Cast<HtmlElement>().Single(input => input.Name == "answer");
                    HtmlElement submitButton = inputs.Cast<HtmlElement>().Single(input => input.OuterHtml.Contains("Answer"));

                    Debug.Assert(answerInput != null);

                    answerInput.InnerText = Fibonacci(number).ToString();
                    submitButton.InvokeMember("click");
                    _hasPosted = true; 
                }
                else
                {
                    // since we have posted, search for the phrase "The next level is". If not found, re-post
                    HtmlElementCollection spans = skullspaceWebBrowser.Document.GetElementsByTagName("span");
                    if (spans.Count == 0 || !spans[0].InnerHtml.Contains("The next level is "))
                    {
                        _hasPosted = false;
                        skullspaceWebBrowser.Navigate("http://www.skullspace.net/2011/08-batman/herecomes9.php");
                    }
                }
            }
        }

        //recursive
        //public int Fibonacci(int n)
        //{
        //    if (n == 0 || n == 1)
        //        return n;

        //    return Fibonacci(n - 1) + Fibonacci(n - 2);
        //}

        //iterative
        public static double Fibonacci(int n)
        {
            double a = 0;
            double b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
