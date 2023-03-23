using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAscon
{
    internal static class ConsoleLogHelper
    {
        public static void StartSerializationMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Информация: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Начало сериализации. " + DateTime.Now);
        }

        public static void EndSerializationMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Информация: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Завершение десериализации. " + DateTime.Now);
        }

        public static void StartDeserializationMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Информация: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Начало десериализации. " + DateTime.Now);
        }

        public static void EndDeserializationMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Информация: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Завершение десериализации. " + DateTime.Now);
        }

        public static void StartDeleteDublicatesMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Информация: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Начало удаления дубликатов. " + DateTime.Now);
        }

        public static void EndDeleteDublicatesMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Информация: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Удаление дубликатов завершено. " + DateTime.Now);
        }

        public static void FileNotExistErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ошибка: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Файл не найден. " + DateTime.Now);
        }

        public static void FileIsEmptyErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ошибка: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Файл пуст. " + DateTime.Now);
        }

        public static void StartUpdateFileMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Информация: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Перезапись файла начата. " + DateTime.Now);
        }

        public static void EndUpdateFileMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Информация: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Перезапись файла закончена. " + DateTime.Now);
        }
    }
}
