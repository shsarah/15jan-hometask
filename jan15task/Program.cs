using System.Security.Cryptography;

namespace jan15task;
class Program
{
    static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
        //Task4();
        //Task5();
        //Task6();
        //Task7();
        //Task8();
        //Task9();
        //Task11();
        //Task12();
        //Task13();
        //Task14();
        
    }
    static void Task1()
    {
        int n;
        int sum = 0;
    l1:
        Console.Write("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out n) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        if (n < 1000 || n > 9999)
        {
            Console.WriteLine("Enter a 4-digit number");
            goto l1;
        }
        else
        {

            while (n > 0)
            {
                sum = sum + (n % 10);
                n = n / 10;

            }
        }
        string result = $"Result: {sum}";
        Console.WriteLine(result);
    }

    static void Task2()
    {
        int n;
        int sum = 0;
    l1:
        Console.Write("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out n) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        if (n < 100000 || n > 999999)
        {
            Console.WriteLine("Enter a 6-digit number");
            goto l1;
        }
        else
        {
            if (Count(n) == 6)
            {
                n = (int)(n / (Math.Pow(10, (Count(n) - 3))));
                while (n > 0)
                {
                    sum = sum + (n % 10);
                    n = n / 10;
                }
            }

        }
        string result = $"Result: {sum} ";
        Console.WriteLine(result);

    }
    static int Count(int num1)
    {
        int count = 0;
        while (num1 > 0)
        {
            num1 = num1 / 10;
            count++;
        }
        return count;
    }

    static void Task3()
    {
        int n, mid;
        int sum = 0;
    l1:
        Console.Write("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out n) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        if (Count(n) != 9)
        {
            Console.WriteLine("Enter a 9-digit number");
            goto l1;
        }
        else
        {
            n = (int)(n / (Math.Pow(10, (Count(n) - 6))));
            mid = (int)(n % (Math.Pow(10, (Count(n) - 3))));
            while (mid > 0)
            {
                sum = sum + (mid % 10);
                mid = mid / 10;
            }

        }
        string result = $"Result: {sum} ";
        Console.WriteLine(result);
    }
    static void Task4()
    {
        int n, lastDigit;
        int sum = 0;
    l1:
        Console.Write("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out n) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        if (Count(n) != 5)
        {
            Console.WriteLine("Enter a 5-digit number");
            goto l1;
        }
        else
        {
            lastDigit = n % 10;
            n = (int)(n / (Math.Pow(10, (Count(n) - 1))));
            lastDigit = (int)(Math.Pow(lastDigit, 2));
            n = (int)(Math.Pow(n, 2));
            lastDigit = lastDigit + n;
        }
        string result = $"Result: {lastDigit} ";
        Console.WriteLine(result);
    }
    static void Task5()
    {
        int number;
        int newNumber;
    l1:
        Console.Write("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        if (Count(number) != 6)
        {
            Console.WriteLine("Enter a 6-digit number");
            goto l1;
        }
        else
        {
            newNumber = number;
            number = (int)(number / (Math.Pow(10, (Count(number) - 1))));
            newNumber = (int)(newNumber * (Math.Pow(10, (Count(number)))));
            newNumber = newNumber + number;
        }
        string result = $"Result: {newNumber} ";
        Console.WriteLine(result);
    }
    static void Task6()
    {
        int number, newNumber;
    l1:
        Console.Write("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        if (Count(number) != 8)
        {
            Console.WriteLine("Enter a 8-digit number");
            goto l1;
        }
        else
        {
            newNumber = number;
            number = (number - (number % 10)) / 10;
            number = (int)(number % (Math.Pow(10, (Count(number) - 1))));

        }
        string result = $"Result: {number} ";
        Console.WriteLine(result);

    }
    static void Task7()
    {
        int number;
        int reverseNumber = 0;
    l1:
        Console.Write("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        if (Count(number) != 4)
        {
            Console.WriteLine("Enter a 4-digit number");
            goto l1;
        }
        else
        {
            while (number > 0)
            {
                reverseNumber = (reverseNumber * 10) + (number % 10);
                number = number / 10;
            }

            reverseNumber = (reverseNumber * 10) + 8;


            reverseNumber = (reverseNumber + 800000);

        }
        string result = $"Result: {reverseNumber} ";
        Console.WriteLine(result);
    }
    static void Task8()
    {
        int number, lastDigit;
    l1:
        Console.Write("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        else
        {
            lastDigit = number % 10;
            number = (number / 100) % 10;
            lastDigit = lastDigit + number;

        }
        string result = $"Result: {lastDigit} ";
        Console.WriteLine(result);
    }
    static void Task9()
    {

        int number;
        int newNumber = 0;
        int newNumber1 = 0;

    l1:
        Console.WriteLine("Enter a new number:");
        if (int.TryParse(Console.ReadLine(), out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        else
        {
            while (number > 0)
            {
                int lastDigit = number % 10;
                newNumber = (newNumber * 10) + lastDigit;
                number = number / 10;
            }

            int i = 1;
            number = newNumber;
            newNumber = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                number = number / 10;
                if (i % 2 == 1)
                {
                    newNumber1 = newNumber1 * 10 + lastDigit;
                }
                i++;
            }
            Console.WriteLine($"Result: {newNumber1}");
        }
    }
    static void Task11()
    {
        int number, group;
        int sum = 0;
    l1:
        Console.Write("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        if (Count(number) != 8)
        {
            Console.WriteLine("Enter a 8-digit number");
            goto l1;
        }
        else
        {
            while (number > 0)
            {
                group = number % 100;
                sum = sum + group;
                number = number / 100;
            }
            sum = (sum * 100) + 99;
            sum = sum - ((sum * 18) / 100);

            Console.WriteLine($"Result: {sum} ");

        }
    }
    static void Task12()
    {
        int number1, number2;
        int sum = 0;
        int result = 1;
    l1:
        Console.Write("Enter first number:");
        if (int.TryParse(Console.ReadLine(), out number1) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }

        if (Count(number1) != 5)
        {
            Console.WriteLine("Enter a 5-digit number");
            goto l1;
        }
    l2:
        Console.Write("Enter second number:");
        if (int.TryParse(Console.ReadLine(), out number2) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l2;
        }

        if (Count(number2) != 5)
        {
            Console.WriteLine("Enter a 5-digit number");
            goto l2;
        }
        else
        {
            int number1Demo = number1;
            while (number1 > 0)
            {
                sum = sum + (number1 % 10);
                number1 = number1 / 10;

            }
            while (number2 > 0)
            {
                result = result * (number2 % 10);
                number2 = number2 / 10;
            }
            sum = sum + result;

            sum = (sum * 10) + (number1Demo % 10);
        }
        Console.WriteLine($"Result: {sum}");

    }
    static void Task13()
    {
        int number1, number2, number3;
        int sum = 0;
    l1:
        Console.Write("Enter first number:");
        if (int.TryParse(Console.ReadLine(), out number1) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }

        if (Count(number1) != 5)
        {
            Console.WriteLine("Enter a 5-digit number");
            goto l1;
        }
    l2:
        Console.Write("Enter second number:");
        if (int.TryParse(Console.ReadLine(), out number2) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l2;
        }

        if (Count(number2) != 5)
        {
            Console.WriteLine("Enter a 5-digit number");
            goto l2;
        }
    l3:
        Console.Write("Enter third number:");
        if (int.TryParse(Console.ReadLine(), out number3) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l3;
        }

        if (Count(number3) != 5)
        {
            Console.WriteLine("Enter a 5-digit number");
            goto l3;
        }
        else
        {
            sum = NewNumber(number1) + NewNumber(number2) + NewNumber(number3);
            sum = sum + (sum / 2);
        }
        Console.WriteLine($"Result: {sum}");
        static int NewNumber(int number)
        {
            int lastDigit = number % 10;
            int firstDigit = (int)(number / (Math.Pow(10, (Count(number) - 1))));
            lastDigit = firstDigit * 10 + lastDigit;
            return lastDigit;
        }

    }
    static void Task14()
    {
        int number1, number2, number3, number4;
        int sum = 0;

        int result = 1;
    l1:
        Console.Write("Enter first number:");
        if (int.TryParse(Console.ReadLine(), out number1) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }

        if (Count(number1) != 6)
        {
            Console.WriteLine("Enter a 6-digit number");
            goto l1;
        }
    l2:
        Console.Write("Enter second number:");
        if (int.TryParse(Console.ReadLine(), out number2) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l2;
        }

        if (Count(number2) != 6)
        {
            Console.WriteLine("Enter a 6-digit number");
            goto l2;
        }
    l3:
        Console.Write("Enter third number:");
        if (int.TryParse(Console.ReadLine(), out number3) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l3;
        }

        if (Count(number3) != 6)
        {
            Console.WriteLine("Enter a 6-digit number");
            goto l3;
        }
    l4:
        Console.Write("Enter fourth number:");
        if (int.TryParse(Console.ReadLine(), out number4) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l4;
        }

        if (Count(number3) != 7)
        {
            Console.WriteLine("Enter a 7-digit number");
            goto l4;
        }
        else
        {
            sum = NewNumber(number1) + NewNumber(number2) + NewNumber(number3);
            sum = sum + (number4 % 10000);
            number4 = number4 / 10000;
            while (number4 > 0)
            {
                result = result * (number4 % 10);
                number4 = number4 / 10;
            }
            sum = sum - result;
            sum = (sum * 60) / 100;
            sum = sum * 100 + 60;
            sum = sum - ((sum * 18) / 100);
            Console.WriteLine($"Result: {sum}");
        }
        static int NewNumber(int number)
        {
            number = (int)(number / (Math.Pow(10, (Count(number) - 3))));
            return number;
        }
    }
    static void Task15()
    {
      int number1, number2, number3, number4, number5;
      int sum = 0;
        int newNumber1 = 0;
        int sum1 = 0;
        int sum2 = 0;
      int newNumber = 0;
      int result = 1;
        l1:
            Console.Write("Enter first number:");
            if (int.TryParse(Console.ReadLine(), out number1) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l1;
            }

            if (Count(number1) != 3)
            {
                Console.WriteLine("Enter a 3-digit number");
                goto l1;
            }
        l2:
            Console.Write("Enter second number:");
            if (int.TryParse(Console.ReadLine(), out number2) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l2;
            }

            if (Count(number2) != 3)
            {
                Console.WriteLine("Enter a 3-digit number");
                goto l2;
            }
        l3:
            Console.Write("Enter third number:");
            if (int.TryParse(Console.ReadLine(), out number3) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l3;
            }

            if (Count(number3) != 6)
            {
                Console.WriteLine("Enter a 6-digit number");
                goto l3;
            }
        l4:
            Console.Write("Enter fourth number:");
            if (int.TryParse(Console.ReadLine(), out number4) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l4;
            }

            if (Count(number3) != 6)
            {
                Console.WriteLine("Enter a 6-digit number");
                goto l4;
            }
        l5:
            Console.Write("Enter fifth number:");
            if (int.TryParse(Console.ReadLine(), out number5) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l5;
            }

            if (Count(number3) != 7)
            {
                Console.WriteLine("Enter a 7-digit number");
                goto l5;
            }
            else
            {
                sum = number1 + number2;
                sum = (int)(Math.Pow((sum % 100), 2));
                newNumber = (number1 * 1000) + number2;
                newNumber = (newNumber * 1000) + number3;
                newNumber = sum + newNumber;
                newNumber = sum - (number5 % 100000);
                sum1 = number3 + number4;
                newNumber = newNumber + (sum1 % 1000);
            int number5Demo=number5
            while (number5 > 0)
            {
                sum2 = sum2 + (number5 % 10);
                number5 = number5 / 10;
            }
            while (sum2 > 0)
            {
                newNumber1 = newNumber1 * 10 + (sum2 % 10);
                sum2 = sum2 / 10;
            }
            newNumber = newNumber + newNumber1;
            newNumber = (newNumber * 100) + 11;

 
            }
        }

    }
}

    


