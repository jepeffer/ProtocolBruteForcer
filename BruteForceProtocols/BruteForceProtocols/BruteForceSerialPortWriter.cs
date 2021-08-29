using System.IO.Ports;
using System.Text;
using System;
using System.Threading;

namespace BruteForceProtocols
{
    internal class BruteForceSerialPortWriter
    {
        //  serial.Write(new byte[] { 0x1D, 0x53 }, 0, 2);
        private SerialPort SerialPort;
        readonly int HEX_SIZE = 16;
        bool HasResponse = false;
        byte[] lastWrite;
        int TimeDelay = 0;

        public BruteForceSerialPortWriter()
        {
            SerialPort = new SerialPort();
            GetUserConfigrations();
            StartSerialPortConnection();
            BruteForceProtocol();
            CloseSerialPortConnection();
        }

        public void GetUserConfigrations()
        {
            Console.Write("Enter in the preferred time delay (in milliseconds) ");
            TimeDelay = Int32.Parse(Console.ReadLine());
        }

        public void WriteResponse()
        {
            string output = "";
            for (int i = 0; i < lastWrite.Length; i++)
            {
                output += " 0x" + lastWrite[i].ToString("X2");
            }

            Console.WriteLine("This was the last written bytes: " + output);
        }


        public void BruteForceProtocol()
        {
            TwoNibble();
            FourNibble();
            SixNibble();
            EightNibble();
            TenNibble();
            TwelveNibble();
            FourteenNibble();
            SixteenNibble();
        }

        public void TwoNibble()
        {
            for (int i = 0; i < Math.Pow(HEX_SIZE, 2); i++)
            {
                byte iToByte = Convert.ToByte(i);
                byte[] iToWrite = { iToByte };
                Thread.Sleep(TimeDelay);
                SerialPort.Write(iToWrite, 0, 1);
                lastWrite = iToWrite;
            }
        }

        public void FourNibble()
        {
            for (int i = 0; i < Math.Pow(HEX_SIZE, 2); i++)
            {
                byte iToByte = Convert.ToByte(i);
                for (int j = 0; j < Math.Pow(HEX_SIZE, 2); j++)
                {

                    byte jToByte = Convert.ToByte(j);
                    byte[] jToWrite = { iToByte, jToByte };
                    Thread.Sleep(TimeDelay);
                    SerialPort.Write(jToWrite, 0, 2);
                    lastWrite = jToWrite;
                }
            }
        }

        public void SixNibble()
        {
            for (int i = 0; i < Math.Pow(HEX_SIZE, 2); i++)
            {

                byte iToByte = Convert.ToByte(i);
               
                for (int j = 0; j < Math.Pow(HEX_SIZE, 2); j++)
                {

                    byte jToByte = Convert.ToByte(j);

                    for (int k = 0; k < Math.Pow(HEX_SIZE, 2); k++)
                    {

                        byte kToByte = Convert.ToByte(k);
                        byte[] kToWrite = { iToByte, jToByte, kToByte };
                        Thread.Sleep(TimeDelay);
                        SerialPort.Write(kToWrite, 0, 3);
                        lastWrite = kToWrite;
                    }
                }
            }
        }

        public void EightNibble()
        {
            for (int i = 0; i < Math.Pow(HEX_SIZE, 2); i++)
            {

                byte iToByte = Convert.ToByte(i);

                for (int j = 0; j < Math.Pow(HEX_SIZE, 2); j++)
                {

                    byte jToByte = Convert.ToByte(j);

                    for (int k = 0; k < Math.Pow(HEX_SIZE, 2); k++)
                    {
                        byte kToByte = Convert.ToByte(k);
                        for (int l = 0; l < Math.Pow(HEX_SIZE, 2); l++)
                        {

                            byte lToByte = Convert.ToByte(l);
                            byte[] lToWrite = { iToByte, jToByte, kToByte, lToByte };
                            Thread.Sleep(TimeDelay);
                            SerialPort.Write(lToWrite, 0, 4);
                            lastWrite = lToWrite;
                        }
                    }
                }
            }
        }

        public void TenNibble()
        {
            for (int i = 0; i < Math.Pow(HEX_SIZE, 2); i++)
            {
                byte iToByte = Convert.ToByte(i);

                for (int j = 0; j < Math.Pow(HEX_SIZE, 2); j++)
                {
                    byte jToByte = Convert.ToByte(j);

                    for (int k = 0; k < Math.Pow(HEX_SIZE, 2); k++)
                    {
                        byte kToByte = Convert.ToByte(k);

                        for (int l = 0; l < Math.Pow(HEX_SIZE, 2); l++)
                        {

                            byte lToByte = Convert.ToByte(l);

                            for (int m = 0; m < Math.Pow(HEX_SIZE, 2); m++)
                            {

                                byte mToByte = Convert.ToByte(m);
                                byte[] mToWrite = { iToByte, jToByte, kToByte, lToByte, mToByte };
                                Thread.Sleep(TimeDelay);
                                SerialPort.Write(mToWrite, 0, 5);
                                lastWrite = mToWrite;
                            }
                        }
                    }
                }
            }
        }

        public void TwelveNibble()
        {
            for (int i = 0; i < Math.Pow(HEX_SIZE, 2); i++)
            {
                byte iToByte = Convert.ToByte(i);

                for (int j = 0; j < Math.Pow(HEX_SIZE, 2); j++)
                {
                    byte jToByte = Convert.ToByte(j);

                    for (int k = 0; k < Math.Pow(HEX_SIZE, 2); k++)
                    {
                        byte kToByte = Convert.ToByte(k);

                        for (int l = 0; l < Math.Pow(HEX_SIZE, 2); l++)
                        {

                            byte lToByte = Convert.ToByte(l);

                            for (int m = 0; m < Math.Pow(HEX_SIZE, 2); m++)
                            {
                                byte mToByte = Convert.ToByte(m);

                                for (int n = 0; n < Math.Pow(HEX_SIZE, 2); n++)
                                {
                                    byte nToByte = Convert.ToByte(n);
                                    byte[] nToWrite = { iToByte, jToByte, kToByte, lToByte, mToByte, nToByte };
                                    Thread.Sleep(TimeDelay);
                                    SerialPort.Write(nToWrite, 0, 6);
                                    lastWrite = nToWrite;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void FourteenNibble()
        {
            for (int i = 0; i < Math.Pow(HEX_SIZE, 2); i++)
            {
                byte iToByte = Convert.ToByte(i);

                for (int j = 0; j < Math.Pow(HEX_SIZE, 2); j++)
                {
                    byte jToByte = Convert.ToByte(j);

                    for (int k = 0; k < Math.Pow(HEX_SIZE, 2); k++)
                    {
                        byte kToByte = Convert.ToByte(k);

                        for (int l = 0; l < Math.Pow(HEX_SIZE, 2); l++)
                        {

                            byte lToByte = Convert.ToByte(l);

                            for (int m = 0; m < Math.Pow(HEX_SIZE, 2); m++)
                            {
                                byte mToByte = Convert.ToByte(m);

                                for (int n = 0; n < Math.Pow(HEX_SIZE, 2); n++)
                                {
                                    byte nToByte = Convert.ToByte(n);

                                    for (int o = 0; o < Math.Pow(HEX_SIZE, 2); o++)
                                    {
                                        byte oToByte = Convert.ToByte(o);
                                        byte[] oToWrite = { iToByte, jToByte, kToByte, lToByte, mToByte, nToByte, oToByte };
                                        Thread.Sleep(TimeDelay);
                                        SerialPort.Write(oToWrite, 0, 7);
                                        lastWrite = oToWrite;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SixteenNibble()
        {
            for (int i = 0; i < Math.Pow(HEX_SIZE, 2); i++)
            {
                byte iToByte = Convert.ToByte(i);

                for (int j = 0; j < Math.Pow(HEX_SIZE, 2); j++)
                {
                    byte jToByte = Convert.ToByte(j);

                    for (int k = 0; k < Math.Pow(HEX_SIZE, 2); k++)
                    {
                        byte kToByte = Convert.ToByte(k);

                        for (int l = 0; l < Math.Pow(HEX_SIZE, 2); l++)
                        {
                            byte lToByte = Convert.ToByte(l);

                            for (int m = 0; m < Math.Pow(HEX_SIZE, 2); m++)
                            {
                                byte mToByte = Convert.ToByte(m);

                                for (int n = 0; n < Math.Pow(HEX_SIZE, 2); n++)
                                {
                                    byte nToByte = Convert.ToByte(n);

                                    for (int o = 0; o < Math.Pow(HEX_SIZE, 2); o++)
                                    {
                                        byte oToByte = Convert.ToByte(o);

                                        for (int p = 0; p < Math.Pow(HEX_SIZE, 2); p++)
                                        {
                                            byte pToByte = Convert.ToByte(p);
                                            byte[] pToWrite = { iToByte, jToByte, kToByte, lToByte, mToByte, nToByte, oToByte, pToByte };
                                            Thread.Sleep(TimeDelay);
                                            SerialPort.Write(pToWrite, 0, 8);
                                            lastWrite = pToWrite;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }



        public void CloseSerialPortConnection()
        {
            System.Console.WriteLine("Please press enter to rerun application");
            System.Console.ReadLine();

            SerialPort.Close();
        }

        private void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort tempPort = (SerialPort)sender;
            string response = tempPort.ReadExisting();
            byte[] stringToBytes = Encoding.Default.GetBytes(response);
            string output = "";

            for (int i = 0; i < stringToBytes.Length; i++)
            {
                output += "0x" + stringToBytes[i].ToString("X2") + " ";
                HasResponse = true;
            }

            WriteResponse();
            System.Console.WriteLine("The serial port responded with: " + output);
        }

        public void StartSerialPortConnection()
        {
            System.Console.WriteLine("Opening serial port");
            ASCIIEncoding ascii = new ASCIIEncoding();
            SerialPort.Encoding = ascii;
            SerialPort.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);
            SerialPort.WriteTimeout = 500;
            SerialPort.BaudRate = 9600;
            SerialPort.DataBits = 8;
            SerialPort.Parity = Parity.None;
            SerialPort.StopBits = StopBits.One;
            SerialPort.RtsEnable = false;
            SerialPort.DtrEnable = false;
            SerialPort.Open();
        }
    }
}