using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Разраблтать_статический_класс_Message_Удалов_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Узнал интересный факт о своей солнцезащитной девушке, что бы не плакать пока режешь солнцезащитную цебулю - она надевает солнцезащитные очки. И ей это помогает.";
            Console.WriteLine(String.Join(" ", text.Split(' ').Where(n => n.Length == text.Split(' ').Max(l => l.Length))));
            Console.ReadLine();
        }
    }
}
