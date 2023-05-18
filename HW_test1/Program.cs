using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int desition = 0;
            Console.WriteLine("Введите номер варианта:\t");
            if(Int32.TryParse(Console.ReadLine(), out desition))
            {
                switch(desition)
                {
                    case 1:
                        Rectangle a = new Rectangle();
                        try
                        {
                            a.Result();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;




                }
            }
            else
            {
                Console.WriteLine("Ошибка выбора");
            }
        }
    }
}
