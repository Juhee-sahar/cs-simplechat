using ChatSocket;

namespace ChatServer
{
    public partial class Form1 : Form
    {

        TCPSocketServer mServer;

        public Form1()
        {
            InitializeComponent();

            mServer = new TCPSocketServer();

            // �̺�Ʈ ����
            mServer.ClientConnected += OnClientConnected;
            mServer.ClientDisconnected += OnClientDisconnected;
            mServer.MessageReceived += OnMessageReceived;

            // �ʱ� UI
            UpdateUiConnectedState(false);
        }



        // ���� ��� ��ư Ŭ��
        private async void BtnAcceptIncoming_Click(object sender, System.EventArgs e)
        {
            UpdateUiConnectedState(true);

            await mServer.StartServerListeningAsync();
        }

        // ���α׷� ���� ��ư Ŭ�� _ ���� ���Ḹ ����.
        private void BtnDisconnectServer_Click(object sender, EventArgs e)
        {
            mServer.StopServer();
            AppendChatLog("���� ������.");
            UpdateUiConnectedState(false);
        }


        // Ŭ���̾�Ʈ ����
        private void OnClientConnected(string ip)
        {
            this.Invoke(new Action(() =>
            {
                AppendClientLog($"[���� ����] {ip}"); 
            }));
        }


        // Ŭ���̾�Ʈ ���� ����
        private void OnClientDisconnected(string ip)
        {
            this.Invoke(new Action(() =>
            {
                AppendClientLog($"[���� ����] {ip}");
            }));
        }



        private void AppendClientLog(string text)
        {
            labelClintList.Text += text + Environment.NewLine;
        }


        private void AppendChatLog(string text)
        {
            labelChatLog.Text += text + Environment.NewLine;    
        }


        private void OnMessageReceived(string ip, string text)
        {
            labelChatLog.Text += $"[{ip}] {text}" + Environment.NewLine;
        }

        public void UpdateUiConnectedState(bool connected)
        {
            btnConnectServer.Enabled = !connected;
            btnDisconnectServer.Enabled = connected;
            btnSendMsg.Enabled = connected;    
        }
    }
}
