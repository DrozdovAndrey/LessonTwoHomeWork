namespace HelloWorld  
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите 3х значное число: ");
            string? number = Console.ReadLine();

            
            if (number == null)                 // это условие не получается выполнить, точнее консоль выдает вот это
                                                                            //Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
                                                                            //    at System.String.get_Chars(Int32 index)
                                                                            //    at HelloWorld.Program.Main(String[] args) in C:\Users\drozd\OneDrive\Рабочий стол\GB\Знакомство с языками программирования\LessonTwoHomeWork\Task10\Program.cs:line 22
                {
                    Console.WriteLine("Не ввведено значение, повторите ввод");
                }
            else 
                {
                    Char[] arr;
                    arr = number.ToCharArray(1,1);
                    Console.WriteLine(arr);
                }
                                                                                // else 
                                                                                    
                                                                                //     for (n = number.Length; n == 3; )
                                                                                //             {
                                                                                //                 Console.WriteLine(number[1]);
                                                                                //             }
                                                                                // // string? number = Console.ReadLine();
                                                                                // if(!string.IsNullOrEmpty(number))
                                                                                //     IsNull(number);
                                                                                
                                                                            
                                                                                // пытаюсь сам разобраться с NULL , пока что не выходит, спросить у преподавателя, пока буду делать без проверки на него.
                                                                                // void IsNull(string? obj)
                                                                                // {
                                                                                //     if (obj == null) Console.WriteLine("null");
                                                                                //     else Console.WriteLine(obj);
                                                                                // }
            
        }  
    }
}