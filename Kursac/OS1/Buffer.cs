﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrodcastAlgorithm
{
    class Buffer
    {
        private String Name { get; }
        private Queue<int> buffer;
        private Semaphore canWriteSemaphore = new Semaphore(0, 10);
        private Semaphore semaphore = new Semaphore(1, 1);
        private Semaphore bufferSizeSemaphore = new Semaphore(10, 10);

		public Buffer(String name)
        {
            this.Name = name;
            buffer = new Queue<int>();
        }

        public event EventHandler<MessageArgs> OnMessageAdd;

        public event EventHandler<MessageArgs> OnMessageRemove;
        /// <summary>
        /// Добавление элемента в буфер
        /// </summary>
        /// <param name="x">Элемент для добавления</param>
        public void WriteMessage(int x)
        {

            bufferSizeSemaphore.WaitOne();
            semaphore.WaitOne();
            buffer.Enqueue(x);
            OnMessageAdd?.Invoke(this, new MessageArgs(x > -1 ? "Добавлен ( " + x + " ) в " + Name + "   " + string.Join("-", buffer.ToArray()) : Name + " умер"));
            semaphore.Release();
            canWriteSemaphore.Release();
        }
        /// <summary>
        /// Чтение элемента из буфера
        /// </summary>
        public void ReadMessage()
        {
            canWriteSemaphore.WaitOne();
            //if(buffer.Count() == 0) { return; }
            semaphore.WaitOne();
            OnMessageRemove?.Invoke(this, new MessageArgs("Прочитал ( " + buffer.Dequeue() + " ) из " + Name + "а"));
            semaphore.Release();
            bufferSizeSemaphore.Release();
        }
    }
}
