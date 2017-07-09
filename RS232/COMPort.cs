using System;
using System.IO.Ports;
using System.Text;

namespace RS232
{
    public class COMPort : IDisposable
    {
        private SerialPort serialPort;

        public event EventHandler<string> TextReceived;

        public COMPort()
        {
            serialPort = new SerialPort("COM1");
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;
            serialPort.Handshake = Handshake.None;
            serialPort.ReadTimeout = 2000;
            serialPort.WriteTimeout = 500;
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
        }

        public void Open()
        {
            serialPort.DataReceived += DataReceivedEventHandler;
            serialPort.Open();
        }

        public void Dispose()
        {
            serialPort.Close();
        }

        public void Send(string data)
        {
            var buffer = Encoding.ASCII.GetBytes(data);
            serialPort.Write(buffer, 0, buffer.Length);
        }

        private void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            var port = sender as SerialPort;
            var data = port.ReadExisting();
            TextReceived?.BeginInvoke(this, data, null, null);
        }
    }
}
