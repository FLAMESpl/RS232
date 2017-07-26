using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace RS232
{
    public partial class Form : System.Windows.Forms.Form
    {
        private COMPort port;

        public Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            if (ports.Length == 0)
                MessageBox.Show("No serial ports detected");

            toolComboBoxPortName.Items.AddRange(ports);

            base.OnLoad(e);
        }

        private void ChangePort(string portName)
        {
            port?.Close();
            port = new COMPort(portName);
            port.Open();
            port.DataReceived += TextReceived;
        }

        private void ClosePort()
        {
            port.Close();
            port.Dispose();
        }

        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                Invoke((Action<string>)AppendText, new object[] { text });
                return;
            }
            textBoxRead.AppendText(text);
        }

        private void TextReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AppendText(port.ReadExisting());
        }

        private void toolButtonSend_Click(object sender, EventArgs e)
        {
            port?.Write(textBoxWrite.Text);
            textBoxWrite.Text = String.Empty;
        }

        private void toolComboBoxPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChangePort((string)toolComboBoxPortName.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
