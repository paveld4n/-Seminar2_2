int randomNum = GetRandomNum(100, 1000);
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

int[] array = new int[3];
int number = 153;

for(int i = 0; i < array.Length; i++)
{
    int lastValue = number % 10;
    array[i] = lastValue;
    number = number /10;
}