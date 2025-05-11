using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("請輸入兩個數字：");
        Console.Write("第一個數字：");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("第二個數字：");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("請選擇運算 (+, -, *, /):");
        string operation = Console.ReadLine() ?? string.Empty;

        double result = 0;
        if (operation == "+")
            result = num1 + num2;
        else if (operation == "-")
            result = num1 - num2;
        else if (operation == "*")
            result = num1 * num2;
        else if (operation == "/")
        {
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("除數不能為 0!");
                return;
            }
        }
        else
        {
            Console.WriteLine("無效的運算符！");
            return;
        }

        Console.WriteLine("結果是：" + result);
    }
}