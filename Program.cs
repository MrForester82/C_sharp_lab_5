using System;

namespace C_sharp_lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Строка1";
            string str2 = new string('s', 5);
            char[] charray = { 't', 'e', 's', 't' };
            string str3 = new string(charray);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine();

            assignment(str1, str2, str3);

            equal(str1, str2, str3);

            concat(str1, str2, str3);

            index(str1, str2, str3);

            comments("Жить - хорошо (а хорошо жить - ещё лучше) ...");

            delStudent("Каждый student в душе ленивец.", "student");

            // Задание 2 --------------------------------------------------------------------------
            sumInWords(5439);
        }

        // Задание 1 --------------------------------------------------------------------------
        /*
        Создайте три объекта типа string, использовав при этом три различных вида инициализации.
        Например:
        -	string str1 = ”Строка1”;
        -	string str2 = new string (‘s’, 5);
        -	char[] charray={‘t’,’e’,’s’,’t’};
            string str3 =new string (charray);
        Протестируйте на созданных строках простейшие операции:
        -     присваивание (=);
        -     две операции проверки эквивалентности (==) и (!=);
        */
        public static void assignment(string str1, string str2, string str3)
        {
            str1 = "test1";
            str2 = "test2";
            str3 = "test3";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine();
        }

        public static void equal(string str1, string str2, string str3)
        {
            if(str1 == "Строка1")
                Console.WriteLine("Строка str1 имеет значение {0}", str1);
            else
                Console.WriteLine("Строка str1 не имеет значение {0}", str1);

            if (str2 == "sssss")
                Console.WriteLine("Строка str2 имеет значение {0}", str2);
            else
                Console.WriteLine("Строка str2 не имеет значение {0}", str2);

            if (str3 == "test")
                Console.WriteLine("Строка str3 имеет значение {0}", str3);
            else
                Console.WriteLine("Строка str3 не имеет значение {0}", str3);
            
            Console.WriteLine();
        }

        public static void concat(string str1, string str2, string str3)
        {
            Console.WriteLine(str1 + str2);
            Console.WriteLine(str2 + str3);
            Console.WriteLine(str1 + str3);
            Console.WriteLine();
        }

        public static void index(string str1, string str2, string str3)
        {
            Console.WriteLine(str1[3]);
            Console.WriteLine(str2[0]);
            Console.WriteLine(str3[2]);
            Console.WriteLine();
        }

        public static void comments(string str1)
        {
            int start = str1.IndexOf('(');
            int finish = str1.IndexOf(')');

            if (start != 0 && finish != 0 && start < finish)
            {
                Console.WriteLine("Исходная строка: {0}", str1);

                str1 = str1.Substring(start+1);
                finish = str1.IndexOf(')');
                str1 = str1.Remove(finish);

                Console.WriteLine("Её комментарий: {0}", str1);
            }
            else
            {
                Console.WriteLine("В данной строке нет комментариев");
            }
            
            Console.WriteLine();
        }

        public static void delStudent(string str1, string todel)
        {
            int start = str1.IndexOf(todel);
            int finish = str1.IndexOf(todel) + todel.Length;
            string str2, str3;

            Console.WriteLine(finish);

            if (start != 0)
            {
                Console.WriteLine("Исходная строка: {0}", str1);

                str2 = str1.Remove(start);
                str3 = str1.Substring(finish);

                Console.WriteLine("Новая строка: {0}", str2 + str3);
            }
            else
            {
                Console.WriteLine(str1);
            }

            Console.WriteLine();
        }
        // Задание 1 --------------------------------------------------------------------------

        // Задание 2 --------------------------------------------------------------------------
        /*
        Объявите функцию SumInWords, которая должна получать параметр (целое число не менее четвертого порядка), а возвращать массив строк (с наименованием валюты). 
        Методические указания:
		        string[]  ar1 = {"один", "два",
                                "три", "четыре", "пять",
                                "шесть", "семь", "восемь",
                                "девять"};
        И так несколько массивов для наименования валюты, десятков, сотен и т.д.
        Например:   Входящий параметр – 1908, результат  – тысяча девятьсот восемь рублей;
	                Входящий параметр – 352,   результат  – триста пятьдесят два рубля;
        */
        public static string rubl(int par)
        {
            bool FirstCondition, SecondCondition;
            string result;

            FirstCondition = par != 12 && par != 13 && par != 14 && (par % 10 == 2 || par % 10 == 3 || par % 10 == 4 || par == 2 || par == 3 || par == 4);
            SecondCondition = par % 10 == 1 && par % 100 != 11 || par == 1;
            if (FirstCondition)
                result = "рубля";
            else
                if (SecondCondition)
                result = "рубль";
            else
                result = "рублей";

            return result;
        }

        public static string points(int par)
        {
            string[] ar = {"один", "два",
                            "три", "четыре", "пять",
                            "шесть", "семь", "восемь",
                            "девять"};

            if (par == 0)
                return "";
            else
                return ar[par - 1];
        }

        public static string decades(int par)
        {
            string[] ar = {"десять", "двадцать",
                            "тридцать", "сорок", "пятьдесят",
                            "шестьдесят", "семьдесят", "восемьдесят",
                            "девяносто"};

            if (par == 0)
                return "";
            else
                return ar[par - 1];
        }

        public static string handreds(int par)
        {
            string[] ar = {"сто", "двести",
                            "триста", "четыреста", "пятьсот",
                            "шестьсот", "семьсот", "восемьсот",
                            "девятьсот"};

            if (par == 0)
                return "";
            else
                return ar[par - 1];
        }

        public static string thouthents(int par)
        {
            string[] ar = {"одна тысяча", "две тысячи",
                            "три тысячи", "четыре тысячи", "пять тысяч",
                            "шесть тысяч", "семь тысяч", "восемь тысяч",
                            "девять тысяч"};

            if (par == 0)
                return "";
            else
                return ar[par - 1];
        }

        public static void sumInWords(int par)
        {
            Console.WriteLine(par);
            Console.Write("{0} ", thouthents(par / 1000));
            Console.Write("{0} ", handreds((par % 1000) / 100));
            Console.Write("{0} ", decades((par % 100) / 10));
            Console.Write("{0} ", points(par % 10));
            Console.WriteLine(rubl(par % 100));
        }
        // Задание 2 --------------------------------------------------------------------------

    }
}
