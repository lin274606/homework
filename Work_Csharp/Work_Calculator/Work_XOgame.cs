using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Calculator
{
    public partial class Work_XOgame : Form
    {
        public Work_XOgame()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyPress += Work_XOgame_KeyPress;
            KeyDown += Work_XOgame_KeyDown;
        }
        private bool turn = true; // true = X turn; false = O turn
        private int turn_count = 0;

        #region Check
        private void checkForWinner()
        {
            bool there_is_a_winner = false;
            // Check rows
            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && (!btnA1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && (!btnB1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (!btnC1.Enabled))
            {
                there_is_a_winner = true;
            }
            // Check columns
            else if ((btnA1.Text == btnB1.Text) && (btnB1.Text == btnC1.Text) && (!btnA1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text) && (!btnA2.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((btnA3.Text == btnB3.Text) && (btnB3.Text == btnC3.Text) && (!btnA3.Enabled))
            {
                there_is_a_winner = true;
            }
            // Check diagonals
            else if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (!btnA1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && (!btnA3.Enabled))
            {
                there_is_a_winner = true;
            }
            if (there_is_a_winner)
            {                
                string winner = "";
                if (turn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show($"{winner}  Wins!\nCongratulations!");
                resetGame();
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!");
                    resetGame();
                }
            }
        }
        #endregion
        #region Button
        private void btnA1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }
        private void btnA2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }
        #endregion
        private void resetGame()
        {
            turn = true;
            turn_count = 0;
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.Enabled = true;
                    control.Text = "";
                }
            }
            btnReset.Text = "Reset(R)";
            btnEsc.Text = "Exit(Esc)";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {                        
            resetGame();            
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Work_XOgame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r' || e.KeyChar == 'R')
            {
                btnReset_Click(null, null);
            }
        }

        private void Work_XOgame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnEsc_Click(null, null);
            }
        }
    }
}
