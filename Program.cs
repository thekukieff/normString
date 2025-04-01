using System.Text;

namespace normString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world!";

            bool result = text.Contains("world"); //Проверяет, содержит ли строка указанную подстроку.

            Console.WriteLine(result);

            Console.WriteLine(text.StartsWith("Hello"));//Проверяет, начинается ли строка с указанной подстроки.

            Console.WriteLine(text.EndsWith("d"));// роверяет, заканчивается ли строка указанной подстрокой.

            Console.WriteLine(text.IndexOf("world"));//Возвращает индекс первого вхождения подстроки или -1, если подстрока не найдена.

            Console.WriteLine(text.LastIndexOf(" "));//Возвращает индекс последнего вхождения подстроки.

            Console.WriteLine(text.ToUpper());//Переводит текст в верхний регистр

            Console.WriteLine(text.ToLower());//Переводит текст в нижний регистр

            Console.WriteLine(text.Replace("world", "C#"));//Меняет первую подстроку на другую

            Console.WriteLine(text.Remove(5, 7));//Удаляет заданное количество символов 

            Console.WriteLine(text.Trim());//Убирает пробельные символы TrimStart() TrimEnd()

            string[] fruits = "apple,banana,cherry".Split(",");//Разделяет строку на массив подстрок по указанному разделителю

            Console.WriteLine(fruits);

            string fruitsString = string.Join(",", fruits);

            Console.WriteLine(fruitsString);

            Console.WriteLine(string.IsNullOrEmpty(text));//является ли строка null или пустой ""

            Console.WriteLine(string.IsNullOrEmpty(null));

            Console.WriteLine(string.IsNullOrWhiteSpace("             "));//проверяет, пустая ли строка или только из пробелов

            Console.WriteLine(text.Substring(7, 5));//извлекает подстроку из строки, начиная с символа и указанной длиной

            Console.WriteLine(text.Equals("hellO world!", StringComparison.OrdinalIgnoreCase));// Сравнивает 2 строки на равенство. Регистр неважен

            Console.WriteLine(string.Compare("AAA", "AAA"));

            Console.WriteLine(text.Length); // длина строки

            string name = "Igor";
            int age = 16;

            Console.WriteLine(string.Format("Name{0}, Age{1}", name, age));

            string newText = text.ToString();//преобразует текст в строку

            newText = "123";

            int number = int.Parse(newText);//преобразует строку в число

            if (int.TryParse(text, out int newNumber))//при возможности переводит строку в число
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            if (char.IsDigit('5'))
            {
                Console.WriteLine(true);//проверяет, является ли данный символ цифрой
            }

            if (char.IsLetter('b'))
            {
                Console.WriteLine(true);//проверяет, является ли данный символ буквой

            }

            if (char.IsWhiteSpace(' '))
            {
                Console.WriteLine(true);//проверяет, является ли данный символ пробелом

            }

            /*Класс StringBuilder в C# используется для эффективной работы с изменяемыми строками. 
                В отличие от класса string, который является неизменяемым (immutable), 
                StringBuilder позволяет модифицировать строки без создания новых объектов, 
                что особенно полезно при работе с большими или часто изменяемыми строками.*/


            StringBuilder sb = new StringBuilder("Hello");//В конструкторе может быть значение или ёмкость

            sb.Append(" World");
            Console.WriteLine(sb);

            sb.AppendLine("next");//добавляет строку и перевод строки \n в конец строки
            sb.AppendLine("next");//добавляет строку и перевод строки \n в конец строки
            Console.WriteLine(sb);

/*            Класс StringBuilder предоставляет мощные инструменты для 
                работы с изменяемыми строками: -Добавление, вставка, удаление и замена текста.
                -Работа с символами и форматирование. -Управление ёмкостью и длиной строки.
*/
        }
    }
}
