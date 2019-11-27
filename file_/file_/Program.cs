using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
        link: Console.WriteLine("1.add rider details \t 2.Data about all riders \t 3.End");
            try
            {
                SpeedRaceAuto raceAuto = new SpeedRaceAuto("Liman");
                int command = int.Parse(Console.ReadLine());
               switch (command)
                {
                    case 1:AddRacer(raceAuto);
                        goto link; 
                    case 2: ReadRacers();
                        goto link;
                    case 3:
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        private static void AddRacer(SpeedRaceAuto raceAuto)
        {
            try
            {
                Console.Write("Enter Name rider: ");
                string name = Console.ReadLine();
                Console.Write("Enter Car: ");
                string car = Console.ReadLine();
                Console.Write("Enter amount circle:");
                int amountCircle = int.Parse(Console.ReadLine());
                Console.Write("Enter distance of one circle in meters:");
                int distance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter time in minutes: ");
                double time = double.Parse(Console.ReadLine());



                using (var rider = new StreamWriter("tr.txt", true, Encoding.UTF8))
                {
                    rider.WriteLine($"Rider {raceAuto.Name} in car {raceAuto.Car}, " +
                            $"with averange speed {raceAuto.AverageSpeed(raceAuto.AmountCircle, raceAuto.Time, raceAuto.Distance)}");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void ReadRacers()
        {
            using (var sr = new StreamReader("tr.txt"))
            {
                var infoR = sr.ReadToEnd();
                Console.WriteLine(infoR);
            }
        }
    }
}
        
    

