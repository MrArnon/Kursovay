using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrodcastAlgorithm
{
    class Reader
    {
        Random random = new Random();
        public bool Doing;
        private String name;
        private List<Buffer> buffers;
        public bool Dyeing;
		public bool Marker { get; set; }


		public Reader(List<Buffer> _buffers, String _name)
        {
            buffers = _buffers;
            name = _name;
            Doing = true;
            Dyeing = false;
        }

        public void AddWriter(Buffer _buffer)
        {
            buffers.Add(_buffer);
        }
        /// <summary>
        /// Чтение случайного буффера
        /// </summary>
        public void ReadMessage()
        {
            var buffer = buffers.ElementAt(random.Next(0, buffers.Count));
            buffer.ReadMessage();
            Thread.Sleep(1000);

        }

        public void Work()
        {
            while (!Dyeing)
            {
                while (Doing && !Dyeing)
                {
                    ReadMessage();
                }
            }
        }

        public void Pause()
        {
            Doing = false;
        }

        public void Resume()
        {
            Doing = true;
        }

        public void Die()
        {
            Dyeing = true;
        }
    }
}

