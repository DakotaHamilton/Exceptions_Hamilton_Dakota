using System;

namespace Exceptions_Hamilton_Dakota
{
    class Program
    {
        /// <summary>
        /// SPITS OUT A RANDOM NUMBER RESULT AFTER A NUMBER IS GIVEN
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            float myCurrentAge = 20f;
            float myBirthday = 0f;
            float result = 0f;

            Random r = new Random();
            int ageRange = r.Next(2, 30);

            try
            {
                result = Divide(myCurrentAge, myBirthday);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter number other than zero");
                myBirthday = (float) Convert.ToDouble(Console.ReadLine());
                try
                {
                    result = Divide(myCurrentAge, myBirthday);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
            finally
            {
                Console.WriteLine("Calculations completed, with result of" + result);
            }
            try
            {
                CheckAge(ageRange);
            }
            catch
            {
                Console.WriteLine("Unable to Calculate age...");
            }
        }
        static float Divide(float x, float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }
        static void CheckAge(int age)
        {
            if (age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
