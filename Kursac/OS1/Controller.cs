using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrodcastAlgorithm
{

    class Controller
    {
        Form1 form;
        Reader reader;
        List<Writer> writers;
        List<Thread> streams;
        List<Buffer> buffers = new List<Buffer>();

        public Controller(Form1 _view)
        {
            form = _view;
        }
        /// <summary>
        /// Связывает контроллер и добаляет первый поток
        /// </summary>
        public void InitializeController()
        {
            Buffer bufferW1 = new Buffer("PС1 компьютер");
            buffers.Add(bufferW1);
            bufferW1.OnMessageAdd += form.OnMessageAddToBuffer;
            bufferW1.OnMessageRemove += form.OnMessageRemoveFromBuffer;
            reader = new Reader(buffers, "Reader");
            Writer writer = new Writer(bufferW1, "Writer1",true);
            writers = new List<Writer> { writer };
            streams = new List<Thread> { new Thread(reader.Work), new Thread(writer.Work) };
            foreach (var t in streams) t.Start();
        }
        /// <summary>
        /// Добавление новый поток
        /// </summary>
        public void AddWriter()
        {
            Buffer buf = new Buffer("PC" + (writers.Count + 1) + " компьютер");
            buffers.Add(buf);
            buf.OnMessageAdd += form.OnMessageAddToBuffer;
            buf.OnMessageRemove += form.OnMessageRemoveFromBuffer;
            Writer writer = new Writer(buf, "Writer" + (writers.Count + 1));
            writers.Add(writer);
            Thread th = new Thread(writer.Work);
            streams.Add(th);
            th.Start();
        }

        public void Stop()
        {
            reader.Pause();
            foreach (var w in writers) w.Doing = false; 
        }
       
        public void Start()
        {
            reader.Resume();
            foreach (var w in writers) w.Doing = true;
        }

        public void StopController()
        {
            reader.Die();
            foreach (Writer writer in writers)
            {
                writer.Die();
            }
            foreach (Thread thread in streams)
            {
                thread.Abort();
            }
        }
        
    }

}
