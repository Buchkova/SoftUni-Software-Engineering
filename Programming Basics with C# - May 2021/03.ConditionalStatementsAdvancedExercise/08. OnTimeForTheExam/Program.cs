using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfTheExam = int.Parse(Console.ReadLine());
            int minuteОfТheЕxam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            string arrivalTime = "";
            int timeOfTheExam = (hourOfTheExam * 60) + minuteОfТheЕxam;
            int timeOfArrival = (hourOfArrival * 60) + minuteOfArrival;
            int hours = Math.Abs((timeOfArrival - timeOfTheExam) / 60);
            int minutes = Math.Abs((timeOfArrival - timeOfTheExam) % 60);


            if (timeOfArrival > timeOfTheExam)
            {
                arrivalTime = "Late";
            }
            else if (timeOfTheExam == timeOfArrival || (timeOfTheExam > timeOfArrival && (timeOfTheExam - timeOfArrival) <= 30))
            {
                arrivalTime = "On time";
            }
            else if ((timeOfTheExam - timeOfArrival) > 30)
            {
                arrivalTime = "Early";
            }

            if (timeOfArrival <= (timeOfTheExam + 1) && timeOfArrival < timeOfTheExam)
            {
                if (hours >= 1)
                {
                    Console.WriteLine(arrivalTime);
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
                else if (hours == 0 && timeOfArrival < timeOfTheExam)
                {
                    Console.WriteLine(arrivalTime);
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if (timeOfArrival >= (timeOfTheExam + 1) && timeOfArrival > timeOfTheExam)
            {
                if (hours >= 1)
                {
                    Console.WriteLine(arrivalTime);
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
                else if (hours == 0 && timeOfArrival > timeOfTheExam)
                {
                    Console.WriteLine(arrivalTime);
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
            }
        }
    }
}