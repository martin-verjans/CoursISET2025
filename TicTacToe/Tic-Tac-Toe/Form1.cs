using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private List<Button> gameButtons = new List<Button>();
        private ITitTacToeGameEngine gameEngine;
        
        public Form1()
        {
            InitializeComponent();
            CreateButtons();
            InitGrid();
            DesactivateAllButtons();
        }

        private void CreateButtons()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col =  0; col < 3; col++)
                {
                    CreateButton(row, col);
                }
            }
        }

        private void CreateButton(int row, int col)
        {
            Button newButton = new Button
            {
                Dock = DockStyle.Fill,
                ImageIndex = 0,
                ImageList = imgTokenList,
                Location = new Point(158, 298),
                Name = $"btn_{row}_{col}",
                Size = new Size(154, 141),
                TabIndex = row * 3 + col,
                UseVisualStyleBackColor = true,
                Tag = new Point(row, col)
            };
            newButton.Click += GameButton_Click;
            tableLayoutPanel2.Controls.Add(newButton, col, row);
            gameButtons.Add(newButton);
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point coordinates = (Point)clickedButton.Tag;
            int row = coordinates.X;
            int col = coordinates.Y;

            gameEngine.PlaceTokenInGrid(row, col);

            if (grid[row, col] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
                return;
            }

            if (NextPlayerIsPlayerOne)
            {
                grid[row, col] = 1;
                clickedButton.ImageIndex = 1;
                clickedButton.Enabled = false;
                lblGameInfo.Text = "Joueur 2, cliquez sur une case";
                NextPlayerIsPlayerOne = false;
            }
            else
            {
                grid[row, col] = 2;
                clickedButton.ImageIndex = 2;
                clickedButton.Enabled = false;
                lblGameInfo.Text = "Joueur 1, cliquez sur une case";
                NextPlayerIsPlayerOne = true;
            }

            CheckWin();
        }

        private void ActivateAllButtons()
        {
            SetEnableGameButton(true);
        }

        private void DesactivateAllButtons()
        {
            SetEnableGameButton(false);
        }

        private void SetEnableGameButton(bool enable)
        {
            foreach (Button button in gameButtons)
            {
                button.Enabled = enable;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitButtonImages();
            ActivateAllButtons();
            SetupFirstPlayer();
            InitGrid();
        }

        private void SetupFirstPlayer()
        {
            NextPlayerIsPlayerOne = true;
            lblGameInfo.Text = "Joueur 1, cliquez sur une case";
        }

        private void InitGrid()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = 0;
                }
            }
        }

        private void InitButtonImages()
        {
            foreach (Button button in gameButtons)
            {
                button.ImageIndex = 0;
            }
        }

        private void DeclareWinner()
        {
            if (!NextPlayerIsPlayerOne)
            {
                MessageBox.Show("Joueur 1 a gagné !");

            }
            else
            {
                MessageBox.Show("Joueur 2 a gagné !");
            }
            lblGameInfo.Text = "Appuyez sur New Game";
            DesactivateAllButtons();
        }

        private void CheckWin()
        {
            //on vérifie si un des deux joueurs à gagné
            if ((grid[0, 0] == 1 && grid[0, 1] == 1 && grid[0, 2] == 1) || //Horizontales
                (grid[1, 0] == 1 && grid[1, 1] == 1 && grid[1, 2] == 1) ||
                (grid[2, 0] == 1 && grid[2, 1] == 1 && grid[2, 2] == 1) ||
                (grid[0, 0] == 1 && grid[1, 0] == 1 && grid[2, 0] == 1) ||
                (grid[0, 1] == 1 && grid[1, 1] == 1 && grid[2, 1] == 1) ||//Verticales
                (grid[0, 2] == 1 && grid[1, 2] == 1 && grid[2, 2] == 1) ||
                (grid[0, 0] == 1 && grid[1, 1] == 1 && grid[2, 2] == 1) ||//Diagonales
                (grid[0, 2] == 1 && grid[1, 1] == 1 && grid[2, 0] == 1))
            {
                DeclareWinner();
            }
            if ((grid[0, 0] == 2 && grid[0, 1] == 2 && grid[0, 2] == 2) ||
                (grid[1, 0] == 2 && grid[1, 1] == 2 && grid[1, 2] == 2) ||
                (grid[2, 0] == 2 && grid[2, 1] == 2 && grid[2, 2] == 2) ||
                (grid[0, 0] == 2 && grid[1, 0] == 2 && grid[2, 0] == 2) ||
                (grid[0, 1] == 2 && grid[1, 1] == 2 && grid[2, 1] == 2) ||
                (grid[0, 2] == 2 && grid[1, 2] == 2 && grid[2, 2] == 2) ||
                (grid[0, 0] == 2 && grid[1, 1] == 2 && grid[2, 2] == 2) ||
                (grid[0, 2] == 2 && grid[1, 1] == 2 && grid[2, 0] == 2))
            {
                DeclareWinner();
            }
        }
    }
}
