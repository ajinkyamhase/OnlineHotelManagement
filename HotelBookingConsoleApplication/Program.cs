using System;
using HotelManagementSystem.PresentationLayer;

namespace HotelBookingConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Hotel Management System!");
                Console.WriteLine("1. Login as Customer");
                Console.WriteLine("2. Login as Admin");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (LoginAsCustomer())
                        {
                            HandleCustomerRole();
                        }
                        break;
                    case "2":
                        if (LoginAsAdmin())
                        {
                            HandleAdminRole();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Thank you for using Hotel Management System!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static bool LoginAsCustomer()
        {
            Console.Clear();
            Console.WriteLine("Customer Login:");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Hardcoded credentials 
            if (username == "customer" && password == "password")
            {
                Console.WriteLine("Customer login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                return false;
            }
        }

        static bool LoginAsAdmin()
        {
            Console.Clear();
            Console.WriteLine("Admin Login:");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Hardcoded credentials
            if (username == "admin" && password == "adminpassword")
            {
                Console.WriteLine("Admin login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                return false;
            }
        }

        static void HandleCustomerRole()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Customer Menu:");
                Console.WriteLine("1. Book a Room");
                Console.WriteLine("2. Update Booking");
                Console.WriteLine("3. Cancel Booking");
                Console.WriteLine("4. View Booking");
                Console.WriteLine("5. List Bookings");
                Console.WriteLine("6. Logout");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PresentationLayer.SelectRoomCategory();
                        BookingPL.BookRoom();
                        break;
                    case "2":
                        BookingPL.UpdateBooking();
                        break;
                    case "3":
                        BookingPL.CancelBooking();
                        break;
                    case "4":
                        BookingPL.ViewBooking();
                        break;
                    case "5":
                        BookingPL.ListBookings();
                        break;
                    case "6":
                        return; // Logout and return to main menu
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void HandleAdminRole()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Manage Hotels");
                Console.WriteLine("2. Manage Hotel Categories");
                Console.WriteLine("3. Manage Rooms");
                Console.WriteLine("4. Manage Room Categories");
                Console.WriteLine("5. View Bookings");
                Console.WriteLine("6. Generate Bill");
                Console.WriteLine("7. Update Bill");
                Console.WriteLine("8. Refund Bill");
                Console.WriteLine("9. Logout");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ManageHotels();
                        break;
                    case "2":
                        ManageHotelCategories();
                        break;
                    case "3":
                        ManageRooms();
                        break;
                    case "4":
                        ManageRoomCategories();
                        break;
                    case "5":
                        BookingPL.ListBookings();
                        break;
                    case "6":
                        BillPL.GenerateBill();
                        break;
                    case "7":
                        BillPL.UpdateBill();
                        break;
                    case "8":
                        BillPL.Refund();
                        break;
                    case "9":
                        return; // Logout and return to main menu
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void ManageHotels()
        {
            Console.Clear();
            Console.WriteLine("Hotel Management:");
            Console.WriteLine("1. Add Hotel");
            Console.WriteLine("2. Update Hotel");
            Console.WriteLine("3. Delete Hotel");
            Console.WriteLine("4. View Hotel");
            Console.WriteLine("5. List Hotels");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PresentationLayer.AddHotel();
                    break;
                case "2":
                    PresentationLayer.UpdateHotel();
                    break;
                case "3":
                    PresentationLayer.DeleteHotel();
                    break;
                case "4":
                    PresentationLayer.ViewHotel();
                    break;
                case "5":
                    PresentationLayer.ListHotels();
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        static void ManageHotelCategories()
        {
            Console.Clear();
            Console.WriteLine("Hotel Category Management:");
            Console.WriteLine("1. Add Hotel Category");
            Console.WriteLine("2. Update Hotel Category");
            Console.WriteLine("3. Delete Hotel Category");
            Console.WriteLine("4. View Hotel Category");
            Console.WriteLine("5. List Hotel Categories");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PresentationLayer.AddHotelCategory();
                    break;
                case "2":
                    PresentationLayer.UpdateHotelCategory();
                    break;
                case "3":
                    PresentationLayer.DeleteHotelCategory();
                    break;
                case "4":
                    PresentationLayer.ViewHotelCategory();
                    break;
                case "5":
                    PresentationLayer.ListHotelCategories();
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        static void ManageRooms()
        {
            Console.Clear();
            Console.WriteLine("Room Management:");
            Console.WriteLine("1. Add Room");
            Console.WriteLine("2. Update Room");
            Console.WriteLine("3. Delete Room");
            Console.WriteLine("4. View Room");
            Console.WriteLine("5. List Rooms");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PresentationLayer.AddRoom();
                    break;
                case "2":
                    PresentationLayer.UpdateRoom();
                    break;
                case "3":
                    PresentationLayer.DeleteRoom();
                    break;
                case "4":
                    PresentationLayer.ViewRoom();
                    break;
                case "5":
                    PresentationLayer.ListRooms();
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        static void ManageRoomCategories()
        {
            Console.Clear();
            Console.WriteLine("Room Category Management:");
            Console.WriteLine("1. Add Room Category");
            Console.WriteLine("2. Update Room Category");
            Console.WriteLine("3. Delete Room Category");
            Console.WriteLine("4. View Room Category");
            Console.WriteLine("5. List Room Categories");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PresentationLayer.AddRoomCategory();
                    break;
                case "2":
                    PresentationLayer.UpdateRoomCategory();
                    break;
                case "3":
                    PresentationLayer.DeleteRoomCategory();
                    break;
                case "4":
                    PresentationLayer.ViewRoomCategory();
                    break;
                case "5":
                    PresentationLayer.ListRoomCategories();
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
