// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Scaffold_EntityFramework.DataBase;
using Scaffold_EntityFramework.Models;
using Scaffold_EntityFramework.TestDatabase;


// sử dung scaffold trong entity frame work
//Install - Package Microsoft.EntityFrameworkCore.SqlServer
//Install-Package Microsoft.EntityFrameworkCore.Tools
//Scaffold-DbContext "Data Source=LAPTOP-7CAHEI3Q\HATHANHHAO;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context dbcontext
class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("---------------------");
        using var context = new dbcontext();
        var khachhangdata = new KhachHangData(context);
        var khachhangdatabase = new KhachHangDatabase(khachhangdata);

        var search = await khachhangdatabase.SearchKhachHangDb("10101");
        Console.WriteLine(" tim thanh cong");
       foreach (var item in search)
        {
            Console.WriteLine($"id: {item.MaKh} kh: {item.TenKh} cty: {item.TenCty} sdt: {item.Sdt} dchi: {item.Diachi}");
        }

        //
        Console.WriteLine("---------------------------");
        var allNhanViens = await khachhangdatabase.GetDataKhachHang();
        Console.WriteLine("All Employees:");
        foreach (var nhanVien in allNhanViens)
        {
            Console.WriteLine($"MaNv: {nhanVien.MaKh}, TenNv: {nhanVien.TenKh}, Diachi: {nhanVien.Diachi} Sdt: {nhanVien.Sdt}");
        }
    }
}
