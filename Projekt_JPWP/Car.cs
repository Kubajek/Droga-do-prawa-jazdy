using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_JPWP
{
    class Car
    {
        public const int CAR_LENGHT = 100;
        public const int CAR_WIDTH = 50;

        private const int SPEED = 4;  //Car speed
        public int X { get; set; }      //
        public int Y { get; set; }      //coordinates of car
        public int Start { get; set; }
        public int? ID { get; set; }
        public bool Stopped { get; set; }

        public Car()
        {
            
        }

        //Moving car
        public void move()
        {
            if (Start == 0)  //left screen side
            {
                X += SPEED;
            }
            if (Start == 1) //top screen side
            {
                Y += SPEED;
            }
            if (Start == 2) //right screen side
            {
                X -= SPEED;
            }
            if (Start == 3) //bottom screen side
            {
                Y -= SPEED;
            }

            //Console.WriteLine(ID + ", ruszam sie");
        }

        public void set()
        {
            //setting coordinates of starting point
            if (Start == 0)  //left screen side
            {
                X = 0;
                Y = 413;
            }
            if (Start == 1) //top screen side
            {
                X = 294;
                Y = 0;
            }
            if (Start == 2) //right screen side
            {
                X = 707;
                Y = 294;
            }
            if (Start == 3) //bottom screen side
            {
                X = 413;
                Y = 707;
            }

            Console.WriteLine(ID + ", " + Start + ", pojawiam sie");
        }

        public bool ifOutOfBound()
        {
            if ((Start == 0 && X >= 717 - CAR_LENGHT) || (Start == 1 && Y >= 717 - CAR_LENGHT) || (Start == 2 && X <= 12) || (Start == 3 && Y <= 12)) 
            {
                return true;
            }
            return false;
        }
    }
}
