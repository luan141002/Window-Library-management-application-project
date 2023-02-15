using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace Final_1__Library.CLASSES
{
    internal class BL_Book
    {
        public DataTable Take_Book()
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
           
            var tps =
            from p in qltvEntity.BOOKS
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Book");
            dt.Columns.Add("Name");
            dt.Columns.Add("ID_publisher");
            dt.Columns.Add("ID_author");
            dt.Columns.Add("Type");
            dt.Columns.Add("Description");
            dt.Columns.Add("Update_day");
            dt.Columns.Add("N_books");
            dt.Columns.Add("price");
            dt.Columns.Add("Picture");

            foreach (var p in tps)
            {
                byte[] pic;
                pic = (byte[])p.Picture;
                MemoryStream picture = new MemoryStream(p.Picture);
                //Image x = (Bitmap)((new ImageConverter()).ConvertFrom(p.Picture));
                //Image picture = byteArrayToImage(p.Picture);

                dt.Rows.Add(p.ID_Book, p.Name, p.ID_publisher, p.ID_author,p.Type,p.Description,p.Update_day,p.N_books,p.price, picture);
            }
            return dt;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
        //public Image byteArrayToImage(byte[] byteArrayIn)
        //{
        //    MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
        //    ms.Write(byteArrayIn, 0, byteArrayIn.Length);
        //    Image returnImage = Image.FromStream(ms, true);
        //    return returnImage;
        //}
        public bool Add_Book(int id, string name, int id_Publisher, int id_Author,string type,string decription,DateTime updateday,int nbook , int price, MemoryStream picture)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();

            BOOK book = new BOOK();
            book.ID_Book = id;
            book.Name = name;
            book.ID_publisher = id_Publisher;
            book.ID_author = id_Author;
            book.Type = type;
            book.Description = decription;
            book.Update_day = updateday;
            book.N_books = nbook;
            book.price = price;
            book.Picture = picture.ToArray();
            
            qltvEntity.BOOKS.Add(book);
            qltvEntity.SaveChanges();

            return true;

        }
        //private byte[] ImageToArray(Image pic, System.Drawing.Imaging.ImageFormat format)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        pic.Save(ms, format);
        //        byte[] ImageBytes = ms.ToArray();

        //        return ImageBytes;
        //    }
        //}
        //public List<BOOK> getList()
        //{
        //    QuanLyThuVienEntities quanLyThuVienEntities = new QuanLyThuVienEntities();
        //    return quanLyThuVienEntities.BOOKS.ToList();
        //}
        public int CountBookinLi()
        {
            int a = 0;
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            BL_BorrowedBook br = new BL_BorrowedBook();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = Take_Book();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                a += int.Parse(dt.Rows[i][7].ToString());
            }
            return a;

        }
        public DataTable GetObjectByID(int id) 
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.BOOKS
                       where  p.ID_Book  == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("ID_publisher");
            dt.Columns.Add("ID_author");
            dt.Columns.Add("Type");
            dt.Columns.Add("Decription");
            dt.Columns.Add("Update_day");
            dt.Columns.Add("N_books");
            dt.Columns.Add("price");
            dt.Columns.Add("Picture");
          
            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Book, p.Name, p.ID_publisher, p.ID_author, p.Type, p.Description, p.Update_day, p.N_books, p.price,p.Picture);
             }
            return dt;
           }
        public DataTable GetObjectByName(string id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.BOOKS
                       where p.Name == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("ID_publisher");
            dt.Columns.Add("ID_author");
            dt.Columns.Add("Type");
            dt.Columns.Add("Decription");
            dt.Columns.Add("Update_day");
            dt.Columns.Add("N_books");
            dt.Columns.Add("price");
            dt.Columns.Add("Picture");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Book, p.Name, p.ID_publisher, p.ID_author, p.Type, p.Description, p.Update_day, p.N_books, p.price,p.Picture);
            }
            return dt;
        }
        public void Changenbook(int id,int index)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tpQuery = (from p in qltvEntity.BOOKS
                           where p.ID_Book == id
                           select p).SingleOrDefault();
            if (tpQuery != null)
            {
                if (index == 1)
                {
                    tpQuery.N_books++;
                    qltvEntity.SaveChanges();
                }
                if (index == 2)
                {
                    tpQuery.N_books--;
                    qltvEntity.SaveChanges();
                }

            }
            
        }
        public DataTable GetObjectByAuthor(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.BOOKS
                       where p.ID_author == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("ID_publisher");
            dt.Columns.Add("ID_author");
            dt.Columns.Add("Type");
            dt.Columns.Add("Decription");
            dt.Columns.Add("Update_day");
            dt.Columns.Add("N_books");
            dt.Columns.Add("price");
            dt.Columns.Add("Picture");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Book, p.Name, p.ID_publisher, p.ID_author, p.Type, p.Description, p.Update_day, p.N_books, p.price,p.Picture);
            }
            return dt;
        }
        public DataTable GetObjectByPublisher(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.BOOKS
                       where p.ID_publisher == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("ID_publisher");
            dt.Columns.Add("ID_author");
            dt.Columns.Add("Type");
            dt.Columns.Add("Decription");
            dt.Columns.Add("Update_day");
            dt.Columns.Add("N_books");
            dt.Columns.Add("price");
            dt.Columns.Add("Picture");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Book, p.Name, p.ID_publisher, p.ID_author, p.Type, p.Description, p.Update_day, p.N_books, p.price,p.Picture);
            }
            return dt;
        }
        public DataTable GetObjectByType(string id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tps = (from p in qltvEntity.BOOKS
                       where p.Type == id
                       select p);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("ID_publisher");
            dt.Columns.Add("ID_author");
            dt.Columns.Add("Type");
            dt.Columns.Add("Decription");
            dt.Columns.Add("Update_day");
            dt.Columns.Add("N_books");
            dt.Columns.Add("price");
            dt.Columns.Add("Picture");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID_Book, p.Name, p.ID_publisher, p.ID_author, p.Type, p.Description, p.Update_day, p.N_books, p.price ,p.Picture);
            }
            return dt;
        }
       
        public bool Edit_Book(int id, string name, int id_Publisher, int id_Author, string type, string decription, DateTime updateday, int nbook, int price, byte[] picture)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tpQuery = (from p in qltvEntity.BOOKS
                           where p.ID_Book == id
                           select p).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.Name = name;
                tpQuery.ID_publisher = id_Publisher;
                tpQuery.ID_author = id_Author;
                tpQuery.Type = type;
                tpQuery.Description = decription;
                tpQuery.Update_day = updateday;
                tpQuery.N_books = nbook;
                tpQuery.price = price;
                tpQuery.Picture = picture;

                qltvEntity.SaveChanges();
            }
            return true;
        }
       
        public bool Delete_Book(int id)
        {
            QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
            var tpQuery = (from p in qltvEntity.BOOKS
                           where p.ID_Book == id
                           select p).SingleOrDefault();
            BOOK book = new BOOK();
          
            BL_BorrowedBook dbBr = new BL_BorrowedBook();
            if (tpQuery != null)
            {
                if (tpQuery.N_books > 1)
                {

                    tpQuery.N_books--;
                    qltvEntity.SaveChanges();

                }
                else
                {
                    dbBr.deleteAllId(tpQuery.ID_Book);
                   
                    qltvEntity.BOOKS.Attach(tpQuery);
                    qltvEntity.BOOKS.Remove(tpQuery);
                    qltvEntity.SaveChanges();

                }
            }
            return true;
        }

    }
}
//public void deleteAllId(int id)
//{
//    QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
//    DataTable dt = new DataTable();
//    dt = GetObjectByAuthor(id);
//    BL_Book dvBo = new BL_Book();
//    BOOK book = new BOOK();
//    for (int i = 0; i < dt.Rows.Count; i++)
//    {
//        //borrow_book.ID_Rd = id_reader;
//        Delete_BookAll(int.Parse(dt.Rows[i][0].ToString()));

//    }
//}
//public void deleteAllId1(int id)
//{
//    QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
//    DataTable dt = new DataTable();
//    dt = GetObjectByPublisher(id);
//    BL_Book dvBo = new BL_Book();
//    BOOK book = new BOOK();
//    for (int i = 0; i < dt.Rows.Count; i++)
//    {
//        //borrow_book.ID_Rd = id_reader;
//        Delete_BookAll(int.Parse(dt.Rows[i][0].ToString()));

//    }
//}
//public bool Delete_BookAll(int id)
//{
//    QuanLyThuVienEntities qltvEntity = new QuanLyThuVienEntities();
//    var tpQuery = (from p in qltvEntity.BOOKS
//                   where p.ID_Book == id
//                   select p).SingleOrDefault();
//    BOOK book = new BOOK();

//    BL_BorrowedBook dbBr = new BL_BorrowedBook();
//    if (tpQuery != null)
//    {
//        dbBr.deleteAllId(tpQuery.ID_Book);

//        qltvEntity.BOOKS.Attach(tpQuery);
//        qltvEntity.BOOKS.Remove(tpQuery);
//        qltvEntity.SaveChanges();

//    }
//    return true;
//}
