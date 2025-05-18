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
    public partial class FormWordleControls : Form
    {
        WordleGame game;
        int gamesPlayed = 1;
        int gamesWon = 0;

        public FormWordleControls()
        {
            game = new WordleGame(this);
            InitializeComponent();
            updateGameStatistics();
        }

        private void buttonResetStatistics_Click(object sender, EventArgs e)
        {
            if(game.getIfGameInProgress())
            {
                gamesPlayed = 1;
            }
            else
            {  
                gamesPlayed = 0; 
            }
            gamesWon = 0;
            updateGameStatistics();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            gamesPlayed++;
            game.startNewGame();
            updateGameStatistics();
        }
        public void incrementWinCount()
        {
            gamesWon++;
            updateGameStatistics();
        }
        public void updateGameStatistics()
        {
            textBoxPlayCount.Text = gamesPlayed.ToString();
            textBoxWinCount.Text = gamesWon.ToString();
            textBoxWinPct.Text = ((double)Math.Round((double)gamesWon/gamesPlayed, 2) * 100).ToString() + "%";
        }
    }
}
