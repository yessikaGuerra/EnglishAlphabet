using System.Text;

namespace AlphabetForm
{
    public partial class AlphabetForm : Form
    {
        private const string TooManyCharMsg = "Too many characters entered, maximum allowed is 256." +
            "\nPlease delete some characters.";

        private const string EnglishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public AlphabetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 256)
            {
                ResultsLabel.Text = TooManyCharMsg;
                ResultsLabel.Visible = true;
            }
            else
            {
                ResultsLabel.Text = DisplayDesiredAlphabetLetters(textBox1.Text);
                ResultsLabel.Visible = true;
            }
        }

        private string DisplayDesiredAlphabetLetters(string text)
        {
            char[] charsToExclude = text.ToUpper().ToCharArray();
            char[] alphabetChars = EnglishAlphabet.ToCharArray();
            var resultStrBuild = new StringBuilder("Letters: ");
            int lettersCount = 0;

            if (charsToExclude.Length == 0)
            {
                resultStrBuild.Append(EnglishAlphabet +
                    $"\nTotal Letters displayed: {EnglishAlphabet.Length}");

                return resultStrBuild.ToString();
            }

            foreach (char aC in alphabetChars)
            {              
                bool match = false;
                
                foreach (char c in charsToExclude)
                {
                    if (c == aC)
                    {
                        match = true;
                        break;
                    }
                }

                if (!match)
                {
                    resultStrBuild.Append(aC);
                    lettersCount++;
                }
            }

            resultStrBuild.AppendLine($"\nTotal Letters displayed: {lettersCount}");

            return resultStrBuild.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ResultsLabel.Visible = false;
        }
    }
}