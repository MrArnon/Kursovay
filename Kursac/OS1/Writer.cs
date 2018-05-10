﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrodcastAlgorithm
{
    class Writer
    {
        Random random = new Random();
        public bool Dyeing;
        public bool Doing;
        private String name;
        private Buffer buffer;

		public Writer(Buffer _buffer, String name)
        {
            buffer = _buffer;
            this.name = name;
            Dyeing = false;
            Doing = true;

        }

        public void PrintMessage()
        {
            if (buffer != null)
            {
                int value = random.Next(0, 106);
                Thread.Sleep(1000);
                if (value <= 100)
                    buffer.WriteMessage(value);
                else
                {
                    buffer.WriteMessage(-1);
                    Die();
                }
            }
        }
        
        public void Work()
        {
            while (!Dyeing)
            {
                while (Doing && !Dyeing)
                {
                    PrintMessage();
                }
            }
        }

        public void Die()
        {
            Dyeing = true;
        }

        public void Pause()
        {
            Doing = false;
        }

        public void Resume()
        {
            Doing = true;
        }
    }
}