using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialBroadcast
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private int portSpeed = 38400;

        Socket sending_socket;
        private IPAddress send_to_address;
        private IPEndPoint sending_end_point;

        public Form1()
        {
            InitializeComponent();

            updateSerialListBox(listBoxSerialPorts);

            sending_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            string ip = getLocalIPAddress();
            ip = broadcastIPAddress(ip);

            send_to_address = IPAddress.Parse(ip);
            sending_end_point = new IPEndPoint(send_to_address, 29421);
            
            sending_socket.EnableBroadcast = checkBox1.Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string getLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "";
        }

        /// <summary>
        /// Converts ip address from xxx.xxx.xxx.xxx to xxx.xxx.xxx.255
        /// If ip is not a valid address, replaces the IP address by he localhost.
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        private string broadcastIPAddress(string ip)
        {
            string[] sss = ip.Split('.');

            if (sss.Length != 4)
            {
                ip = "127.0.0.1";
                sss = ip.Split('.');
                checkBox1.BackColor = Color.Salmon;
            }

            sss[3] = "255";
            ip = sss[0] + "." + sss[1] + "." + sss[2] + "." + sss[3];

            return ip;
        }

        /// <summary>
        /// Dynamic listing of serial ports
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 537: //WM_DEVICECHANGE
                    updateSerialListBox(listBoxSerialPorts);
                    break;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Opens a serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string portName = (string)listBoxSerialPorts.SelectedItem;
            selectSerialPort(portName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listbox"></param>
        private void updateSerialListBox(ListBox listbox)
        {
            var ports = SerialPort.GetPortNames().OrderBy(name => name);

            listbox.Items.Clear();
            // Fill in the listy of serial ports on PC
            foreach (var portName in ports)
            {
                listbox.Items.Add(portName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="portNmae"></param>
        private void selectSerialPort(string portNmae)
        {
            if (setSerialPort(portNmae, portSpeed))
            {
                comboBoxSerialBaudRate.Text = String.Format("{0}", portSpeed);
                labelSerialStatus.Text = portNmae + String.Format(": {0} bps", portSpeed);
                groupBoxSerialSettings.BackColor = SystemColors.Control;
            }
            else
            {
                labelSerialStatus.Text = "No serial port open";
                groupBoxSerialSettings.BackColor = Color.Salmon;
            }
        }

        /// <summary>
        /// Set up the Serial port.
        /// </summary>
        /// <param name="port"></param>
        /// <param name="portSpeed"></param>
        /// <returns></returns>
        private bool setSerialPort(string port, int portSpeed)
        {
            bool flag = false;

            if (serialPort != null)
            {
                serialPort.Close();
                serialPort.Dispose();
            }
            serialPort = new SerialPort(port);

            if (serialPort != null)
            {
                serialPort.DataReceived += serialPortMob_DataReceived;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.BaudRate = portSpeed;
                serialPort.Parity = Parity.None;
                try
                {
                    serialPort.Open();
                    flag = true;
                }
                catch (System.UnauthorizedAccessException ex)
                {
                    display(ex.Message + "\r\n");
                }
                catch (System.IO.IOException ex)
                {
                    display(ex.Message + "\r\n");
                }
            }
            return flag;
        }

        /// <summary>
        /// Serial input data arrives here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPortMob_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                int n = serialPort.BytesToRead;  // Number of bytes available in this call
                char[] data = new char[n];
                serialPort.Read(data, 0, n);
                string str = new String(data);
                display(str);
                broadcast(str);
            }
            catch (System.IO.IOException ex)
            {
                Console.Write(ex.Message);
            }
        }

        /// <summary>
        /// Display stuff on serial terminal.
        /// </summary>
        /// <param name="str"></param>
        private void display(string str)
        {
            {
                textBox1.Invoke((MethodInvoker)delegate
                {
                    textBox1.AppendText(str);
                });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        private void broadcast(string str)
        {
            // the socket object must have an array of bytes to send.
            // this loads the string entered by the user into an array of bytes.
            byte[] send_buffer = Encoding.ASCII.GetBytes(str);

            // Remind the user of where this is going.
            Console.WriteLine("sending to address: {0} port: {1}", sending_end_point.Address, sending_end_point.Port);
            try
            {
                sending_socket.SendTo(send_buffer, sending_end_point);
            }
            catch (Exception send_exception)
            {
                Console.WriteLine(" Exception {0}", send_exception.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sending_socket.EnableBroadcast = checkBox1.Checked;
        }
    }
}
