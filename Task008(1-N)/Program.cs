Console.Write("Введите первое целое число: ");

int userInput = int.Parse(Console.ReadLine() ?? "");

int i = 1;

while (userInput >= i)

{
 if (i % 2 == 0)
 {
 Console.Write(i + ", ");
 }


    
i++;

}