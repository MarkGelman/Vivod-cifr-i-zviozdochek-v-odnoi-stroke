using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphri_i_zviozdochki_v_stroku
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /*Программа получает целое число. Согласно этому числу
                 выводится к-во строк. Каждая строка начинается с 1 и следующая строка
                 уже 12 строка 3-тья 123 и т.к далее пока к-во цифр в строке не будет равно введёному числу
                 каждая строка дополняется звёздочками так что бы в конце вышел квадрат а не треугольник:
                 Введёное число 4:
                 1***
                 12**
                 123*
                 1234  */
                string s = Console.ReadLine();
                int len = s.Length;
                int num = int.Parse(s);
                for (int i = 1; i <= num; i++)
                {
                    for (int g = 1; g <= i; g++)
                        Console.Write(g);
                    for (int j = 0; j < num - i; j++)
                    {
                        if (j != num - i - 1)
                            Console.Write("*");
                    }
                    if (i != num)
                        Console.WriteLine("*");
                    else
                        Console.WriteLine();
                }

            }
        }
    }
}
