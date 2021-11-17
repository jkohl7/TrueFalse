using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrueFalse
{
    public partial class MainPage : ContentPage
    {
        private static string[] questions = new string[]
        {
            "Do pigs exist?",
            "Do cows exist?",
            "Do unicorns exist?",
            "Do fish exist?",
            "Do jackalope exist?",
        };

        private static bool[] answers = new bool[]
        {
            true,
            true,
            false,
            true,
            false
        };
        private int score = 0;
        private int counter = 0;

        public MainPage()
        {
            InitializeComponent();
            outlabel.Text = questions[counter];
        }

        private void nextQuestion()
        {
            counter++;
            outlabel.Text = questions[counter];
        }

  

        private void onTrueClick(object user, EventArgs e)
        {
            if (answers[counter])
            {
                score++;
            }
            if (counter <=3)
            {
                nextQuestion();
            }
            else
            {
                endQuiz();
            }
        }

        private void onFalseClick(object user, EventArgs e)
        {
            if (!answers[counter])
            {
                score++;
            }
            if (counter <= 3)
            {
                nextQuestion();
            }
            else
            {
                endQuiz();
            }
        }


        private void endQuiz()
        {
            outlabel.Text = "Quiz has ended, your score was " + score;
            trueButton.IsEnabled = false;
            falseButton.IsEnabled = false;
        }
    }
}
