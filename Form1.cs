using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMS;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Management;
namespace HundredXSMSGateway
{
    public partial class Form1 : Form
    {
        string porta = "";
        Thread thEscutaPorta;
        Thread thEnviaLista;
        Thread thVerificaStatusModens;
        bool servidorIniciado = false;
        TcpListener Listener;
        string[,] vetMensagens = new string[9999999, 4];
        int tlMensagens;
        int mensagensRecebidasSrv = 0;
        int mensagensEnviadas = 0;
        public Form1()
        {
            InitializeComponent();
            carregarPortas();
            thEscutaPorta = new Thread(new ThreadStart(iniciarServidor));
            thEnviaLista = new Thread(new ThreadStart(verificaLista));
            thVerificaStatusModens = new Thread(new ThreadStart(verificaStatusModens));
            Control.CheckForIllegalCrossThreadCalls = false;
            iniciaThVerificaModem();
        }

        private void verificaStatusModens()
        {
            while (true)
            {
                carregarPortas();
                string[,] modens = pegaModensSistema();
                string status = pegaStatusModem(modens, porta);
                if (status != "OK")
                {
                    lbStatusModem.ForeColor = Color.Red;
                    if (status == null || cbPortas.SelectedIndex < 0)
                        lbStatusModem.Text = "Nenhum modem selecionado!";
                    else
                        lbStatusModem.Text = "Houve um erro => " + status;

                    if (servidorIniciado)
                        paraThreadsSMS();
                    defineTamanhoInicial();
                }
                else
                {
                    lbStatusModem.ForeColor = Color.Green;
                    lbStatusModem.Text = "OK - Modem conectado";
                    if (servidorIniciado)
                        iniciaThreadsSMS();
                    defineTamanhoNormal();
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            sms classSMS = new sms(cbPortas.Text);
            classSMS.Abrir();
            classSMS.enviarSms(txtNumero.Text, txtMensagem.Text);
            classSMS.Fechar();
        }

        private void carregarPortas()
        {
            string[,] modens = pegaModensSistema();
            for (int i = 0; i < modens.GetLength(0); i++)
            {
                if (modens[i, 0] == "OK")
                {
                    if (!cbPortas.Items.Contains(modens[i, 1] + " - " + modens[i, 2]))
                        cbPortas.Items.Add(modens[i, 1] + " - " + modens[i, 2]);
                }
            }
        }

        private string[,] pegaModensSistema()
        {
            string[,] modens = new string[999999, 3];

            int tl = 0;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_POTSModem");
            foreach (ManagementObject mo in mos.Get())
            {
                modens[tl, 0] = mo["Status"].ToString();
                modens[tl, 1] = mo["AttachedTo"].ToString();
                if (mo["Caption"] != null)
                    modens[tl, 2] = mo["Caption"].ToString();
                else
                    modens[tl, 2] = "Desconhecido";
                tl++;
            }
            string[,] modensFinal = new string[tl, 3];

            for (int i = 0; i < tl; i++)
            {
                modensFinal[i, 0] = modens[i, 0];
                modensFinal[i, 1] = modens[i, 1];
                modensFinal[i, 2] = modens[i, 2];
            }

            return modensFinal;
        }

        private string pegaStatusModem(string[,] modens, string portaCom)
        {
            string status = null;
            bool achei = false;
            for (int i = 0; i < modens.GetLength(0) && achei == false; i++)
            {
                if (modens[i, 1] == portaCom)
                {
                    status = modens[i, 0];
                    achei = true;
                }
            }
            return status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNumeros.Items.Add(txtNumeros.Text);
            btnEnviar.Enabled = false;
            btnEnviarMassa.Enabled = true;
            txtNumeros.Clear();
        }

        private void Start(string IP, int Port)
        {
            Listener = new TcpListener(IPAddress.Parse(IP), Port);
            lbStatus.Text = "Iniciando servidor...";
            Listener.Start();
            Socket socket = Listener.AcceptSocket();
            lbStatus.Text = "Conexão estabelecida";
            Byte[] Buff = new Byte[1024];
            string mensagem = "";
            string[] mensagemQuebrada;
            int ReceivedMessage;
            while (true)
            {
                ReceivedMessage = socket.Receive(Buff);
                for (int i = 0; i < ReceivedMessage; i++)
                {
                    mensagem += Convert.ToChar(Buff[i]);
                    lbStatus.Text = "Recebendo dados...";
                }

                if (mensagem != "")
                {
                    if (mensagem.Contains("|*|"))
                    {
                        mensagemQuebrada = mensagem.Split(new string[] { "|*|" }, StringSplitOptions.None);
                        addMensagemLista(mensagemQuebrada[0], mensagemQuebrada[1]);
                        mensagensRecebidasSrv++;
                        lbRecebidas.Text = mensagensRecebidasSrv.ToString();
                        lbStatus.Text = "Conexão estabelecida";
                    }
                    mensagem = "";
                    socket = Listener.AcceptSocket();
                }
            }
        }

        private void addMensagemLista(string telefone, string mensagem)
        {
            vetMensagens[tlMensagens, 0] = (tlMensagens + 1).ToString();
            vetMensagens[tlMensagens, 1] = telefone;
            vetMensagens[tlMensagens, 2] = mensagem;
            vetMensagens[tlMensagens, 3] = "pendente";
            tlMensagens++;
        }

        private void verificaLista()
        {
            while (true)
            {
                for (int i = 0; i < tlMensagens; i++)
                {
                    if (vetMensagens[i, 3] == "pendente")
                    {
                        enviaSms(vetMensagens[i, 1], vetMensagens[i, 2]);
                        mensagensEnviadas++;
                        lbEnviadas.Text = mensagensEnviadas.ToString();
                        vetMensagens[i, 3] = "enviada";
                        Thread.Sleep(Convert.ToInt32(txtTempo.Text) * 1000);
                    }
                }
            }
        }

        private void enviaSms(string tel, string mensagem)
        {
            sms classSMS = new sms(porta);
            classSMS.Abrir();
            classSMS.enviarSms(tel, mensagem);
            classSMS.Fechar();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (cbPortas.SelectedIndex < 0)
                MessageBox.Show("Selecione um modem!");
            else if (!verificaNumero(txtPortaSrv.Text))
                MessageBox.Show("Porta inválida!");
            else if (!verificaNumero(txtTempo.Text))
                MessageBox.Show("Tempo inválido!");
            else
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                servidorIniciado = true;
                iniciaThreadsSMS();

                button3.Enabled = false;
                button4.Enabled = true;
                txtPortaSrv.Enabled = false;
                txtTempo.Enabled = false;
            }
        }

        private void iniciarServidor()
        {
            Start("127.0.0.1", Convert.ToInt32(txtPortaSrv.Text));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            defineTamanhoInicial();
        }

        private void defineTamanhoInicial()
        {
            this.Width = 570;
            this.Height = 115;
        }

        private void defineTamanhoNormal()
        {
            this.Width = 570;
            this.Height = 500;
        }

        private void iniciaThVerificaModem()
        {
            if (thVerificaStatusModens == null && !thVerificaStatusModens.IsAlive)
            {
                thVerificaStatusModens = new Thread(new ThreadStart(verificaStatusModens));
                thVerificaStatusModens.Start();
            }
            else if (!thVerificaStatusModens.IsAlive)
                thVerificaStatusModens.Start();

        }

        private void iniciaThreadsSMS()
        {
            if (thEscutaPorta == null)
            {
                thEscutaPorta = new Thread(new ThreadStart(iniciarServidor));
                thEscutaPorta.Start();
            }
            else if(!thEscutaPorta.IsAlive)
                thEscutaPorta.Start();

            if (thEnviaLista == null)
            {
                thEnviaLista = new Thread(new ThreadStart(verificaLista));
                thEnviaLista.Start();
            } else if(!thEnviaLista.IsAlive)
                thEnviaLista.Start();
        }

        private void paraThreadsSMS()
        {
            if (thEscutaPorta != null && thEscutaPorta.IsAlive)
            {
                thEscutaPorta.Abort();
                thEscutaPorta = null;
            }

            if (thEnviaLista != null && thEnviaLista.IsAlive)
            {
                thEnviaLista.Abort();
                thEnviaLista = null;
            }
        }

        private void paraThreadsVerificaModem()
        {
            if (thVerificaStatusModens != null && thVerificaStatusModens.IsAlive)
            {
                thVerificaStatusModens.Abort();
                thVerificaStatusModens = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paraThreadsSMS();
            Listener.Stop();
            servidorIniciado = false;
            button3.Enabled = true;
            button4.Enabled = false;
            txtPortaSrv.Enabled = true;
            txtTempo.Enabled = true;
            lbStatus.Text = "Parado";
        }

        private bool verificaNumero(string num)
        {
            int temp;
            if (int.TryParse(num, out temp))
                return true;
            else return false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            paraThreadsVerificaModem();
            paraThreadsSMS();
            if (Listener != null)
                Listener.Stop();
        }

        private void cbPortas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strQuebrada = cbPortas.Text.Split(new string[] { " - " }, StringSplitOptions.None);
            porta = strQuebrada[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sms classSMS = new sms(cbPortas.Text);
            classSMS.Abrir();
            for (int i = 0; i < lbNumeros.Items.Count; i++)
            {
                classSMS.enviarSms(lbNumeros.Items[i].ToString(), txtMensagem.Text);
            }
            classSMS.Fechar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lbNumeros.Items.Remove(lbNumeros.SelectedItem);
            if (lbNumeros.Items.Count == 0)
            {
                btnEnviar.Enabled = true;
                btnEnviarMassa.Enabled = false;
            }
        }

        private void cbPortas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbPortas.SelectedIndex >= 0)
            {

                string[,] modens = pegaModensSistema();

                if (pegaStatusModem(modens, porta) != "OK")
                {
                    pGeral.Visible = true;
                    defineTamanhoNormal();
                    iniciaThVerificaModem();
                    string[] strQuebrada = cbPortas.Text.Split(new string[] { " - " }, StringSplitOptions.None);
                    porta = strQuebrada[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sms classSMS = new sms(porta);
            classSMS.Abrir();
            string teste = classSMS.receberSMS();
            MessageBox.Show(teste);
            classSMS.Fechar();

        }

    }
}

