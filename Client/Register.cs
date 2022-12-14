using MESSAGE;
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
    public partial class Register : Form
    {
        IPEndPoint iep;
        Socket client;
        bool thoat = false;
        Thread trd;
        Thread loginForm;
        Thread chatForm;
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            iep = new IPEndPoint(IPAddress.Parse(Login.ip), int.Parse("2008"));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iep);
            trd = new Thread(new ThreadStart(this.handleRegister));
            trd.IsBackground = true;
            trd.Start();
        }
        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        private void LoadFormChat(object? obj)
        {
            Application.Exit();
            Application.Run(new FormChat(phoneTxt.Text, firstNameTxt.Text + " " + lastNameTxt.Text));
        }
        private void handleRegister()
        {
            if (phoneTxt.Text == "" || passwordTxt.Text == "" || confirmPassTxt.Text == "" || firstNameTxt.Text == "" || lastNameTxt.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
            else
            {
                if (passwordTxt.Text != confirmPassTxt.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu chưa đúng");
                }
                else
                {
                    byte[] data = new byte[1024];
                    MESSAGE.REGISTER register = new MESSAGE.REGISTER(phoneTxt.Text, passwordTxt.Text, firstNameTxt.Text, lastNameTxt.Text, "2022-12-02");

                    string jsonString = JsonSerializer.Serialize(register);

                    MESSAGE.COMMON common = new MESSAGE.COMMON(2, jsonString);
                    sendJson(common);
                    int recv = client.Receive(data);

                    jsonString = UTF8Encoding.UTF8.GetString(data, 0, recv);
                    MESSAGE.COMMON? com = JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
                    try
                    {
                        if (com != null && com.kind == 21)
                        {
                            if (com.content == "OK")
                            {
                                chatForm = new Thread(LoadFormChat);
                                chatForm.SetApartmentState(ApartmentState.STA);
                                chatForm.Start();
                            }
                            else MessageBox.Show("Số điện thoại đã được đăng ký");
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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadLoginForm(object? obj)
        {
            Application.Exit();
            Application.Run(new Login());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            loginForm = new Thread(LoadLoginForm);
            loginForm.SetApartmentState(ApartmentState.STA);
            loginForm.Start();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
