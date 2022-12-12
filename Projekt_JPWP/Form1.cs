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
        public const int START_POINTS = 4;
        public const int DESTINATION_POINTS = 4;

        public int carID = 0;
        public bool gameStarted = false;

        public int score = 0;
        public int highScore = 0; //docelowo czytane z pliku

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

        private void startButton_Click(object sender, EventArgs e)
        {
            gameStarted = true;
            SpawnCar();
        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void StartGame(object sender, MouseEventArgs e)
        {

        }

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {

        }

        private void SpawnCar()
        {
            Car carObj = new Car();
            PictureBox carPic = new PictureBox();

            carObj.Start = rand.Next(0, START_POINTS*100)%4;
            carObj.Stopped = false;
            carObj.ID = carID;
            carObj.set();

            //seting up a picture of a car
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
            carPic.BackColor = Color.Red;
            carPic.Location = new Point(carObj.X, carObj.Y);
            //

            carsObj.Add(carObj);
            carsPic.Add(carPic);

            carPic.Click += CarPic_Click;

            Console.WriteLine(carPic.Location);

            this.Controls.Add(carPic);
            carPic.BringToFront();
            carID++;
        }

        private void CarPic_Click(object sender, EventArgs e)
        {
            PictureBox temPic = sender as PictureBox;
            int index = carsPic.IndexOf(temPic);
            carsObj[index].Stopped = !carsObj[index].Stopped;
            Console.WriteLine("Klik! " + carsObj[index].ID);
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            for (int i = carsObj.Count - 1; i>=0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (carsPic[i].Bounds.IntersectsWith(carsPic[j].Bounds) && (i != j))
                    {
                        Console.WriteLine("Kolizja " + carsObj[i].ID + " i " + carsObj[j].ID);
                        gameOver();
                    }
                }

                if (carsObj[i].ifOutOfBound())
                {
                    //Console.WriteLine(carsObj[i].ID + ", znikam");
                    carsObj.RemoveAt(i);
                    this.Controls.Remove(carsPic[i]);
                    carsPic.RemoveAt(i);

                    score++;
                    txtScoreInt.Text = score.ToString();
                }
                else if (!carsObj[i].Stopped && gameStarted)
                {
                    carsObj[i].move();
                    carsPic[i].Location = new Point(carsObj[i].X, carsObj[i].Y);
                }
            }
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

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
        }

        private void gameOver()
        {
            gameStarted = false;
            gameOverText.BringToFront();
            gameOverText.Visible = true;
            if(score > highScore) { highScore = score; }
            txtHighScoreInt.Text = highScore.ToString();
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
    }
}
