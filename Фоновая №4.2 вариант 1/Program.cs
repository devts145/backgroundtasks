using System;

namespace Фоновая__4._2__Вариант__1_
{
    class Weather1
    {
        static private Random rnd = new Random();
        static private int[] temperature;
        static private int date;
        static private int month;
        public Weather1()
        {
            date = RandomDate();
            month = RandomMonth();
            int kolvodays = OpredelenieSizeArray(date, month);
            RandomTemperature(kolvodays);
        }
        private int OpredelenieSizeArray(int date, int month)
        {
            int k;
            if (month == 2)
            {
                k = 28 - date + 1;
            }
            else if ((month == 4) || (month == 6) || (month == 9) || (month == 11)) k = 30 - date + 1;
            else k = 31 - date + 1;
            return k;
        }
        /*private int MostHotDay()
        {
            int hotday = temperature[0];
            for (int i = 0; i < temperature.Length; i++)
            {
                if (temperature[i] > hotday)
                {
                    hotday = temperature[i];
                }
            }
            return hotday;
        }*/
        /*private int MostColdDay()
        {
            int coldday = temperature[0];
            for (int i = 0; i < temperature.Length; i++)
            {
                if (coldday > temperature[i])
                {
                    coldday = temperature[i];
                }
            }
            return coldday;
        }*/
        public int DateSv
        {
            get { return date; }
            set
            {
                try
                {
                    if (value > date)
                    {
                        date = value;
                        int[] newtemperature = new int[OpredelenieSizeArray(value, month)];
                        for (int i = 0; i < newtemperature.Length; i++)
                        {
                            newtemperature[i] = temperature[i + (temperature.Length - newtemperature.Length)];
                        }
                        for (int f = 0; f < newtemperature.Length; f++)
                        {
                            temperature[f] = newtemperature[f];
                        }
                    }
                    else
                    {
                        throw new Exception("Новое значение даты месяца, которое вы ввели, меньше или равно прошлой даты. Значение даты не изменилось. ");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
        public int this[int i]
        {
            get
            {
                try
                {
                    if (i < temperature.Length) return temperature[i];
                    else throw new Exception("Индекс, который вы ввели, находится за границами массива! ");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    return 0;
                }
            }
            set
            {
                try
                {
                    temperature[i] = value;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Случилась проблемка, такой даты нет, поэтому не получится задать значение. Ошибка: {0}", exc.Message);
                }
            }
        }
        public static bool operator false(Weather1 weather)
        {
            int k = 0;
            int[] temperature = weather.TemperatureSv;
            for (int i = 0; i < temperature.Length; i++)
            {
                if (temperature[i] <= 0) k++;
            }
            if (k == temperature.Length) return false;
            else return true;
        }
        public static bool operator true(Weather1 weather)
        {
            int k = 0;
            int[] temperature = weather.TemperatureSv;
            for (int i = 0; i < temperature.Length; i++)
            {
                if (temperature[i] >= 0) k++;
            }
            if (k == temperature.Length) return true;
            else return false;
        }
        public static Weather1 operator --(Weather1 weather)
        {
            int[] newtemperature = new int[weather.TemperatureSv.Length - 1];
            for (int i = 0; i < newtemperature.Length; i++)
            {
                newtemperature[i] = temperature[i];
            }
            temperature = newtemperature;
            return weather;
        }
        public static Weather1 operator ++(Weather1 weather)
        {
            int[] newtemperature = new int[weather.TemperatureSv.Length + 1];
            for (int i = 0; i < newtemperature.Length - 1; i++)
            {
                newtemperature[i] = temperature[i];
            }
            newtemperature[newtemperature.Length - 1] = weather.FindAvarageTemperature();
            temperature = newtemperature;
            return weather;
        }
        public static bool operator <(Weather1 weather1, Weather1 weather2)
        {
            int kolvodaysone = weather1.OpredelenieSizeArray(weather1.DateSv, weather1.MonthSv);
            int kolvodaystwo = weather2.OpredelenieSizeArray(weather2.DateSv, weather2.MonthSv);
            return kolvodaysone < kolvodaystwo;
        }
        public static bool operator >(Weather1 weather1, Weather1 weather2)
        {
            int kolvodaysone = weather1.OpredelenieSizeArray(weather1.DateSv, weather1.MonthSv);
            int kolvodaystwo = weather2.OpredelenieSizeArray(weather2.DateSv, weather2.MonthSv);
            return kolvodaysone > kolvodaystwo;
        }
        /*private int NumberZero()
        {
            int k = 0;
            for (int i = 0; i < OpredelenieSizeArray(date, month); i++)
            {
                if (i < temperature.Length)
                {
                    if ((temperature[i] < 0 && temperature[i + 1] > 0) || (temperature[i] > 0 && temperature[i + 1] < 0)) k++;
                }
            }
            return k;
        }*/
        public int NumberZeroSv
        {
            get
            {
                int k = 0;
                for (int i = 0; i < OpredelenieSizeArray(date, month); i++)
                {
                    if (i < temperature.Length)
                    {
                        if ((temperature[i] < 0 && temperature[i + 1] > 0) || (temperature[i] > 0 && temperature[i + 1] < 0)) k++;
                    }
                }
                return k; ;
            }
        }
        public int[] TemperatureSv
        {
            get { return temperature; }
        }
        public int MonthSv
        {
            get { return month; }
        }
        public int Cold
        {
            get
            {
                int coldday = temperature[0];
                for (int i = 0; i < temperature.Length; i++)
                {
                    if (coldday > temperature[i])
                    {
                        coldday = temperature[i];
                    }
                }
                return coldday;
            }
        }
        public int Hot
        {
            get
            {
                int hotday = temperature[0];
                for (int i = 0; i < temperature.Length; i++)
                {
                    if (temperature[i] > hotday)
                    {
                        hotday = temperature[i];
                    }
                }
                return hotday;
            }
        }
        public int SizeArray
        {
            get { return OpredelenieSizeArray(date, month); }
        }
        static public void RandomTemperature(int kolvodays)
        {
            temperature = new int[kolvodays];
            for (int i = 0; i < kolvodays; i++)
            {
                temperature[i] = rnd.Next(-100, 101);
            }
        }
        static public int RandomMonth()
        {
            return rnd.Next(1, 12);
        }
        static public int RandomDate()
        {
            return rnd.Next(1, 32);
        }
        public int FindAvarageTemperature() //double
        {
            int sum = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }
            return (sum / temperature.Length);
        }
        public int MostDifferentFromAvarage(int sredn)
        {
            int res = 0, razn = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                if ((Math.Abs(temperature[i]) - Math.Abs(sredn)) > razn)
                {
                    razn = (Math.Abs(temperature[i]) - Math.Abs(sredn));
                    res = temperature[i];
                }
            }
            return res;
        }
        public Weather1(int userdate, int usermonth)
        {
            date = userdate;
            month = usermonth;
            int k = OpredelenieSizeArray(userdate, usermonth);
            temperature = new int[k];
            for (int i = 0; i < k; i++)
            {
                temperature[i] = rnd.Next(-100, 100);
            }
        }
        public void Output()
        {
            int dateizm = this.DateSv;
            int monthizm = this.MonthSv;
            int k = OpredelenieSizeArray(dateizm, monthizm);
            Console.Write(@"Дата              ");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0}.{1} \t", dateizm, monthizm);
                dateizm++;
            }
            Console.WriteLine(" ");
            Console.Write(@"Температура       ");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} \t", temperature[i]);
            }
            int average = FindAvarageTemperature();
            Console.WriteLine(" ");
            Console.WriteLine("Температура, которая максимально сильно отклонена от среднего значения: {0}.", MostDifferentFromAvarage(average));
            Console.WriteLine("(Среднее значение: {0})", average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1, если хотите врчную задать значения. 0, если не хотите, тогда задается рандомом. ");
            byte cases = byte.Parse(Console.ReadLine());
            int date, month;
            Weather1 weather, weather1;
            if (cases == 1)
            {
                Console.WriteLine("Введите дату, с которой начнется отсчет: ");
                date = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите месяц: ");
                month = int.Parse(Console.ReadLine());
                weather = new Weather1(date, month);
            }
            else
            {
                Console.WriteLine("Задал значения по рандому! ");
                weather = new Weather1();
                Console.WriteLine("Дата: {0}, Месяц: {1}", weather.DateSv, weather.MonthSv);
            }
            weather.Output();
            Console.WriteLine("Введите 1, если хотите изменить значение даты месяца, с которой начинается отсчет: ");
            cases = byte.Parse(Console.ReadLine());
            if (cases == 1)
            {
                Console.WriteLine("Введите новое значение даты месяца: ");
                weather.DateSv = int.Parse(Console.ReadLine());
                Console.WriteLine("Результат: ");
                weather.Output();
            }
            Console.WriteLine("Количество дней, за которые велось наблюдение за погодой: {0}", weather.SizeArray);
            Console.WriteLine("Количество переходов через ноль: {0} ", weather.NumberZeroSv);
            Console.WriteLine("Месяц: {0}", weather.MonthSv);
            Console.WriteLine("Самый жаркий день в месяце, температура: {0}", weather.Hot);
            Console.WriteLine("Самый холодный день в месяцу, температура: {0}", weather.Cold);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            weather1 = new Weather1();
            Console.WriteLine("Я создал новый дневник, вот он: ");
            weather1.Output();
            bool morenotes = weather > weather1;
            Console.WriteLine("Я сравнил количество записей в двух дневниках. ");
            if (morenotes == true) Console.WriteLine("Записей в первом дневнике больше, чем во втором. ");
            else if (morenotes == false) Console.WriteLine("Записей во втором дневнике больше, чем в первом. ");
            Console.WriteLine(" ");
            weather--;
            weather++;
            Console.WriteLine(" ");
            Console.WriteLine("Результат перегруженного оператора декремента и инкремента для второго дневника: ");
            weather.Output();
            if (weather) Console.WriteLine("В первом дневнике нет ни одного дня с отрицательной температурой");
            else Console.WriteLine("В первом дневнике нет ни одного дня с положительной температурой");
            Console.WriteLine("Введите день месяца: ");
            int dateofmonthindex = int.Parse(Console.ReadLine());
            Console.WriteLine(weather[dateofmonthindex]);
            Console.ReadKey();
        }
    }
}