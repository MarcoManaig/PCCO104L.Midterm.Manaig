using System;

namespace Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            int fanSpeed = getFanSpeed();
            bool oscillate = getOscillate();
            int fanPowerOutput = getFanPower(fanSpeed);

            if (oscillate)
            {
                Oscillate(fanPowerOutput);
            }
            else
            {
                Steady(fanPowerOutput);
            }
        }

        static int getFanSpeed()
        {
            int fanSpeed;
            while (true)
            {
                Console.Write("Enter fan speed (1, 2, or 3): ");
                if (int.TryParse(Console.ReadLine(), out fanSpeed) && fanSpeed >= 1 && fanSpeed <= 3)
                {
                    return fanSpeed;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid fan speed (1, 2, or 3).");
                }
            }
        }

        static bool getOscillate()
        {
            while (true)
            {
                Console.Write("Do you want to oscillate the fan? (Y/N): ");
                string input = Console.ReadLine().Trim().ToUpper();
                if (input == "Y")
                {
                    return true;
                }
                else if (input == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter 'Y' or 'N'.");
                }
            }
        }

        static int getFanPower(int fanSpeed)
        {
            const int baseFanPower = 10;
            return baseFanPower * fanSpeed;
        }

        static void Oscillate(int fanPowerOutput)
        {
            for (int i = 1; i <= fanPowerOutput; i++)
            {
                Console.WriteLine(new string('~', i));
            }
            for (int i = fanPowerOutput; i >= 1; i--)
            {
                Console.WriteLine(new string('~', i));
            }
        }

        static void Steady(int fanPowerOutput)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('~', fanPowerOutput));
            }
        }
    }
}