// // See https://aka.ms/new-console-template for more information
//  Console.WriteLine("Hello, World!");
while (true)
{
    Console.WriteLine("Введите Оператор");
    string Operator = Console.ReadLine();
    if (Operator == "end")
    {
        break;
    }
    Console.WriteLine("Введите первое число");

    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");

    int number2 = Convert.ToInt32(Console.ReadLine());   
     
    if (Operator == "+")
    {
        Console.WriteLine("Мы сложили числа");
        Console.WriteLine(number1 + number2);
    }
    else if (Operator == "-")
    {
        Console.WriteLine("Мы вычли числа");
        Console.WriteLine(number1 - number2);
    }
    else if (Operator == "*")
    {
        Console.WriteLine("Мы умножили числа");
        Console.WriteLine(number1 * number2);
    }
    else if (Operator == "/")
    {
        Console.WriteLine("Мы разделили числа");
        Console.WriteLine(number1 / number2);
    }
}

