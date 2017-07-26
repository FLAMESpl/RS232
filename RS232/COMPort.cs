using System.IO.Ports;
using System.Text;

namespace RS232
{
    public class COMPort : SerialPort
    {
        public COMPort(string name) : base(name)
        {
        }

        public new void Write(string data)
        {
            var buffer = Encoding.ASCII.GetBytes(data);
            Write(buffer, 0, buffer.Length);
        }
    }
}
