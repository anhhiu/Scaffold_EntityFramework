using Scaffold_EntityFramework.DataBase;
using Scaffold_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scaffold_EntityFramework.TestDatabase
{
    
    public class KhachHangDatabase
    {
        private readonly KhachHangData _data;

        public KhachHangDatabase(KhachHangData data)
        {
            _data = data;

        }
      
        public async Task<List<KhachHang>> GetDataKhachHang()
        {
            return await _data.GetKhachHangs();
        }

        public async Task AddNewKhachHangDB(string idkh, string tenkh, string tencty, string sdt, string diachi)
        {
            var Khach = new KhachHang { MaKh = idkh, TenKh = tenkh, TenCty = tencty, Sdt = sdt, Diachi = diachi};
            await _data.AddKhachHang(Khach);
        }

        public async Task UpdateKhachHangDB(string id, string tenkh, string tencty, string sdt,string diachi)
        {
            var khach = new KhachHang {MaKh =id, TenKh = tenkh, TenCty = tencty, Sdt = sdt, Diachi = diachi};
            await  _data.UpdateKhachHang(khach);

        }

        public async Task DeleteKhachHangDB(string id)
        {
            await _data.DeleteKhachHang(id);
        }

        public async Task<List<KhachHang>> SearchKhachHangDb(string search)
        {
           return await _data.SearchKhachHang(search);
        }
    }
}
