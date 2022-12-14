using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        IPEndPoint iep;
        Socket client;
        bool thoat = false;
        string fullName;
        Thread trd;
        Thread registerForm;
        Thread chatForm;
        public static string ip = "192.168.169.151";

        public Login()
        {
            InitializeComponent();
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

      
        private void LoadRegisterForm(object? obj)
        {
            Application.Exit();
            Application.Run(new Register());
        }
        private void LoadChatForm(object? obj)
        {
            Application.Exit();
            Application.Run(new FormChat(username.Text, fullName));
        }


        private void goToRegisterBtn_Click(object sender, EventArgs e)
        {
            registerForm = new Thread(LoadRegisterForm);
            registerForm.SetApartmentState(ApartmentState.STA);
            registerForm.Start();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            iep = new IPEndPoint(IPAddress.Parse(ip), int.Parse("2008"));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iep);
            trd = new Thread(new ThreadStart(this.handleLogin));
            trd.IsBackground = true;
            trd.Start();
        }
        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        private void handleLogin()
        {
            byte[] data = new byte[1024];
            MESSAGE.LOGIN login = new MESSAGE.LOGIN(username.Text, password.Text);

            string jsonString = JsonSerializer.Serialize(login);

            MESSAGE.COMMON common = new MESSAGE.COMMON(1, jsonString);
            sendJson(common);
            int recv = client.Receive(data);

            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            MESSAGE.COMMON? com = JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
            try
            {
                if (com != null && com.kind == 11)
                {
                    if (com.content != "CANCEL")
                    {
                        fullName = com.content;
                        chatForm = new Thread(LoadChatForm);
                        chatForm.SetApartmentState(ApartmentState.STA);
                        chatForm.Start();
                    }
                    else MessageBox.Show("Login fail!");
                }
                client.Disconnect(true);
                client.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
