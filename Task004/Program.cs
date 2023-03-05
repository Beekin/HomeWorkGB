Console.Write("Введите первое целое число: ");

int userNumber_1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе целое число: ");

int userNumber_2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье целое число: ");

int userNumber_3 = int.Parse(Console.ReadLine() ?? "");

int max = userNumber_1;

int min = userNumber_1;



if (userNumber_1 > userNumber_2)
{
    
    max = userNumber_1;

    min = userNumber_2;

    if (userNumber_3 > max)

    {

        max = userNumber_3;

        min = userNumber_2;

    }

}

else 
{
    max = userNumber_2;

    min = userNumber_1;

    if (userNumber_3 > max)

    {

        max = userNumber_3;
        
        min = userNumber_1;

    }

    else

    {

        if (userNumber_3 < min)
        {
            min = userNumber_3;
        }

    }

}

Console.Write(" Max = " + max + " Min = " + min);
