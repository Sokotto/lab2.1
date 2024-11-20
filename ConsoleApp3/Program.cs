try
{
    Console.WriteLine("Введите число A: ");
    if (int.TryParse(Console.ReadLine(), out int A))
    {
        bool isFourDigit = (A >= 1000 && A <= 9999);
        bool isNot4999 = (A != 4999);

        if (isFourDigit && isNot4999)
        {
            Console.WriteLine("Число A является четырехзначным и не равно 4999.");
        }
        else
        {
            Console.WriteLine("Число A не удовлетворяет условиями.");
        }
    }
}
catch
{
    Console.WriteLine("Введите правильно!");
}