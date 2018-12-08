﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_ввода_логина_Удалов_
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "qwerty1234";
            // Проверка на лишние символы
            byte[] bytes = new byte[192];
            int kol = 0;
            for (int i = 0; i < 47; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }
            for (int i = 58; i < 64; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }
            for (int i = 91; i < 96; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }
            for (int i = 123; i < 255; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }

            char[] chars = System.Text.Encoding.ASCII.GetChars(bytes);

            bool flag = false;

            foreach (var item in chars)
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (login[i] == item)
                    {
                        flag = true;
                    }
                }
            }

            //
            if (login.Length >= 2 && login.Length <= 10 && Char.IsDigit((char)login[0]) == false && flag == false)
                Console.WriteLine("Данный логин - {0}, вполне корректен", login);
            else
                Console.WriteLine("Логин не корректен");

        }
    }
}
