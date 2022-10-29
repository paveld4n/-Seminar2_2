int randomNum = GetRandomNum(10, 100);
Console.WriteLine(randomNum);

int maxNumber = FindMaxNumber(randomNum);
Console.WriteLine($"Большее число - {maxNumber}");

int FindMaxNumber(int number)
{
    int max = number % 10;
    number = number / 10;
       while (number > 0)
    {
        int lastNum = number % 10;
        if (lastNum > max)
        {
            max = lastNum;
        }
        number = number / 10;
    }
    return max;
}





int GetRandomNum(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNum = random.Next(minValue, maxValue);
    return randomNum;
}