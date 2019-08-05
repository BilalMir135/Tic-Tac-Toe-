using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool Isplayerone;
        private byte ButtonClick;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EnableButtons(bool enable)
        {
            but1.Enabled = enable;
            but2.Enabled = enable;
            but3.Enabled = enable;
            but4.Enabled = enable;
            but5.Enabled = enable;
            but6.Enabled = enable;
            but7.Enabled = enable;
            but8.Enabled = enable;
            but9.Enabled = enable;
        }
        private void ClearButtons()
        {
            but1.Text = "";
            but2.Text = "";
            but3.Text = "";
            but4.Text = "";
            but5.Text = "";
            but6.Text = "";
            but7.Text = "";
            but8.Text = "";
            but9.Text = "";
        }
        private void EnableGroupBoxes(bool enable)
        {
            gbxPlayersName.Enabled = enable;
            gbxStartPlayer.Enabled = enable;
            gbxXplayer.Enabled = enable;
        }
        private void ResetGame()
        {
            EnableButtons(false);
            EnableGroupBoxes(true);
            startNewGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;
            ClearButtons();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGame();          
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableButtons(true);
            EnableGroupBoxes(false);
            startNewGameToolStripMenuItem.Enabled = false;
            resetGameToolStripMenuItem.Enabled = true;
            Isplayerone = radbutPlayer1.Checked;
            ButtonClick = 0;
            if (tbxPlayer1.Text == "")
                tbxPlayer1.Text = "Player1";
            if (tbxPlayer2.Text == "")
                tbxPlayer2.Text = "Player2";
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            EnableGroupBoxes(true);
            startNewGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;
            ResetGame();
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Isplayerone)
            {
                if (radbutPlayer1X.Checked)
                    button.Text = "X";
                else
                    button.Text = "O";
                Isplayerone = false;
                button.Enabled = false;
            }
            else
            {
                if (radbutPlayer2X.Checked)
                    button.Text = "X";
                else
                    button.Text = "O";
                Isplayerone = true;
                button.Enabled = false;
            }
            ButtonClick++;
            CheckTheWinner();
        }
        private void CheckTheWinner()
        {
            bool IsWinner = false;    
                if ((but1.Text == but2.Text) && (but2.Text == but3.Text) && (!but1.Enabled))
                    IsWinner = true;
                else if ((but4.Text == but5.Text) && (but5.Text == but6.Text) && (!but4.Enabled))
                    IsWinner = true;
                else if ((but7.Text == but8.Text) && (but8.Text == but9.Text) && (!but7.Enabled))
                    IsWinner = true;
                else if ((but1.Text == but4.Text) && (but4.Text == but7.Text) && (!but1.Enabled))
                    IsWinner = true;
                else if ((but2.Text == but5.Text) && (but5.Text == but8.Text) && (!but2.Enabled))
                    IsWinner = true;
                else if ((but3.Text == but6.Text) && (but6.Text == but9.Text) && (!but3.Enabled))
                    IsWinner = true;
                else if ((but1.Text == but5.Text) && (but5.Text == but9.Text) && (!but1.Enabled))
                    IsWinner = true;
                else if ((but3.Text == but5.Text) && (but5.Text == but7.Text) && (!but3.Enabled))
                    IsWinner = true;
                else if(ButtonClick == 9)
                {
                    MessageBox.Show("The game is drawn, please reset the game!!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }

                if (IsWinner)
                {
                    if (!Isplayerone)
                    {
                        MessageBox.Show(tbxPlayer1.Text+" is the winner!!!", "Congratulations "+tbxPlayer1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(tbxPlayer2.Text+" is the winner!!!", "Congratulations "+tbxPlayer2.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ResetGame();
                }
            }

        private void aboutTicTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic-tac-toe. ... Tic-tac-toe (American English), noughts and crosses (British English) or Xs and Os, is a paper-and-pencil game for two players, X and O, who take turns marking the spaces in a 3×3 grid. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row wins the game.", "About Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Tia Tac Toe game was designed and developed by Software Engineer Bilal Mir and all the rights are reserved to Bilal Mir.", "About Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

