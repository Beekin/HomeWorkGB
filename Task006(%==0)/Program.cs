Console.Write("Введите первое целое число: ");

int userInput = int.Parse(Console.ReadLine() ?? "");

if (userInput % 2 == 0)

{

   Console.Write(userInput + " Четное число"); 

}

else

{

  Console.Write(userInput + " Нечетное число");   

}