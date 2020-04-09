using System;

namespace HomeWork09._04
{
    class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            System.Console.WriteLine("Проигрывание поставлено на паузу");;
        }

        public void PauseRecord()
        {
            System.Console.WriteLine("Запись поставлена на паузу");;
        }

        public void Play()
        {
            System.Console.WriteLine("Проигрывание");
        }

        public void StartRecord()
        {
            System.Console.WriteLine("Запись");
        }

        public void Stop()
        {
            System.Console.WriteLine("Проигрывание остановлено");
        }

        public void StopRecord()
        {
            System.Console.WriteLine("Запись остановлена");
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void StartRecord();
        void PauseRecord();
        void StopRecord();
    }
}