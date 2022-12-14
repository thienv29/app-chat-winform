using Newtonsoft.Json;
using System.Drawing.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace Client
{
    public partial class FormChat : Form
    {
        Boolean onRightBar = true;
        private IPEndPoint IP;
        Socket client;
        string idNguoiDung;
        string sodienthoai;
        string ten;
        List<DTO.NguoiDungDTO> dsbb;
        List<DTO.NhomDTO> dsnhombb;
        bool thoat = false;
        Thread trd;
        Thread trddangnhap;
        Thread trdtaonhom;
        Thread trdthemban;
        IPEndPoint iep;

        private int _ContactPanelsAddedCount = 0;
        private int _MessagePanelsAddedCount = 0;

        bool isCurGroup = false;
        string curId = "";


        public FormChat(string phone, string fullName)
        {
            InitializeComponent();
            iep = new IPEndPoint(IPAddress.Parse(Login.ip), int.Parse("2008"));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iep);
            sodienthoai = phone;
            ten = fullName;
            AppendTextBox(fullName);
            trd = new Thread(new ThreadStart(this.ThreadFormChat));
            trd.IsBackground = true;
            trd.Start();
        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                try { this.Invoke(new Action<string>(AppendTextBox), new object[] { value }); }
                catch (Exception) { }
                return;
            }
        }
        private void ThreadFormChat()
        {
            byte[] data = new byte[2048];
            MESSAGE.COMMON common = new MESSAGE.COMMON(3, sodienthoai);
            sendJson(common);
            int recv = client.Receive(data);

            string jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            MESSAGE.COMMON? com = System.Text.Json.JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
            try
            {
                if (com != null && com.kind == 31)
                {
                    dsbb = new List<DTO.NguoiDungDTO>();
                    MESSAGE.DSBANBENHOM? ds = JsonConvert.DeserializeObject<MESSAGE.DSBANBENHOM>(com.content);
                    dsbb = ds.DSBAN;
                    dsnhombb = ds.DSNHOM;
                    AppendListView(dsbb, dsnhombb);
                    while (!thoat)
                    {
                        data = new byte[1024];
                        recv = client.Receive(data);

                        jsonString = Encoding.ASCII.GetString(data, 0, recv);
                        com = System.Text.Json.JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
                        if (com != null)
                        {
                            switch (com.kind)
                            {
                                case 21:
                                    {
                                        MESSAGE.TNNHOM? messageGroups = JsonConvert.DeserializeObject<MESSAGE.TNNHOM>(com.content);
                                        messageGroups.DSTN.ForEach(g =>
                                        {
                                            if(g.IDNguoiGui == idNguoiDung)
                                            {
                                                CreateMessagePanel(g.IDNoiDung, true);
                                            }
                                            else
                                            {
                                                CreateMessagePanel(g.IDNoiDung, false);
                                            }
                                            Console.WriteLine(g.IDNoiDung);
                                        });
                                        break;
                                    }
                                case 22:
                                    {
                                        MESSAGE.TNBAN? messageUsers = JsonConvert.DeserializeObject<MESSAGE.TNBAN>(com.content);

                                        break;
                                    }
                            }
                        }
                    }
                }
                client.Disconnect(true);
                client.Close();
            }
            catch (Exception)
            {

            }
        }
        public void AppendListView(List<DTO.NguoiDungDTO> value, List<DTO.NhomDTO> value1)
        {
            if (InvokeRequired)
            {
                try { this.Invoke(new Action<List<DTO.NguoiDungDTO>, List<DTO.NhomDTO>>(AppendListView), new object[] { value, value1 }); }
                catch (Exception) { }
                return;
            }
            System.Windows.Forms.ImageList myIcon = new ImageList();
            myIcon.ImageSize = new Size(50, 50);
            int i = 0;
            foreach (DTO.NguoiDungDTO ng in value)
            {
                var id = ng.IDNguoiDung;
                var username = ng.HoNguoiDung + " " + ng.TenNguoiDung;
                var phone = ng.SoDienThoai;
                CreateContactPanel(id, username, phone, false);
                i++;
            }
            foreach (DTO.NhomDTO nh in value1)
            {
                var id =  nh.IDNhom;
                var username = "Nhóm: " + nh.TenNhom;
                var phone = "";
                CreateContactPanel(id, username, phone,true);
                i++;
            }
        }

        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        void Close()
        {
            if(client != null)
            {
                client.Close();
            }
        }
     

        private void iconSend_Click(object sender, EventArgs e)
        {
        }

        private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }


        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (txtMessage.Text.Length > 0)
            {
                iconSend.IconColor = Color.Pink;
            }
            else
            {
                iconSend.IconColor = Color.FromArgb(197, 197, 197);
            }
        }

        private void btnOnRightBar_Click(object sender, EventArgs e)
        {
            pnRight.Width = !onRightBar ? 265 : 0;
            onRightBar = !onRightBar;
            resetMyLocationMessage();
        }
        private void resetMyLocationMessage()
        {
            foreach (Control ctr in pnListMessage.Controls)
            {

                if (ctr.Controls.Count > 0 && ctr.Controls[0].Location.X > 0)
                {
                    ctr.Controls[0].Location = new System.Drawing.Point(pnListMessage.Size.Width - ctr.Controls[0].Width, 14);
                }
            }
        }

        public void CreateContactPanel()
        {
            Panel contactPanel;
            contactPanel = new Panel();
            {
                var withBlock = contactPanel;
                withBlock.BackColor = Color.White;
                withBlock.Size = new Size(420, 50);
                withBlock.Name = "pnlContact" + (_ContactPanelsAddedCount + 1).ToString();
                withBlock.Dock = DockStyle.Top;
            }
            contactPanel.Click += DynamicButton_Click;
            flpMain.Controls.Add(contactPanel);
            flpMain.ScrollControlIntoView(contactPanel);
            _ContactPanelsAddedCount += 1;
        }

        public void DynamicButton_Click(object sender, EventArgs e)
        {
            string parentPanelName ="";

            foreach (Control controlObj in flpMain.Controls)
            {
                if (controlObj.Name == (sender as Panel).Name)
                {
                    parentPanelName = controlObj.Name;
                    controlObj.BackColor = Color.FromArgb(254, 227, 236);
                    isCurGroup = parentPanelName.Split('_')[1] == "group";
                    curId = parentPanelName.Split('_')[2];

                    if (isCurGroup)
                    {
                        currentInterac.Text = dsnhombb.Find(nhom => nhom.IDNhom == curId).TenNhom;
                        var a = new Thread(getMessageGroup);
                        a.SetApartmentState(ApartmentState.STA);
                        a.Start();
                        //getMessageGroup();
                    }
                    else
                    {
                        var bb = dsbb.Find(nhom => nhom.IDNguoiDung == curId);
                        currentInterac.Text = bb.HoNguoiDung + " " + bb.TenNguoiDung;
                        getMessageUser();
                    }
                    
                }
                else
                {
                    controlObj.BackColor = Color.White;
                }
            }

            Console.WriteLine(parentPanelName);


        }

        private void getMessageUser()
        {
            MESSAGE.REQUEST_MESSAGE requestMessage = new MESSAGE.REQUEST_MESSAGE(sodienthoai, curId,isCurGroup);
            string jsonString = System.Text.Json.JsonSerializer.Serialize(requestMessage);
            MESSAGE.COMMON common = new MESSAGE.COMMON(22, jsonString);
            sendJson(common);
        }
        private void getMessageGroup()
        {
            byte[] data = new byte[1024];
            MESSAGE.REQUEST_MESSAGE requestMessage = new MESSAGE.REQUEST_MESSAGE(sodienthoai, curId, isCurGroup);
            string jsonString = System.Text.Json.JsonSerializer.Serialize(requestMessage);
            MESSAGE.COMMON common = new MESSAGE.COMMON(21, jsonString);
            sendJson(common);
            int recv = client.Receive(data);

            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            Console.WriteLine("asdaw"+jsonString);
            MESSAGE.COMMON? com = System.Text.Json.JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
            try
            {
                if (com != null && com.kind == 21)
                {
                    if (com.content != "CANCEL")
                    {
                       
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

        public void CreateMessagePanel(string message, Boolean isMine)
        {
            _MessagePanelsAddedCount += 1;

            Panel messagePanel;
            messagePanel = new Panel();
            {
                var withBlock = messagePanel;
                withBlock.AutoSize = true;
                withBlock.BackColor = Color.Transparent;
                withBlock.Name = "pnlMessage" + (_MessagePanelsAddedCount).ToString();
                withBlock.Dock = DockStyle.Bottom;
                withBlock.Padding = new System.Windows.Forms.Padding(15);
            }

            Label messageLabel;
            messageLabel = new Label();
            {
                var withBlock = messageLabel;
                withBlock.AutoSize = true;
                withBlock.Name = "lblMessagePhone" + _MessagePanelsAddedCount.ToString();
                withBlock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                withBlock.ForeColor = isMine ? Color.White : System.Drawing.SystemColors.ControlDarkDark; ;
                withBlock.BackColor = isMine ? System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(159))))) : Color.White;
                withBlock.MaximumSize = new System.Drawing.Size(500, 0);
                withBlock.Padding = new System.Windows.Forms.Padding(10);
                withBlock.Text = message;
            }

            messagePanel.Controls.Add(messageLabel);

            pnListMessage.Controls.Add(messagePanel);
            pnListMessage.ScrollControlIntoView(messagePanel);
            resetMyLocationMessage();
        }

        public void CreateContactPanel(string id, string username, string phoneNumber, Boolean isGroup)
        {
            _ContactPanelsAddedCount += 1;
            Panel contactPanel;
            contactPanel = new Panel();
            {
                var withBlock = contactPanel;
                withBlock.BackColor = Color.White;
                withBlock.Size = new Size(420, 50);
                if (isGroup)
                {
                    withBlock.Name = "pnlContact_group_" + id;
                }
                else
                {
                withBlock.Name = "pnlContact_user_" + id;

                }
                withBlock.Dock = DockStyle.Top;
            }
            contactPanel.Click += DynamicButton_Click;

            PictureBox contactPictureBox;
            contactPictureBox = new PictureBox();
            {
                var withBlock = contactPictureBox;
                withBlock.SizeMode = PictureBoxSizeMode.Zoom;
                withBlock.Size = new Size(45, 45);
                withBlock.Location = new Point(5, 5);
                withBlock.Name = "picContactImage" + (_ContactPanelsAddedCount).ToString();
                if (isGroup)
                {
                    withBlock.ImageLocation = "https://static.thenounproject.com/png/983470-200.png";
                }
                else
                {
                    withBlock.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/User_font_awesome.svg/1200px-User_font_awesome.svg.png";

                }
            }

            Rectangle r = new Rectangle(0, 0, contactPictureBox.Width, contactPictureBox.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, contactPictureBox.Width - 3, contactPictureBox.Height - 3);
            Region rg = new Region(gp);
            contactPictureBox.Region = rg;


            Label contactNameLabel;
            contactNameLabel = new Label();
            {
                var withBlock = contactNameLabel;
                withBlock.AutoSize = true;
                withBlock.Location = new Point(60, 10);
                withBlock.Name = "lblContactName" + _ContactPanelsAddedCount.ToString();
                withBlock.ForeColor = Color.Black;
                withBlock.Text = username;
            }


            Label contactPhoneLabel;
            contactPhoneLabel = new Label();
            {
                var withBlock = contactPhoneLabel;
                withBlock.AutoSize = true;
                withBlock.Location = new Point(60, 30);
                withBlock.Name = "lblContactPhone" + _ContactPanelsAddedCount.ToString();
                withBlock.ForeColor = Color.Gray;
                withBlock.Text = phoneNumber;
            }


            contactPanel.Controls.Add(contactPictureBox);
            contactPanel.Controls.Add(contactNameLabel);
            contactPanel.Controls.Add(contactPhoneLabel);

            flpMain.Controls.Add(contactPanel);
            flpMain.ScrollControlIntoView(contactPanel);
        }



        private void FormChat_Load(object sender, EventArgs e)
        {
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconSend.PerformClick();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            trdthemban = new Thread(LoadFormAddFriend);
            trdthemban.SetApartmentState(ApartmentState.STA);
            trdthemban.Start();
        }
        private void LoadFormAddFriend(object? obj)
        {
            Application.Run(new AddFriend(sodienthoai, ten));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            trdtaonhom = new Thread(LoadFormCreateGroup);
            trdtaonhom.SetApartmentState(ApartmentState.STA);
            trdtaonhom.Start();
        }
        private void LoadFormCreateGroup(object? obj)
        {
            Application.Run(new CreateGroup(sodienthoai, dsbb, ten));
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            MESSAGE.COMMON common = new MESSAGE.COMMON(4, sodienthoai);
            sendJson(common);
            trddangnhap = new Thread(LoadFormLogin);
            trddangnhap.SetApartmentState(ApartmentState.STA);
            trddangnhap.Start();
        }
        private void LoadFormLogin(object? obj)
        {
            Application.Exit();
            Application.Run(new Login());
        }
    }
}