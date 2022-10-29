int number = GetRandomNumber(100, 1000);
int result = DeleteSecondDigit(number);
Console.WriteLine(number);
Console.WriteLine(result);

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