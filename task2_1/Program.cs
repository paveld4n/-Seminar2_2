int number = GetRandomNumber(100, 1000);
int result = DeleteSecondDigit(number);
Console.WriteLine($"Выпавшее число - {number}");
Console.WriteLine($"Без средней цифры - {result}");

int DeleteSecondDigit(int number)
{
    int lastNum = number % 10;
    number = number / 100;
    int result = number * 10 + lastNum;
    return result;
}

int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}