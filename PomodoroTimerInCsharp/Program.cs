namespace PomodoroTimerInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pomodoro Timer!");
            Console.ReadLine();

            while (true)
            {
                // Create an instance of the Time class
                Time timer = new Time();
                Console.ReadLine();

                // Start the Pomodoro timer
                timer.StartPomodoro();
                Console.ReadLine();

                Console.WriteLine("Press 'Enter' to start the next Pomodoro or 'Ctrl + C' to exit.");
                //prompts the user to start the next Pomodoro cycle or exit the program.
                Console.ReadLine();
            }
        }
    }
}
