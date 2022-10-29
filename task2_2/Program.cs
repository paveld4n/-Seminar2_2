// Принимает число и решает кратно 23 и 7
int number = 161;

CompareNumder(number);
void CompareNumder(int num)
{
    int result1 = num % 7;
    int result2 = num % 23;
    if(result1 ==0 & result2 == 0)
    {
        Console.WriteLine("Полученное число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Полученное число НЕ кратно 7 и 23");
    }
}