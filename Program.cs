// Задача 10: Напишите программу, которая принимает на вход трёхзначное
//  число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// void SecNum(int num1){
// int tens = num1 / 10 % 10;
//     Console.WriteLine($"Вторая цифра равна - {tens}");
// }
//     Console.WriteLine("Введите число: "); 
// int num1 = Convert.ToInt32(Console.ReadLine());
// SecNum(num1);

// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
void ThdNum(int num2){
   int num=num2;
   int bitdepth_num2 = 0;
   l1:  if (num>0){
        num=num/10;
        bitdepth_num2++;
      goto l1;
   }   
   if (bitdepth_num2<3)
   Console.WriteLine($"Третьей цифры в числе {num2} нет");
   else
   {    
    int thdnum = num2;
    for (int i=0 ; i<bitdepth_num2-3; i++)
    {    thdnum = thdnum/10;
        
        }
        thdnum = thdnum%10;
               
    Console.WriteLine($"Третья цифра в числе {num2} равна - {thdnum}");
    }
}
    Console.WriteLine("Введите число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

ThdNum(num2);

// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// void NumbDay(int a){
//         if (1<=a&&a<6)
//         Console.WriteLine("Нет");
//         else 
//         if (a==6||a==7)   
//         Console.WriteLine("Да");
//         else
//         Console.WriteLine("Неверный день недели"+" "+";-P");
// }
// Console.WriteLine("Введите число дня недели: "); 
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Выходной?: ");
// NumbDay(num3);