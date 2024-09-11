using Microsoft.EntityFrameworkCore;
using Scaffold_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scaffold_EntityFramework.DataBase
{
    public class KhachHangData
    {
        private readonly dbcontext context;

        public KhachHangData(dbcontext _context)
        {
            this.context = _context;
        }
        // hien thi khach hang
        public async Task<List<KhachHang>> GetKhachHangs()
        {
            return await context.Set<KhachHang>().ToListAsync();
        }
        // insert 
        public  async Task AddKhachHang(KhachHang khach)
        {
            if (khach == null) throw new ArgumentNullException(nameof(khach));
            context.KhachHangs.Add(khach);
            await context.SaveChangesAsync();
        }

        // update
        public async Task UpdateKhachHang(KhachHang khach)
        {
            if (khach == null) throw new ArgumentNullException(nameof(khach));

            var exitstingKhach = await context.KhachHangs.FindAsync(khach.MaKh);
            if (exitstingKhach == null) throw new KeyNotFoundException("KhachHang not found");

            exitstingKhach.TenKh = khach.TenKh;
            exitstingKhach.Diachi = khach.Diachi;
            exitstingKhach.TenCty = khach.TenCty;
            exitstingKhach.Sdt = khach.Sdt;
            exitstingKhach.Thanhpho = khach.Thanhpho;

            await context.SaveChangesAsync();
        }
        // delete
        public async Task DeleteKhachHang(string khachid)
        {
            var delKhach = await context.KhachHangs.FindAsync(khachid);

            if (delKhach == null)
                throw new KeyNotFoundException("khong tim thay khach hang de xoa");
            context.KhachHangs.Remove(delKhach);
            await context.SaveChangesAsync();
        }

        public async Task<List<KhachHang>> SearchKhachHang(string search)
        {
            if (string.IsNullOrWhiteSpace(search)) 
                throw new ArgumentNullException(nameof(search));

            return await context.KhachHangs
                .Where(p => p.MaKh == search)
                .ToListAsync();
        }
    }
}
