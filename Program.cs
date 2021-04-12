﻿using System;
using ExcecoesPersonalizadas.Entities;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            System.Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            if (checkOut <= checkIn)
            {
                System.Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                System.Console.WriteLine(reservation);

                System.Console.WriteLine();
                System.Console.WriteLine("Enter date to update the reservation:");
                System.Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    System.Console.WriteLine("Error in reservation: Reservation dates for updates must be futures dates");
                }
                else if (checkOut <= checkIn)
                {
                    System.Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    System.Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
