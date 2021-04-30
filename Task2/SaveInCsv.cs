using System;
using System.IO;

namespace Task2
{
    public class SaveInCsv : ISaveFile
    {
        public void SaveInFormat()
        {
            string path = Environment.CurrentDirectory + "\\MyFile.csv";

            Console.WriteLine("Enter text you want to save:");
            string stringForWrite = Console.ReadLine();

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(stringForWrite);

                sw.Close();
            }
        }
    }
}

/*2. Создать программу, которая сохраняет введеный текст из консоли в файлы формата: txt,csv,pdf.(Использовать интерфейсы и классы)
Пользователь должен иметь возможность выбора формата сохранения. Не валидные кейсы должны быть учтены.*/