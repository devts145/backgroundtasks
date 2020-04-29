using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_3__Вариант_1__номер_1_
{
    class Program
    {
        static int oprednomera(string s1)
        {
            bool twoorfour = false;
            int tsifra = 0, bukva = 0, result = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (Char.IsDigit(s1[i]) == true) tsifra++;
                if (Char.IsLetter(s1[i]) == true) bukva++;
                if (Char.IsLetter(s1[s1.Length - 1]) == true) twoorfour = true;
            }
            if (tsifra == 3 && bukva == 3) result = 1;
            else if (tsifra == 3 && bukva == 2) result = 2;
            else if (tsifra == 4 && bukva == 2 && twoorfour == false) result = 3;
            else if (tsifra == 4 && bukva == 2 && twoorfour == true) result = 4;
            else result = 0;
            return result;
        }
        static string formatstring(string user)
        {
            for (int a = 0; a < user.Length - 1; a++)
            {
                if (user[a] == ' ' && user[a + 1] == ' ')
                {
                    user = user.Remove(a, 1);
                    a--;
                }
                if (user[0] == ' ')
                {
                    user = user.Remove(0, 1);
                }
            }
            user = user.Replace(user[0], Char.ToUpper(user[0]));
            user = user.Replace(" .", ".");
            user = user.Replace(" ,", ",");
            user = user.Replace(" !", "!");
            user = user.Replace(" ?", "?");
            user = user.Replace(" :", ":");
            user = user.Replace(" ;", ";");
            return user;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Первая задача: ");
            Console.Write("Введите строку: ");
            string user = Console.ReadLine();
            Console.WriteLine(formatstring(user));
            Console.WriteLine("Вторая задача: ");
            Console.Write("Введите первую строку: ");
            string firststr = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string secondstr = Console.ReadLine();
            Console.Write("Введите третью строку: ");
            string thirdstr = Console.ReadLine();
            Console.WriteLine("{0} \t {1}", firststr, oprednomera(firststr));
            Console.WriteLine("{0} \t {1}", secondstr, oprednomera(secondstr));
            Console.WriteLine("{0} \t {1}", thirdstr, oprednomera(thirdstr));
            Console.ReadLine();
        }
    }
}