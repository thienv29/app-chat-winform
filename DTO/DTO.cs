
using System.Security.Cryptography.X509Certificates;

namespace DTO
{
    public class NguoiDungDTO
    {
        private string idnguoidung;
        private string sodienthoai;
        private string matkhau;
        private string ho;
        private string ten;
        private string ngaysinh;
        public NguoiDungDTO(string idnguoidung, string sodienthoai, string matkhau, string ho, string ten, string ngaysinh)
        {
            this.idnguoidung = idnguoidung;
            this.sodienthoai = sodienthoai;
            this.matkhau = matkhau;
            this.ho = ho;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
        }
        public string IDNguoiDung { get => idnguoidung; set => idnguoidung = value; }
        public string SoDienThoai { get => sodienthoai; set => sodienthoai = value; }
        public string MatKhau { get => matkhau; set => matkhau = value; }
        public string HoNguoiDung { get => ho; set => ho = value; }
        public string TenNguoiDung { get => ten; set => ten = value; }
        public string NgaySinh { get => ngaysinh; set => ngaysinh = value; }
    }
    public class NhomDTO
    {
        private string idnhom;
        private string tennhom;
        private string slthanhvien;
        private string hinh;
        public NhomDTO(string idnhom, string tennhom, string slthanhvien, string hinh)
        {
            this.idnhom = idnhom;
            this.tennhom = tennhom;
            this.slthanhvien = slthanhvien;
            this.hinh = hinh;
        }
        public string IDNhom { get => idnhom; set => idnhom = value; }
        public string TenNhom { get => tennhom; set => tennhom = value; }
        public string SLThanhVien { get => slthanhvien; set => slthanhvien = value; }
        public string Hinh { get => hinh; set => hinh = value; }
    }
    public class ThanhVienNhomDTO
    {
        private string idnhom;
        private string idnguoi;
        public ThanhVienNhomDTO(string idnhom, string idnguoi)
        {
            this.idnhom = idnhom;
            this.idnguoi = idnguoi;
        }
        public string IDNhom { get => idnhom; set => idnhom = value; }
        public string IDNguoi { get => idnguoi; set => idnguoi = value; }
    }
    public class TinNhanCaNhan
    {
        private string id;
        private string nguoiGui;
        private string nguoiNhan;
        private string noiDung;
        private string trangThai;
        public TinNhanCaNhan(string id,
            string nguoiGui,
            string nguoiNhan,
            string noiDung,
            string trangThai
)
        {
            this.id = id;
            this.nguoiGui = nguoiGui;
            this.nguoiNhan = nguoiNhan;
            this.noiDung = noiDung;
            this.trangThai = trangThai;
        }
        public string ID { get => id; set => id = value; }
        public string IDNguoiGui { get => nguoiGui; set => nguoiGui = value; }
        public string IDNguoiNhan { get => nguoiNhan; set => nguoiNhan = value; }
        public string IDNoiDung { get => noiDung; set => noiDung = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
    public class TinNhanNhom
    {
        private string id;
        private string nguoiGui;
        private string nhomNhan;
        private string noiDung;
        private string trangThai;
        public TinNhanNhom(string id,
            string nguoiGui,
            string nhomNhan,
            string noiDung,
            string trangThai
)
        {
            this.id = id;
            this.nguoiGui = nguoiGui;
            this.nhomNhan = nhomNhan;
            this.noiDung = noiDung;
            this.trangThai = trangThai;
        }
        public string ID { get => id; set => id = value; }
        public string IDNguoiGui { get => nguoiGui; set => nguoiGui = value; }
        public string IDNhomNhan { get => nhomNhan; set => nhomNhan = value; }
        public string IDNoiDung { get => noiDung; set => noiDung = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }

    internal class DTO
    {
        static void Main(string[] args)
        {
        }
    }
}
