using System;

namespace ConsoleApp6
{
    public class Validator 
    {
        public const int MAX_ATTEMPTS = 10;

        public int GetCountOfLampsInGarland()
        {
            Console.WriteLine("\nPopulate how many lamps are in the garland, should be more than 3 ");
            int attempt = 0;
            int countOfLamps = 0;
            while (attempt < MAX_ATTEMPTS)
            {
                string inputString = Console.ReadLine();
                if (inputString.ToString() != string.Empty)
                {
                    try
                    {
                        if ((inputString.IndexOf('0') != -1) && (inputString.Length == 1))
                        {
                            Console.WriteLine("\nIncorrect Input: Zero is not allowed ");
                            attempt++;
                            continue;
                        }
                        else if (Convert.ToInt32(inputString) < 4)
                        {
                            Console.WriteLine("\nIncorrect Input: Values less than 3 are not allowed ");
                            attempt++;
                            continue;
                        }
                        else
                        {
                            countOfLamps = Convert.ToInt32(inputString);
                            Console.WriteLine("\n Count of Lamps in the garland= " + countOfLamps);
                            return countOfLamps;
                        }
                    }
                    catch (SystemException ex)
                    {
                        Console.WriteLine("\nIncorrect Input, error: " + ex.Message);
                        Console.WriteLine("\nTry again to populate correct count");
                        attempt++;
                    }
                }
                else
                {
                    Console.WriteLine("\nIncorrect Input: Empty value is not allowed");
                }
            }
        return 0;
        }
    }
}
