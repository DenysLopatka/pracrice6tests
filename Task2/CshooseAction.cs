using System;


namespace Task2
{
    public class ChooseActionClass
    {
        public void ChooseAction()
        {
            Console.WriteLine("Choose format (txt/pdf/csv)");
            var format = Console.ReadLine();

            var toTxt = new SaveInTxt();
            var toPdf = new SaveInPdf();
            var toCsv = new SaveInCsv();

            if (format == "txt")            
                toTxt.SaveInFormat();            

            else if (format == "pdf")
                toPdf.SaveInFormat();            

            else if (format == "csv")
                toCsv.SaveInFormat();            

            else
            {
                Console.WriteLine($"You can't save file in \"{format}\" format");
                return;
            }
        }
    }
}

/*2. Создать программу, которая сохраняет введеный текст из консоли в файлы формата: txt,csv,pdf.(Использовать интерфейсы и классы)
Пользователь должен иметь возможность выбора формата сохранения. Не валидные кейсы должны быть учтены.*/