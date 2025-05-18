using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowerWordle
{
    public class WordleGame
    {
        FormWordleKeyboard keys;
        FormWordleLetterBoard tiles;
        FormWordleControls controls;
        string correctWord = "";
        bool gameInProgress = false;
        int guessCount = 0;
        public WordleGame(FormWordleControls ctrls) 
        {
            keys = new FormWordleKeyboard(this);
            tiles = new FormWordleLetterBoard(this);
            controls = ctrls;
            keys.Show();
            tiles.Show();
            startNewGame();
        }
        public void startNewGame()
        {
            keys.resetKeyColors();
            tiles.clearBoard();
            correctWord = WordleDictionary.getWord();
            gameInProgress = true;
            guessCount = 0;
        }
        public bool getIfGameInProgress()
        {
            return gameInProgress;
        }
        public void submitGuess(String word)
        {
            tiles.processSubmissionOfGuess(correctWord, word);
            if(word == correctWord)
            {
                gameInProgress = false;
                controls.incrementWinCount();
            }
            else if(guessCount == 5)
            {
                gameInProgress = false;
                tiles.revealAnswer(correctWord);
            }
            else
            {
                guessCount++;
            }
        }
        public FormWordleLetterBoard getLetterBoard()
        {
            return tiles;
        }
        public FormWordleKeyboard getKeyboard()
        {
            return keys;
        }
    }
}
