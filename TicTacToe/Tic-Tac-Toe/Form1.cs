using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private bool player1 = true;
        private int[,] grid = new int[3, 3];
        public Form1()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = 0;
                }
            }

            InitializeComponent();

            btn_0_0.Enabled = false;
            btn_0_1.Enabled = false;
            btn_0_2.Enabled = false;
            btn_1_0.Enabled = false;
            btn_1_1.Enabled = false;
            btn_1_2.Enabled = false;
            btn2_0.Enabled = false;
            btn2_1.Enabled = false;
            btn2_2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //New game
            //Init les images
            btn_0_0.ImageIndex = 0;
            btn_0_1.ImageIndex = 0;
            btn_0_2.ImageIndex = 0;
            btn_1_0.ImageIndex = 0;
            btn_1_1.ImageIndex = 0;
            btn_1_2.ImageIndex = 0;
            btn2_0.ImageIndex = 0;
            btn2_1.ImageIndex = 0;
            btn2_2.ImageIndex = 0;
            //Activation des boutons
            btn_0_0.Enabled = true;
            btn_0_1.Enabled = true;
            btn_0_2.Enabled = true;
            btn_1_0.Enabled = true;
            btn_1_1.Enabled = true;
            btn_1_2.Enabled = true;
            btn2_0.Enabled = true;
            btn2_1.Enabled = true;
            btn2_2.Enabled = true;
            player1 = true;
            label1.Text = "Joueur 1, cliquez sur une case";
            //init de la grille
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = 0;
                }
            }
        }

        private void btn_0_0_Click(object sender, EventArgs e)
        {

            if (grid[0, 0] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
            }
            else
            {
                if (player1)
                {
                    grid[0, 0] = 1;
                    btn_0_0.ImageIndex = 1;
                    btn_0_0.Enabled = false;
                    label1.Text = "Joueur 2, cliquez sur une case";
                    player1 = false;
                }
                else
                {
                    grid[0, 0] = 2;
                    btn_0_0.ImageIndex = 2;
                    btn_0_0.Enabled = false;
                    label1.Text = "Joueur 1, cliquez sur une case";
                    player1 = true;
                }
            }

            CheckWin();
        }

        private void btn_0_1_Click(object sender, EventArgs e)
        {

            if (grid[0, 1] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
            }
            else
            {
                if (player1)
                {
                    grid[0, 1] = 1;
                    btn_0_1.ImageIndex = 1;
                    btn_0_1.Enabled = false;
                    label1.Text = "Joueur 2, cliquez sur une case";
                    player1 = false;
                }
                else
                {
                    grid[0, 1] = 1;
                    btn_0_1.ImageIndex = 2;
                    btn_0_1.Enabled = false;
                    label1.Text = "Joueur 1, cliquez sur une case";
                    player1 = true;
                }
            }

            CheckWin();
        }

        private void btn_0_2_Click(object sender, EventArgs e)
        {

            if (grid[0, 2] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
            }
            else
            {
                if (player1)
                {
                    grid[0, 2] = 1;
                    btn_0_2.ImageIndex = 1;
                    btn_0_2.Enabled = false;
                    label1.Text = "Joueur 2, cliquez sur une case";
                    player1 = false;
                }
                else
                {
                    grid[0, 2] = 2;
                    btn_0_2.ImageIndex = 2;
                    btn_0_2.Enabled = false;
                    label1.Text = "Joueur 1, cliquez sur une case";
                    player1 = true;
                }
            }

            CheckWin();
        }

        private void btn_1_0_Click(object sender, EventArgs e)
        {

            if (grid[1, 0] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
            }
            else
            {
                if (player1)
                {
                    grid[1, 0] = 1;
                    btn_1_0.ImageIndex = 1;

                    label1.Text = "Joueur 2, cliquez sur une case";
                    player1 = false;
                }
                else
                {
                    grid[1, 0] = 2;
                    btn_1_0.ImageIndex = 2;
                    label1.Text = "Joueur 1, cliquez sur une case";
                    player1 = true;
                }
                btn_1_0.Enabled = false;
            }

            CheckWin();
        }

        private void DeclarerVainqueur()
        {
            if (player1)
            {
                MessageBox.Show("Joueur 1 a gagné !");

            }
            else
            {
                MessageBox.Show("Joueur 2 a gagné !");
            }
            label1.Text = "Appuyez sur New Game";
        }

        private void btn_1_1_Click(object sender, EventArgs e)
        {

            if (grid[1, 1] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
            }
            else
            {
                if (player1)
                {
                    grid[1, 1] = 1;
                    btn_1_1.ImageIndex = 1;

                    label1.Text = "Joueur 2, cliquez sur une case";
                    player1 = false;
                }
                else
                {
                    grid[1, 1] = 2;
                    btn_1_1.ImageIndex = 2;
                    label1.Text = "Joueur 1, cliquez sur une case";
                    player1 = true;
                }
            }
            btn_1_1.Enabled = false;
            CheckWin();
        }

        private void btn_1_2_Click(object sender, EventArgs e)
        {
            if (grid[1, 2] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
            }
            else
            {
                if (player1)
                {
                    grid[1, 2] = 1;
                    btn_1_2.ImageIndex = 1;

                    label1.Text = "Joueur 2, cliquez sur une case";
                    player1 = false;
                }
                else
                {
                    grid[1, 2] = 2;
                    btn_1_2.ImageIndex = 2;
                    label1.Text = "Joueur 1, cliquez sur une case";
                    player1 = true;
                }
            }
            btn_1_2.Enabled = false;
            CheckWin();
        }

        private void btn2_0_Click(object sender, EventArgs e)
        {
            int player = 1;
            if (!player1)
            {
                player = 2;
            }
            if (grid[2, 0] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
            }
            else
            {
                if (player1)
                {
                    grid[2, 0] = player;
                    btn2_0.ImageIndex = player;

                    label1.Text = "Joueur " + player + ", cliquez sur une case";
                    player1 = false;
                }
                else
                {
                    grid[2, 0] = player;
                    btn2_0.ImageIndex = player;
                    label1.Text = $"Joueur {player}, cliquez sur une case";
                    player1 = true;
                }
            }
            btn2_0.Enabled = false;
            CheckWin();
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
                DeclarerVainqueur();
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
                DeclarerVainqueur();
            }
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            int player = 1;
            if (!player1)
            {
                player = 2;
            }
            if (grid[2, 1] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
            }
            else
            {
                if (player1)
                {
                    grid[2, 1] = player;
                    btn2_1.ImageIndex = player;


                    player1 = false;
                }
                else
                {
                    grid[2, 1] = player;
                    btn2_1.ImageIndex = player;

                    player1 = true;
                }
            }
            btn2_1.Enabled = false;
            label1.Text = "Joueur " + player + ", cliquez sur une case";
            CheckWin();
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            int player = 1;
            if (!player1)
            {
                player = 2;
            }
            if (grid[2, 2] != 0)
            {
                MessageBox.Show("Vous ne pouvez pas cliquer ici, la case a déja été prise");
            }
            else
            {
                if (player1)
                {
                    grid[2, 1] = player;
                    btn2_1.ImageIndex = player;


                    player1 = false;
                }
                else
                {
                    grid[2, 1] = player;
                    btn2_1.ImageIndex = player;

                    player1 = true;
                }
            }
            btn2_1.Enabled = false;
            label1.Text = "Joueur " + player + ", cliquez sur une case";
            CheckWin();
        }
    }
}
