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
    public partial class ScoreForm : Form
    {
        int finalScore; // Stores the final score

        // Constructor receives score from GameForm
        public ScoreForm(int score)
        {
            InitializeComponent();
            finalScore = score;

            Scorelbl.Text = "Your Score : " + finalScore + " / 3";
        }

        private void Titlelbl_Click(object sender, EventArgs e)
        {

        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {
            TitleForm title = new TitleForm();
            title.Show();
            this.Hide();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}