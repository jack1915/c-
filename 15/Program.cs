//Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.




Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
  if (day == 6 || day == 7) {
  Console.WriteLine(" да.это выходной день");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("нет,это не выходной день");
