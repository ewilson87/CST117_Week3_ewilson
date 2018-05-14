/**
 * Program: Project 3: Text file reader/formatter
 * File: TextFileProcessor.cs
 * Summary: Basic windows form that opens a text file, and does different processing aspects to it and allows save to new file.
 * Author: Evan Wilson
 * Date: May 10th, 2018
 **/

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Week3_Project3
{
    public partial class TextFileProcessor : Form
    {
        private String[] words;
        public TextFileProcessor()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text | *.txt | Word | *.doc";
            saveFileDialog.FileName = "Converted Text File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);

                streamWriter.Write("Original Text \r\n");
                foreach (string word in words)
                {
                    streamWriter.Write(word + " ");
                }
                streamWriter.Write("\r\n\r\n" + lowerCaseTextBox.Text + "\r\n\r\n" + firstAndLastTextBox.Text + "\r\n\r\n" + longestTextBox.Text +
                                   "\r\n\r\n" + mostVowelsTextBox.Text);

                streamWriter.Dispose();
            }
        }

        private void browseButton_Click_1(object sender, EventArgs e)
        {
            //creates OpenFileDialog and allows user to only select .txt files
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open a text file";
            openFileDialog.Filter = "Text | *.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //creates StreamReader and reads each word into a string array using a space as the delimiter
                StreamReader streamReader = new StreamReader(File.OpenRead(openFileDialog.FileName));
                words = streamReader.ReadToEnd().Split(' ');
                lowerCaseTextBox.Text = "The file read as all lower case is: \r\n\r\n";

                //char[] delimiters = new char[] {'.', ',', '!', '?'};

                //char array for vowels
                char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                //declarations
                String longestWord = "";
                String mostVowels = "";
                int mostVowelsInt = 0;
                int i = 0;
                foreach (String word in words)
                {
                    //changes all words to lower case                   
                    lowerCaseTextBox.Text = lowerCaseTextBox.Text + words[i].ToLower() + " ";

                    //removes special characters before determining length used in longest word calculation
                    if (word.Contains('.') | word.Contains(',') | word.Contains('!') |
                        word.Contains('?'))
                    {
                        words[i] = words[i].Remove(words[i].Length - 1);
                    }

                    //sets longest word
                    if (words[i].Length > longestWord.Length)
                    {
                        longestWord = words[i];
                    }

                    //sets word with most vowels
                    int numberOfVowels = 0;
                    char[] eachWordAsChars = word.ToCharArray();
                    foreach (char character in eachWordAsChars)
                    {
                        if (vowels.Contains(character))
                        {
                            numberOfVowels++;
                        }
                    }
                    if (numberOfVowels > mostVowelsInt)
                    {
                        mostVowels = words[i];
                        mostVowelsInt = numberOfVowels;
                    }

                    i++;
                }

                //creates a new array based on words and sorts alphabetically and takes first and last element
                String[] sortedStrings = new string[words.Length];
                int j = 0;
                foreach (string tempWord in words)
                {
                    sortedStrings[j] = tempWord;
                    j++;
                }
                Array.Sort(sortedStrings);

                //sets textBoxes text
                firstAndLastTextBox.Text = "First word alphabetically: " + sortedStrings.First() + "\r\nLast word alphabetically: " + sortedStrings.Last();
                longestTextBox.Text = "The longest word is: " + longestWord;
                mostVowelsTextBox.Text = "The word with the most vowels is: " + mostVowels;

                //closes streamreader
                streamReader.Dispose(); ;
                saveAsButton.Enabled = true;
            }
        }
    }
}
