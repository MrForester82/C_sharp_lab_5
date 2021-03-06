﻿using System;
using System.Text;

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

            // Задание 3 --------------------------------------------------------------------------
            Console.WriteLine("\nОт края до края небо в огне сгорает,\nИ в нём исчезают все надежды и мечты,\nНо ты засыпаешь, и ангел к тебе слетает.\nСмахнёт твои слёзы, и во сне смеёшься ты.\n");
            devideSentens("От края до края небо в огне сгорает, И в нём исчезают все надежды и мечты, Но ты засыпаешь, и ангел к тебе слетает. Смахнёт твои слёзы, и во сне смеёшься ты.");

            // Задание 4 --------------------------------------------------------------------------
            testStringBuilder();

            // Задание 6 --------------------------------------------------------------------------
            chars();
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

        // Задание 3 --------------------------------------------------------------------------
        /*
        Написать функциию, получающую в качестве параметра строку;
        В этой функции объявите два массива строк:
			string[] SimpleSentences, Words;
	        SimpleSentences – должен состоять из простых предложений, составляющих основную строку; 
            Words – должен состоять из слов, составляющих основную строку;
        Используя встроенный метод класса String, разделить основную строку на простые предложения,
        в качестве разделителя использую ‘,’ и проинициализируйте массив SimpleSentences:
		        SimpleSentences = txt.Split(',');
        Аналогично разбейте строку на слова и инициализируйте ими второй массив;
        Используя метод Join соберите строку из элементов массива Words
        */
        public static void devideSentens(string par)
        {
            string[] SimpleSentences, Words;

            char[] sep = { ',', '.' };
            SimpleSentences = par.Split(sep);

            foreach(string SimpleSentence in SimpleSentences)
            {
                Console.WriteLine(SimpleSentence);
            }

            Words = par.Split(' ');
            foreach (string Word in Words)
            {
                Console.Write("{0}\t",Word);
            }
            Console.WriteLine();

            Console.WriteLine("\n{0}\n", String.Join(" ", Words));
        }
        // Задание 3 --------------------------------------------------------------------------

        // Задание 4 --------------------------------------------------------------------------
        /*
        Объявите функцию TestStringBuilder(), демонстрирующую главные отличия класса StringBuilder от  класса String: 
        Методические указания:
            - объявите два объекта класса StringBuilder, используя конструктор:
                StringBuilder  str1=new StringBuilder("String – example of StringBuilder");
            - инициализируйте оба объекта;
            - приведите примеры изменения данных объектов;
        Вызовите эту функция через функцию Main 
        Сконструируйте строку. Выведите ее на экран пронумеровав, каждое простое предложение входящее в эту строку.
        Методические указания:
            - в цикле foreach используйте метод AppendFormat (в качестве разделителя простых предложений в составе сложного примите ‘,’):
                txtbuild.AppendFormat(" {0}: {1} ", num++,sub);
        Выведите на экран обе строки. Полученные результаты проанализируйте.

        */
        public static void testStringBuilder()
        {
            StringBuilder str1 = new StringBuilder();
            str1.Insert(0, "string – example of StringBuilder", 1);
            str1[0] = 'S';
            
            Console.WriteLine("{0}", str1);
            

            StringBuilder str2 = new StringBuilder("Ах, как хочется вернуться, ах, как хочется ворваться в городок\n");
            StringBuilder str3 = new StringBuilder();
            str3.Append(str2);
            int num = 1;
            string[] simpleText = str3.ToString().Split(',');
            
            foreach (string sub in simpleText)
            {
                str3.AppendFormat("{0}: {1}\n", num++, sub);
            }

            Console.WriteLine(str3);

            // Задание 5 --------------------------------------------------------------------------
            /*
            Откройте консольное приложение из предыдущего задания;
            С помощью методов Capacity и Maxcapacity измерьте текущие и максимальные емкости буфера соответственно для txtbuild и strbuild;
            Выведите на экран полученные значения емкостей, проанализируйте полученный результат;
            С помощью метода EnsureCapacity уменьшить емкость буфера для обоих объектов до определенного значения,
            и также произведите вывод на экран новых значений емкостей (объяснить разницу полученных значений);
            */
            Console.WriteLine("Текущий размер буфера str1: {0}", str1.Capacity);
            Console.WriteLine("Максимальный размер буфера str1: {0}", str1.MaxCapacity);
            Console.WriteLine("Текущий размер буфера str3: {0}", str3.Capacity);
            Console.WriteLine("Максимальный размер буфера str3: {0}", str3.MaxCapacity);
            str1.EnsureCapacity(50);
            str3.EnsureCapacity(300);
            Console.WriteLine("Текущий размер буфера str1: {0}", str1.Capacity);
            Console.WriteLine("Максимальный размер буфера str1: {0}", str1.MaxCapacity);
            Console.WriteLine("Текущий размер буфера str3: {0}", str3.Capacity);
            Console.WriteLine("Максимальный размер буфера str3: {0}", str3.MaxCapacity);
            // Задание 5 --------------------------------------------------------------------------
        }
        // Задание 4 --------------------------------------------------------------------------

        // Задание 6 --------------------------------------------------------------------------
        /*
        Создайте несколько строк, инициализируя их различными способами;
            char[] str1 = "Hello, World!";
            string str2 = "Здравствуй, Мир!";
        В каком случае выведется сообщение об ошибке и почему?
        Напишите функцию PrintCharAr(), выводящую на экран массив символов, получаемый в качестве входящего параметра;
        В цикле произвести вывод посимвольно: 
            Console.Write(ar[i]);
        Напишите функцию CharArrayToString(), обратную методу ToCharArray, т.е. преобразующую массив символов в строку;
            String CharArrayToString(char[] ar) //функция возвращает объект типа String
        Напишите функцию IndexOfStr, находящую индекс вхождения подстроки в строку:
        Методически указания:
            int IndexOfStr( char[]s1, char[] s2) // нахождение строки s2 в s1
        Напишите процедуру TestIndexSym(), определяющую индексы вхождения символов и подстрок в строку;
        Проанализируйте результаты выполнения всех функций.
        */

        public static void printCharAr(char[] par)
        {
            for(int i = 0; i < par.Length; i++)
            {
                Console.Write(par[i]);
            }
        }

        public static string charArrayToString(char[] par)
        {
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < par.Length; i++)
            {
                res[i] = par[i];
            }
            return res.ToString();
        }

        public static int indexOfStr(char[] s1, char[] s2)
        {
            string ss1 = charArrayToString(s1);
            string ss2 = charArrayToString(s2);
            return ss1.IndexOf(ss2);
        }

        public static void chars()
        {
            string tmp = "Hello, World!";
            char[] str1 = tmp.ToCharArray();
            string str2 = "Здравствуй, Мир!";

            Console.WriteLine();
            printCharAr(str1);
            Console.WriteLine();
        }
        // Задание 6 --------------------------------------------------------------------------
    }
}
