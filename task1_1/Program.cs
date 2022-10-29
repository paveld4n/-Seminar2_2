﻿int randomNum = GetRandomNum(10, 100);
Console.WriteLine(randomNum);

int max = randomNum % 10; /// задается последнее число, корое решено считать максимальным
randomNum = randomNum / 10; /// переменная уменьшается на 1 разряд

while(randomNum > 0)
{
    Console.WriteLine($"Random number - {randomNum}");
    int lastNum = randomNum % 10;
    if (lastNum > max)
    {
        max = lastNum;
    }
    randomNum = randomNum / 10;
}
Console.WriteLine($"Большее число - {max}");

int GetRandomNum(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNum = random.Next(minValue, maxValue);
    return randomNum;
}