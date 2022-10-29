// Принимает два числа и решает является ли одно квадратом другого
Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = CheckSquare(num1, num2);
if(result)
{
    Console.WriteLine("Да, квадрат");
}
else
{
    Console.WriteLine("Нет, не квадрат");
}

// метод
bool CheckSquare(int firstNumber, int secondNumber)
{
    int square1 = firstNumber * firstNumber;
    int square2 = secondNumber * secondNumber;

    return square1 == secondNumber | square2 == firstNumber;
}