// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static void calc()
{
    while (true)
    {
        double num1;
        double num2;
        string symbol;
        double result;
        bool parseB;
        double parseout;

        Console.WriteLine("Enter first number:");
        parseB = double.TryParse(Console.ReadLine(), out num1);

        if(!parseB)
        {
            Console.WriteLine("erreur");
            continue;
        }

        Console.WriteLine("Enter second number:");
        parseB = double.TryParse(Console.ReadLine(), out num2);

        Console.WriteLine("Enter symbol(+,-,*,/):");
        symbol = Console.ReadLine();


        switch (symbol)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine("Addition:" + result);
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine("Subtraction:" + result);
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine("Multiplication:" + result);
                break;

            case "/":
                result = num1 / num2;
                Console.WriteLine("Division:" + result);
                break;
        }
    }
}

calc();