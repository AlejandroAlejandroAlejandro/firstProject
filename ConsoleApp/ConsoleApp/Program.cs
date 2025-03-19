namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {

        int numberOfStudents;
        bool successfulConversion;
        string userInput;


        Console.Write("Enter number of students in class: ");
        userInput = Console.ReadLine();
        successfulConversion = int.TryParse(userInput, out numberOfStudents);

        while (!successfulConversion || numberOfStudents <= 0)
        {
            if (!successfulConversion || numberOfStudents <= 0)
            {
                Console.WriteLine("Invalid! Please try again.");
                Console.Write("Enter number of students in class: ");
                userInput = Console.ReadLine();
                successfulConversion = int.TryParse(userInput, out numberOfStudents);
            }
        }

        Console.WriteLine($"There are {numberOfStudents} students in the class.");
        Console.WriteLine("Press 'Enter' to exit...");
        Console.ReadLine();

    }
}

