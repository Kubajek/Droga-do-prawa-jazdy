using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_JPWP
{
    public partial class Form1 : Form
    {
        private MainMenu mainMenu;

        public const int START_POINTS = 4;
        public const int DESTINATION_POINTS = 4;
        public const int CAR_SPAWN_INTERVAL = 1; //time in seconds

        public int carID = 0;
        public bool gameStarted = false;

        public int score = 0;
        public int highScore = 0; //docelowo czytane z pliku
         
        public int carSpawnTimer = 0;

        Random rand = new Random();
        List<PictureBox> carsPic = new List<PictureBox>();
        List<Car> carsObj = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startButton.FlatAppearance.BorderSize = 0;
            restartButton.FlatAppearance.BorderSize = 0;
        }

        //Main game loop
        private void TimerEvent(object sender, EventArgs e)
        {
            //=====================Handling cars==========================================
            for (int i = carsObj.Count - 1; i>=0; i--)
            {
                //-----checking fo collisions------
                for (int j = i - 1; j >= 0; j--)
                {
                    if (carsPic[i].Bounds.IntersectsWith(carsPic[j].Bounds) && (i != j))
                    {
                        GameOver();
                    }
                }

                //-----checking if car hit edge of map------
                if (carsObj[i].ifOutOfBound())
                {
                    carsObj.RemoveAt(i);
                    this.Controls.Remove(carsPic[i]);
                    carsPic.RemoveAt(i);

                    score++;
                    txtScoreInt.Text = score.ToString();
                }
                //-----handling car movement-----
                else if (!carsObj[i].Stopped && gameStarted)
                {
                    carsObj[i].move();
                    carsPic[i].Location = new Point(carsObj[i].X, carsObj[i].Y);
                }
            }
            //============================================================================

            if (gameStarted)
            {
                carSpawnTimer++;
                if (carSpawnTimer == CAR_SPAWN_INTERVAL / (gameTimer.Interval * 0.001)) 
                {

                    SpawnCar(); 
                    carSpawnTimer = 0; 
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameStarted = true;
            SpawnCar();
            startButton.Enabled = false;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            for (int i = carsObj.Count - 1; i >= 0; i--)
            {
                carsObj.RemoveAt(i);
                this.Controls.Remove(carsPic[i]);
                carsPic.RemoveAt(i);
            }

            gameOverText.Visible = false;
            carID = 0;
            score = 0;
            txtScoreInt.Text = "0";

            startButton.Enabled = true;
        }

        private void GameOver()
        {
            gameStarted = false;
            gameOverText.BringToFront();
            gameOverText.Visible = true;
            if(score > highScore) { highScore = score; }
            txtHighScoreInt.Text = highScore.ToString();
        }

        private void SpawnCar()
        {
            int[] carsAtSpawnPos = {0,0,0,0};
            bool[] tooManyCarsAtPos = {false,false,false,false};

            int startPos;

            //making sure that not too many cars will spawn at once in the same place
            //==================================================================
            for (int i = carsObj.Count - 1; i >= 0; i--)
            {
                if (carsPic[i].Bounds.IntersectsWith(spawnPos0.Bounds))
                {
                    carsAtSpawnPos[0]++;
                }
                if (carsPic[i].Bounds.IntersectsWith(spawnPos1.Bounds))
                {
                    carsAtSpawnPos[1]++;
                }
                if (carsPic[i].Bounds.IntersectsWith(spawnPos2.Bounds))
                {
                    carsAtSpawnPos[2]++;
                }
                if (carsPic[i].Bounds.IntersectsWith(spawnPos3.Bounds))
                {
                    carsAtSpawnPos[3]++;
                }
            }
            for (int j = 3; j >= 0; j--)
            {
                if(carsAtSpawnPos[j] >= 2)
                {
                    tooManyCarsAtPos[j] = true;
                }
            }

            //prevent freezing game if all the spots are taken
            if(tooManyCarsAtPos[0] && tooManyCarsAtPos[1] && tooManyCarsAtPos[2] && tooManyCarsAtPos[3])
            { return; }

            do  
            {
                startPos = rand.Next(0, START_POINTS * 100) % 4; //Randomly choosing starting point of a car
            } while (tooManyCarsAtPos[startPos]);
            //==================================================================
            Car carObj = new Car();
            PictureBox carPic = new PictureBox();

            carObj.Start = startPos;
            carObj.Stopped = false;
            carObj.ID = carID;
            carObj.set();

            //==============seting up a picture of a car========================
            if (carObj.Start == 0 || carObj.Start == 2)  //horizontal movement
            {
                carPic.Width = Car.CAR_LENGHT;
                carPic.Height = Car.CAR_WIDTH;
            }
            if (carObj.Start == 1 || carObj.Start == 3) //vertical movement
            {
                carPic.Width = Car.CAR_WIDTH;
                carPic.Height = Car.CAR_LENGHT;
            }
            carPic.BackColor = Color.Red; //<-- change to image
            carPic.Location = new Point(carObj.X, carObj.Y);
            //==================================================================

            carsObj.Add(carObj);
            carsPic.Add(carPic);

            carPic.Click += CarPic_Click;

            //Console.WriteLine(carPic.Location);

            this.Controls.Add(carPic);
            carPic.BringToFront();
            carID++;
        }

        //Stopping car when clicked
        private void CarPic_Click(object sender, EventArgs e)
        {
            PictureBox temPic = sender as PictureBox;
            int index = carsPic.IndexOf(temPic);
            carsObj[index].Stopped = !carsObj[index].Stopped;
        }


        //Changing button when hovered
        //=======================================================================
        private void startButton_MouseHover(object sender, EventArgs e)
        {
            startButton.Image = Properties.Resources.buttonEmptyHovered_150x75;
        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.Image = Properties.Resources.buttonEmpty_150x75;
        }

        private void restartButton_MouseHover(object sender, EventArgs e)
        {
            restartButton.Image = Properties.Resources.buttonEmptyHovered_150x75;
        }

        private void restartButton_MouseLeave(object sender, EventArgs e)
        {
            restartButton.Image = Properties.Resources.buttonEmpty_150x75;
        }
        //=========================================================================

        //===============Handling closing app======================================
        public void Show(MainMenu menu)
        {
            mainMenu = menu;
            this.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainMenu.Show();
        }
        //=========================================================================
    }
}