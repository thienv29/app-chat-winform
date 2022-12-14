using ConnectDatabase;
using DTO;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data.Common;

namespace DAO
{
    public class NguoiDungDAO
    {
        public NguoiDungDAO()
        {
            
        }
        public static ArrayList LayDSNguoiDung(MySqlConnection conn)
        {            
            ArrayList listnguoidung = new ArrayList();
            string sql = "select * from nguoi_dung";
            MySqlCommand command = new MySqlCommand();
            command.Connection= conn;
            command.CommandText= sql;
            using (DbDataReader reader= command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        DTO.NguoiDungDTO ngdung = new NguoiDungDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        listnguoidung.Add(ngdung);
                    }
                }
            }
            return listnguoidung;
        }
        public static List<DTO.NguoiDungDTO> LayDSBanBeNguoiDung(MySqlConnection conn,string id)
        {
            List<DTO.NguoiDungDTO> listnguoidung = new List<NguoiDungDTO>();
            string sql = "SELECT nguoi_dung.* from ban_be,nguoi_dung WHERE nguoi_dung.IDNguoiDung = ban_be.IDBanBe AND ban_be.IDNguoiDung = @id";
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", id);
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DTO.NguoiDungDTO ngdung = new NguoiDungDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        listnguoidung.Add(ngdung);
                    }
                }
            }
            return listnguoidung;
        }
        public static int ThemNguoiDung(MySqlConnection conn, NguoiDungDTO ng)
        {

            String sql = "INSERT INTO `nguoi_dung`(`IDNguoiDung`, `SoDienThoai`, `MatKhau`, `Ho`, `Ten`, " +
                "`NgaySinh`, `AnhDaiDien`, `TrangThai`) VALUES (@idnguoidung,@sdt,@pass,@ho,@ten" +
                ",@ngaysinh,'',1) ";

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = sql;

            command.Parameters.AddWithValue("@idnguoidung", "USER"+ng.SoDienThoai);

            command.Parameters.AddWithValue("@sdt", ng.SoDienThoai);

            command.Parameters.AddWithValue("@pass", ng.MatKhau);

            command.Parameters.AddWithValue("@ho", ng.HoNguoiDung);
            command.Parameters.AddWithValue("@ten", ng.TenNguoiDung);
            command.Parameters.AddWithValue("@ngaysinh", ng.NgaySinh);

            int rows = command.ExecuteNonQuery();

            return rows;
        }
    }
    public class BanBeDAO
    {
        public BanBeDAO() 
        { 

        }
        public static int ThemBan(MySqlConnection conn, string nguoidung, string banbe)
        {

            string sql = "INSERT INTO `ban_be`(`IDNguoiDung`, `IDBanBe`) VALUES (@idnguoidung,@idbanbe)";

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = sql;

            command.Parameters.AddWithValue("@idnguoidung", nguoidung);

            command.Parameters.AddWithValue("@idbanbe", banbe);
            Console.WriteLine(nguoidung);
            Console.WriteLine(banbe);

            int rows = command.ExecuteNonQuery();

            return rows;
        }
    }
    public class NhomDAO
    {
        public NhomDAO()
        {

        }
        public static int ThemNhom(MySqlConnection conn, DTO.NhomDTO nh)
        {

            string sql = "INSERT INTO `nhom`(`IDNhom`, `TenNhom`, `SoLuongThanhVien`, `AnhDaiDien`, `TrangThai`) " +
                "VALUES (@idnhom,@tennhom,@slthanhvien,@hinh,1)";

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = sql;

            command.Parameters.AddWithValue("@idnhom", nh.IDNhom);

            command.Parameters.AddWithValue("@tennhom", nh.TenNhom);

            command.Parameters.AddWithValue("@slthanhvien", nh.SLThanhVien);

            command.Parameters.AddWithValue("@hinh", nh.Hinh);

            int rows = command.ExecuteNonQuery();

            return rows;
        }
        public static List<DTO.NhomDTO> LayDSNhomNguoiDung(MySqlConnection conn, string id)
        {
            List<DTO.NhomDTO> listnhomnguoidung = new List<NhomDTO>();
            string sql = "SELECT nhom.* FROM nhom, thanh_vien_nhom WHERE nhom.IDNhom = thanh_vien_nhom.IDNhom AND thanh_vien_nhom.IDNguoiDung = @id";
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", id);
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DTO.NhomDTO ngdung = new NhomDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        listnhomnguoidung.Add(ngdung);
                    }
                }
            }
            return listnhomnguoidung;
        }
    }
    public class ThanhVienNhomDAO
    {
        public ThanhVienNhomDAO()
        {

        }
        public static int ThemThanhVienNhom(MySqlConnection conn, List<DTO.ThanhVienNhomDTO> tvn)
        {
            

            MySqlCommand command = new MySqlCommand();
            int rows = 0;
            command.Connection = conn;
            foreach (DTO.ThanhVienNhomDTO tv in tvn)
            {
                string sql = "INSERT INTO `thanh_vien_nhom`(`IDNhom`, `IDNguoiDung`) " +
                "VALUES ('" + tv.IDNhom + "','" + tv.IDNguoi + "')";

                command.CommandText = sql;

                rows = command.ExecuteNonQuery();
            }
            
            return rows;
        }
        
    }

    public class TinNhanDAO
    {
        public TinNhanDAO()
        {

        }
        public static int MessageToUser(MySqlConnection conn, string fromUser, string toUser, string content)
        {

            string sql = "INSERT INTO `tin_nhan_ca_nhan` VALUES (uuid(),@fromUser,@toUser,@content,0);";

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = sql;

            command.Parameters.AddWithValue("@fromUser", fromUser);
            command.Parameters.AddWithValue("@toUser", toUser);
            command.Parameters.AddWithValue("@content", content);

            int rows = command.ExecuteNonQuery();

            return rows;
        }


        public static List<DTO.TinNhanCaNhan> getMessageFromUser(MySqlConnection conn, string fromUser, string toUser)
        {
            var listTn = new List<DTO.TinNhanCaNhan>();
            string sql = "SELECT * FROM tin_nhan_ca_nhan where NguoiGui in ('" + fromUser + "', '" + toUser + "') and NguoiNhan in ('" + fromUser + "', '" + toUser + "');";
            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = sql;
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DTO.TinNhanCaNhan tn = new TinNhanCaNhan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        listTn.Add(tn);
                    }
                }
            }
            return listTn;
        }

        public static List<DTO.TinNhanNhom> getMessageFromGroup(MySqlConnection conn, string groupId)
        {
            var listTn = new List<DTO.TinNhanNhom>();
            string sql = "SELECT * FROM tin_nhan_nhom where  NhomNhan = '" + groupId+"'";
            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = sql;
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DTO.TinNhanNhom tn = new TinNhanNhom(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        listTn.Add(tn);
                    }
                }
            }
            return listTn;
        }

        public static int MessageToGroup(MySqlConnection conn, string fromUser, string toGroup, string content)
        {

            string sql = "INSERT INTO `tin_nhan_nhom` VALUES (uuid(),@fromUser,@toGroup,@content,0);";

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = sql;

            command.Parameters.AddWithValue("@fromUser", fromUser);
            command.Parameters.AddWithValue("@toGroup", toGroup);
            command.Parameters.AddWithValue("@content", content);

            int rows = command.ExecuteNonQuery();

            return rows;
        }

    }
    internal class DAO
    {
        static void Main(string[] args)
        {
        }
    }
}
