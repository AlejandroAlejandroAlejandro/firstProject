namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int numberOfStudents;
        bool successfulConversion;
        string userInput;

        Console.Write("Enter number of students in class: ");

        do
        {
            userInput = Console.ReadLine();
            successfulConversion = int.TryParse(userInput, out numberOfStudents);

            if (!successfulConversion || numberOfStudents <= 0)
            {
                Console.WriteLine("Invalid! Please try again.");
            }

        } while (!successfulConversion || numberOfStudents <= 0);
    }
}

