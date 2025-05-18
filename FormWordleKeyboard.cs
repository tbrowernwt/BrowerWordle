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
    public partial class FormWordleKeyboard : Form
    {
        static Color DEFAULT_KEY_COLOR = SystemColors.Control;
        static Color INCORRECT_LETTER_COLOR = SystemColors.MenuBar;
        static Color CORRECT_BOX_COLOR = Color.Chartreuse;
        static Color CORRECT_LETTER_COLOR = Color.LemonChiffon;

        WordleGame game;
        String guess = "";
        List<Button> listKeys = new List<Button>();

        public FormWordleKeyboard(WordleGame game)
        {
            InitializeComponent();
            this.game = game;
            compileKeysList();   
        }

        private void processKeyEntry(object sender, EventArgs e)
        {
            if (sender == buttonBkSp)
            {
                if(guess != "")
                {
                    guess = guess.Remove(guess.Length - 1);
                    game.getLetterBoard().updateCurrentLineLetters(guess);
                }
            }
            else if (sender == buttonSubmit)
            {
                if(guess.Length == 5 & WordleDictionary.isValidWord(guess))
                {
                    game.submitGuess(guess);
                    guess = "";
                }
                else if(guess.Length == 5 & !WordleDictionary.isValidWord(guess))
                {
                    MessageBox.Show("Please enter a valid word");
                }
                else
                {
                    MessageBox.Show("Please enter a 5 letter word");
                }
            }
            else
            {
                if(guess.Length < 5)
                {
                    guess += getEnteredLetter((Button) sender);
                    game.getLetterBoard().updateCurrentLineLetters(guess);
                }
            }
            
        }
        private string getEnteredLetter(Button b)
        {
            return b.Text;
        }
        public void setKeyColor(String letter, Color color)
        {
            foreach(Button b in listKeys)
            {
                if(b.Text == letter)
                {
                    if(b.BackColor == DEFAULT_KEY_COLOR || (b.BackColor == CORRECT_LETTER_COLOR && color == CORRECT_BOX_COLOR))
                    {
                        b.BackColor = color;
                    }
                }
            }
        }
        public void resetKeyColors()
        {
            foreach (Button b in listKeys)
            {
                b.BackColor = DEFAULT_KEY_COLOR;
            }
        }
        private void compileKeysList()
        {
            listKeys.Add(buttonA);
            listKeys.Add(buttonB);
            listKeys.Add(buttonC);
            listKeys.Add(buttonD);
            listKeys.Add(buttonE);   
            listKeys.Add(buttonF);
            listKeys.Add(buttonG);
            listKeys.Add(buttonH);
            listKeys.Add(buttonI);
            listKeys.Add(buttonJ);
            listKeys.Add(buttonK);
            listKeys.Add(buttonL);
            listKeys.Add(buttonM);
            listKeys.Add(buttonN);
            listKeys.Add(buttonO);
            listKeys.Add(buttonP);
            listKeys.Add(buttonQ);
            listKeys.Add(buttonR);
            listKeys.Add(buttonS);
            listKeys.Add(buttonT);
            listKeys.Add(buttonU);
            listKeys.Add(buttonV);
            listKeys.Add(buttonW);
            listKeys.Add(buttonX);
            listKeys.Add(buttonY);
            listKeys.Add(buttonZ);
        }
    }
}
