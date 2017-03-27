using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Brain_Ticklers
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        int score = 0;
        string score2 = "";

        private void HomeButton_Click(object sender, EventArgs e)
        {
           DialogResult DialogResult = new DialogResult();
            DialogResult =  MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                score = score - score;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
                MessageBox.Show("Thank you for playing with us!");
                this.Hide();
                SplashScreen form1 = new SplashScreen();// this code should be replaced tho, the home button should direct the user to the main menu of the game :)
                form1.Show();
                ManOnBoardpictureBox.Visible = true;
                ManonBoardtextBox.Visible = true;
                

            }        
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How am I suppose to play this? \n 1.  You need to work your brain but don't over do it! \n 2.  Please enter your answers in LOWER CASE! Thank you for doing so! \n 3.  If nothing happens when you clicked submit, your answer is wrong,        obviously! \n 4. Enjoy the game!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            //man on board
            if (ManonBoardtextBox.Text == "man on board")
            {
                MessageBox.Show("Correct! You're good at this!", "" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManOnBoardpictureBox.Visible = false;
                TunaFishpictureBox.Visible = true;
                ManonBoardtextBox.Visible = false;
                ManonBoardtextBox.Text = "";
                TunatextBox.Visible = true;
                TunatextBox.Focus();
              
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
            }


            // tuna fish
            if (TunatextBox.Text == "tuna fish")
            {
                MessageBox.Show("Correct! Let's put things up a notch!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TunaFishpictureBox.Visible = false;
                ReadingpictureBox.Visible = true;
                TunatextBox.Visible = false;
                ReadingtextBox.Visible = true;
                ReadingtextBox.Focus();
                TunatextBox.Text = "";
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
            }
         
          

            //reading between lines
            if (ReadingtextBox.Text == "reading between lines")
            {
                MessageBox.Show("Correct! YES! Feel your brain working!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReadingpictureBox.Visible = false;
                EggspictureBox.Visible = true;
                ReadingtextBox.Visible = false;
                EggtextBox.Visible = true;
                EggtextBox.Focus();
                ReadingtextBox.Text = "";
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
            }
          

            //scrambled eggs
            if (EggtextBox.Text == "scrambled eggs")
            {
                MessageBox.Show("Brain is functioning as expected!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EggspictureBox.Visible = false;
                GoingOnADietpictureBox.Visible = true;
                EggtextBox.Visible = false;
                DiettextBox.Visible = true;
                DiettextBox.Focus();
                EggtextBox.Text = "";
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
            }

            //going on a diet
            if (DiettextBox.Text == "going on a diet")
            {
                MessageBox.Show("Let's se if you got this!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoingOnADietpictureBox.Visible = false;
                IUnderstandpictureBox.Visible = true;
                DiettextBox.Visible = false;
                StanttextBox.Visible = true;
                StanttextBox.Focus();
                DiettextBox.Text = "";                
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
            }

            //I understand
            if (StanttextBox.Text == "i understand")
            {
                MessageBox.Show("Ok, may be you got that one, how about this?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LifepictureBox.Visible = true;
                IUnderstandpictureBox.Visible = false;
                LifetextBox.Visible = true;
                LifetextBox.Focus();
                StanttextBox.Visible = false;
                StanttextBox.Text = "";                
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
            }

            //life after death
            if (LifetextBox.Text == "life after death")
            {
                MessageBox.Show("Must be from ravenclaw!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LifepictureBox.Visible = false;
                MindOverMatterpictureBox.Visible = true;
                LifetextBox.Visible = false;
                MattertextBox.Visible = true;
                MattertextBox.Focus();
                LifetextBox.Text = ""; 
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
            }
           
            //mind over matter
            if (MattertextBox.Text == "mind over matter")
            {
                MessageBox.Show("You're good, I should keep up!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BananapictureBox.Visible = true;
                MindOverMatterpictureBox.Visible = false;
                MattertextBox.Visible = false;
                BananatextBox.Visible = true;
                BananatextBox.Focus();
                MattertextBox.Text = "";      
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
            }

            //banana split
            if (BananatextBox.Text == "banana split")
            {
                MessageBox.Show("One more and you're good to go!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlancepictureBox.Visible = true;
                BananapictureBox.Visible = false;
                BananatextBox.Visible = false;
                GlancetextBox.Visible = true;
                GlancetextBox.Focus();
                BananatextBox.Text = "";               
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
            }

            //backward glance
            if (GlancetextBox.Text == "backward glance")
            {
                GlancetextBox.Text = "";
                score += 1;
                score2 = score.ToString();
                ScoreLabel.Text = score2;
                
                DialogResult DialogResult = new DialogResult();
                DialogResult = MessageBox.Show("Your brain has been tickled! Congratulations! Want to try again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ManOnBoardpictureBox.Visible = true;
                    ManonBoardtextBox.Visible = true;
                    ManonBoardtextBox.Focus();
                    GlancepictureBox.Visible = false;
                    GlancetextBox.Visible = false;
                    score = score - score;
                    score2 = score.ToString();
                    ScoreLabel.Text = score2;
                }
                else
                {
                    MessageBox.Show("Congratulations and thank you for playing with us!");
                    this.Hide();
                    SplashScreen form1 = new SplashScreen();// this code should be replaced tho, the home button should direct the user to the main menu of the game :)
                    form1.Show();
                }
            }
        }
       
    }
}
