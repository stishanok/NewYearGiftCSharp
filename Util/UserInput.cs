using System;

namespace Util
{
    public class UserInput
    {
        private const string MSG_ERROR_INPUT__NUMBER = "Error! Data is not number!";
        private const string MSG_ERROR_INPUT_POSITIV_NUMBER = "Error! Data is not positiv number!";
        private static double GetNumber(string msg)
        {
            while (true)
            {
                Console.Write(msg);

                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(MSG_ERROR_INPUT__NUMBER);
                }
            }
        }
        
        private static bool IsPositivNumber(double number)
        {
            return number >= 0;
        }

        public static double GetPositivNumber(string msg)
        {
            while (true)
            {
                double number = GetNumber(msg);

                if (IsPositivNumber(number))
                {
                    return number;
                }

                Console.WriteLine(MSG_ERROR_INPUT_POSITIV_NUMBER);
            }
        }
    }
}