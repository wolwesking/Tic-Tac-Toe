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
    public partial class GamePlayer : Form
    {
        //Global variables
       
        bool isPlayerX = true;

        //0 = null; 1 = X; 2 = O;
        /*
        B1_1, B2_1, B3_1
        B1_2, B2_2, B3_2
        B1_3, B2_3, B3_3
         */

        int B1_1 = 0;
        int B2_1 = 0;
        int B3_1 = 0;

        int B1_2 = 0;
        int B2_2 = 0;
        int B3_2 = 0;

        int B1_3 = 0;
        int B2_3 = 0;
        int B3_3 = 0;

        public GamePlayer()
        {
            InitializeComponent();
        }

        private void GamePlayer_Load(object sender, EventArgs e)
        {
            playerState(isPlayerX);
        }
        //Win
        private void Win(int X)
        {
            menu.Enabled = true;
            restart.Enabled = true;
            menu.Visible = true;
            restart.Visible = true;
            foreach (Control B in Controls)
            {
                if (B.GetType().Equals(typeof(Button)) && B.Name != menu.Name &&  B.Name != restart.Name)
                {
                    B.Enabled = false;
                }
            }
            if (X == 1)
            {
                Player.Text = "Win: X";
            }
            else if (X == 2)
            {
                Player.Text = "Win: O";
            }
            else
            {
                Player.Text = "Draw";
            }
            
        }
        //isWin

        private void IsWin()
        {
            if (
                // Vertical
                (B1_1 == 1 && B2_1 == 1 && B3_1 == 1) || 
                (B1_2 == 1 && B2_2 == 1 && B3_2 == 1) ||
                (B1_3 == 1 && B2_3 == 1 && B3_3 ==1) ||
                // Horizontal
                (B1_1 == 1 && B1_2 == 1 && B1_3 == 1) ||
                (B2_1 == 1 && B2_2 == 1 && B2_3 == 1) ||
                (B3_1 == 1 && B3_2 == 1 && B3_3 == 1) ||
                // Cross
                (B1_1 == 1 && B2_2 == 1 && B3_3 == 1) ||
                (B3_1 == 1 && B2_2 == 1 && B1_3 == 1)
                )
            {
                Win(1);
            }
            else if (

                // Vertical
                (B1_1 == 2 && B2_1 == 2 && B3_1 == 2) ||
                (B1_2 == 2 && B2_2 == 2 && B3_2 == 2) ||
                (B1_3 == 2 && B2_3 == 2 && B3_3 == 2) ||
                // Horizontal
                (B1_1 == 2 && B1_2 == 2 && B1_3 == 2) ||
                (B2_1 == 2 && B2_2 == 2 && B2_3 == 2) ||
                (B3_1 == 2 && B3_2 == 2 && B3_3 == 2) ||
                // Cross
                (B1_1 == 2 && B2_2 == 2 && B3_3 == 2) ||
                (B3_1 == 2 && B2_2 == 2 && B1_3 == 2)
                )
            {
                Win(2);
            }
            else if (
                B1_1 != 0 && B2_1 != 0 && B3_1 != 0 &&
                B1_2 != 0 && B2_2 != 0 && B3_2 != 0 && 
                B1_3 != 0 && B2_3 != 0 && B3_3 != 0
                )
            {
                Win(3);
            }
        }

        // Player satate
        private void playerState(bool isplayerX)
        {
            if (isPlayerX)
            {
                Player.Text = "Player: X";
            }
            else
            {
                Player.Text = "Player: O";
            }
        }

        //Set the Buttons
        private void BT_1_1_Click(object sender, EventArgs e)
        {
            if (isPlayerX && B1_1 == 0)
            {
                isPlayerX = false;
                BT_1_1.Text = "X";
                B1_1 = 1;
                playerState(isPlayerX);
                IsWin();
            }
            else if (!isPlayerX && B1_1 == 0)
            {
                isPlayerX = true;
                BT_1_1.Text = "O";
                B1_1 = 2;
                playerState(isPlayerX);
                IsWin();
            }
        }

        private void BT_2_1_Click(object sender, EventArgs e)
        {
            if (isPlayerX && B2_1 == 0)
            {
                isPlayerX = false;
                BT_2_1.Text = "X";
                B2_1 = 1;
                playerState(isPlayerX);
                IsWin();
            }
            else if (!isPlayerX && B2_1 == 0)
            {
                isPlayerX = true;
                BT_2_1.Text = "O";
                B2_1 = 2;
                playerState(isPlayerX);
                IsWin();
            }
        }

        private void BT_3_1_Click(object sender, EventArgs e)
        {
            if (isPlayerX && B3_1 == 0)
            {
                isPlayerX = false;
                BT_3_1.Text = "X";
                B3_1 = 1;
                playerState(isPlayerX);
                IsWin();
            }
            else if (!isPlayerX && B3_1 == 0)
            {
                isPlayerX = true;
                BT_3_1.Text = "O";
                B3_1 = 2;
                playerState(isPlayerX);
                IsWin();
            }
        }

        private void BT_1_2_Click(object sender, EventArgs e)
        {
            if (isPlayerX && B1_2 == 0)
            {
                isPlayerX = false;
                BT_1_2.Text = "X";
                B1_2 = 1;
                playerState(isPlayerX);
                IsWin();
            }
            else if (!isPlayerX && B1_2 == 0)
            {
                isPlayerX = true;
                BT_1_2.Text = "O";
                B1_2 = 2;
                playerState(isPlayerX);
                IsWin();
            }
        }

        private void BT_2_2_Click(object sender, EventArgs e)
        {
            if (isPlayerX && B2_2 == 0)
            {
                isPlayerX = false;
                BT_2_2.Text = "X";
                B2_2 = 1;
                playerState(isPlayerX);
                IsWin();
            }
            else if (!isPlayerX && B2_2 == 0)
            {
                isPlayerX = true;
                BT_2_2.Text = "O";
                B2_2 = 2;
                playerState(isPlayerX);
                IsWin();
            }
        }

        private void BT_3_2_Click(object sender, EventArgs e)
        {
            if (isPlayerX && B3_2 == 0)
            {
                isPlayerX = false;
                BT_3_2.Text = "X";
                B3_2 = 1;
                playerState(isPlayerX);
                IsWin();
            }
            else if (!isPlayerX && B3_2 == 0)
            {
                isPlayerX = true;
                BT_3_2.Text = "O";
                B3_2 = 2;
                playerState(isPlayerX);
                IsWin();
            }
        }

        private void BT_1_3_Click(object sender, EventArgs e)
        {
            if (isPlayerX && B1_3 == 0)
            {
                isPlayerX = false;
                BT_1_3.Text = "X";
                B1_3 = 1;
                playerState(isPlayerX);
                IsWin();
            }
            else if (!isPlayerX && B1_3 == 0)
            {
                isPlayerX = true;
                BT_1_3.Text = "O";
                B1_3 = 2;
                playerState(isPlayerX);
                IsWin();
            }
        }

        private void BT_2_3_Click(object sender, EventArgs e)
        {
            if (isPlayerX && B2_3 == 0)
            {
                isPlayerX = false;
                BT_2_3.Text = "X";
                B2_3 = 1;
                playerState(isPlayerX);
                IsWin();
            }
            else if (!isPlayerX && B2_3 == 0)
            {
                isPlayerX = true;
                BT_2_3.Text = "O";
                B2_3 = 2;
                playerState(isPlayerX);
                IsWin();
            }
        }

        private void BT_3_3_Click(object sender, EventArgs e)
        {
            if (isPlayerX && B3_3 == 0)
            {
                isPlayerX = false;
                BT_3_3.Text = "X";
                B3_3 = 1;
                playerState(isPlayerX);
                IsWin();
            }
            else if (!isPlayerX && B3_3 == 0)
            {
                isPlayerX = true;
                BT_3_3.Text = "O";
                B3_3 = 2;
                playerState(isPlayerX);
                IsWin();
            }
        }

        private void restart_Click(object sender, EventArgs e)
        { 
            Controls.Clear();
            this.InitializeComponent();
             B1_1 = 0;
             B2_1 = 0;
             B3_1 = 0;

             B1_2 = 0;
             B2_2 = 0;
             B3_2 = 0;

             B1_3 = 0;
             B2_3 = 0;
             B3_3 = 0;
             isPlayerX = true;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }
        
    }
}
