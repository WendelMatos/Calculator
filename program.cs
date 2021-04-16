using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            // Declare as variáveis e inicialize com zero.
            double num1 = 0; double num2 = 0;

            // Display title as the C# console calculator app.
            // Exibe o título como o aplicativo de calculadora do console C #.
            Console.WriteLine("Console Calculator in C#\n");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            // Peça ao usuário para digitar o primeiro número.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            // Peça ao usuário para digitar o segundo número.
            Console.WriteLine("Type another number, and the press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to choose an option.
            // Peça ao usuário para escolher uma opção.
            Console.WriteLine("Choose an option from the following list");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option?");

            // Use a switch statement to do the math.
            // Use uma instrução switch para fazer as contas.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "b":
                    Console.WriteLine($"Your result:  {num1} - {num2} = " + (num1 - num2));
                    break;
                case "c":
                    Console.WriteLine($"Your result:  {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so
                    // Peça ao usuário para inserir um divisor diferente de zero até que o faça
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            // Aguarde a resposta do usuário antes de fechar.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
