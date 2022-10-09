using System.Drawing.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
namespace Server
{
    public partial class FormChat : Form
    {
        Boolean onRightBar = true;
        private IPEndPoint IP;
        private Socket server;
        private List<Socket> clientList;
        private int _ContactPanelsAddedCount = 0;
        private int _MessagePanelsAddedCount = 0;
        public FormChat()
        {

            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 1611);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        Console.WriteLine("new client connected");
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 1611);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });
            Listen.IsBackground = true;
            Listen.Start();
            Console.WriteLine("server is running 1611");

        }
        void Close()
        {
            server.Close();
        }
        void Send(Socket client)
        {
            if (txtMessage.Text != string.Empty)
            {
                client.Send(Serialize(txtMessage.Text));
            }
        }
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    foreach (Socket socket in clientList)
                    {
                        if (socket != null && socket != client)
                            socket.Send(Serialize(message));
                    }
                    if (this.InvokeRequired)
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            CreateMessagePanel(message, false);
                        });
                    }
                   

                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }
        byte[] Serialize(object obj)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);
            return ms.ToArray();

        }
        object Deserialize(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(ms);

        }


        private void iconSend_Click(object sender, EventArgs e)
        {
            foreach (Socket client in clientList)
            {
                Send(client);
            }
            CreateMessagePanel(txtMessage.Text, true);
            txtMessage.Clear();
        }

        private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (server != null)
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

        public void DynamicButton_Click(object sender, EventArgs e)
        {
            string parentPanelName;

            parentPanelName = null;
            foreach (Control controlObj in flpMain.Controls)
            {
                if (controlObj.Name == (sender as Panel).Name)
                {
                    parentPanelName = controlObj.Name;
                    controlObj.BackColor = Color.FromArgb(254, 227, 236);
                }
                else
                {
                    controlObj.BackColor = Color.White;
                }
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
                var s = (message.Length * 9) > 480 ? 500 : ((message.Length * 9) + 20);
                withBlock.AutoSize = true;
                withBlock.Name = "lblMessagePhone" + _MessagePanelsAddedCount.ToString();
                withBlock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                withBlock.ForeColor = isMine ? Color.White : System.Drawing.SystemColors.ControlDarkDark; ;
                withBlock.BackColor = isMine ? System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(159))))) : Color.White;
                withBlock.MaximumSize = new System.Drawing.Size(500, 0);
                withBlock.Padding = new System.Windows.Forms.Padding(10);
                withBlock.Location = isMine ? new System.Drawing.Point(1, 14) : new System.Drawing.Point(0, 14);
                withBlock.Text = message;
            }

            messagePanel.Controls.Add(messageLabel);

            pnListMessage.Controls.Add(messagePanel);
            pnListMessage.ScrollControlIntoView(messagePanel);
            resetMyLocationMessage();
        }

        public void CreateContactPanel(string imagePath, string username, string phoneNumber)
        {
            _ContactPanelsAddedCount += 1;
            Panel contactPanel;
            contactPanel = new Panel();
            {
                var withBlock = contactPanel;
                withBlock.BackColor = Color.White;
                withBlock.Size = new Size(420, 50);
                withBlock.Name = "pnlContact" + (_ContactPanelsAddedCount).ToString();
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
                withBlock.ImageLocation = imagePath;
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

        private void btn_addContact_Click_1(object sender, EventArgs e)
        {
            var strImage = "logo.png";
            var username = "LAPTRINHVB.NET";
            var phone = "+(84) 956.123.122";
            CreateContactPanel(strImage, username, phone);
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
    }
}