using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using ConnectDatabase;
using MESSAGE;
using System.Net;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Linq;
using System.Text;
using System.Text.Json;
using DAO;
using DTO;
using System.Collections;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;

namespace Server
{
    public partial class Server : Form
    {
        MySqlConnection conn;
        IPEndPoint iep;
        Socket server;
        Dictionary<string, string> DSUser;
        Dictionary<string, List<string>> DSNhom;
        Dictionary<string, Socket> DSClient;
        ArrayList dsnguoidung;
        bool active = false;
        public Server()
        {
            InitializeComponent();
            IP.Text = "192.168.169.151";
        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                try { this.Invoke(new Action<string>(AppendTextBox), new object[] { value }); }
                catch (Exception) { }
                return;
            }
            KQServer.Text += value + Environment.NewLine;
        }

        public void KhoiTaoNguoiDung(MySqlConnection conn)
        {
            dsnguoidung = new ArrayList();
            dsnguoidung = DAO.NguoiDungDAO.LayDSNguoiDung(conn);
            DSUser= new Dictionary<string, string>();
            foreach (DTO.NguoiDungDTO ng in dsnguoidung)
            {
                DSUser.Add(ng.SoDienThoai, ng.MatKhau);
            }
            DSClient = new Dictionary<string, Socket>();
        }

        public string LayTenNguoiDung(string sodienthoai)
        {
            string hoten="";
            foreach (DTO.NguoiDungDTO ng in dsnguoidung)
            {
                if (ng.SoDienThoai == sodienthoai)
                {
                    hoten = ng.HoNguoiDung + " " + ng.TenNguoiDung;
                    break;
                }

            }
            return hoten;
        }
        public string LayIDNguoiDung(string sodienthoai)
        {
            string id = "";
            foreach (DTO.NguoiDungDTO ng in dsnguoidung)
            {
                if (ng.SoDienThoai == sodienthoai)
                {
                    id = ng.IDNguoiDung;
                    break;
                }

            }
            return id;
        }
        public DTO.NguoiDungDTO LayNguoiDung(string sodienthoai)
        {            
            foreach (DTO.NguoiDungDTO ng in dsnguoidung)
            {
                if (ng.SoDienThoai == sodienthoai)
                {
                    return ng;
                }

            }
            return null;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            active = true;
            iep = new IPEndPoint(IPAddress.Parse(IP.Text), int.Parse("2008"));
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(iep);
            server.Listen(10);
            AppendTextBox("Bắt đầu kết nối CSDL MySQL ...");
            conn = ConnectDatabase.Ketnoi.GetDBConnection();
            try
            {
                AppendTextBox("Bắt đầu mở kết nối ...");
                conn.Open();
                AppendTextBox("Kết nối thành công !");
                KhoiTaoNguoiDung(conn);
                Thread trd = new Thread(new ThreadStart(this.ThreadServer));
                trd.IsBackground = true;
                trd.Start();
            }
            catch (Exception ex)
            {
                AppendTextBox("Kết nối thất bại với lỗi sau: " + ex.Message);
            }
        }
        private void ThreadServer()
        {
            while (active)
            {
                try
                {
                    Socket client = server.Accept();
                    var t = new Thread(() => ThreadClient(client));
                    t.Start();
                }
                catch (Exception)
                {
                    active = false;
                }
            }

        }
        private void sendJson(Socket client, object obj)
        {
            byte[] jsonUtf8Bytes = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        private void ThreadClient(Socket client)
        {
            byte[] data = new byte[1024];
            int recv = 0;
            recv = client.Receive(data);
            if (recv == 0) return;
            string jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            MESSAGE.COMMON? com = System.Text.Json.JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
            if (com != null)
            {
                if (com.content != null)
                {
                    switch (com.kind)
                    {
                        case 1: // Đăng nhập
                            {
                                LOGIN? login = System.Text.Json.JsonSerializer.Deserialize<LOGIN>(com.content);
                                if (login != null && login.username != null && DSUser.Keys.Contains(login.username) && login.pass == DSUser[login.username])
                                {
                                    string fullName = LayTenNguoiDung(login.username);
                                    com = new COMMON(11, fullName);
                                    sendJson(client, com);
                                    if (DSClient.Keys.Contains(login.username))
                                        DSClient.Remove(login.username);
                                    DSClient.Add(login.username, client);
                                    AppendTextBox("Client kết nối có họ tên là: " + fullName);
                                }
                                else
                                {
                                    com = new COMMON(11, "CANCEL");
                                    sendJson(client, com);
                                    return;
                                }
                                break;
                            }
                        case 2: // Đăng ký
                            {
                                REGISTER? register = System.Text.Json.JsonSerializer.Deserialize<REGISTER>(com.content);
                                if (register != null)
                                {
                                    if (DSUser.Keys.Contains(register.sdt))
                                    {
                                        com = new COMMON(21, "CANCEL");
                                        sendJson(client, com);
                                        return;
                                    }
                                    else
                                    {
                                        com = new COMMON(21, "OK");
                                        sendJson(client, com);
                                        NguoiDungDTO ng = new NguoiDungDTO("",register.sdt, register.pass, register.ho, register.ten, register.ngaysinh);
                                        DAO.NguoiDungDAO.ThemNguoiDung(conn, ng);
                                        dsnguoidung.Add(ng);
                                        DSUser.Add(register.sdt, register.pass);
                                        DSClient.Add(register.sdt, client);
                                        AppendTextBox("Client kết nối có họ tên là: " + LayTenNguoiDung(register.sdt));
                                    }
                                }
                                    break;
                            }
                        case 3: // Tải trang chủ lấy danh sách bạn bè, danh sách nhóm
                            {
                                string idnguoidung = LayIDNguoiDung(com.content);
                                List<DTO.NguoiDungDTO> dsban = new List<DTO.NguoiDungDTO>();                                
                                dsban = DAO.NguoiDungDAO.LayDSBanBeNguoiDung(conn, idnguoidung);

                                List<DTO.NhomDTO> dsnhom = new List<DTO.NhomDTO>();
                                dsnhom = DAO.NhomDAO.LayDSNhomNguoiDung(conn, idnguoidung);

                                MESSAGE.DSBANBENHOM? ds = new MESSAGE.DSBANBENHOM(dsban,dsnhom);
                                string s1 = JsonConvert.SerializeObject(ds);
                                com = new COMMON(31, s1);
                                sendJson(client, com);
                                break;
                            }
                        case 41: // Tắt form tạo nhóm
                            {
                                com = new COMMON(411, "CANCEL");
                                sendJson(client, com);
                                break;
                            }
                        case 5: // Thêm bạn
                            {
                                THEMBAN? themban = System.Text.Json.JsonSerializer.Deserialize<THEMBAN>(com.content);
                                if (themban != null)
                                {
                                    string idnguoi = LayIDNguoiDung(themban.nguoidung);
                                    string idban = LayIDNguoiDung(themban.banbe);
                                    DAO.BanBeDAO.ThemBan(conn, idnguoi, idban);
                                    com = new COMMON(51, "OK");
                                    sendJson(client, com);
                                }
                                break;
                            }
                        case 6: // Thêm nhóm
                            {
                                THEMNHOM? themnhom = JsonConvert.DeserializeObject<THEMNHOM>(com.content);
                                if (themnhom != null)
                                {
                                    string idnguoi = LayIDNguoiDung(themnhom.SoDienThoaiNguoiTao);
                                    DTO.ThanhVienNhomDTO tv = new DTO.ThanhVienNhomDTO(themnhom.Nhom.IDNhom, idnguoi);
                                    themnhom.DSThanhVien.Add(tv);
                                    DAO.NhomDAO.ThemNhom(conn, themnhom.Nhom);
                                    DAO.ThanhVienNhomDAO.ThemThanhVienNhom(conn, themnhom.DSThanhVien);
                                    com = new COMMON(61, "OK");
                                    sendJson(client, com);
                                }
                                break;
                            }

                        case 21:// get group message
                            {
                                AppendTextBox("group message: "+com.content);
                                REQUEST_MESSAGE? reqMessage = JsonConvert.DeserializeObject<REQUEST_MESSAGE>(com.content);
                                if (reqMessage!= null)
                                {
                                    List<DTO.TinNhanNhom> dstnGR = new List<DTO.TinNhanNhom>();
                                    dstnGR = DAO.TinNhanDAO.getMessageFromGroup(conn, reqMessage.toId);
                                    com = new COMMON(21, JsonConvert.SerializeObject(dstnGR));
                                    sendJson(client, com);
                                }
                                break;
                            }

                        case 22:// get user message
                            {
                                AppendTextBox("user message: "+com.content);
                                REQUEST_MESSAGE? reqMessage = JsonConvert.DeserializeObject<REQUEST_MESSAGE>(com.content);
                                string idNguoiDung = LayIDNguoiDung(reqMessage.fromPhone);
                                List<DTO.TinNhanCaNhan> dstnCN = new List<DTO.TinNhanCaNhan>();
                                dstnCN = DAO.TinNhanDAO.getMessageFromUser(conn, idNguoiDung, reqMessage.toId);
                                com = new COMMON(22, JsonConvert.SerializeObject(dstnCN));
                                sendJson(client, com);
                                break;
                            }
                    }
                }
                else
                {
                    com = new COMMON(0, "CANCEL");
                    sendJson(client, com);
                    return;
                }
            }
            try
            {
                bool tieptuc = true;
                while (tieptuc)
                {
                    data = new byte[1024];
                    recv = client.Receive(data);
                    if (recv == 0) continue;
                    string s = Encoding.ASCII.GetString(data, 0, recv);
                    com = System.Text.Json.JsonSerializer.Deserialize<MESSAGE.COMMON>(s);

                    if (com != null && com.content != null)
                    {
                        switch (com.kind)
                        {
                            case 4: // Đăng xuất
                                {
                                    DSClient[com.content].Close();
                                    DSClient.Remove(com.content);
                                    tieptuc = false;
                                    break;
                                }
                            
                            
                        }
                    }
                }
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            catch (Exception)
            {
                server.Close();
            }
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}