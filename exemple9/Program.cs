/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/
int newDay = new int();
 Console.WriteLine("Введите число от 1 до 7: ");
 newDay = Convert.ToInt32(Console.ReadLine());
 
 if (newDay == 1)
 {
    Console.WriteLine("Понедельник");
 }
 if (newDay == 2)
 {
    Console.WriteLine("Вторник");
 }
 if (newDay == 3)
 {
    Console.WriteLine("Среда");
 }
 if (newDay == 4)
 {
    Console.WriteLine("Четверг");
 }
 if (newDay == 5)
 {
    Console.WriteLine("Пятница");
 }
 if (newDay == 6)
 {
    Console.WriteLine("Суббота");
 }
 if (newDay == 7)
 {
    Console.WriteLine("Воскресение");
 }
