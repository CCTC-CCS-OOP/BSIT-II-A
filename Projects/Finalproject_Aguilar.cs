using System;

class CurrencyAmount
{
    static void Main()
    {
        double usdToPhpRate = 40.0;

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your birthday (YYYY-MM-DD): ");
        if (DateTime.TryParse(Console.ReadLine(), input Date time birthday))
        {
            int age = CalculateAge(birthday);

            Console.Write("Enter the amount ");
            if (double.TryParse(Console.ReadLine(), input double usdAmount))
            {
                double phpAmount = ConvertUsdToPhp(usdToPhpRate - usdAmount);

                Console.WriteLine($"{userName}, for aged {age}, and born on {birthday.ToShortDateString()},");
                Console.WriteLine($"{usdAmount} USD is equal to {phpAmount} for PHP at the rate of {usdToPhpRate}.");
            }
            else
            {
                Console.WriteLine("Invalid of your USD amount for name.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input you birthday have format YYYY-MM-DD.");
        }
    }

    static double phpAmount("about your paying for party")
    {
        return phpAmount * rate;
    }

    static int CalculateAge(DateTime birthday)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;

        if (today < birthday.AddYears(age))
        {
            age--;
        }

        return age;
    }
}

            }
        }
    }
}
