using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrodcastAlgorithm
{
    public partial class Form1 : Form
    {
        Controller controller;
        Random rnd = new Random();
        Thread Add;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller(this);
            controller.InitializeController();

            Add = new Thread(AddingWork);
            Add.Start();
        }
        /// <summary>
        /// Добавляет нового писателя через случайное время
        /// </summary>
        private void AddingWork()
        {
            while (true)
            {
                Thread.Sleep(rnd.Next(5, 10) * 1000);
                controller.AddWriter();
                AddNewMessageToBuffer(tb1, "Сгенерированы новые потоки");
            }
        }

        #region Write
        public delegate void AddStringCallback(TextBox tb, String msg);

        public void AddNewMessageToBuffer(TextBox tb, String msg)
        {
            if (tb.InvokeRequired)
            {
                AddStringCallback d = new AddStringCallback(AddNewMessageToBuffer);
                Invoke(d, new object[] { tb, msg });
            }
            else
            {
                tb.Text += Environment.NewLine + msg;
            }
        }

        public void OnMessageAddToBuffer(object sender, MessageArgs e)
        {
            AddNewMessageToBuffer(tb1, e.Message);
        }
        #endregion

        #region Read
        public void RemoveMessagFromBuffer(TextBox tb, String msg)
        {
            if (tb.InvokeRequired)
            {
                AddStringCallback d = new AddStringCallback(RemoveMessagFromBuffer);
                Invoke(d, new object[] { tb, msg });
            }
            else
            {
                tb.Text += Environment.NewLine + msg;
            }
        }

        public void OnMessageRemoveFromBuffer(object sender, MessageArgs e)
        {
            RemoveMessagFromBuffer(tb2, e.Message);
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            controller.StopController();
            Application.Exit();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {            
            controller.Stop();
            Add.Suspend();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {           
            controller.Start();
            Add.Resume();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }
    }
}
