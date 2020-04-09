using System;

namespace HomeWork09._04
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            System.Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            System.Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            System.Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            System.Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            System.Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            System.Console.WriteLine("Сохранить документ в новом формате?\nДа - чтобы сохранить в новом\nНет - чтобы сохранить в старом\nИначе файл не будет сохранен");
            string chose = Console.ReadLine();
            if(chose.ToLower() == "да")
            System.Console.WriteLine("Документ сохранен в новом формате");
            else if(chose.ToLower() == "нет")
            System.Console.WriteLine("Документ был сохранен в старом формате");
            else System.Console.WriteLine("Документ не был сохранен");
        }
    }
}