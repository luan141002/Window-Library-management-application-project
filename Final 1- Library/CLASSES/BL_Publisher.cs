using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Final_1__Library.CLASSES
{
    internal class BL_Publisher
    {
        public DataTable Take_Publisher()
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps =
            from p in qltvEntity.PUBLISHERs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_publisher, p.Name, p.Phone,p.Email, p.Address);
            }
            return dt;
        }
        public bool Add_Publisher(int id, string name, int phone,string email, string address)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            PUBLISHER publisher = new PUBLISHER();
            publisher.ID_publisher = id;
            publisher.Name = name;
            publisher.Phone = phone;
            publisher.Email = email;
            publisher.Address = address;
            qltvEntity.PUBLISHERs.Add(publisher);
            qltvEntity.SaveChanges();

            return true;

        }
        public DataTable GetObjectByID(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.PUBLISHERs
                       where p.ID_publisher == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_publisher, p.Name, p.Phone, p.Email, p.Address);
            }
            return dt;
        }
        public DataTable GetObjectByName(string name)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.PUBLISHERs
                       where p.Name == name
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_publisher, p.Name, p.Phone, p.Email, p.Address);
            }
            return dt;
        }
        public bool Edit_Publisher(int id, string name, int phone, string email, string address)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tpQuery = (from p in qltvEntity.PUBLISHERs
                           where p.ID_publisher == id
                           select p).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.Name = name;
                tpQuery.Phone = phone;
                tpQuery.Email = email;
                tpQuery.Address = address;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        public bool Delete_Publisher(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            PUBLISHER publisher = new PUBLISHER();
            BL_Book dbBo = new BL_Book();
            publisher.ID_publisher = id;
           // dbBo.deleteAllId1(id);
            qltvEntity.PUBLISHERs.Attach(publisher);
            qltvEntity.PUBLISHERs.Remove(publisher);
            qltvEntity.SaveChanges();
            return true;
        }
    }
}
