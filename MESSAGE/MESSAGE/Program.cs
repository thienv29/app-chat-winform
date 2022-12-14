
using System.Collections;
using DTO;

namespace MESSAGE
{
    public class COMMON
    {
        public COMMON(int kind, string? content)
        {
            this.kind = kind;
            this.content = content;
        }
        public int kind { get; set; }
        public string? content { get; set; }
    }
    public class LOGIN
    {
        public LOGIN(string? username, string? pass)
        {
            this.username = username;
            this.pass = pass;
        }
        public string? username { get; set; }
        public string? pass { get; set; }
    }
    public class REQUEST_MESSAGE
    {
        public REQUEST_MESSAGE(string? fromPhone, string? toId, bool isGroup)
        {
            this.fromPhone = fromPhone;
            this.toId = toId;
            this.isGroup = isGroup;
        }
        public string? fromPhone { get; set; }
        public string? toId { get; set; }
        public bool? isGroup { get; set; }
    }
    public class REGISTER
    {
        public REGISTER(string? sdt, string? pass, string? ho, string? ten, string? ngaysinh)
        {
            this.sdt = sdt;
            this.pass = pass;
            this.ho = ho;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
        }
        public string? sdt { get; set; }
        public string? pass { get; set; }
        public string? ho { get; set; }
        public string? ten { get; set; }
        public string? ngaysinh { get; set; }
    }
    public class DSBANBENHOM
    {
        public DSBANBENHOM(List<DTO.NguoiDungDTO>? dsban, List<DTO.NhomDTO>? dsnhom)
        {
            this.DSBAN = dsban;
            this.DSNHOM = dsnhom;
        }
        public List<DTO.NguoiDungDTO>? DSBAN { get; set; }
        public List<DTO.NhomDTO>? DSNHOM { get; set; }
    }

    public class TNNHOM
    {
        public TNNHOM(List<DTO.TinNhanNhom>? dstn)
        {
            this.DSTN = dstn;
        }
        public List<DTO.TinNhanNhom>? DSTN { get; set; }
    }

    public class TNBAN
    {
        public TNBAN(List<DTO.TinNhanCaNhan>? dstn)
        {
            this.DSTN = dstn;
        }
        public List<DTO.TinNhanCaNhan>? DSTN { get; set; }
    }
    public class THEMBAN
    {
        public THEMBAN(string? nguoidung, string? banbe)
        {
            this.nguoidung = nguoidung;
            this.banbe = banbe;
        }
        public string? nguoidung { get; set; }
        public string? banbe { get; set; }
    }
    public class MESSAGE
    {
        public MESSAGE(string? usernameSender, string? usernameReceiver, string? content)
        {
            this.usernameSender = usernameSender;
            this.usernameReceiver = usernameReceiver;
            this.content = content;
        }
        public string? usernameSender { get; set; }
        public string? usernameReceiver { get; set; }
        public string? content { get; set; }
    }
    public class THEMNHOM
    {
        public THEMNHOM(DTO.NhomDTO? nhom, List<DTO.ThanhVienNhomDTO>? dsthanhvien,string sdtnguoitao)
        {
            this.Nhom = nhom;
            this.DSThanhVien = dsthanhvien;
            this.SoDienThoaiNguoiTao = sdtnguoitao;
            
        }
        public DTO.NhomDTO? Nhom { get; set; }
        public List<DTO.ThanhVienNhomDTO>? DSThanhVien { get; set; }
        public string? SoDienThoaiNguoiTao { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
