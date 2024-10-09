using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameIteration4
{
    public partial class Form1 : Form
    {
        int PlayerPos = 113;
        int GamesState = 0;
        string BlockState = "";
        int EnemyPosition = 0;
        string ELastLooked = "";
        string PLastLooked = "";

        PictureBox[] MPB = new PictureBox[225];
        Enemies Mercs = new Enemies();

        
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TiGameTick.Enabled = true;
            int LeftPos = 0;
            int TopPos = 0;
            int Rows = 0;

            for (int x = 0; x < 225; x++)
            {
                MPB[x] = new PictureBox();
                MPB[x].Height = 35;
                MPB[x].Width = 35;
                MPB[x].Left = LeftPos;
                MPB[x].Top = TopPos;
                PlayerSpace.Controls.Add(MPB[x]);
                LeftPos = LeftPos + 35;
                Rows++;

                if (Rows > 14)
                {
                    TopPos = TopPos + 35;
                    LeftPos = 0;
                    Rows = 0;
                }
                BlockState = MPB[x].BackColor.ToString();
            }
            MPB[35].BackColor = Color.Gray;
            MPB[36].BackColor = Color.Gray;
            MPB[34].BackColor = Color.Gray;
            MPB[20].BackColor = Color.Gray;

        }

        private void MoveNorth(object sender, EventArgs e)
            {
            if (PlayerPos == 35)
            {
                PlayerPos = PlayerPos + 15;
            }
            if (PlayerPos == 36)
            {
                PlayerPos = PlayerPos + 15;
            }
            if (PlayerPos == 37)
            {
                PlayerPos = PlayerPos + 15;
            }
            else
            {
                MPB[PlayerPos].BackColor = Color.NavajoWhite;
                PlayerPos = PlayerPos - 15;
                if (PlayerPos < 0)
                {
                    PlayerPos = PlayerPos + 225;
                }
                MPB[PlayerPos].BackColor = Color.Aqua;
            }
            }

        private void MoveEast(object sender, EventArgs e)
        {
            if (PlayerPos == 21)
            {
                PlayerPos = PlayerPos - 1;
            }
            if (PlayerPos == 35)
            {
                PlayerPos = PlayerPos - 1;
            }

            else
            {
                MPB[PlayerPos].BackColor = Color.NavajoWhite;
                PlayerPos = PlayerPos + 1;
                string Placer = "2";
                if (PlayerPos == 15)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 30)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 45)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 60)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 75)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 90)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 105)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 120)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 135)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 150)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 165)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 180)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 195)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 210)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 225)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos - 15;
                        Placer = "1";
                    }
                }
                MPB[PlayerPos].BackColor = Color.Aqua;
            }
        }

        private void MoveSouth(object sender, EventArgs e)
        {
            if (PlayerPos == 21)
            {
                PlayerPos = PlayerPos - 15;
            }
            if (PlayerPos == 35)
            {
                PlayerPos = PlayerPos - 15;
            }
            if (PlayerPos == 37)
            {
                PlayerPos = PlayerPos - 15;
            }
            else
            {
                MPB[PlayerPos].BackColor = Color.NavajoWhite;
            PlayerPos = PlayerPos + 15;
            if (PlayerPos >= 225)
            {
                PlayerPos = PlayerPos - 225;
            }
               MPB[PlayerPos].BackColor = Color.Aqua;
            }
        }

        private void MoveWest(object sender, EventArgs e)
        {
            if (PlayerPos == 21) 
            {
                PlayerPos = PlayerPos + 1;
            }
            if (PlayerPos == 35)
            {
                PlayerPos = PlayerPos + 1;
            }

            else
            {
                MPB[PlayerPos].BackColor = Color.NavajoWhite;
                PlayerPos = PlayerPos - 1;
                string Placer = "2";
                if (PlayerPos < 0)
                {
                    PlayerPos = PlayerPos + 15;
                    Placer = "1";
                }
                if (PlayerPos == 14)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 29)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 44)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 59)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 74)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 89)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 104)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 119)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 134)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 149)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 164)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 179)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 194)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 209)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos == 224)
                {
                    if (Placer == "2")
                    {
                        PlayerPos = PlayerPos + 15;
                        Placer = "1";
                    }
                }
                if (PlayerPos > 225)
                {
                    PlayerPos = PlayerPos - 15;
                }
                MPB[PlayerPos].BackColor = Color.Aqua;
            }
        }

        private void GameTick(object sender, EventArgs e)
        {
            
        }

        private void GamePaused(object sender, EventArgs e)
        {
            this.TiGameTick.Enabled = false;
            this.Hide();
            Application.Run(new PauseMenu());
        }
        private void EnemyMovement(object sender, EventArgs e)
        {
            Random PRand = new Random();
            int MoveDirection = PRand.Next(1, 6);

            GamesState++;

            Mercs.EnemyName = "Mercenaries";
            Mercs.EnPos = EnemyPosition;
            MPB[EnemyPosition].BackColor = Color.NavajoWhite;
            if (MoveDirection == 1)
            {

                EnemyPosition = EnemyPosition - 15;
                ELastLooked = "North";
                if (EnemyPosition < 0)
                {
                    EnemyPosition = EnemyPosition + 225;
                }
            }
            if (MoveDirection == 2)
            {
                EnemyPosition = EnemyPosition + 1;
                ELastLooked = "East";
                if (EnemyPosition > 224)
                {
                    EnemyPosition = EnemyPosition - 15;
                }
            }
            if (MoveDirection == 3)
            {
                EnemyPosition = EnemyPosition + 15;
                ELastLooked = "South";
                if (EnemyPosition > 224)
                {
                    EnemyPosition = EnemyPosition - 225;
                }
            }
            if (MoveDirection == 4)
            {
                EnemyPosition = EnemyPosition - 1;
                ELastLooked = "West";
                if (EnemyPosition < 0)
                {
                    EnemyPosition = EnemyPosition + 15;
                }
            }
            if (MoveDirection == 5)
            {

            }
            MPB[EnemyPosition].BackColor = Color.Red;
        }

        private void PlayerMovement(object sender, EventArgs e)
        {

        }
    }
}
