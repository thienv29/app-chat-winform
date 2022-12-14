using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MESSAGE;

namespace Client
{
    public partial class AddFriend : Form
    {
        Socket client;
        string sodienthoai;
        string ten;
        List<DTO.NguoiDungDTO> dsbb;
        bool thoat = false;
        Thread trd;
        Thread trdtat;
        IPEndPoint iep;
        public AddFriend(string sdt,  string hoten)
        {
            InitializeComponent();
            iep = new IPEndPoint(IPAddress.Parse(Login.ip), int.Parse("2008"));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iep);
            sodienthoai = sdt;
            ten = hoten;
        }
        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        private void TatForm(object? obj)
        {
            Application.Exit();
            Application.Run(new FormChat(sodienthoai, ten));
        }

        private void ThoatFormThemBan_Click(object sender, EventArgs e)
        {
            trdtat = new Thread(TatForm);
            trdtat.SetApartmentState(ApartmentState.STA);
            trdtat.Start();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            trd = new Thread(new ThreadStart(this.ThreadThemBan));
            trd.IsBackground = true;
            trd.Start();
        }

        private void ThreadThemBan()
        {
            byte[] data = new byte[1024];
            MESSAGE.THEMBAN themban = new MESSAGE.THEMBAN(sodienthoai, phone.Text);

            string jsonString = System.Text.Json.JsonSerializer.Serialize(themban);

            MESSAGE.COMMON common = new MESSAGE.COMMON(5, jsonString);
            sendJson(common);
            int recv = client.Receive(data);

            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            MESSAGE.COMMON? com = System.Text.Json.JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
            try
            {
                if (com != null && com.kind == 51)
                {
                    if (com.content == "OK")
                    {
                        MessageBox.Show("Thêm bạn thành công");
                        trdtat = new Thread(TatForm);
                        trdtat.SetApartmentState(ApartmentState.STA);
                        trdtat.Start();
                    }                    
                }
            }
            catch (Exception)
            {

            }
        }

        private void goToRegisterBtn_Click(object sender, EventArgs e)
        {
            trdtat = new Thread(TatForm);
            trdtat.SetApartmentState(ApartmentState.STA);
            trdtat.Start();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            trd = new Thread(new ThreadStart(this.ThreadThemBan));
            trd.IsBackground = true;
            trd.Start();
        }
    }
}
