using System;
/*C# 12 (23 октября 2023)
Словари
Срок: к следующему занятию, четвергу 25 октября

1. Напишите класс автоматического переводчика фраз с русского на английский и обратно. Переводчик содержит в себе два словаря: англо-русский и русско-английский.

Программа заполняет словарь парами: кошка->cat в одну сторону и cat->кошка в другую. Заполните словари 10-20 часто встречающимися парами.

2. Затем переводчит криступает к работе. Пользователь выбирает режим: англо-русский или русско-английский, затем вводит фразу, которую надо перевести. Переводчик выполняет перевод дословно. Он не владеет такими тонкостями, как падежи.

I have a cat -> Я иметь некоторый кошка

Пользователь вводит фразу, получает перевод; вводит ещё одну фразу, получает перевод; и так далее.

3*. Необязательная задача на повышенную оценку. Если пользователь вводит незнакомое слово, программа спрашивает его перевод и добавляет в свои словари. Потом она справляется с переводом фразы.
*/
namespace HW12Collections
{
    class Program
    {
        private static void TranslateToRus(Translator translator)
        {
            Console.WriteLine($"Введите фразу для перевода: ");
            string input = Console.ReadLine();
            translator.TranslateToRussian(input);
            Console.WriteLine();
            Console.WriteLine(translator.TranslateToRussian(input));
        }

        private static void TranslateToEng(Translator translator)
        {
            Console.WriteLine($"Введите фразу для перевода: ");
            string input = Console.ReadLine();
            translator.TranslateToEnglish(input);
            Console.WriteLine();
            Console.WriteLine(translator.TranslateToEnglish(input));
        }


        private static void mode(Translator translator)
        {
            while (true)
            {
                Console.WriteLine($"Выберите нужный вам режим перевода: ");
                Console.WriteLine($"1 - русский -> английский ");
                Console.WriteLine($"2 - английский -> русский ");
                string text = Console.ReadLine();
                int choice = int.Parse(text);

                switch (choice)
                {
                    case 1:
                        TranslateToEng(translator);
                        break;
                    case 2:
                        TranslateToRus(translator);
                        break;
                    default:
                        Console.WriteLine($"Введена неверная цифра!!");
                        break;
                }
            }
        }


        static void Main(string[] args)
        {
            Translator translator = new Translator();
            mode(translator);

        }
    }
}
