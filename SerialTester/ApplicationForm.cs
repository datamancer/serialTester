using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Client.Networking;

namespace SerialTester
{
    public partial class MainForm : Form
    {
        SocketClient socketClient;

        public MainForm()
        {
            socketClient = new SocketClient();
            InitializeComponent();
            getPorts();
        }

        /**
         * Name: getPorts
         * Purpose: to find available serial ports
         * Parameters: none
         * Returns: void
         */

        private void getPorts()
        {
            String[] ports = SerialPort.GetPortNames();
            PortListDropDown.Items.AddRange(ports);
        }

        /**
         * Name: sendButton
         * Purpose: Sends a message to the COM port, expects it to come to the socket.
         * Parameters: object sender, EventArgs e
         * returns: void
         */
        private void SendButton (object sender, EventArgs e)
        {
            serialPort1.WriteLine (sendTextBox.Text);
            sendTextBox.Text = "";
        }

        /**
         * Name: startButtonClicked
         * Purpose: start button, opens a port and a socket to read on
         * Parameters: object sender, EventArgs e
         * returns: void
         */

        private void startButtonClicked (object sender, EventArgs e)
        {
            try
            {
                if (PortListDropDown.Text == "" || BaudComboBox.Text == "")
                {
                    ReceiveTextBox.Text = "Please select port settings";
                }
                else
                {
                    ReceiveTextBox.Text = "";
                    serialPort1.PortName = PortListDropDown.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudComboBox.Text);

                    serialPort1.Open();
                    socketClient.Connect(socketTextBox.Text);

                    progressBar.Value = 100;

                    sendButton.Enabled = true;
                    readButton.Enabled = true;
                    sendTextBox.Enabled = true;
                    startButton.Enabled = false;
                    stopButton.Enabled = true;
                }
            }

            catch (System.ArgumentException)
            {
                ReceiveTextBox.Text = "Invalid port name. Names must begin with COM- and end with an integer!";
            }

            catch (UnauthorizedAccessException)
            {
                ReceiveTextBox.Text = "Invalid Operation!";
            }
        }

        /**
         * Name: Close
         * Purpose: close button, closese a port and a socket to read on
         * Parameters: object sender, EventArgs e
         * returns: void
         */
        private void Close(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar.Value = 0;
            sendButton.Enabled = false;
            readButton.Enabled = false;
            sendTextBox.Enabled = false;
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        /**
         * Name: Read
         * Purpose: reads in any content that has been sent to the client socket
         * Parameters: object sender, EventArgs e
         * returns: void
         */
        private void Read(object sender, EventArgs e)
        {
            try
            {

                ReceiveTextBox.Text = socketClient.Read();
            }
            catch(TimeoutException)
            {
                ReceiveTextBox.Text = "Timeout Exception!";
            }
           
        }

        private void sendTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
