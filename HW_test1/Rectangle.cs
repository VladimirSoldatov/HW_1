using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_CSharp1
{
    class Rectangle
    {
        int a;
        int b;
        int c;
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("Не верная длина");
                    throw new ArgumentOutOfRangeException("Параметр А");
                }
                else
                {
                    a = value;
                }
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Не верная длина");
                    throw new ArgumentOutOfRangeException("Параметр B");
                }
                else
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Не верная длина");
                    throw new ArgumentOutOfRangeException("Параметр C");
                }
                else
                {
                    c = value;
                }
            }
        }
        public Rectangle(int first, int second, int third)
        {
            A = first;
            B = second;
            C = third;
        }
        public Rectangle()
        {
            Console.Write("Введите сторону А: ");
            A = GetValue();
            Console.Write("Введите сторону B: ");
            B = GetValue();
            Console.Write("Введите сторону C: ");
            C = GetValue();
        }
        static public int GetValue()
        {
            int result = 0;
            Int32.TryParse(Console.ReadLine(), out result);
            return result;
        }
        public void Result()
        {
            Console.WriteLine("A = {0}, B = {1}, c = {2}", A,B,C);
            if(C==0)
            {
                throw new ArgumentException("Деление на ноль");
            }
            if(C > A || C > B)
            {
                Console.WriteLine("Ни одного квадрата в прямоугольнике расположить нельзя");
            }
            else
            {
                Console.WriteLine("В прямоугольнике можно разместить {0} квадратов со стороной {1}, что составляет {2}",(A/C) * (B/C), C, (A / C) * (B / C) * C * C);
                Console.WriteLine("Площадь незанятой площади равна {0}, а общая {1}", A * B - (A / C )* (B / C) * C * C, A * B);
            }

        }
        ~Rectangle()
        {

        }

    }
}
