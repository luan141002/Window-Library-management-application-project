using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Final_1__Library.CLASSES
{
    internal class BL_BorrowedBook
    {
        public DataTable Take_BorrowedBook()
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps =
            from p in qltvEntity.Borrow_Book
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Rd");
            dt.Columns.Add("ID_Book");
            dt.Columns.Add("Borrowed_date");
            dt.Columns.Add("Estimated_date");
            dt.Columns.Add("Returned_date");
            dt.Columns.Add("Extra_fee");
            dt.Columns.Add("Current_status");
            dt.Columns.Add("Loss_book");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Rd, p.ID_Book, p.Borrowed_date,p.Estimated_date, p.Returned_date,p.Extra_fee,p.Current_status,p.Loss_book);
            }
            return dt;
        }
        
        public DataTable GetObjectByIDReader(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.Borrow_Book
                       where p.ID_Rd == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Reader");
            dt.Columns.Add("ID_Book");
            dt.Columns.Add("Borrowed_date");
            dt.Columns.Add("Estimated_date");
            dt.Columns.Add("Return_date");
            dt.Columns.Add("Extra_fee");
            dt.Columns.Add("Current_status");
            dt.Columns.Add("Loss_book");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Rd, p.ID_Book, p.Borrowed_date, p.Estimated_date, p.Returned_date, p.Extra_fee, p.Current_status, p.Loss_book);
            }
            return dt;
        }
        public void deleteAllId(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            DataTable dt = new DataTable();
            dt = GetObjectByIDBook(id);
            Borrow_Book borrow_book = new Borrow_Book();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //borrow_book.ID_Rd = id_reader;
                borrow_book.ID_Book = id;
                borrow_book.ID_Rd = int.Parse(dt.Rows[i][0].ToString());
                qltvEntity.Borrow_Book.Attach(borrow_book);
                qltvEntity.Borrow_Book.Remove(borrow_book);
                qltvEntity.SaveChanges();
            }
           // return true;
        }


        public DataTable GetObjectByIDBook(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.Borrow_Book
                       where p.ID_Book == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Reader");
            dt.Columns.Add("ID_Book");
            dt.Columns.Add("Borrowed_date");
            dt.Columns.Add("Estimated_date");
            dt.Columns.Add("Return_date");
            dt.Columns.Add("Extra_fee");
            dt.Columns.Add("Current_status");
            dt.Columns.Add("Loss_book");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Rd, p.ID_Book, p.Borrowed_date, p.Estimated_date, p.Returned_date, p.Extra_fee, p.Current_status, p.Loss_book);
            }
            return dt;
        }
        public bool Add_BorrowedBookreturn(int id_reader, int id_book, DateTime borrow_time,DateTime estimated_time, DateTime return_time,bool current_status,bool loss_book)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            Borrow_Book borrow_Book = new Borrow_Book();
            borrow_Book.ID_Rd = id_reader;
            borrow_Book.ID_Book = id_book;
            borrow_Book.Borrowed_date = borrow_time;
            borrow_Book.Estimated_date = estimated_time;
            borrow_Book.Returned_date = return_time;
            borrow_Book.Extra_fee = cal_ExtraFee(id_reader, id_book, borrow_time, estimated_time, return_time, current_status, loss_book); 
            borrow_Book.Current_status = current_status;
            borrow_Book.Loss_book = loss_book;
            qltvEntity.Borrow_Book.Add(borrow_Book);
            qltvEntity.SaveChanges();

            return true;

        }
        public bool Add_BorrowedBooknotreturn(int id_reader, int id_book, DateTime borrow_time, DateTime estimated_time)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            Borrow_Book borrow_Book = new Borrow_Book();
            borrow_Book.ID_Rd = id_reader;
            borrow_Book.ID_Book = id_book;
            borrow_Book.Borrowed_date = borrow_time;
            borrow_Book.Estimated_date = estimated_time;
            qltvEntity.Borrow_Book.Add(borrow_Book);
            qltvEntity.SaveChanges();

            return true;

        }
        public bool Edit_BorrowedBook(int id_reader, int id_book, DateTime borrow_time, DateTime estimated_time, DateTime return_time, bool current_status, bool loss_book)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tpQuery = (from p in qltvEntity.Borrow_Book
                           where p.ID_Rd == id_reader && p.ID_Book == id_book
                            select p).FirstOrDefault();
            if (tpQuery != null)
            {
                tpQuery.Borrowed_date = borrow_time;
                tpQuery.Estimated_date= estimated_time;
                tpQuery.Returned_date = return_time;
                tpQuery.Extra_fee = cal_ExtraFee(id_reader,id_book,borrow_time,estimated_time,return_time,current_status,loss_book);
                tpQuery.Current_status = current_status;
                tpQuery.Loss_book = loss_book;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        public int cal_ExtraFee(int id_re, int id_book, DateTime borrowday, DateTime estimateday, DateTime returnday , bool original, bool lost)
        {
            int a = 0;
            

                if (returnday > estimateday)
                {
                    a = (returnday - estimateday).Days * 200;
                }

                return a;
        }
        public bool Delete_BorrowedBook(int id_reader, int id_book)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            Borrow_Book borrow_book = new Borrow_Book();
            borrow_book.ID_Rd = id_reader;
            borrow_book.ID_Book = id_book;
            qltvEntity.Borrow_Book.Attach(borrow_book);
            qltvEntity.Borrow_Book.Remove(borrow_book);
            qltvEntity.SaveChanges();
            return true;
        }
        

    }
}
