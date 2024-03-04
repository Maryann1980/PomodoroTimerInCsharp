using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   
namespace PomodoroTimerInCsharp
{

    // Method to start a Pomodoro cycle
    internal class Time
    {

        public void StartPomodoro()
        {
            Console.WriteLine("Work for 25 minutes...");
            Timer(25);

            Console.WriteLine("Take a 5-minute break!");
            Timer(5);
        }
        // Private method to handle the timer logic
        private static void Timer(int minutes)
        {
            int seconds = minutes * 60; //calculates the total number of seconds based 60 minutes.

            while (seconds > 0) //starts a loop that continues until the remaining seconds reach zero.
            {
                Console.Clear();
                Console.WriteLine($"Time Remaining: {TimeFormat(seconds)}");//prints the remaining time to the console 
                Thread.Sleep(1000); // pauses the execution for one second to simulate the passage of time.
                seconds--; //decrements the remaining seconds.
            }

            Console.Clear();
            Console.WriteLine("Time's up!");
        }
        // Private method to format time in MM:SS
        private static string TimeFormat(int seconds)
        {
            int minutes = seconds / 60; //calculates the remaining minutes by dividing the remaining seconds by 60.
            int remainingSeconds = seconds % 60; //calculates the remaining seconds by taking the remainder when dividing the total seconds by 60.

            return $"{minutes:D2}:{remainingSeconds:D2}";//returns a string formatted as MM:SS,
             //ensuring that both minutes and seconds are displayed with leading zeros if needed.
        }
    }
}
