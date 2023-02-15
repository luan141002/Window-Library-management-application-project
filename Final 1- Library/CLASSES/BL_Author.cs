using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Final_1__Library.CLASSES
{
    internal class BL_Author 
    {
        public DataTable TakeAuthor()
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps =
            from p in qltvEntity.AUTHORs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_author,p.Name,p.Phone,p.Address);
            }
            return dt;
        }
        public DataTable GetObjectByID(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.AUTHORs
                       where p.ID_author == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_author, p.Name, p.Phone, p.Address);
            }
            return dt;
        }
        public DataTable GetObjectByName(string name)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.AUTHORs
                       where p.Name == name
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_author, p.Name, p.Phone, p.Address);
            }
            return dt;
        }
        public bool AddAuthor(int id, string name,int phone , string address)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            AUTHOR author = new AUTHOR();
            author.ID_author = id;
            author.Name = name;
            author.Phone = phone;
            author.Address = address;
            qltvEntity.AUTHORs.Add(author);
            qltvEntity.SaveChanges();

            return true;

        }
        public bool EditAuthor(int id, string name, int phone, string address)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tpQuery = (from p in qltvEntity.AUTHORs
                           where p.ID_author == id
                           select p).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.Name = name;
                tpQuery.Phone = phone;
                tpQuery.Address = address;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        public bool Delete_Author(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            AUTHOR author = new AUTHOR();
            BL_Book dbBo = new BL_Book();
            author.ID_author = id;
            //dbBo.deleteAllId(id);
            qltvEntity.AUTHORs.Attach(author);
            qltvEntity.AUTHORs.Remove(author);
            qltvEntity.SaveChanges();
            return true;
        }
    }
}
