/*
 DESENVOLVIDO POR VICTOR TASSINARI MARTINS
 * victortassinarix@gmail.com
 * victortassinari@outlook.com
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;
namespace SMS
{
    class sms
    {
        SerialPort serialPort;
        public sms(string comPort)
        {
            this.serialPort = new SerialPort();
            this.serialPort.PortName = comPort;
            this.serialPort.BaudRate = 9600;
            this.serialPort.Parity = Parity.None;
            this.serialPort.DataBits = 8;
            this.serialPort.StopBits = StopBits.One;
            this.serialPort.Handshake = Handshake.RequestToSend;
            this.serialPort.DtrEnable = true;
            this.serialPort.RtsEnable = true;
            this.serialPort.NewLine = System.Environment.NewLine;
            Abrir();
        }
        public bool enviarSms(string numeroTel, string textoSMS)
        {

            string mensagem = null;
            mensagem = textoSMS;
            if (this.serialPort.IsOpen == true)
            {
                try
                {
                    this.serialPort.WriteLine("AT" + (char)(13));
                    Thread.Sleep(4);
                    this.serialPort.WriteLine("AT+CMGF=1" + (char)(13));
                    Thread.Sleep(5);
                    this.serialPort.WriteLine("AT+CMGS=\"" + numeroTel + "\"");
                    Thread.Sleep(10);
                    this.serialPort.WriteLine(mensagem + (char)(26));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Source);
                }
                return true;
            }
            else
                return false;
        }

        public string receberSMS()
        {

            if (this.serialPort.IsOpen == true)
            {
                try
                {
                    this.serialPort.WriteLine("AT+CMGL=\"ALL\"");
                    string resultado = this.serialPort.ReadLine();
                    return resultado;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Source);
                    return null;
                }
                
            }
            else
                return null;
        }

        public void Abrir()
        {
            if (this.serialPort.IsOpen == false)
            {
                this.serialPort.Open();
            }
        }
        public void Fechar()
        {
            if (this.serialPort.IsOpen == true)
            {
                this.serialPort.Close();
            }
        }
    }
}