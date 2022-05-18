using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double studentTicketCount = 0;
            double standartTicketCount = 0;
            double kidTicketCount = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                double ticketsSoldForMovie = 0;

                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    if (ticketType == "student")
                    {
                        studentTicketCount++;
                    }
                    else if (ticketType == "standard")
                    {
                        standartTicketCount++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketCount++;
                    }

                    ticketsSoldForMovie++;

                    if (ticketsSoldForMovie == availableSeats)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }

                double seatsTakenPercentage = ticketsSoldForMovie / availableSeats * 100;
                Console.WriteLine($"{movie} - {seatsTakenPercentage:F2}% full.");

                movie = Console.ReadLine();
            }

            double totalTickets = studentTicketCount + standartTicketCount + kidTicketCount;
            double standartTicketPercentage = (standartTicketCount / totalTickets) * 100;
            double studentTicketPercentage = (studentTicketCount / totalTickets) * 100;
            double kidTicketPercentage = (kidTicketCount / totalTickets) * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketPercentage:f2}% student tickets.");
            Console.WriteLine($"{standartTicketPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketPercentage:f2}% kids tickets.");
        }
    }
}
