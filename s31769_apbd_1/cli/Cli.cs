using DefaultNamespace;

namespace s31769_apbd_1.cli;

public class Cli
{
    private static LoanService _loanService = LoanService.getInstance();
    private static ReportService _reportService = ReportService.getInstance();
    private static UserService _userService = UserService.getInstance();


    static void programLoop()
    {

        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Add equipment");
            Console.WriteLine("2. Add user");
            Console.WriteLine("3. Borrow equipment");
            Console.WriteLine("4. Return equipment");
            Console.WriteLine("5. Show equipment list");
            Console.WriteLine("0. Exit");

            Console.Write("Choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    Console.WriteLine("TODO: return logic");
                    break;

                case "5":
                    break;

                case "0":
                    return;
            }
        }

    }
    
    private static void addEquipment()
    {
        Console.WriteLine("--- Add equipment ----");
        Console.WriteLine("-- Equipment type: ");
        Console.WriteLine("1. Laptop");
        Console.WriteLine("2. Camera");
        Console.WriteLine("3. Projector");
        
        
        
    }
}