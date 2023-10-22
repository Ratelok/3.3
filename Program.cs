using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ваш текст: ");
        string text = Console.ReadLine();

        int openCount = 0;
        int closeCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '(')
            {
                openCount++;
            }
            else if (text[i] == ')')
            {
                closeCount++;
                if (openCount < closeCount)
                {
                    Console.WriteLine($"Нет, лишняя закрывающая скобка на позиции {i + 1}");
                    return;
                }
            }
        }

        if (openCount > closeCount)
        {
            Console.WriteLine($"Нет, есть {openCount - closeCount} лишних открывающих скобок");
        }
        else
        {
            Console.WriteLine("Да, скобки расставлены правильно");
        }
    }
}
