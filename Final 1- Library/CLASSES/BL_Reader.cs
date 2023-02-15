using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Final_1__Library.CLASSES
{
    internal class BL_Reader
    {
        public DataTable Take_Reader()
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps =
            from p in qltvEntity.READERs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Gender");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");
            dt.Columns.Add("Nbook");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_rd, p.Name, p.Birthday, p.Gender,p.CCCD,p.Phone,p.Address,p.N_books_br);
            }
            return dt;
        }
        public DataTable GetObjectByID(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.READERs
                       where p.ID_rd == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Gender");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");
            dt.Columns.Add("Nbook");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_rd, p.Name, p.Birthday, p.Gender, p.CCCD, p.Phone, p.Address, p.N_books_br);
            }
            return dt;
        }
        public DataTable GetObjectByName(string name)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.READERs
                       where p.Name == name
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Gender");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");
            dt.Columns.Add("Nbook");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_rd, p.Name, p.Birthday, p.Gender, p.CCCD, p.Phone, p.Address, p.N_books_br);
            }
            return dt;
        }
        public DataTable GetObjectByCCCD(int cccd)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.READERs
                       where p.CCCD == cccd
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Gender");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");
            dt.Columns.Add("Nbook");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_rd, p.Name, p.Birthday, p.Gender, p.CCCD, p.Phone, p.Address, p.N_books_br);
            }
            return dt;
        }
        public bool Add_Reader(int id, string name,DateTime birthday,string gender,int cccd,int phone, string address)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            READER reader = new READER();
            reader.ID_rd = id;
            reader.Name = name;
            reader.Birthday = birthday;
            reader.Gender = gender;
            reader.CCCD = cccd;
            reader.Phone = phone;
            reader.Address = address;
            reader.N_books_br = 0;
            qltvEntity.READERs.Add(reader);
            qltvEntity.SaveChanges();

            return true;

        }
        public void ChangeNBrBook(int id,int index)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tpQuery = (from p in qltvEntity.READERs
                           where p.ID_rd == id
                           select p).SingleOrDefault();
            if (index == 1)
            {
                if (tpQuery != null)
                {
                    tpQuery.N_books_br++;
                    qltvEntity.SaveChanges();
                }
            }
            if (index == 2)
            {
                if (tpQuery != null)
                {
                    tpQuery.N_books_br--;
                    qltvEntity.SaveChanges();
                }
            }
        }
        public bool Edit_Reader(int id, string name, DateTime birthday, string gender, int cccd, int phone, string address, int nbook)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tpQuery = (from p in qltvEntity.READERs
                           where p.ID_rd == id
                           select p).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.Name = name;
                tpQuery.Birthday = birthday;
                tpQuery.Gender = gender;
                tpQuery.CCCD = cccd;
                tpQuery.Phone = phone;
                tpQuery.Address = address;
                tpQuery.N_books_br = nbook;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        public bool Delete_Reader(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            READER reader = new READER();
            reader.ID_rd = id;
            qltvEntity.READERs.Attach(reader);
            qltvEntity.READERs.Remove(reader);
            qltvEntity.SaveChanges();
            return true;
        }
    }
}
