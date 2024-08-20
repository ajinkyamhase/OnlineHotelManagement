using System;

namespace HotelManagementSystem.PresentationLayer
{

    public class PresentationLayer
    {
        public static void RegisterCustomer()
        {
            Console.Clear();
            Console.WriteLine("Customer Registration:");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Registration logic goes here

            Console.WriteLine("Customer registration successful!");
        }

        public static void RegisterAdmin()
        {
            Console.Clear();
            Console.WriteLine("Admin Registration:");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Registration logic goes here

            Console.WriteLine("Admin registration successful!");
        }
        // Hotel Management
        public static void AddHotel()
        {
            Console.WriteLine("Adding Hotel...");
            // Implement add hotel logic here
        }

        public static void UpdateHotel()
        {
            Console.WriteLine("Updating Hotel...");
            // Implement update hotel logic here
        }

        public static void DeleteHotel()
        {
            Console.WriteLine("Deleting Hotel...");
            // Implement delete hotel logic here
        }

        public static void ViewHotel()
        {
            Console.WriteLine("Viewing Hotel...");
            // Implement view hotel logic here
        }

        public static void ListHotels()
        {
            Console.WriteLine("Listing Hotels...");
            // Implement list hotels logic here
        }

        // Hotel Category Management
        public static void AddHotelCategory()
        {
            Console.WriteLine("Adding Hotel Category...");
            // Implement add hotel category logic here
        }

        public static void UpdateHotelCategory()
        {
            Console.WriteLine("Updating Hotel Category...");
            // Implement update hotel category logic here
        }

        public static void DeleteHotelCategory()
        {
            Console.WriteLine("Deleting Hotel Category...");
            // Implement delete hotel category logic here
        }

        public static void ViewHotelCategory()
        {
            Console.WriteLine("Viewing Hotel Category...");
            // Implement view hotel category logic here
        }

        public static void ListHotelCategories()
        {
            Console.WriteLine("Listing Hotel Categories...");
            // Implement list hotel categories logic here
        }

        // Room Management
        public static void AddRoom()
        {
            Console.WriteLine("Adding Room...");
            // Implement add room logic here
        }

        public static void UpdateRoom()
        {
            Console.WriteLine("Updating Room...");
            // Implement update room logic here
        }

        public static void DeleteRoom()
        {
            Console.WriteLine("Deleting Room...");
            // Implement delete room logic here
        }

        public static void ViewRoom()
        {
            Console.WriteLine("Viewing Room...");
            // Implement view room logic here
        }

        public static void ListRooms()
        {
            Console.WriteLine("Listing Rooms...");
            // Implement list rooms logic here
        }

        // Room Category Management
        public static void AddRoomCategory()
        {
            Console.WriteLine("Adding Room Category...");
            // Implement add room category logic here
        }

        public static void UpdateRoomCategory()
        {
            Console.WriteLine("Updating Room Category...");
            // Implement update room category logic here
        }

        public static void DeleteRoomCategory()
        {
            Console.WriteLine("Deleting Room Category...");
            // Implement delete room category logic here
        }

        public static void ViewRoomCategory()
        {
            Console.WriteLine("Viewing Room Category...");
            // Implement view room category logic here
        }

        public static void ListRoomCategories()
        {
            Console.WriteLine("Listing Room Categories...");
            // Implement list room categories logic here
        }

        // Booking Management
        public static void BookRoom()
        {
            Console.WriteLine("Booking Room...");
            // Implement booking room logic here
        }

        public static void UpdateBooking()
        {
            Console.WriteLine("Updating Booking...");
            // Implement update booking logic here
        }

        public static void CancelBooking()
        {
            Console.WriteLine("Canceling Booking...");
            // Implement cancel booking logic here
        }

        public static void ViewBooking()
        {
            Console.WriteLine("Viewing Booking...");
            // Implement view booking logic here
        }

        public static void ListBookings()
        {
            Console.WriteLine("Listing Bookings...");
            // Implement list bookings logic here
        }

        // Bill Management
        public static void GenerateBill()
        {
            Console.WriteLine("Generating Bill...");
            // Implement generate bill logic here
        }

        public static void UpdateBill()
        {
            Console.WriteLine("Updating Bill...");
            // Implement update bill logic here
        }

        public static void Refund()
        {
            Console.WriteLine("Refunding Bill...");
            // Implement refund bill logic here
        }

        public static void ViewBill()
        {
            Console.WriteLine("Viewing Bill...");
            // Implement view bill logic here
        }

        // Select Room Category for Customers
        public static void SelectRoomCategory()
        {
            Console.WriteLine("Selecting Room Category...");
            // Implement room category selection logic here
        }
    }
    public class BillPL
    {
        public static void GenerateBill()
        {
            Console.WriteLine("Generating Bill...");
            // Implement generate bill logic here
        }

        public static void UpdateBill()
        {
            Console.WriteLine("Updating Bill...");
            // Implement update bill logic here
        }

        public static void Refund()
        {
            Console.WriteLine("Refunding Bill...");
            // Implement refund logic here
        }

        public static void ViewBill()
        {
            Console.WriteLine("Viewing Bill...");
            // Implement view bill logic here
        }

        public static void ListBills()
        {
            Console.WriteLine("Listing Bills...");
            // Implement list bills logic here
        }
    }
    public class BookingPL
    {
        public static void BookRoom()
        {
            Console.WriteLine("Booking Room...");
            // Implement booking logic here
        }

        public static void UpdateBooking()
        {
            Console.WriteLine("Updating Booking...");
            // Implement update booking logic here
        }

        public static void CancelBooking()
        {
            Console.WriteLine("Canceling Booking...");
            // Implement cancel booking logic here
        }

        public static void ViewBooking()
        {
            Console.WriteLine("Viewing Booking...");
            // Implement view booking logic here
        }

        public static void ListBookings()
        {
            Console.WriteLine("Listing Bookings...");
            // Implement list bookings logic here
        }
    }
}
