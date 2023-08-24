// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. (Можно изучить метод Split.
// Пример: stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);, где первый аргумент это разделитель чисел, второе обработчик введеной последовательности)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.Write("Введите числа через запятую: ");
string s = Console.ReadLine();
string[] numb=s.Split(",", StringSplitOptions.RemoveEmptyEntries);
Console.Write($"{numCount(numb)}");


int numCount(string[] numb){

int count=0;
for (int i=0; i<numb.Length; i++){
    if(Convert.ToInt32(numb[i])>0) count++;
}
return count;
}