/**
 * Program: Exercise 5: Pi aprroximator
 * File: ApproximatePi.cs
 * Summary: Basic windows form that approximates Pi up to 10,000,000 terms
 * Author: Evan Wilson
 * Date: May 10th, 2018
 **/

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Week3_Exercise5
{
    public partial class ApproximatePi : Form
    {
        //array to store all values of pi uo to 10000000 (larger values start taking too much processing time, so this program is limited in this factor
        private readonly decimal[] piArray = new decimal[10000001];

        public ApproximatePi()
        {
            InitializeComponent();
            //Stopwatch sw = Stopwatch.StartNew();
            calculatePi();
            //sw.Stop();
            //MessageBox.Show(sw.ElapsedMilliseconds.ToString());
        }

        private void termsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Loads all values of pi up to 10000000 into an array at launch of program to reduce run time calculations
        private void calculatePi()
        {
            decimal answer = 4;
            piArray[0] = 4;
            decimal fractionTerm = 3;
            int count = 1;            
            while (count < piArray.Length)
            {
                //odd numbers terms
                answer -= (4 / fractionTerm);
                piArray[count] = answer;
                count++;
                fractionTerm += 2;
                //even numbered terms
                answer += (4 / fractionTerm);
                piArray[count] = answer;
                count++;
                fractionTerm += 2;
            }

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //sets piLabel text
            int terms;
            if (int.TryParse(termsTextBox.Text, out terms))
            {
                if (terms < 0)
                {
                    //prevents negative numbers
                    MessageBox.Show("You can only enter positive whole numbers!");
                    termsTextBox.Text = "";
                    piAnswerLabel.Text = "";
                }
                else
                {
                    //sets piAnswer text
                    piLabel.Text = "Approximate value of Pi after " + terms.ToString("n0") + " terms";                    
                    piAnswerLabel.Text = "= " + piArray[terms];
                }
            }
            else
            {
                MessageBox.Show("You can only enter positive whole numbers!");
                termsTextBox.Text = "";
                piAnswerLabel.Text = "";

            }
        }

        private void ApproximatePi_Load(object sender, EventArgs e)
        {

        }
    }
}
