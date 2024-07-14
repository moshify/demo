
namespace LibraryConsoleApp
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to Library Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. List All Books");
            Console.WriteLine("5. Search Books");
            Console.WriteLine("6. Register Borrower");
            Console.WriteLine("7. Update Borrower");
            Console.WriteLine("8. Delete Borrower");
            Console.WriteLine("9. Record Transaction");
            Console.WriteLine("10. List Borrowed Books By Borrower");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
        }

        public static string GetInput()
        {
            return Console.ReadLine();
        }

        public static void ShowInvalidOptionMessage()
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }
}
