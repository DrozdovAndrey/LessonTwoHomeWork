namespace HelloWorld  
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Clear();    
            int number = Convert.ToInt32(Console.ReadLine());
            // string[] week = {"monday", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"}; пытался выводить и день недели, но увы смог только циклом перечислять дни недели, а как выдвть конкретное значение не получилось.
        	
            
            if (number == 6 || number == 7)
                {
                    Console.WriteLine("Сегодня выходной!");
                }
            else 
                {
                    Console.WriteLine("Увы, но нет!");
                }
            
            
            
            
            
            
            
            
            // int i = week.Length;
            // if (i = number)
            //     {
            //         Console.WriteLine(week[i]);
            //     }
            
            
            // if (number == 6 || number == 7)
            //     {
            //         Console.WriteLine("О, да, это выходный, отдохни и раслабься!");
            //     }           
           
        }  
    }
}