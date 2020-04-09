using System;

namespace HomeWork09._04
{
    class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            System.Console.WriteLine("Пауза");;
        }

        public void Play()
        {
            System.Console.WriteLine("Проигрывание");
        }

        public void Record()
        {
           System.Console.WriteLine("Запись");;
        }

        public void Stop()
        {
            System.Console.WriteLine("Остановить");
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
        void Record();
        void Pause();
        void Stop();
    }
}