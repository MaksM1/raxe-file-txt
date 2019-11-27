using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_
{
    public class SpeedRaceAuto
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null && value.Length > 100)
                {
                    throw new Exception("Incorrect data");

                }
                else name = value;
            }
        }

        private string car;
        public string Car
        {
            get { return car; }
            set
            {
                if (value == null && value.Length > 100)
                {
                    throw new Exception("Incorrect data");

                }
                else car = value;
            }
        }

        private int amountCircle;
        public int AmountCircle
        {
            get { return amountCircle; }
            set
            {
                if (value == 0 && value > 500)
                {
                    throw new Exception("Incorrect data");

                }
                else amountCircle = value;
            }
        }
        private int distance;

        public int Distance
        {
            get { return distance; }
            set
            {
                if (value <= 10)
                {
                    throw new Exception("Incorrect data");

                }
                else distance = value;
            }
        }

        private double time;
        public double Time
        {
            get { return distance; }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Incorrect data");

                }
                else time = value;
            }
        }

       public string NameRace { get; private set; }
        public SpeedRaceAuto(string nameRace) 
        {
            if (nameRace == null)
            {
                throw new Exception("Incorrect data");
            } else NameRace = nameRace;
        } 
        public double AverageSpeed(int AmountCircle,double Time,int Distance)
        {
            double speed = (double)(AmountCircle * Distance / 1000) / (Time /60);
            return speed;
        }
     }
}
