using System;
using System.IO;

namespace HomeWork09._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Функционал программы\nВ обычной версии: Открытые документа\nВ версии Про: Открытые документа - Изменение документа - Сохранение документа в старом формате\nВ весрии Эксперт: Открытые документа - Изменение документа - Сохранение документа в других форматах");
            System.Console.Write("Для обычной версии ключ не нужен\nКлюч для Про версии: 1q2w-3e4r-5t6y-7u8i\nКлюч для Эксперт версии: 1qaz-2wsx-3edc-4rfv\nВведите ключ: ");
            string key = Console.ReadLine();
            DocumentWorker DW = (key == "1q2w-3e4r-5t6y-7u8i")? new ProDocumentWorker():(key == "1qaz-2wsx-3edc-4rfv")?new ExpertDocumentWorker():new DocumentWorker();
            int choose = 0;
            while(choose != 4)
            {
                Console.Clear();
                System.Console.Write("1. Открыть документ\n2. Отредактировать документ\n3. Сохранить документ\n4. Выход\nВаш выбор: ");
                choose = int.Parse(Console.ReadLine());
                switch(choose)
                    {
                        case 1:
                            DW.OpenDocument();
                        break;
                        case 2:
                            DW.EditDocument();
                        break;
                        case 3: 
                            DW.SaveDocument();
                        break;
                    }
                    System.Console.Write("Нажмите на любую клавишу чтобы продолжить...");Console.ReadKey();
            }
        }
    }
}
