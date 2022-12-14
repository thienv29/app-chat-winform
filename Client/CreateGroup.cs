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

namespace Client
{
    public partial class CreateGroup : Form
    {
        Socket client;
        string phone;
        string ten;
        string idnhom;
        List<DTO.NguoiDungDTO> dsbb;
        List<DTO.ThanhVienNhomDTO> dstv;
        bool thoat = false;
        Thread trd;
        Thread trdtat;
        IPEndPoint iep;
        public CreateGroup(string sdt, List<DTO.NguoiDungDTO> ds, string hoten)
        {
            InitializeComponent();
            iep = new IPEndPoint(IPAddress.Parse(Login.ip), int.Parse("2008"));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iep);
            phone = sdt;
            ten = hoten;
            dsbb = ds;
            AppendListViewBanBe(dsbb);            
        }
        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        public void AppendListViewBanBe(List<DTO.NguoiDungDTO> value)
        {
            if (InvokeRequired)
            {
                try { this.Invoke(new Action<List<DTO.NguoiDungDTO>>(AppendListViewBanBe), new object[] { value }); }
                catch (Exception) { }
                return;
            }
            System.Windows.Forms.ImageList myIcon = new ImageList();
            myIcon.ImageSize = new Size(32, 32);
            listViewBanBeTaoNhom.SmallImageList= myIcon;
            int i = 0;
            foreach (DTO.NguoiDungDTO ng in value)
            {
                ListViewItem lvsitem = new ListViewItem();
                lvsitem.ImageIndex = i;
                lvsitem.Tag = ng.IDNguoiDung;
                lvsitem.Text = ng.HoNguoiDung + " " + ng.TenNguoiDung;
                listViewBanBeTaoNhom.Items.Add(lvsitem);
                i++;
            }
        }
        public void XulyCheckboxListView(System.Windows.Forms.ListView value)
        {
            if (InvokeRequired)
            {
                try { this.Invoke(new Action<System.Windows.Forms.ListView>(XulyCheckboxListView), new object[] { value }); }
                catch (Exception) { }
                return;
            }
            System.Windows.Forms.ListView lsv = value as System.Windows.Forms.ListView;
            List<DTO.ThanhVienNhomDTO> dstv1 = new List<DTO.ThanhVienNhomDTO>();
            for (int i = 0; i < lsv.CheckedItems.Count; i++)
            {
                if (lsv.CheckedItems[i].Checked == true)
                {
                    DTO.ThanhVienNhomDTO tv = new DTO.ThanhVienNhomDTO(idnhom, lsv.CheckedItems[i].Tag.ToString());
                    dstv1.Add(tv);
                }
            }
            dstv = dstv1;
        }
        private void ThreadTaoNhom()
        {
            DateTime date = DateTime.Now; 
            idnhom = "NHOM" + groupName.Text + date;
            idnhom.Replace(" ", "");
            XulyCheckboxListView(listViewBanBeTaoNhom);
            DTO.NhomDTO nhom = new DTO.NhomDTO(idnhom, groupName.Text,dstv.Count.ToString(),"");

            byte[] data = new byte[1024];
            MESSAGE.THEMNHOM themnhom = new MESSAGE.THEMNHOM(nhom, dstv,phone);

            string jsonString = JsonConvert.SerializeObject(themnhom);
            MESSAGE.COMMON common = new MESSAGE.COMMON(6, jsonString);
            sendJson(common);
            int recv = client.Receive(data);

            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            MESSAGE.COMMON? com = System.Text.Json.JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
            try
            {
                if (com != null && com.kind == 61)
                {
                    if (com.content == "OK")
                    {
                        MessageBox.Show("Thêm nhóm thành công");
                        trdtat = new Thread(TatForm);
                        trdtat.SetApartmentState(ApartmentState.STA);
                        trdtat.Start();
                    }
                }
                client.Disconnect(true);
                client.Close();
            }
            catch (Exception)
            {

            }
        }

        private void ThemNhom_Click(object sender, EventArgs e)
        {
            trd = new Thread(new ThreadStart(this.ThreadTaoNhom));
            trd.IsBackground = true;
            trd.Start();
        }
        private void TatForm(object? obj)
        {
            Application.Exit();
            Application.Run(new FormChat(phone,ten));
        }
        private void ThoatFormTaoNhom_Click(object sender, EventArgs e)
        {
            MESSAGE.COMMON common = new MESSAGE.COMMON(41, phone);
            sendJson(common);
            byte[] data = new byte[1024];
            int recv = client.Receive(data);

            string jsonString = Encoding.ASCII.GetString(data, 0, recv);
            MESSAGE.COMMON? com = System.Text.Json.JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
            try
            {
                if (com != null && com.kind == 411)
                {
                    
                    if (com.content == "CANCEL")
                    {
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

        private void CreateGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
