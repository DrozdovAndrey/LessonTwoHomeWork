namespace HelloWorld  
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Clear();
            int number = 65;
            Console.WriteLine($"Задано число: {number}");
            string str = number.ToString();
            int[] arrayNumber = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
                {
                    arrayNumber[i] = str[i];
                }
            if (str.Length > 2) 
                {
                    Console.WriteLine($"Третья цифра заданного числа: {str[2]}");
                }
           else 
                {
                    Console.WriteLine("Третьего числа нет");
                }          
           
           
        }  
    }
}