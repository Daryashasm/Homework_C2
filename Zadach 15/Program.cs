Console.Write("Введите номер дня: ");
int numberDay = int.Parse(Console.ReadLine());
if (numberDay == 1)
{
    Console.WriteLine($"{numberDay} день недели - это ПОНЕДЕЛЬНИК, рабочий день");
}
else if (numberDay == 2)
{
     Console.WriteLine($"{numberDay} день недели - это ВТОРНИК, рабочий день");
}
else if (numberDay == 3)
{
     Console.WriteLine($"{numberDay} день недели - это СРЕДА, маленькая пятница, но рабочий день");
}
else if (numberDay == 4)
{
     Console.WriteLine($"{numberDay} день недели - это ЧЕТВЕРГ, рабочий день");
}
else if (numberDay == 5)
{
     Console.WriteLine($"{numberDay} день недели - это ПЯТНИЦА, рабочий день, а завтра уже будет выходной");
}
else if (numberDay == 6)
{
     Console.WriteLine($"{numberDay} день недели - это СУББОТА, выходной день");
}
else if (numberDay == 7)
{
     Console.WriteLine($"{numberDay} день недели - это ВОСКРЕСЕНЬЕ, выходной день, а завтра на работу");
}
else
{
     Console.WriteLine($"{numberDay} - такого дня недели нет, в 1 неделе всего 7 дней");
}