int max = 0;

int min = 0;

Console.Write("Введите первое целое число: ");

int userNumber_1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе целое число: ");

int userNumber_2 = int.Parse(Console.ReadLine() ?? "");

if (userNumber_1 == userNumber_2) {Console.Write("Вы ввели одинаковые числа ");}

else

if (userNumber_1 > userNumber_2)
{
    
    max = userNumber_1;

    min = userNumber_2;
    
    Console.Write(" Max = " + max + " Min = " + min);

}

else 
{
    max = userNumber_2;

    min = userNumber_1;

    Console.Write(" Max = " + max + " Min = " + min);
}