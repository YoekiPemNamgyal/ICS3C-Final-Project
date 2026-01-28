using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS3C_Final_Project
{
    public partial class GameForm : Form
    {
        // Array that stores the correct words
        string[] words = { "KNOWLEDGE", "ADVENTURE", "MYSTERIOUS" };

        // Array that stores hints for each word
        string[] hints =
        {
            "Something you gain by studying",
            "An exciting experience or journey",
            "Something difficult to explain or understand"
        };

        // Keeps track of the current question number
        int currentIndex = 0;

        // Stores the player's score
        int score = 0;

        // Stores the remaining time for each question
        int timeLeft = 30;

        // Random object used to scramble words
        Random rnd = new Random();

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Load the first question when the game form opens
            LoadQuestion();
        }

        // Load a new question
        private void LoadQuestion()
        {
            // Check if all questions have been completed
            if (currentIndex >= words.Length)
            {
                // Stop the timer
                QuizTimer.Stop();

                // Open the Score Form and pass the final score
                ScoreForm scoreForm = new ScoreForm(score);
                scoreForm.Show();

                // Hide the game form
                this.Hide();
                return;
            }

            // Display the scrambled word
            Wordslbl.Text = ScrambleWord(words[currentIndex]);

            // Display the hint for the current word
            Hintlbl.Text = hints[currentIndex];

            // Clear previous result and user input
            Resultlbl.Text = "";
            Entertxt.Text = "";

            // Reset the timer for the new question
            timeLeft = 30;
            Timelbl.Text = "Time Left : " + timeLeft + " s";

            // Start the countdown timer
            QuizTimer.Start();

        }

        // Move to the next question
        private void NextQuestion()
        {
            currentIndex++;
            LoadQuestion();
        }

        // Scramble Word Method
        private string ScrambleWord(string word)
        {
            // Randomly rearranges the letters in the word
            return new string(word.OrderBy(x => rnd.Next()).ToArray());
        }

        // Timer Tick Event (runs every second)
        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            // Decrease the remaining time by 1 second
            timeLeft--;

            // Update the time label
            Timelbl.Text = "Time Left : " + timeLeft + " s";

            // Check if time has run out
            if (timeLeft <= 0)
            {
                // Stop the timer
                QuizTimer.Stop();

                // Display time up message
                Resultlbl.Text = "Time's up!";

                // Move to the next question
                currentIndex++;
                LoadQuestion();
            }
        }

        //Check answer button Click Event
        private void Checkbtn_Click(object sender, EventArgs e)
        {
            // Stop the timer when the player submits an answer
            QuizTimer.Stop();

            // Check if the player's input matches the correct answer
            if (Entertxt.Text.ToUpper() == words[currentIndex])
            {
                Resultlbl.Text = "CORRECT!";
                score++;
            }
            else
            {
                Resultlbl.Text = "Incorrect...";
            }

            // Wait 1 second before moving to the next question
            Timer delayTimer = new Timer();
            delayTimer.Interval = 1000;
            delayTimer.Tick += (s, args) =>
            {
                delayTimer.Stop();
                delayTimer.Dispose();
                NextQuestion();
            };
            delayTimer.Start();
        }

        private void Wordslbl_Click(object sender, EventArgs e)
        {

        }
    }
}