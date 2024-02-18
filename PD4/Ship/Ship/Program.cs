using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using Ship.BL;

namespace Ship
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int option;
            string ShipNumber;
            int Degrees;
            float Minutes;
            char Direction;
            List<Ship1> MyData = new List<Ship1>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press 1 to add Ships");
                Console.WriteLine("Press 2 view ship position");
                Console.WriteLine("Press 3 to view ship serial number");
                Console.WriteLine("Press 4 to change ship position");
                Console.WriteLine("Press 5 to exit");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter ship number");
                    ShipNumber = Console.ReadLine();
                    Console.WriteLine("Enter Ship's Latitude");
                    Console.WriteLine("Enter Latitude's degree");
                    Degrees = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's minutes");
                    Minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's direction");
                    Direction = char.Parse(Console.ReadLine());
                    Angle Latitude = new Angle(Degrees, Minutes, Direction);
                    Console.WriteLine("Enter Ship's Longitude");
                    Console.WriteLine("Enter Longitude's degree");
                    Degrees = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's minutes");
                    Minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's direction");
                    Direction = char.Parse(Console.ReadLine());
                    Angle Longitude = new Angle(Degrees, Minutes, Direction);

                    Ship1 Info = new Ship1(ShipNumber, Latitude, Longitude);
                    MyData.Add(Info);

                }

                else if (option == 2)
                {
                    Console.Clear();
                    string Serial;
                    bool found = false;
                    Console.WriteLine("Enter Ship's serial number to find its position: ");
                    Serial = Console.ReadLine();
                    foreach (Ship1 Display in MyData)
                    {
                        if (Display.ShipNumber == Serial)
                        {
                            Console.WriteLine("Ship is at " + Display.Latitude.AngleS() + " and " + Display.Longitude.AngleS());
                            Console.ReadLine();
                            found = true;
                            break;
                        }

                    }
                    if (!found)
                    {
                        Console.WriteLine("Ship not found");
                        Console.ReadLine();
                    }
                }
                else if (option == 3)
                {
                    bool found = false;
                    int LatitudeDegreeCheck;
                    float LatitudeMinuteCheck;
                    char LatitudeDirectionCheck;
                    int LongitudeDegreeCheck;
                    float LongitudeMinutecheck;
                    char LongitudeDirectionCheck;
                    Console.WriteLine("Enter ship's Latitude Degrees: ");
                    LatitudeDegreeCheck = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ship's Latitude Minutes: ");
                    LatitudeMinuteCheck = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ship's Latitude Direction: ");
                    LatitudeDirectionCheck = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ship's Longitude Degrees: ");
                    LongitudeDegreeCheck = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ship's Longitude Minutes: ");
                    LongitudeMinutecheck = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ship's Longitude Direction: ");
                    LongitudeDirectionCheck = char.Parse(Console.ReadLine());

                    foreach (Ship1 check in MyData)
                    {
                        if (LatitudeDegreeCheck == check.Latitude.Degrees && LatitudeMinuteCheck == check.Latitude.Minutes && LatitudeDirectionCheck == check.Latitude.Direction && LongitudeDegreeCheck == check.Longitude.Degrees && LongitudeMinutecheck == check.Longitude.Minutes && LongitudeDirectionCheck == check.Longitude.Direction)
                        {
                            Console.WriteLine("Ship Number is {0}", check.ShipNumber);
                            Console.ReadLine();
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Ship not found");
                        Console.ReadLine();
                    }
                }
                else if (option == 4)
                {
                    string SerialNumber;
                    Console.WriteLine("Enter ships's serial number");
                    SerialNumber = Console.ReadLine();
                    bool found = false;
                    foreach (Ship1 check in MyData)
                    {
                        if (SerialNumber == check.ShipNumber)
                        {
                            Console.WriteLine("Enter Ship's Latitude");
                            Console.WriteLine("Enter Latitude's degree");
                            Degrees = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Latitude's minutes");
                            Minutes = float.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Latitude's direction");
                            Direction = char.Parse(Console.ReadLine());
                            Angle LatitudeUpdate = new Angle(Degrees, Minutes, Direction);
                            Console.WriteLine("Enter Ship's Longitude");
                            Console.WriteLine("Enter Longitude's degree");
                            Degrees = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Longitude's minutes");
                            Minutes = float.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Longitude's direction");
                            Direction = char.Parse(Console.ReadLine());
                            Angle LongitudeUpdate = new Angle(Degrees, Minutes, Direction);

                            Ship1 InfoUpdate = new Ship1(SerialNumber, LatitudeUpdate, LongitudeUpdate);
                            MyData[MyData.IndexOf(check)] = InfoUpdate;
                            found = true;   
                            break;
                        }
                    }
                    if (found)
                    {
                        Console.Clear();
                        Console.WriteLine("UPDATED SUCCESSFULLY");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Ship not found");
                        Console.ReadLine();
                    }
                }
                else if (option==5)
                {
                    break;
                }
            }
        }
    }
}
