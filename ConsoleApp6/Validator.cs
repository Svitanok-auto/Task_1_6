using System;

namespace ConsoleApp6
{
    public class Validator 
    {
        public const int MAX_ATTEMPTS = 30;

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

        public int GetChoiceToShowGarland()
        {
            Console.WriteLine("\nPopulate 1 to see Ordinary Garland or 2 to see Colored Garland: ");
            int attempt = 0;
            int choiceToSeeGarland = 0;
            while (attempt < MAX_ATTEMPTS)
            {
                string inputString = Console.ReadLine();
                if ((inputString.ToString() != string.Empty) && ((inputString.ToString() == "1") || (inputString.ToString() == "2")))
                {
                    try
                    {
                        if ((inputString.IndexOf('0') != -1) && (inputString.Length == 1))
                        {
                            Console.WriteLine("\nIncorrect Input: Zero is not allowed ");
                            attempt++;
                            continue;
                        }
                        else
                        {
                            choiceToSeeGarland = Convert.ToInt32(inputString);
                            Console.WriteLine("\n Choice is= " + choiceToSeeGarland);
                            return choiceToSeeGarland;
                        }
                    }
                    catch (SystemException ex)
                    {
                        Console.WriteLine("\nIncorrect Input, error: " + ex.Message);
                        Console.WriteLine("\nMake a choice 1 or 2");
                        attempt++;
                    }
                }
                else
                {
                    Console.WriteLine("\nIncorrect Input: Such value is not allowed");
                }
            }
        return 0;
        }

    }
}
