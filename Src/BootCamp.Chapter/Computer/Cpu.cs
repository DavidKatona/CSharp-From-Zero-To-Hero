﻿namespace BootCamp.Chapter.Computer
{
    public class Cpu : Component
    {
        private string _socket;

        public string GetSocket()
        {
            return _socket;
        }

        private int _cores;

        public int GetCores()
        {
            return _cores;
        }

        private int _threads;

        public int GetThreads()
        {
            return _threads;
        }

        private int _clockSpeed;

        public int GetClockSpeed()
        {
            return _clockSpeed;
        }

        public Cpu(string id, string manufacturer, string modelName, string socket, int cores, int threads, int clockSpeed) : base (id, manufacturer, modelName)
        {
            _socket = socket;
            _cores = cores;
            _threads = threads;
            _clockSpeed = clockSpeed;
        }

    }
}