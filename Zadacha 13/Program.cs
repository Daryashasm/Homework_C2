Console.Write("Введите число; А = ");
int numberA = Convert.ToInt32(Console.ReadLine());
numberA = Math.Abs(numberA);

if (numberA < 100)
{
     Console.WriteLine($"{numberA} - в этом числе нет третьей цифры");
}
else
{
    string numberB = numberA.ToString();
    Console.WriteLine($"{numberB[2]} - это третья цифра введенного числа");
}
