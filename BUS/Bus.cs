using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Globalization;

namespace BUS
{
    public class Bus
    {
        DataDiagramDataContext data = new DataDiagramDataContext();
        public object getData1()//Lấy các dữ liệu liên quan đến giáo viên
        {
            var database = from u in data.GiaoViens
                           from v in data.MonHocs
                           where u.MaMon == v.MaMon
                           select new
                           {
                               MaGV = u.MaGV,
                               HoTen = u.TenGV,
                               NS = u.NgaySinh,
                               GT = u.Gioitinh,
                               SDT = u.SoDT,
                               MaMon = u.MaMon
                           };

            return database;
        }
        public object addTeacher(string magv, string hoten, string gt,string ns,string sdt, string mamon)
        {
            GiaoVien gv = new GiaoVien();
            MonHoc mh = data.MonHocs.Single(a => a.MaMon == mamon);

            gv.MaGV = magv;
                gv.TenGV = hoten;
               
                if (gt == "Nam")
                {
                    gv.Gioitinh = false;
                }
                if (gt == "Nữ")
                {
                    gv.Gioitinh = true;
                }
                gv.NgaySinh = DateTime.ParseExact(ns, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                gv.SoDT = sdt;
                if(mh != null)
                {
                     gv.MaMon = mamon;
                }
                

                data.GiaoViens.InsertOnSubmit(gv);
                data.SubmitChanges();
           

            return 1;
        }
    }
}
