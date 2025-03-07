namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int numberOfStudents;
        bool successfulConversion;
        string userInput;        

        do
        {

            Console.Write("Enter number of students in class: ");

            userInput = Console.ReadLine();
            successfulConversion = int.TryParse(userInput, out numberOfStudents);

            if (!successfulConversion || numberOfStudents <= 0)
            {
                Console.WriteLine("Invalid! Please try again.");
            }

        } while (!successfulConversion || numberOfStudents <= 0);

        Console.WriteLine($"There are {numberOfStudents} in the class.");
    }
}

