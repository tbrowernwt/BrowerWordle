using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowerWordle
{
    public partial class FormWordleLetterBoard : Form
    {
        // Create a "two dimensional" list to cleanly iterate through each letter and each guess. 
        List<List<TextBox>> guessBoxes = new List<List<TextBox>>();
        List<TextBox> answerBoxes = new List<TextBox>();

        WordleGame game;

        // Define colors
        static Color BLACKOUT_ANSWER_COLOR = Color.Black;
        static Color INCORRECT_LETTER_COLOR = SystemColors.ControlDark;
        static Color ANSWER_LOSS_COLOR = Color.IndianRed;
        static Color CORRECT_BOX_COLOR = Color.Chartreuse;
        static Color CORRECT_LETTER_COLOR = Color.LemonChiffon;
        static Color ADDITIONAL_GUESS_BLANKS_COLOR = SystemColors.WindowFrame;
        static Color CURRENT_GUESS_ROW_COLOR = SystemColors.Window;

        byte guessNumber = 0;

        public FormWordleLetterBoard(WordleGame game)
        {
            InitializeComponent();
            this.game = game;
            
            // Add each guess row
            guessBoxes.Add(new List<TextBox>());
            guessBoxes.Add(new List<TextBox>());
            guessBoxes.Add(new List<TextBox>());
            guessBoxes.Add(new List<TextBox>());
            guessBoxes.Add(new List<TextBox>());
            guessBoxes.Add(new List<TextBox>());

            // Add each letter to each guess
            guessBoxes[0].Add(textBoxGuess0Letter0);
            guessBoxes[0].Add(textBoxGuess0Letter1);
            guessBoxes[0].Add(textBoxGuess0Letter2);
            guessBoxes[0].Add(textBoxGuess0Letter3);
            guessBoxes[0].Add(textBoxGuess0Letter4);

            guessBoxes[1].Add(textBoxGuess1Letter0);
            guessBoxes[1].Add(textBoxGuess1Letter1);
            guessBoxes[1].Add(textBoxGuess1Letter2);
            guessBoxes[1].Add(textBoxGuess1Letter3);
            guessBoxes[1].Add(textBoxGuess1Letter4);

            guessBoxes[2].Add(textBoxGuess2Letter0);
            guessBoxes[2].Add(textBoxGuess2Letter1);
            guessBoxes[2].Add(textBoxGuess2Letter2);
            guessBoxes[2].Add(textBoxGuess2Letter3);
            guessBoxes[2].Add(textBoxGuess2Letter4);

            guessBoxes[3].Add(textBoxGuess3Letter0);
            guessBoxes[3].Add(textBoxGuess3Letter1);
            guessBoxes[3].Add(textBoxGuess3Letter2);
            guessBoxes[3].Add(textBoxGuess3Letter3);
            guessBoxes[3].Add(textBoxGuess3Letter4);

            guessBoxes[4].Add(textBoxGuess4Letter0);
            guessBoxes[4].Add(textBoxGuess4Letter1);
            guessBoxes[4].Add(textBoxGuess4Letter2);
            guessBoxes[4].Add(textBoxGuess4Letter3);
            guessBoxes[4].Add(textBoxGuess4Letter4);

            guessBoxes[5].Add(textBoxGuess5Letter0);
            guessBoxes[5].Add(textBoxGuess5Letter1);
            guessBoxes[5].Add(textBoxGuess5Letter2);
            guessBoxes[5].Add(textBoxGuess5Letter3);
            guessBoxes[5].Add(textBoxGuess5Letter4);

            answerBoxes.Add(textBoxAnswerLetter0);
            answerBoxes.Add(textBoxAnswerLetter1);
            answerBoxes.Add(textBoxAnswerLetter2);  
            answerBoxes.Add(textBoxAnswerLetter3);
            answerBoxes.Add(textBoxAnswerLetter4);
        }
        public void clearBoard()
        {
            for(int i = 0; i < guessBoxes.Count(); i++)
            {
                foreach(TextBox letter in guessBoxes[i])
                {
                    letter.Text = "";
                    if (i == 0)
                    {
                        letter.BackColor = CURRENT_GUESS_ROW_COLOR;
                    }
                    else
                    {
                        letter.BackColor = ADDITIONAL_GUESS_BLANKS_COLOR;
                    }
                }
            }
            foreach (TextBox letter in answerBoxes)
            {
                letter.Text = "";
                letter.BackColor = BLACKOUT_ANSWER_COLOR;
            }
            guessNumber = 0;
        }
        public void revealAnswer(String answer, bool isCorrect = false)
        {
            for (int i = 0; i < answer.Length; i++)
            {
                answerBoxes[i].Text = answer[i].ToString();
                if (isCorrect)
                {
                    answerBoxes[i].BackColor = CORRECT_BOX_COLOR;
                }
                else
                {
                    answerBoxes[i].BackColor = ANSWER_LOSS_COLOR;
                }
            }
        }
        public void updateCurrentLineLetters(String word)
        {
            for (int i = 0; i < 5 ; i++)
            {
                if(i >= word.Length)
                {
                    guessBoxes[guessNumber][i].Text = "";
                }
                else
                {
                    guessBoxes[guessNumber][i].Text = word[i].ToString();
                }
            }
        }
        public void processSubmissionOfGuess(string correctWord, string guess)
        {
            if(correctWord == guess)
            {
                foreach(TextBox letter in guessBoxes[guessNumber])
                {
                    letter.BackColor = CORRECT_BOX_COLOR;
                }
                revealAnswer(correctWord, true);
            }
            else
            {
                for (int i = 0; i < correctWord.Length; i++)
                {
                    if (guess[i] == correctWord[i])
                    {
                        guessBoxes[guessNumber][i].BackColor = CORRECT_BOX_COLOR;
                        game.getKeyboard().setKeyColor(guess[i].ToString(), CORRECT_BOX_COLOR);
                    }
                    else
                    {
                        for(int j = 0; j < guess.Length; j++)
                        {
                            if (correctWord[i] == guess[j] && guessBoxes[guessNumber][j].BackColor == CURRENT_GUESS_ROW_COLOR)
                            {
                                guessBoxes[guessNumber][j].BackColor = CORRECT_LETTER_COLOR;
                                game.getKeyboard().setKeyColor(guess[j].ToString(), CORRECT_LETTER_COLOR);
                                break;
                            }
                        }
                    }
                }
                for(int i = 0; i < correctWord.Length; i ++)
                {
                    if(guessBoxes[guessNumber][i].BackColor == CURRENT_GUESS_ROW_COLOR)
                    {
                        guessBoxes[guessNumber][i].BackColor = INCORRECT_LETTER_COLOR;
                        game.getKeyboard().setKeyColor(guess[i].ToString(), INCORRECT_LETTER_COLOR);
                    }
                }
                guessNumber++;
                if(guessNumber == 6 && guess != correctWord)
                {
                    revealAnswer(correctWord);
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        guessBoxes[guessNumber][i].BackColor = CURRENT_GUESS_ROW_COLOR;
                    }
                }
            }
        }
    }
}
