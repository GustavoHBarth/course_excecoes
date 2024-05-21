using System;
using course_exceções.Entities;

namespace course_exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados da reserva
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //Testar se pode instanciar ou não
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation checkOut <= checkIn");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation" + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                
                //Atualizar reserva
                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation");
                }
                else if (checkOut <= checkIn) 
                {
                    Console.WriteLine("Error in reservation checkOut <= checkIn");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }

           



        }
    }
}
