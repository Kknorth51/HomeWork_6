// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] NewArray()
{
    Console.WriteLine("Введите количество чисел, которые будете вводить: ");
    int Z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите числа: ");
    int[] numbers = new int[Z];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}
void CreateArray()
{
    int[] nums = NewArray();
    int count = 0;
    foreach (int i in nums)
        if (i > 0)
            count++;
    Console.WriteLine($"Количество искомых положительных чисел будет равно:  {count}");
}
CreateArray();