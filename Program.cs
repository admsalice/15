//Напишите программу, 
//которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int Prompt(string message)
{
Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}
bool IsWeekend(int weekday)
{
if (weekday > 5)
{
return true;
}
return false;
}
bool ValidateWeekday(int number)
{
if (number > 0 && number <= 7)
{
return true;
}
Console.WriteLine("Это совсем не день недели");
return false;
}
int weekday = Prompt("Введите день недели >");
if (ValidateWeekday(weekday))
{
    if (IsWeekend(weekday))
    {
        Console.WriteLine("Ура выходной !");
    }
    else
    {
        Console.WriteLine("Снова на работу");
    }
}